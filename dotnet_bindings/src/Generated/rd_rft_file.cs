// Auto-generated from resdata\rd_rft_file.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_rd_rft_file {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool rd_rft_file_case_has_rft(string case_input);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_rft_file_free(IntPtr p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_rft_file_get_size(IntPtr rft_file);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_rft_file_get_num_wells(IntPtr rft_file);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\rd_rft_file.hpp");
            try { var r = rd_rft_file_case_has_rft(null); Console.WriteLine("rd_rft_file_case_has_rft -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_file_case_has_rft threw: " + ex.Message); }
            try { rd_rft_file_free(IntPtr.Zero); Console.WriteLine("rd_rft_file_free -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_rft_file_free threw: " + ex.Message); }
            try { var r = rd_rft_file_get_size(IntPtr.Zero); Console.WriteLine("rd_rft_file_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_file_get_size threw: " + ex.Message); }
            try { var r = rd_rft_file_get_num_wells(IntPtr.Zero); Console.WriteLine("rd_rft_file_get_num_wells -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_file_get_num_wells threw: " + ex.Message); }
        }
    }
}
