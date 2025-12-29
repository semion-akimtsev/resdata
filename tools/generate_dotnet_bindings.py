"""
Generate a .NET 9 console app with P/Invoke wrappers for C APIs declared under lib/include.
Creates project at dotnet_bindings/, wrappers at dotnet_bindings/src/Generated.
This script extracts top-level prototypes inside 'extern "C" { ... }' blocks and emits simple DllImport wrappers.
"""
import os, re, json
ROOT = os.path.abspath(os.path.join(os.path.dirname(__file__), '..'))
INCLUDE_DIR = os.path.join(ROOT, 'lib', 'include')
OUT_ROOT = os.path.join(ROOT, 'dotnet_bindings')
SRC_DIR = os.path.join(OUT_ROOT, 'src', 'Generated')
PROJECT_DIR = os.path.join(OUT_ROOT, 'src')
os.makedirs(SRC_DIR, exist_ok=True)

# simple regex for C prototypes (crude but works for common cases)
proto_re = re.compile(r"^\s*([A-Za-z_][A-Za-z0-9_\s\*]+?)\s+([A-Za-z_][A-Za-z0-9_]*)\s*\(([^;{]*)\)\s*;\s*$")

manifest = {}

# helper mappings
c_to_cs = {
    'int':'int', 'double':'double', 'float':'float', 'void':'void',
    'const char *':'string', 'char *':'string', 'bool':'bool', 'time_t':'long', 'size_t':'nuint'
}

# collect SafeHandle types to emit
safe_handles = set()

# helper to map arg

def map_arg(a, idx=0):
    a = a.strip()
    if not a or a=='void':
        return None
    parts = a.split()
    # if only a type (no name) or last token is a type-like token, generate placeholder name
    last = parts[-1]
    type_like_tokens = set(['int','double','float','char','const','bool','void','size_t'])
    has_name = True
    if len(parts) == 1 or last in type_like_tokens or last == '*' or last.endswith('*'):
        has_name = False
    # handle pointer types
    if '*' in a:
        # char* => string
        if 'char' in a:
            name = ('p{}'.format(idx)) if not has_name else parts[-1].strip('*')
            csharp_keywords = {'string','int','float','double','bool','long','object','decimal','char'}
            if name in csharp_keywords:
                name = '@' + name
            return ('string', name, False)
        # otherwise inspect the base type
        base = a.replace('const','').replace('*','').strip()
        # try to extract type and name (if present)
        m = re.match(r'(.+?)\s+(\w+)$', base)
        if m:
            typ = m.group(1).strip()
            nm = m.group(2).strip()
        else:
            # fallback: no name present
            toks = base.split()
            typ = toks[0]
            nm = ('p{}'.format(idx)) if not has_name else toks[-1]
        nm = ('p{}'.format(idx)) if not has_name else nm
        csharp_keywords = {'string','int','float','double','bool','long','object','decimal','char'}
        if nm in csharp_keywords:
            nm = '@' + nm
        prims = {'int':'int','double':'double','float':'float','long':'long','size_t':'nuint','unsigned int':'uint','uint32_t':'uint'}
        if typ in prims:
            # primitive pointer: if const -> treat as IntPtr (input array), else treat as out param
            if 'const' in a:
                return ('IntPtr', nm, False)
            else:
                return ('out ' + prims[typ], nm, True)
        # named opaque pointer -> SafeHandle
        tokens = typ.split()
        typename = tokens[-1]
        safe_name = 'Safe' + ''.join([p.capitalize() for p in typename.split('_')]) + 'Handle'
        safe_handles.add(safe_name)
        return (safe_name, nm, False)
    # non-pointer types
    typ = ' '.join(parts[:-1]) if len(parts)>1 else parts[0]
    name = ('p{}'.format(idx)) if not has_name else parts[-1]
    # escape C# keywords used as identifiers
    csharp_keywords = {'string','int','float','double','bool','long','object','decimal','char'}
    if name in csharp_keywords:
        name = '@' + name
    return (c_to_cs.get(typ, 'IntPtr'), name, False)

