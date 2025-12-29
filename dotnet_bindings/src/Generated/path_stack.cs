// Auto-generated from ert\util\path_stack.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_path_stack {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void path_stack_pop(SafePathStackHandle? path_stack);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void path_stack_push_cwd(SafePathStackHandle? path_stack);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool path_stack_push(SafePathStackHandle? path_stack, string? path);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void path_stack_free(SafePathStackHandle? path_stack);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int path_stack_size(SafePathStackHandle? path_stack);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: ert\\util\\path_stack.hpp");
            try { path_stack_pop((SafePathStackHandle?)null); Console.WriteLine("path_stack_pop -> (void)"); } catch(Exception ex) { Console.WriteLine("path_stack_pop threw: " + ex.Message); }
            try { path_stack_push_cwd((SafePathStackHandle?)null); Console.WriteLine("path_stack_push_cwd -> (void)"); } catch(Exception ex) { Console.WriteLine("path_stack_push_cwd threw: " + ex.Message); }
            try { var r = path_stack_push((SafePathStackHandle?)null, (string?)null); Console.WriteLine("path_stack_push -> " + r); } catch(Exception ex) { Console.WriteLine("path_stack_push threw: " + ex.Message); }
            try { path_stack_free((SafePathStackHandle?)null); Console.WriteLine("path_stack_free -> (void)"); } catch(Exception ex) { Console.WriteLine("path_stack_free threw: " + ex.Message); }
            try { var r = path_stack_size((SafePathStackHandle?)null); Console.WriteLine("path_stack_size -> " + r); } catch(Exception ex) { Console.WriteLine("path_stack_size threw: " + ex.Message); }
        }
    }
}
