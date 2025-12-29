// Auto-generated from resdata\rd_smspec.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_rd_smspec {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern IntPtr rd_smspec_identify_var_type(string var);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_smspec_free(IntPtr p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_smspec_get_date_day_index(IntPtr smspec);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_smspec_get_date_month_index(IntPtr smspec);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_smspec_get_date_year_index(IntPtr smspec);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_smspec_get_time_seconds(IntPtr rd_smspec);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_smspec_get_time_index(IntPtr rd_smspec);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern long rd_smspec_get_start_time(IntPtr p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_smspec_get_formatted(IntPtr rd_smspec);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_smspec_get_first_step(IntPtr rd_smspec);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_smspec_get_restart_step(IntPtr rd_smspec);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_smspec_get_params_size(IntPtr smspec);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_smspec_num_nodes(IntPtr smspec);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_smspec_equal(IntPtr self, IntPtr other);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr rd_smspec_get_unit_system(IntPtr smspec);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\rd_smspec.hpp");
            try { var r = rd_smspec_identify_var_type(null); Console.WriteLine("rd_smspec_identify_var_type -> " + r); } catch(Exception ex) { Console.WriteLine("rd_smspec_identify_var_type threw: " + ex.Message); }
            try { rd_smspec_free(IntPtr.Zero); Console.WriteLine("rd_smspec_free -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_smspec_free threw: " + ex.Message); }
            try { var r = rd_smspec_get_date_day_index(IntPtr.Zero); Console.WriteLine("rd_smspec_get_date_day_index -> " + r); } catch(Exception ex) { Console.WriteLine("rd_smspec_get_date_day_index threw: " + ex.Message); }
            try { var r = rd_smspec_get_date_month_index(IntPtr.Zero); Console.WriteLine("rd_smspec_get_date_month_index -> " + r); } catch(Exception ex) { Console.WriteLine("rd_smspec_get_date_month_index threw: " + ex.Message); }
            try { var r = rd_smspec_get_date_year_index(IntPtr.Zero); Console.WriteLine("rd_smspec_get_date_year_index -> " + r); } catch(Exception ex) { Console.WriteLine("rd_smspec_get_date_year_index threw: " + ex.Message); }
            try { var r = rd_smspec_get_time_seconds(IntPtr.Zero); Console.WriteLine("rd_smspec_get_time_seconds -> " + r); } catch(Exception ex) { Console.WriteLine("rd_smspec_get_time_seconds threw: " + ex.Message); }
            try { var r = rd_smspec_get_time_index(IntPtr.Zero); Console.WriteLine("rd_smspec_get_time_index -> " + r); } catch(Exception ex) { Console.WriteLine("rd_smspec_get_time_index threw: " + ex.Message); }
            try { var r = rd_smspec_get_start_time(IntPtr.Zero); Console.WriteLine("rd_smspec_get_start_time -> " + r); } catch(Exception ex) { Console.WriteLine("rd_smspec_get_start_time threw: " + ex.Message); }
            try { var r = rd_smspec_get_formatted(IntPtr.Zero); Console.WriteLine("rd_smspec_get_formatted -> " + r); } catch(Exception ex) { Console.WriteLine("rd_smspec_get_formatted threw: " + ex.Message); }
            try { var r = rd_smspec_get_first_step(IntPtr.Zero); Console.WriteLine("rd_smspec_get_first_step -> " + r); } catch(Exception ex) { Console.WriteLine("rd_smspec_get_first_step threw: " + ex.Message); }
            try { var r = rd_smspec_get_restart_step(IntPtr.Zero); Console.WriteLine("rd_smspec_get_restart_step -> " + r); } catch(Exception ex) { Console.WriteLine("rd_smspec_get_restart_step threw: " + ex.Message); }
            try { var r = rd_smspec_get_params_size(IntPtr.Zero); Console.WriteLine("rd_smspec_get_params_size -> " + r); } catch(Exception ex) { Console.WriteLine("rd_smspec_get_params_size threw: " + ex.Message); }
            try { var r = rd_smspec_num_nodes(IntPtr.Zero); Console.WriteLine("rd_smspec_num_nodes -> " + r); } catch(Exception ex) { Console.WriteLine("rd_smspec_num_nodes threw: " + ex.Message); }
            try { var r = rd_smspec_equal(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_smspec_equal -> " + r); } catch(Exception ex) { Console.WriteLine("rd_smspec_equal threw: " + ex.Message); }
            try { var r = rd_smspec_get_unit_system(IntPtr.Zero); Console.WriteLine("rd_smspec_get_unit_system -> " + r); } catch(Exception ex) { Console.WriteLine("rd_smspec_get_unit_system threw: " + ex.Message); }
        }
    }
}