for dp, dn, fnames in os.walk(INCLUDE_DIR):
    for fname in fnames:
        if not fname.endswith('.hpp'):
            continue
        path = os.path.join(dp, fname)
        with open(path, 'r', encoding='utf-8') as fh:
            txt = fh.read()
        # find extern "C" blocks
        idx = 0
        funcs = []
        for m in re.finditer(r'extern\s+"C"\s*\{', txt):
            i = m.end()
            depth = 1
            start = i
            while i < len(txt) and depth > 0:
                if txt[i] == '{':
                    depth += 1
                elif txt[i] == '}':
                    depth -= 1
                i += 1
            block = txt[start:i-1]
            seen = set()
            for line in block.splitlines():
                line = line.strip()
                if not line or line.startswith('//'):
                    continue
                pm = proto_re.match(line)
                if pm:
                    ret, name, args = pm.groups()
                    # skip typedefs and function pointer typedefs
                    if 'typedef' in ret or '(' in ret or '(' in name or ')' in name:
                        continue
                    # skip C keywords as function names
                    C_KEYWORDS = {'double','int','float','char','void','bool','struct','union','typedef'}
                    if name in C_KEYWORDS:
                        continue
                    # skip variadic functions (cannot P/Invoke ... directly)
                    if '...' in args:
                        continue

                    # compute mapped param types to deduplicate overloads that only differ in argument names
                    arg_items = [s.strip() for s in args.split(',')] if args and args!='void' else []
                    mapped_types = []
                    for idx, a in enumerate(arg_items):
                        mapped = map_arg(a, idx)
                        if mapped:
                            mapped_types.append(mapped[0])
                    key = (name.strip(), tuple(mapped_types))
                    if key in seen:
                        continue
                    seen.add(key)
                    funcs.append({'ret':ret.strip(), 'name':name.strip(), 'args':args.strip()})
        if funcs:
            rel = os.path.relpath(path, INCLUDE_DIR)
            manifest[rel] = funcs

# helper mappings
c_to_cs = {
    'int':'int', 'double':'double', 'float':'float', 'void':'void',
    'const char *':'string', 'char *':'string', 'bool':'bool', 'time_t':'long', 'size_t':'nuint'
}

# helper to map arg

def map_arg(a, idx=0):
    a = a.strip()
    if not a or a=='void':
        return None
    parts = a.split()
    # if only a type (no name) or last token is a type-like token, generate placeholder name
    last = parts[-1]
    type_like_tokens = set(['int','double','float','char','const','bool','void','size_t'])
    has_name = True
    if len(parts) == 1 or last in type_like_tokens or last == '*' or last.endswith('*'):
        has_name = False
    # handle pointer types
    if '*' in a:
        # char* => string
        if 'char' in a:
            name = ('p{}'.format(idx)) if not has_name else parts[-1].strip('*')
            csharp_keywords = {'string','int','float','double','bool','long','object','decimal','char'}
            if name in csharp_keywords:
                name = '@' + name
            return ('string', name, False)
        # otherwise inspect the base type
        base = a.replace('const','').replace('*','').strip()
        # try to extract type and name (if present)
        m = re.match(r'(.+?)\s+(\w+)$', base)
        if m:
            typ = m.group(1).strip()
            nm = m.group(2).strip()
        else:
            # fallback: no name present
            toks = base.split()
            typ = toks[0]
            nm = ('p{}'.format(idx)) if not has_name else toks[-1]
        nm = ('p{}'.format(idx)) if not has_name else nm
        csharp_keywords = {'string','int','float','double','bool','long','object','decimal','char'}
        if nm in csharp_keywords:
            nm = '@' + nm
        prims = {'int':'int','double':'double','float':'float','long':'long','size_t':'nuint','unsigned int':'uint','uint32_t':'uint'}
        if typ in prims:
            # primitive pointer: if const -> treat as IntPtr (input array), else treat as out param
            if 'const' in a:
                return ('IntPtr', nm, False)
            else:
                return ('out ' + prims[typ], nm, True)
        # named opaque pointer -> SafeHandle
        tokens = typ.split()
        typename = tokens[-1]
        safe_name = 'Safe' + ''.join([p.capitalize() for p in typename.split('_')]) + 'Handle'
        safe_handles.add(safe_name)
        return (safe_name, nm, False)
    # non-pointer types
    typ = ' '.join(parts[:-1]) if len(parts)>1 else parts[0]
    name = ('p{}'.format(idx)) if not has_name else parts[-1]
    # escape C# keywords used as identifiers
    csharp_keywords = {'string','int','float','double','bool','long','object','decimal','char'}
    if name in csharp_keywords:
        name = '@' + name
    return (c_to_cs.get(typ, 'IntPtr'), name, False)

