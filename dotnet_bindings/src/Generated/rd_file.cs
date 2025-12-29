// Auto-generated from resdata\rd_file.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_rd_file {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_file_load_all(SafeRdFileHandle? rd_file);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool rd_file_index_valid(string? file_name, string? index_file_name);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_file_close(SafeRdFileHandle? rd_file);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool rd_file_has_kw(SafeRdFileHandle? rd_file, string? kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern int rd_file_get_num_named_kw(SafeRdFileHandle? rd_file, string? kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_file_get_size(SafeRdFileHandle? rd_file);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr rd_file_get_rd_version(SafeFileHandle? file);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_file_get_phases(SafeInitFileHandle? init_file);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_file_writable(SafeRdFileHandle? rd_file);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_file_flags_set(SafeRdFileHandle? rd_file, int flags);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_file_save_kw(SafeRdFileHandle? rd_file, SafeRdKwHandle? rd_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_file_has_report_step(SafeRdFileHandle? rd_file, int report_step);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_file_has_sim_time(SafeRdFileHandle? rd_file, long sim_time);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\rd_file.hpp");
            try { var r = rd_file_load_all((SafeRdFileHandle?)null); Console.WriteLine("rd_file_load_all -> " + r); } catch(Exception ex) { Console.WriteLine("rd_file_load_all threw: " + ex.Message); }
            try { var r = rd_file_index_valid((string?)null, (string?)null); Console.WriteLine("rd_file_index_valid -> " + r); } catch(Exception ex) { Console.WriteLine("rd_file_index_valid threw: " + ex.Message); }
            try { rd_file_close((SafeRdFileHandle?)null); Console.WriteLine("rd_file_close -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_file_close threw: " + ex.Message); }
            try { var r = rd_file_has_kw((SafeRdFileHandle?)null, (string?)null); Console.WriteLine("rd_file_has_kw -> " + r); } catch(Exception ex) { Console.WriteLine("rd_file_has_kw threw: " + ex.Message); }
            try { var r = rd_file_get_num_named_kw((SafeRdFileHandle?)null, (string?)null); Console.WriteLine("rd_file_get_num_named_kw -> " + r); } catch(Exception ex) { Console.WriteLine("rd_file_get_num_named_kw threw: " + ex.Message); }
            try { var r = rd_file_get_size((SafeRdFileHandle?)null); Console.WriteLine("rd_file_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("rd_file_get_size threw: " + ex.Message); }
            try { var r = rd_file_get_rd_version((SafeFileHandle?)null); Console.WriteLine("rd_file_get_rd_version -> " + r); } catch(Exception ex) { Console.WriteLine("rd_file_get_rd_version threw: " + ex.Message); }
            try { var r = rd_file_get_phases((SafeInitFileHandle?)null); Console.WriteLine("rd_file_get_phases -> " + r); } catch(Exception ex) { Console.WriteLine("rd_file_get_phases threw: " + ex.Message); }
            try { var r = rd_file_writable((SafeRdFileHandle?)null); Console.WriteLine("rd_file_writable -> " + r); } catch(Exception ex) { Console.WriteLine("rd_file_writable threw: " + ex.Message); }
            try { var r = rd_file_flags_set((SafeRdFileHandle?)null, 0); Console.WriteLine("rd_file_flags_set -> " + r); } catch(Exception ex) { Console.WriteLine("rd_file_flags_set threw: " + ex.Message); }
            try { var r = rd_file_save_kw((SafeRdFileHandle?)null, (SafeRdKwHandle?)null); Console.WriteLine("rd_file_save_kw -> " + r); } catch(Exception ex) { Console.WriteLine("rd_file_save_kw threw: " + ex.Message); }
            try { var r = rd_file_has_report_step((SafeRdFileHandle?)null, 0); Console.WriteLine("rd_file_has_report_step -> " + r); } catch(Exception ex) { Console.WriteLine("rd_file_has_report_step threw: " + ex.Message); }
            try { var r = rd_file_has_sim_time((SafeRdFileHandle?)null, 0L); Console.WriteLine("rd_file_has_sim_time -> " + r); } catch(Exception ex) { Console.WriteLine("rd_file_has_sim_time threw: " + ex.Message); }
        }
    }
}
