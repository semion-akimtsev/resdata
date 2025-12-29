// Auto-generated from ert\util\path_stack.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_path_stack {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void path_stack_pop(IntPtr path_stack);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void path_stack_push_cwd(IntPtr path_stack);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool path_stack_push(IntPtr path_stack, string path);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void path_stack_free(IntPtr path_stack);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int path_stack_size(IntPtr path_stack);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: ert\\util\\path_stack.hpp");
            try { path_stack_pop(IntPtr.Zero); Console.WriteLine("path_stack_pop -> (void)"); } catch(Exception ex) { Console.WriteLine("path_stack_pop threw: " + ex.Message); }
            try { path_stack_push_cwd(IntPtr.Zero); Console.WriteLine("path_stack_push_cwd -> (void)"); } catch(Exception ex) { Console.WriteLine("path_stack_push_cwd threw: " + ex.Message); }
            try { var r = path_stack_push(IntPtr.Zero, null); Console.WriteLine("path_stack_push -> " + r); } catch(Exception ex) { Console.WriteLine("path_stack_push threw: " + ex.Message); }
            try { path_stack_free(IntPtr.Zero); Console.WriteLine("path_stack_free -> (void)"); } catch(Exception ex) { Console.WriteLine("path_stack_free threw: " + ex.Message); }
            try { var r = path_stack_size(IntPtr.Zero); Console.WriteLine("path_stack_size -> " + r); } catch(Exception ex) { Console.WriteLine("path_stack_size threw: " + ex.Message); }
        }
    }
}