# emit cs files per header
for header, funcs in manifest.items():
    base = os.path.basename(header)
    name = os.path.splitext(base)[0]
    cls_name = 'Native_' + re.sub(r'[^A-Za-z0-9_]', '_', name)
    outpath = os.path.join(SRC_DIR, (cls_name[7:].lower() + '.cs'))
    with open(outpath, 'w', encoding='utf-8') as fh:
        fh.write('// Auto-generated from {}\n'.format(header))
        fh.write('using System;\nusing System.Runtime.InteropServices;\nusing Microsoft.Win32.SafeHandles;\n\n')
        fh.write('namespace Resdata.Bindings.Generated {\n')
        fh.write('    public static class {} {{\n'.format(cls_name))
        fh.write('        private const string LIB = "libresdata";\n\n')
        for f in funcs:
            ret = f['ret']
            namef = f['name']
            args = f['args']
            params = []
            for idx, a in enumerate([s.strip() for s in args.split(',')] if args and args!='void' else []):
                mapped = map_arg(a, idx)
                if mapped:
                    params.append(mapped)
            # write DllImport
            charset = ''
            if 'char *' in ret or 'const char *' in ret or any((p[0]=='string' or (isinstance(p[0], str) and p[0].startswith('Safe'))) for p in params):
                charset = ', CharSet=CharSet.Ansi'
            # return type (handle pointer returns specially)
            ret_clean = ret.strip()
            if '*' in ret_clean:
                if 'char' in ret_clean:
                    ret_cs = 'string?'
                else:
                    base = ret_clean.replace('const','').replace('*','').strip()
                    tokens = base.split()
                    typename = tokens[-1]
                    ret_cs = 'Safe' + ''.join([p.capitalize() for p in typename.split('_')]) + 'Handle'
                    safe_handles.add(ret_cs)
                    # make return nullable (SafeHandles are reference-like)
                    ret_cs = ret_cs + '?'
            else:
                # primitive returns keep as-is
                ret_cs = c_to_cs.get(ret_clean, 'IntPtr')
            fh.write('        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl{} )]\n'.format(charset))
            # ensure unique parameter names
            used_names = {}
            unique_params = []
            for t,p,outflag in params:
                base_name = p
                if base_name in used_names:
                    used_names[base_name] += 1
                    new_name = f"{base_name}_{used_names[base_name]}"
                else:
                    used_names[base_name] = 0
                    new_name = base_name
                unique_params.append((t, new_name, outflag))
            # format parameter types to be nullable for reference-like types (string and SafeHandles)
            def fmt_param_type(t):
                # t may be 'out int' for out params - preserve that
                if t.startswith('out '):
                    return t
                if t == 'string':
                    return 'string?'
                if t.startswith('Safe'):
                    return t + '?'
                return t
            fh.write('        public static extern {ret} {name}({params});\n'.format(
                ret=ret_cs,
                name=namef,
                params=', '.join([('{0} {1}'.format(fmt_param_type(t),p) if not str(t).startswith('out ') else (str(t) + ' ' + p)) for t,p,_ in unique_params])
            ))
        # ExecuteAll
        fh.write('\n        public static void ExecuteAll() {\n')
        safe_header = header.replace('\\','\\\\')
        fh.write('            Console.WriteLine(@"Executing functions from: {0}");\n'.format(safe_header))
        for f in funcs:
            namef = f['name']
            args = f['args']
            callargs = []
            predecls = []
            postprints = []
            for idx, a in enumerate([s.strip() for s in args.split(',')] if args and args!='void' else []):
                mapped = map_arg(a, idx)
                if not mapped:
                    continue
                t, pname, is_out = mapped
                # handle out params
                if isinstance(t, str) and t.startswith('out '):
                    base_t = t[len('out '):]
                    # make tmp variable unique per function to avoid name collisions
                    safe_fname = re.sub(r'[^A-Za-z0-9_]','_', namef)
                    pname_clean = pname.lstrip('@')
                    tmp_name = f"tmp_{safe_fname}_{pname_clean}"
                    # predeclare tmp variable with default value
                    if base_t == 'int' or base_t == 'uint' or base_t == 'long':
                        predecls.append(f"int {tmp_name} = 0;")
                    elif base_t == 'double':
                        predecls.append(f"double {tmp_name} = 0.0;")
                    elif base_t == 'float':
                        predecls.append(f"float {tmp_name} = 0.0f;")
                    elif base_t == 'nuint' or base_t == 'nint':
                        predecls.append(f"nuint {tmp_name} = 0;")
                    else:
                        predecls.append(f"int {tmp_name} = 0;")
                    callargs.append(f"out {tmp_name}")
                    postprints.append((pname, tmp_name))
                else:
                    if t == 'int':
                        callargs.append('0')
                    elif t == 'double':
                        callargs.append('0.0')
                    elif t == 'float':
                        callargs.append('0.0f')
                    elif t == 'string':
                        # use a typed null so nullable/overload resolution is explicit
                        callargs.append('(string?)null')
                    elif t == 'bool':
                        callargs.append('false')
                    elif t == 'long':
                        callargs.append('0L')
                    elif t == 'nint' or t == 'nuint':
                        callargs.append('0')
                    elif isinstance(t, str) and t.startswith('Safe'):
                        # cast null to the nullable SafeHandle type to disambiguate overloads
                        callargs.append('({0}?)null'.format(t))
                    else:
                        callargs.append('IntPtr.Zero')
            # choose calling/printing strategy based on return type
            ret_clean = f['ret'].strip()
            if '*' in ret_clean and 'char' not in ret_clean:
                base = ret_clean.replace('const','').replace('*','').strip()
                tokens = base.split()
                typename = tokens[-1]
                ret_cs = 'Safe' + ''.join([p.capitalize() for p in typename.split('_')]) + 'Handle'
                ret_cs = ret_cs + '?'
            elif '*' in ret_clean and 'char' in ret_clean:
                ret_cs = 'string?'
            else:
                ret_cs = c_to_cs.get(ret_clean, 'IntPtr')

            # write predecls, call, and post prints
            if predecls:
                for d in predecls:
                    fh.write('            ' + d + '\n')
            if ret_cs == 'void':
                fh.write('            try {{ {name}({args}); Console.WriteLine("{name} -> (void)"); }} catch(Exception ex) {{ Console.WriteLine("{name} threw: " + ex.Message); }}\n'.format(name=namef, args=', '.join(callargs)))
            else:
                if ret_cs == 'string':
                    fh.write('            try {{ var r = {name}({args}); Console.WriteLine("{name} -> " + (r==null?"(null)":r)); }} catch(Exception ex) {{ Console.WriteLine("{name} threw: " + ex.Message); }}\n'.format(name=namef, args=', '.join(callargs)))
                elif ret_cs.startswith('Safe'):
                    fh.write('            try {{ var r = {name}({args}); Console.WriteLine("{name} -> " + (r==null?"(null)":r.ToString())); }} catch(Exception ex) {{ Console.WriteLine("{name} threw: " + ex.Message); }}\n'.format(name=namef, args=', '.join(callargs)))
                else:
                    fh.write('            try {{ var r = {name}({args}); Console.WriteLine("{name} -> " + r); }} catch(Exception ex) {{ Console.WriteLine("{name} threw: " + ex.Message); }}\n'.format(name=namef, args=', '.join(callargs)))
            for orig_name, tmp_name in postprints:
                fh.write('            Console.WriteLine("    out {orig} -> " + {tmp});\n'.format(orig=orig_name, tmp=tmp_name))
        fh.write('        }\n')
        fh.write('    }\n')
        fh.write('}\n')

