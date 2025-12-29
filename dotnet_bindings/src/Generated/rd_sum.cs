// Auto-generated from resdata\rd_sum.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_rd_sum {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_sum_time2days(SafeRdSumHandle? rd_sum, long sim_time);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_sum_get_report_step_from_time(SafeSumHandle? sum, long sim_time);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_sum_get_report_step_from_days(SafeSumHandle? sum, double sim_days);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_sum_check_sim_time(SafeSumHandle? sum, long sim_time);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_sum_check_sim_days(SafeSumHandle? sum, double sim_days);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_sum_iget(SafeRdSumHandle? rd_sum, int time_index, int param_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_sum_get_data_length(SafeRdSumHandle? rd_sum);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_sum_free(SafeRdSumTypeHandle? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool rd_sum_has_general_var(SafeRdSumHandle? rd_sum, string? lookup_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool rd_sum_has_key(SafeRdSumHandle? rd_sum, string? lookup_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr rd_sum_get_unit_system(SafeRdSumHandle? rd_sum);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_sum_get_restart_step(SafeRdSumHandle? rd_sum);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_sum_get_last_report_step(SafeRdSumHandle? rd_sum);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_sum_get_first_report_step(SafeRdSumHandle? rd_sum);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern long rd_sum_get_report_time(SafeRdSumHandle? rd_sum, int report_step);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern long rd_sum_iget_sim_time(SafeRdSumHandle? rd_sum, int index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_sum_iget_sim_days(SafeRdSumHandle? rd_sum, int time_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_sum_iget_report_step(SafeRdSumHandle? rd_sum, int internal_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern long rd_sum_get_data_start(SafeRdSumHandle? rd_sum);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern long rd_sum_get_end_time(SafeRdSumHandle? rd_sum);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern long rd_sum_get_start_time(SafeRdSumTypeHandle? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_sum_get_sim_length(SafeRdSumHandle? rd_sum);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_sum_get_first_day(SafeRdSumHandle? rd_sum);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern IntPtr rd_sum_identify_var_type(string? var);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_sum_iget_report_end(SafeRdSumHandle? rd_sum, int report_step);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void rd_sum_set_case(SafeRdSumHandle? rd_sum, string? input_arg);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_sum_fwrite(SafeRdSumHandle? rd_sum);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_sum_can_write(SafeRdSumHandle? rd_sum);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\rd_sum.hpp");
            try { var r = rd_sum_time2days((SafeRdSumHandle?)null, 0L); Console.WriteLine("rd_sum_time2days -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_time2days threw: " + ex.Message); }
            try { var r = rd_sum_get_report_step_from_time((SafeSumHandle?)null, 0L); Console.WriteLine("rd_sum_get_report_step_from_time -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_get_report_step_from_time threw: " + ex.Message); }
            try { var r = rd_sum_get_report_step_from_days((SafeSumHandle?)null, 0.0); Console.WriteLine("rd_sum_get_report_step_from_days -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_get_report_step_from_days threw: " + ex.Message); }
            try { var r = rd_sum_check_sim_time((SafeSumHandle?)null, 0L); Console.WriteLine("rd_sum_check_sim_time -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_check_sim_time threw: " + ex.Message); }
            try { var r = rd_sum_check_sim_days((SafeSumHandle?)null, 0.0); Console.WriteLine("rd_sum_check_sim_days -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_check_sim_days threw: " + ex.Message); }
            try { var r = rd_sum_iget((SafeRdSumHandle?)null, 0, 0); Console.WriteLine("rd_sum_iget -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_iget threw: " + ex.Message); }
            try { var r = rd_sum_get_data_length((SafeRdSumHandle?)null); Console.WriteLine("rd_sum_get_data_length -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_get_data_length threw: " + ex.Message); }
            try { rd_sum_free((SafeRdSumTypeHandle?)null); Console.WriteLine("rd_sum_free -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_sum_free threw: " + ex.Message); }
            try { var r = rd_sum_has_general_var((SafeRdSumHandle?)null, (string?)null); Console.WriteLine("rd_sum_has_general_var -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_has_general_var threw: " + ex.Message); }
            try { var r = rd_sum_has_key((SafeRdSumHandle?)null, (string?)null); Console.WriteLine("rd_sum_has_key -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_has_key threw: " + ex.Message); }
            try { var r = rd_sum_get_unit_system((SafeRdSumHandle?)null); Console.WriteLine("rd_sum_get_unit_system -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_get_unit_system threw: " + ex.Message); }
            try { var r = rd_sum_get_restart_step((SafeRdSumHandle?)null); Console.WriteLine("rd_sum_get_restart_step -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_get_restart_step threw: " + ex.Message); }
            try { var r = rd_sum_get_last_report_step((SafeRdSumHandle?)null); Console.WriteLine("rd_sum_get_last_report_step -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_get_last_report_step threw: " + ex.Message); }
            try { var r = rd_sum_get_first_report_step((SafeRdSumHandle?)null); Console.WriteLine("rd_sum_get_first_report_step -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_get_first_report_step threw: " + ex.Message); }
            try { var r = rd_sum_get_report_time((SafeRdSumHandle?)null, 0); Console.WriteLine("rd_sum_get_report_time -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_get_report_time threw: " + ex.Message); }
            try { var r = rd_sum_iget_sim_time((SafeRdSumHandle?)null, 0); Console.WriteLine("rd_sum_iget_sim_time -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_iget_sim_time threw: " + ex.Message); }
            try { var r = rd_sum_iget_sim_days((SafeRdSumHandle?)null, 0); Console.WriteLine("rd_sum_iget_sim_days -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_iget_sim_days threw: " + ex.Message); }
            try { var r = rd_sum_iget_report_step((SafeRdSumHandle?)null, 0); Console.WriteLine("rd_sum_iget_report_step -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_iget_report_step threw: " + ex.Message); }
            try { var r = rd_sum_get_data_start((SafeRdSumHandle?)null); Console.WriteLine("rd_sum_get_data_start -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_get_data_start threw: " + ex.Message); }
            try { var r = rd_sum_get_end_time((SafeRdSumHandle?)null); Console.WriteLine("rd_sum_get_end_time -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_get_end_time threw: " + ex.Message); }
            try { var r = rd_sum_get_start_time((SafeRdSumTypeHandle?)null); Console.WriteLine("rd_sum_get_start_time -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_get_start_time threw: " + ex.Message); }
            try { var r = rd_sum_get_sim_length((SafeRdSumHandle?)null); Console.WriteLine("rd_sum_get_sim_length -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_get_sim_length threw: " + ex.Message); }
            try { var r = rd_sum_get_first_day((SafeRdSumHandle?)null); Console.WriteLine("rd_sum_get_first_day -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_get_first_day threw: " + ex.Message); }
            try { var r = rd_sum_identify_var_type((string?)null); Console.WriteLine("rd_sum_identify_var_type -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_identify_var_type threw: " + ex.Message); }
            try { var r = rd_sum_iget_report_end((SafeRdSumHandle?)null, 0); Console.WriteLine("rd_sum_iget_report_end -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_iget_report_end threw: " + ex.Message); }
            try { rd_sum_set_case((SafeRdSumHandle?)null, (string?)null); Console.WriteLine("rd_sum_set_case -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_sum_set_case threw: " + ex.Message); }
            try { rd_sum_fwrite((SafeRdSumHandle?)null); Console.WriteLine("rd_sum_fwrite -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_sum_fwrite threw: " + ex.Message); }
            try { var r = rd_sum_can_write((SafeRdSumHandle?)null); Console.WriteLine("rd_sum_can_write -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_can_write threw: " + ex.Message); }
        }
    }
}
