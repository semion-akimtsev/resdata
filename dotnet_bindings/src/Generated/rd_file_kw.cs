// Auto-generated from resdata\rd_file_kw.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_rd_file_kw {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void inv_map_free(SafeMapHandle? map);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_file_kw_equal(SafeKw1Handle? kw1, SafeKw2Handle? kw2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_file_kw_free(SafeFileKwHandle? file_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_file_kw_get_size(SafeFileKwHandle? file_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr rd_file_kw_get_data_type(SafeRdFileKwTypeHandle? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr rd_file_kw_get_offset(SafeFileKwHandle? file_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_file_kw_fskip_data(SafeFileKwHandle? file_kw, SafeFortioHandle? fortio);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_file_kw_inplace_fwrite(SafeFileKwHandle? file_kw, SafeFortioHandle? fortio);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_file_kw_fwrite(SafeFileKwHandle? file_kw, SafeStreamHandle? stream);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_file_kw_end_transaction(SafeFileKwHandle? file_kw, int ref_count);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\rd_file_kw.hpp");
            try { inv_map_free((SafeMapHandle?)null); Console.WriteLine("inv_map_free -> (void)"); } catch(Exception ex) { Console.WriteLine("inv_map_free threw: " + ex.Message); }
            try { var r = rd_file_kw_equal((SafeKw1Handle?)null, (SafeKw2Handle?)null); Console.WriteLine("rd_file_kw_equal -> " + r); } catch(Exception ex) { Console.WriteLine("rd_file_kw_equal threw: " + ex.Message); }
            try { rd_file_kw_free((SafeFileKwHandle?)null); Console.WriteLine("rd_file_kw_free -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_file_kw_free threw: " + ex.Message); }
            try { var r = rd_file_kw_get_size((SafeFileKwHandle?)null); Console.WriteLine("rd_file_kw_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("rd_file_kw_get_size threw: " + ex.Message); }
            try { var r = rd_file_kw_get_data_type((SafeRdFileKwTypeHandle?)null); Console.WriteLine("rd_file_kw_get_data_type -> " + r); } catch(Exception ex) { Console.WriteLine("rd_file_kw_get_data_type threw: " + ex.Message); }
            try { var r = rd_file_kw_get_offset((SafeFileKwHandle?)null); Console.WriteLine("rd_file_kw_get_offset -> " + r); } catch(Exception ex) { Console.WriteLine("rd_file_kw_get_offset threw: " + ex.Message); }
            try { var r = rd_file_kw_fskip_data((SafeFileKwHandle?)null, (SafeFortioHandle?)null); Console.WriteLine("rd_file_kw_fskip_data -> " + r); } catch(Exception ex) { Console.WriteLine("rd_file_kw_fskip_data threw: " + ex.Message); }
            try { rd_file_kw_inplace_fwrite((SafeFileKwHandle?)null, (SafeFortioHandle?)null); Console.WriteLine("rd_file_kw_inplace_fwrite -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_file_kw_inplace_fwrite threw: " + ex.Message); }
            try { rd_file_kw_fwrite((SafeFileKwHandle?)null, (SafeStreamHandle?)null); Console.WriteLine("rd_file_kw_fwrite -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_file_kw_fwrite threw: " + ex.Message); }
            try { rd_file_kw_end_transaction((SafeFileKwHandle?)null, 0); Console.WriteLine("rd_file_kw_end_transaction -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_file_kw_end_transaction threw: " + ex.Message); }
        }
    }
}
