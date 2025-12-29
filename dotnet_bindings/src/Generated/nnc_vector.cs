// Auto-generated from resdata\nnc_vector.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_nnc_vector {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int nnc_vector_iget_nnc_index(SafeNncVectorHandle? nnc_vector, int index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int nnc_vector_iget_grid_index(SafeNncVectorHandle? nnc_vector, int index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void nnc_vector_free(SafeNncVectorHandle? nnc_vector);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int nnc_vector_get_lgr_nr(SafeNncVectorHandle? nnc_vector);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void nnc_vector_free__(SafeArgHandle? arg);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int nnc_vector_get_size(SafeNncVectorHandle? nnc_vector);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\nnc_vector.hpp");
            try { var r = nnc_vector_iget_nnc_index((SafeNncVectorHandle?)null, 0); Console.WriteLine("nnc_vector_iget_nnc_index -> " + r); } catch(Exception ex) { Console.WriteLine("nnc_vector_iget_nnc_index threw: " + ex.Message); }
            try { var r = nnc_vector_iget_grid_index((SafeNncVectorHandle?)null, 0); Console.WriteLine("nnc_vector_iget_grid_index -> " + r); } catch(Exception ex) { Console.WriteLine("nnc_vector_iget_grid_index threw: " + ex.Message); }
            try { nnc_vector_free((SafeNncVectorHandle?)null); Console.WriteLine("nnc_vector_free -> (void)"); } catch(Exception ex) { Console.WriteLine("nnc_vector_free threw: " + ex.Message); }
            try { var r = nnc_vector_get_lgr_nr((SafeNncVectorHandle?)null); Console.WriteLine("nnc_vector_get_lgr_nr -> " + r); } catch(Exception ex) { Console.WriteLine("nnc_vector_get_lgr_nr threw: " + ex.Message); }
            try { nnc_vector_free__((SafeArgHandle?)null); Console.WriteLine("nnc_vector_free__ -> (void)"); } catch(Exception ex) { Console.WriteLine("nnc_vector_free__ threw: " + ex.Message); }
            try { var r = nnc_vector_get_size((SafeNncVectorHandle?)null); Console.WriteLine("nnc_vector_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("nnc_vector_get_size threw: " + ex.Message); }
        }
    }
}
