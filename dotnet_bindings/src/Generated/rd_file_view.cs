// Auto-generated from resdata\rd_file_view.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_rd_file_view {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_file_view_check_flags(int state_flags, int query_flags);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_file_view_make_index(SafeRdFileViewHandle? rd_file_view);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool rd_file_view_has_kw(SafeRdFileViewHandle? rd_file_view, string? kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_file_view_get_num_distinct_kw(SafeRdFileViewHandle? rd_file_view);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_file_view_get_size(SafeRdFileViewHandle? rd_file_view);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_file_view_load_all(SafeRdFileViewHandle? rd_file_view);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_file_view_free(SafeRdFileViewHandle? rd_file_view);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_file_view_drop_flag(SafeFileViewHandle? file_view, int flag);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_file_view_add_flag(SafeFileViewHandle? file_view, int flag);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_file_view_fclose_stream(SafeFileViewHandle? file_view);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\rd_file_view.hpp");
            try { var r = rd_file_view_check_flags(0, 0); Console.WriteLine("rd_file_view_check_flags -> " + r); } catch(Exception ex) { Console.WriteLine("rd_file_view_check_flags threw: " + ex.Message); }
            try { rd_file_view_make_index((SafeRdFileViewHandle?)null); Console.WriteLine("rd_file_view_make_index -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_file_view_make_index threw: " + ex.Message); }
            try { var r = rd_file_view_has_kw((SafeRdFileViewHandle?)null, (string?)null); Console.WriteLine("rd_file_view_has_kw -> " + r); } catch(Exception ex) { Console.WriteLine("rd_file_view_has_kw threw: " + ex.Message); }
            try { var r = rd_file_view_get_num_distinct_kw((SafeRdFileViewHandle?)null); Console.WriteLine("rd_file_view_get_num_distinct_kw -> " + r); } catch(Exception ex) { Console.WriteLine("rd_file_view_get_num_distinct_kw threw: " + ex.Message); }
            try { var r = rd_file_view_get_size((SafeRdFileViewHandle?)null); Console.WriteLine("rd_file_view_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("rd_file_view_get_size threw: " + ex.Message); }
            try { var r = rd_file_view_load_all((SafeRdFileViewHandle?)null); Console.WriteLine("rd_file_view_load_all -> " + r); } catch(Exception ex) { Console.WriteLine("rd_file_view_load_all threw: " + ex.Message); }
            try { rd_file_view_free((SafeRdFileViewHandle?)null); Console.WriteLine("rd_file_view_free -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_file_view_free threw: " + ex.Message); }
            try { var r = rd_file_view_drop_flag((SafeFileViewHandle?)null, 0); Console.WriteLine("rd_file_view_drop_flag -> " + r); } catch(Exception ex) { Console.WriteLine("rd_file_view_drop_flag threw: " + ex.Message); }
            try { rd_file_view_add_flag((SafeFileViewHandle?)null, 0); Console.WriteLine("rd_file_view_add_flag -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_file_view_add_flag threw: " + ex.Message); }
            try { rd_file_view_fclose_stream((SafeFileViewHandle?)null); Console.WriteLine("rd_file_view_fclose_stream -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_file_view_fclose_stream threw: " + ex.Message); }
        }
    }
}
