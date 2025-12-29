// Auto-generated from ert\util\hash.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_hash {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void hash_free(SafeHashTypeHandle? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void hash_insert_ref(SafeHashTypeHandle? p0, string? p1, SafeVoidHandle? p2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void hash_insert_string(SafeHashTypeHandle? p0, string? p1, string? p2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool hash_has_key(SafeHashTypeHandle? p0, string? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int hash_get_size(SafeHashTypeHandle? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void hash_resize(SafeHashHandle? hash, int new_size);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void hash_insert_int(SafeHashTypeHandle? p0, string? p1, int p2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern int hash_get_int(SafeHashTypeHandle? p0, string? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void hash_insert_double(SafeHashTypeHandle? p0, string? p1, double p2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern double hash_get_double(SafeHashTypeHandle? p0, string? p1);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: ert\\util\\hash.hpp");
            try { hash_free((SafeHashTypeHandle?)null); Console.WriteLine("hash_free -> (void)"); } catch(Exception ex) { Console.WriteLine("hash_free threw: " + ex.Message); }
            try { hash_insert_ref((SafeHashTypeHandle?)null, (string?)null, (SafeVoidHandle?)null); Console.WriteLine("hash_insert_ref -> (void)"); } catch(Exception ex) { Console.WriteLine("hash_insert_ref threw: " + ex.Message); }
            try { hash_insert_string((SafeHashTypeHandle?)null, (string?)null, (string?)null); Console.WriteLine("hash_insert_string -> (void)"); } catch(Exception ex) { Console.WriteLine("hash_insert_string threw: " + ex.Message); }
            try { var r = hash_has_key((SafeHashTypeHandle?)null, (string?)null); Console.WriteLine("hash_has_key -> " + r); } catch(Exception ex) { Console.WriteLine("hash_has_key threw: " + ex.Message); }
            try { var r = hash_get_size((SafeHashTypeHandle?)null); Console.WriteLine("hash_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("hash_get_size threw: " + ex.Message); }
            try { hash_resize((SafeHashHandle?)null, 0); Console.WriteLine("hash_resize -> (void)"); } catch(Exception ex) { Console.WriteLine("hash_resize threw: " + ex.Message); }
            try { hash_insert_int((SafeHashTypeHandle?)null, (string?)null, 0); Console.WriteLine("hash_insert_int -> (void)"); } catch(Exception ex) { Console.WriteLine("hash_insert_int threw: " + ex.Message); }
            try { var r = hash_get_int((SafeHashTypeHandle?)null, (string?)null); Console.WriteLine("hash_get_int -> " + r); } catch(Exception ex) { Console.WriteLine("hash_get_int threw: " + ex.Message); }
            try { hash_insert_double((SafeHashTypeHandle?)null, (string?)null, 0.0); Console.WriteLine("hash_insert_double -> (void)"); } catch(Exception ex) { Console.WriteLine("hash_insert_double threw: " + ex.Message); }
            try { var r = hash_get_double((SafeHashTypeHandle?)null, (string?)null); Console.WriteLine("hash_get_double -> " + r); } catch(Exception ex) { Console.WriteLine("hash_get_double threw: " + ex.Message); }
        }
    }
}
