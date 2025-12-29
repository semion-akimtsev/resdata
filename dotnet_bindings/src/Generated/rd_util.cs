// Auto-generated from resdata\rd_util.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_rd_util {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern int rd_filename_report_nr(string p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern long rd_get_start_date(string p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern int rd_get_num_cpu(string data_file);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool rd_fmt_file(string filename, IntPtr __fmt_file);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_fname_report_cmp(IntPtr f1, IntPtr f2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern long rd_make_date(int mday, int month, int year);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern long rd_make_date__(int mday, int month, int year, IntPtr year_offset);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_set_date_values(long t, IntPtr mday, IntPtr month, IntPtr year);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool rd_path_access(string rd_case);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\rd_util.hpp");
            try { var r = rd_filename_report_nr(null); Console.WriteLine("rd_filename_report_nr -> " + r); } catch(Exception ex) { Console.WriteLine("rd_filename_report_nr threw: " + ex.Message); }
            try { var r = rd_get_start_date(null); Console.WriteLine("rd_get_start_date -> " + r); } catch(Exception ex) { Console.WriteLine("rd_get_start_date threw: " + ex.Message); }
            try { var r = rd_get_num_cpu(null); Console.WriteLine("rd_get_num_cpu -> " + r); } catch(Exception ex) { Console.WriteLine("rd_get_num_cpu threw: " + ex.Message); }
            try { var r = rd_fmt_file(null, IntPtr.Zero); Console.WriteLine("rd_fmt_file -> " + r); } catch(Exception ex) { Console.WriteLine("rd_fmt_file threw: " + ex.Message); }
            try { var r = rd_fname_report_cmp(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_fname_report_cmp -> " + r); } catch(Exception ex) { Console.WriteLine("rd_fname_report_cmp threw: " + ex.Message); }
            try { var r = rd_make_date(0, 0, 0); Console.WriteLine("rd_make_date -> " + r); } catch(Exception ex) { Console.WriteLine("rd_make_date threw: " + ex.Message); }
            try { var r = rd_make_date__(0, 0, 0, IntPtr.Zero); Console.WriteLine("rd_make_date__ -> " + r); } catch(Exception ex) { Console.WriteLine("rd_make_date__ threw: " + ex.Message); }
            try { rd_set_date_values(0L, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_set_date_values -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_set_date_values threw: " + ex.Message); }
            try { var r = rd_path_access(null); Console.WriteLine("rd_path_access -> " + r); } catch(Exception ex) { Console.WriteLine("rd_path_access threw: " + ex.Message); }
        }
    }
}