# write csproj and Program.cs
os.makedirs(PROJECT_DIR, exist_ok=True)
csproj = os.path.join(PROJECT_DIR, 'ResdataBindings.csproj')
with open(csproj, 'w', encoding='utf-8') as fh:
    fh.write('<Project Sdk="Microsoft.NET.Sdk">\n')
    fh.write('  <PropertyGroup>\n')
    fh.write('    <OutputType>Exe</OutputType>\n')
    fh.write('    <TargetFramework>net9.0</TargetFramework>\n')
    fh.write('    <ImplicitUsings>enable</ImplicitUsings>\n')
    fh.write('    <Nullable>enable</Nullable>\n')
    fh.write('  </PropertyGroup>\n')
    fh.write('</Project>\n')

prog = os.path.join(PROJECT_DIR, 'Program.cs')
with open(prog, 'w', encoding='utf-8') as fh:
    fh.write('using System;\nusing Resdata.Bindings.Generated;\n\n')
    fh.write('class Program {\n    static void Main() {\n')
    # call ExecuteAll on each generated class
    for header, funcs in manifest.items():
        base = os.path.basename(header)
        name = os.path.splitext(base)[0]
        cls_name = 'Native_' + re.sub(r'[^A-Za-z0-9_]', '_', name)
        fh.write('        try {{ {}.ExecuteAll(); }} catch(Exception ex) {{ Console.WriteLine("{} ExecuteAll failed: " + ex.Message); }}\n'.format('Resdata.Bindings.Generated.' + cls_name, cls_name))
    fh.write('    }\n}\n')

