// Auto-generated from resdata\nnc_vector.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_nnc_vector {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int nnc_vector_iget_nnc_index(IntPtr nnc_vector, int index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int nnc_vector_iget_grid_index(IntPtr nnc_vector, int index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void nnc_vector_free(IntPtr nnc_vector);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int nnc_vector_get_lgr_nr(IntPtr nnc_vector);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void nnc_vector_free__(IntPtr arg);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int nnc_vector_get_size(IntPtr nnc_vector);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\nnc_vector.hpp");
            try { var r = nnc_vector_iget_nnc_index(IntPtr.Zero, 0); Console.WriteLine("nnc_vector_iget_nnc_index -> " + r); } catch(Exception ex) { Console.WriteLine("nnc_vector_iget_nnc_index threw: " + ex.Message); }
            try { var r = nnc_vector_iget_grid_index(IntPtr.Zero, 0); Console.WriteLine("nnc_vector_iget_grid_index -> " + r); } catch(Exception ex) { Console.WriteLine("nnc_vector_iget_grid_index threw: " + ex.Message); }
            try { nnc_vector_free(IntPtr.Zero); Console.WriteLine("nnc_vector_free -> (void)"); } catch(Exception ex) { Console.WriteLine("nnc_vector_free threw: " + ex.Message); }
            try { var r = nnc_vector_get_lgr_nr(IntPtr.Zero); Console.WriteLine("nnc_vector_get_lgr_nr -> " + r); } catch(Exception ex) { Console.WriteLine("nnc_vector_get_lgr_nr threw: " + ex.Message); }
            try { nnc_vector_free__(IntPtr.Zero); Console.WriteLine("nnc_vector_free__ -> (void)"); } catch(Exception ex) { Console.WriteLine("nnc_vector_free__ threw: " + ex.Message); }
            try { var r = nnc_vector_get_size(IntPtr.Zero); Console.WriteLine("nnc_vector_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("nnc_vector_get_size threw: " + ex.Message); }
        }
    }
}
