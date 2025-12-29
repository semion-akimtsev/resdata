// Auto-generated from resdata\nnc_info.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_nnc_info {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void nnc_info_free(SafeNncInfoHandle? nnc_info);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int nnc_info_get_lgr_nr(SafeNncInfoHandle? nnc_info);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int nnc_info_get_size(SafeNncInfoHandle? nnc_info);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int nnc_info_get_total_size(SafeNncInfoHandle? nnc_info);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool nnc_info_has_grid_index_list(SafeNncInfoHandle? nnc_info, int lgr_nr);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\nnc_info.hpp");
            try { nnc_info_free((SafeNncInfoHandle?)null); Console.WriteLine("nnc_info_free -> (void)"); } catch(Exception ex) { Console.WriteLine("nnc_info_free threw: " + ex.Message); }
            try { var r = nnc_info_get_lgr_nr((SafeNncInfoHandle?)null); Console.WriteLine("nnc_info_get_lgr_nr -> " + r); } catch(Exception ex) { Console.WriteLine("nnc_info_get_lgr_nr threw: " + ex.Message); }
            try { var r = nnc_info_get_size((SafeNncInfoHandle?)null); Console.WriteLine("nnc_info_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("nnc_info_get_size threw: " + ex.Message); }
            try { var r = nnc_info_get_total_size((SafeNncInfoHandle?)null); Console.WriteLine("nnc_info_get_total_size -> " + r); } catch(Exception ex) { Console.WriteLine("nnc_info_get_total_size threw: " + ex.Message); }
            try { var r = nnc_info_has_grid_index_list((SafeNncInfoHandle?)null, 0); Console.WriteLine("nnc_info_has_grid_index_list -> " + r); } catch(Exception ex) { Console.WriteLine("nnc_info_has_grid_index_list threw: " + ex.Message); }
        }
    }
}
