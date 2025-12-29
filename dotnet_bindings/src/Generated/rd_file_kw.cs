// Auto-generated from resdata\rd_file_kw.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_rd_file_kw {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void inv_map_free(IntPtr map);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_file_kw_equal(IntPtr kw1, IntPtr kw2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_file_kw_free(IntPtr file_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_file_kw_get_size(IntPtr file_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr rd_file_kw_get_data_type(IntPtr p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr rd_file_kw_get_offset(IntPtr file_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_file_kw_fskip_data(IntPtr file_kw, IntPtr fortio);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_file_kw_inplace_fwrite(IntPtr file_kw, IntPtr fortio);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_file_kw_fwrite(IntPtr file_kw, IntPtr stream);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_file_kw_end_transaction(IntPtr file_kw, int ref_count);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\rd_file_kw.hpp");
            try { inv_map_free(IntPtr.Zero); Console.WriteLine("inv_map_free -> (void)"); } catch(Exception ex) { Console.WriteLine("inv_map_free threw: " + ex.Message); }
            try { var r = rd_file_kw_equal(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_file_kw_equal -> " + r); } catch(Exception ex) { Console.WriteLine("rd_file_kw_equal threw: " + ex.Message); }
            try { rd_file_kw_free(IntPtr.Zero); Console.WriteLine("rd_file_kw_free -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_file_kw_free threw: " + ex.Message); }
            try { var r = rd_file_kw_get_size(IntPtr.Zero); Console.WriteLine("rd_file_kw_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("rd_file_kw_get_size threw: " + ex.Message); }
            try { var r = rd_file_kw_get_data_type(IntPtr.Zero); Console.WriteLine("rd_file_kw_get_data_type -> " + r); } catch(Exception ex) { Console.WriteLine("rd_file_kw_get_data_type threw: " + ex.Message); }
            try { var r = rd_file_kw_get_offset(IntPtr.Zero); Console.WriteLine("rd_file_kw_get_offset -> " + r); } catch(Exception ex) { Console.WriteLine("rd_file_kw_get_offset threw: " + ex.Message); }
            try { var r = rd_file_kw_fskip_data(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_file_kw_fskip_data -> " + r); } catch(Exception ex) { Console.WriteLine("rd_file_kw_fskip_data threw: " + ex.Message); }
            try { rd_file_kw_inplace_fwrite(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_file_kw_inplace_fwrite -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_file_kw_inplace_fwrite threw: " + ex.Message); }
            try { rd_file_kw_fwrite(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_file_kw_fwrite -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_file_kw_fwrite threw: " + ex.Message); }
            try { rd_file_kw_end_transaction(IntPtr.Zero, 0); Console.WriteLine("rd_file_kw_end_transaction -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_file_kw_end_transaction threw: " + ex.Message); }
        }
    }
}
