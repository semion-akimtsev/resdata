// Auto-generated from resdata\rd_smspec.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_rd_smspec {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern IntPtr rd_smspec_identify_var_type(string? var);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_smspec_free(SafeRdSmspecTypeHandle? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_smspec_get_date_day_index(SafeSmspecHandle? smspec);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_smspec_get_date_month_index(SafeSmspecHandle? smspec);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_smspec_get_date_year_index(SafeSmspecHandle? smspec);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_smspec_get_time_seconds(SafeRdSmspecHandle? rd_smspec);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_smspec_get_time_index(SafeRdSmspecHandle? rd_smspec);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern long rd_smspec_get_start_time(SafeRdSmspecTypeHandle? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_smspec_get_formatted(SafeRdSmspecHandle? rd_smspec);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_smspec_get_first_step(SafeRdSmspecHandle? rd_smspec);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_smspec_get_restart_step(SafeRdSmspecHandle? rd_smspec);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_smspec_get_params_size(SafeSmspecHandle? smspec);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_smspec_num_nodes(SafeSmspecHandle? smspec);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_smspec_equal(SafeSelfHandle? self, SafeOtherHandle? other);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr rd_smspec_get_unit_system(SafeSmspecHandle? smspec);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\rd_smspec.hpp");
            try { var r = rd_smspec_identify_var_type((string?)null); Console.WriteLine("rd_smspec_identify_var_type -> " + r); } catch(Exception ex) { Console.WriteLine("rd_smspec_identify_var_type threw: " + ex.Message); }
            try { rd_smspec_free((SafeRdSmspecTypeHandle?)null); Console.WriteLine("rd_smspec_free -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_smspec_free threw: " + ex.Message); }
            try { var r = rd_smspec_get_date_day_index((SafeSmspecHandle?)null); Console.WriteLine("rd_smspec_get_date_day_index -> " + r); } catch(Exception ex) { Console.WriteLine("rd_smspec_get_date_day_index threw: " + ex.Message); }
            try { var r = rd_smspec_get_date_month_index((SafeSmspecHandle?)null); Console.WriteLine("rd_smspec_get_date_month_index -> " + r); } catch(Exception ex) { Console.WriteLine("rd_smspec_get_date_month_index threw: " + ex.Message); }
            try { var r = rd_smspec_get_date_year_index((SafeSmspecHandle?)null); Console.WriteLine("rd_smspec_get_date_year_index -> " + r); } catch(Exception ex) { Console.WriteLine("rd_smspec_get_date_year_index threw: " + ex.Message); }
            try { var r = rd_smspec_get_time_seconds((SafeRdSmspecHandle?)null); Console.WriteLine("rd_smspec_get_time_seconds -> " + r); } catch(Exception ex) { Console.WriteLine("rd_smspec_get_time_seconds threw: " + ex.Message); }
            try { var r = rd_smspec_get_time_index((SafeRdSmspecHandle?)null); Console.WriteLine("rd_smspec_get_time_index -> " + r); } catch(Exception ex) { Console.WriteLine("rd_smspec_get_time_index threw: " + ex.Message); }
            try { var r = rd_smspec_get_start_time((SafeRdSmspecTypeHandle?)null); Console.WriteLine("rd_smspec_get_start_time -> " + r); } catch(Exception ex) { Console.WriteLine("rd_smspec_get_start_time threw: " + ex.Message); }
            try { var r = rd_smspec_get_formatted((SafeRdSmspecHandle?)null); Console.WriteLine("rd_smspec_get_formatted -> " + r); } catch(Exception ex) { Console.WriteLine("rd_smspec_get_formatted threw: " + ex.Message); }
            try { var r = rd_smspec_get_first_step((SafeRdSmspecHandle?)null); Console.WriteLine("rd_smspec_get_first_step -> " + r); } catch(Exception ex) { Console.WriteLine("rd_smspec_get_first_step threw: " + ex.Message); }
            try { var r = rd_smspec_get_restart_step((SafeRdSmspecHandle?)null); Console.WriteLine("rd_smspec_get_restart_step -> " + r); } catch(Exception ex) { Console.WriteLine("rd_smspec_get_restart_step threw: " + ex.Message); }
            try { var r = rd_smspec_get_params_size((SafeSmspecHandle?)null); Console.WriteLine("rd_smspec_get_params_size -> " + r); } catch(Exception ex) { Console.WriteLine("rd_smspec_get_params_size threw: " + ex.Message); }
            try { var r = rd_smspec_num_nodes((SafeSmspecHandle?)null); Console.WriteLine("rd_smspec_num_nodes -> " + r); } catch(Exception ex) { Console.WriteLine("rd_smspec_num_nodes threw: " + ex.Message); }
            try { var r = rd_smspec_equal((SafeSelfHandle?)null, (SafeOtherHandle?)null); Console.WriteLine("rd_smspec_equal -> " + r); } catch(Exception ex) { Console.WriteLine("rd_smspec_equal threw: " + ex.Message); }
            try { var r = rd_smspec_get_unit_system((SafeSmspecHandle?)null); Console.WriteLine("rd_smspec_get_unit_system -> " + r); } catch(Exception ex) { Console.WriteLine("rd_smspec_get_unit_system threw: " + ex.Message); }
        }
    }
}