# emit SafeHandle helper types
if safe_handles:
    # collect free/destroy/unref function candidates across headers
    free_candidates = {}
    for dp, dn, fnames in os.walk(INCLUDE_DIR):
        for fname in fnames:
            if not fname.endswith('.hpp'):
                continue
            path = os.path.join(dp, fname)
            with open(path, 'r', encoding='utf-8') as fh:
                txt = fh.read()
            for line in txt.splitlines():
                pm = proto_re.match(line.strip())
                if not pm:
                    continue
                retf, namef, argsf = pm.groups()
                if re.search(r'(_free__|_free|_destroy|_unref|_release)$', namef):
                    args_items = [s.strip() for s in argsf.split(',') if s.strip()]
                    first_arg = args_items[0] if args_items else ''
                    free_candidates[namef] = {'ret': retf.strip(), 'first_arg': first_arg.strip(), 'header': path}

    sh_path = os.path.join(SRC_DIR, 'SafeHandles.cs')
    with open(sh_path, 'w', encoding='utf-8') as fh:
        fh.write('// Auto-generated SafeHandle types\n')
        fh.write('using System;\nusing Microsoft.Win32.SafeHandles;\nusing System.Runtime.InteropServices;\n\n')
        fh.write('namespace Resdata.Bindings.Generated {\n')
        for sh in sorted(safe_handles):
            fh.write('    public sealed class {0} : SafeHandleZeroOrMinusOneIsInvalid {{\n'.format(sh))
            fh.write('        private {0}() : base(true) {{}}\n'.format(sh))
            fh.write('        public {0}(IntPtr handle, bool ownsHandle = true) : base(ownsHandle) {{ SetHandle(handle); }}\n'.format(sh))
            # compute candidate free function name from SafeHandle class name
            base = sh[len('Safe'):-len('Handle')]
            snake = re.sub(r'(?<!^)([A-Z])', r'_\1', base).lower()
            candidates = [snake + s for s in ['_free','_free__','_destroy','_unref','_release']]
            found = None
            for c in candidates:
                if c in free_candidates:
                    found = c
                    break
            if found:
                ret = free_candidates[found]['ret']
                ret_cs = c_to_cs.get(ret.strip(), 'IntPtr')
                fh.write('        [DllImport("libresdata", CallingConvention = CallingConvention.Cdecl)]\n')
                fh.write('        private static extern {0} {1}(IntPtr ptr);\n'.format(ret_cs, found))
                fh.write('        protected override bool ReleaseHandle() {\n')
                if ret_cs == 'void':
                    fh.write('            {0}(handle);\n            return true;\n'.format(found))
                elif ret_cs == 'int':
                    fh.write('            return {0}(handle) != 0;\n'.format(found))
                elif ret_cs == 'bool':
                    fh.write('            return {0}(handle);\n'.format(found))
                else:
                    fh.write('            {0}(handle);\n            return true;\n'.format(found))
                fh.write('        }\n')
            else:
                fh.write('        protected override bool ReleaseHandle() {\n')
                fh.write('            // TODO: add proper release via native free function when available\n')
                fh.write('            return true;\n')
                fh.write('        }\n')
            fh.write('    }\n')
        fh.write('}\n')

# write manifest file
with open(os.path.join(OUT_ROOT, 'manifest.json'), 'w', encoding='utf-8') as fh:
    json.dump(manifest, fh, indent=2)

print('Generated project with {} header wrappers.'.format(len(manifest)))
print('Project at {}'.format(OUT_ROOT))
