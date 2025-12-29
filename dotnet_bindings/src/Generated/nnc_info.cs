// Auto-generated from resdata\nnc_info.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_nnc_info {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void nnc_info_free(IntPtr nnc_info);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int nnc_info_get_lgr_nr(IntPtr nnc_info);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int nnc_info_get_size(IntPtr nnc_info);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int nnc_info_get_total_size(IntPtr nnc_info);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool nnc_info_has_grid_index_list(IntPtr nnc_info, int lgr_nr);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\nnc_info.hpp");
            try { nnc_info_free(IntPtr.Zero); Console.WriteLine("nnc_info_free -> (void)"); } catch(Exception ex) { Console.WriteLine("nnc_info_free threw: " + ex.Message); }
            try { var r = nnc_info_get_lgr_nr(IntPtr.Zero); Console.WriteLine("nnc_info_get_lgr_nr -> " + r); } catch(Exception ex) { Console.WriteLine("nnc_info_get_lgr_nr threw: " + ex.Message); }
            try { var r = nnc_info_get_size(IntPtr.Zero); Console.WriteLine("nnc_info_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("nnc_info_get_size threw: " + ex.Message); }
            try { var r = nnc_info_get_total_size(IntPtr.Zero); Console.WriteLine("nnc_info_get_total_size -> " + r); } catch(Exception ex) { Console.WriteLine("nnc_info_get_total_size threw: " + ex.Message); }
            try { var r = nnc_info_has_grid_index_list(IntPtr.Zero, 0); Console.WriteLine("nnc_info_has_grid_index_list -> " + r); } catch(Exception ex) { Console.WriteLine("nnc_info_has_grid_index_list threw: " + ex.Message); }
        }
    }
}
