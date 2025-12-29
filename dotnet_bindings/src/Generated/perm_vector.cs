// Auto-generated from ert\util\perm_vector.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_perm_vector {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void perm_vector_free(IntPtr perm_vector);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int perm_vector_get_size(IntPtr perm);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int perm_vector_iget(IntPtr perm, int index);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: ert\\util\\perm_vector.hpp");
            try { perm_vector_free(IntPtr.Zero); Console.WriteLine("perm_vector_free -> (void)"); } catch(Exception ex) { Console.WriteLine("perm_vector_free threw: " + ex.Message); }
            try { var r = perm_vector_get_size(IntPtr.Zero); Console.WriteLine("perm_vector_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("perm_vector_get_size threw: " + ex.Message); }
            try { var r = perm_vector_iget(IntPtr.Zero, 0); Console.WriteLine("perm_vector_iget -> " + r); } catch(Exception ex) { Console.WriteLine("perm_vector_iget threw: " + ex.Message); }
        }
    }
}
