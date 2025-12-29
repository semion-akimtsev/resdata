// Auto-generated from resdata\rd_sum.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_rd_sum {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_sum_time2days(IntPtr rd_sum, long sim_time);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_sum_get_report_step_from_time(IntPtr sum, long sim_time);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_sum_get_report_step_from_days(IntPtr sum, double sim_days);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_sum_check_sim_time(IntPtr sum, long sim_time);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_sum_check_sim_days(IntPtr sum, double sim_days);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_sum_iget(IntPtr rd_sum, int time_index, int param_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_sum_get_data_length(IntPtr rd_sum);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_sum_free(IntPtr p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool rd_sum_has_general_var(IntPtr rd_sum, string lookup_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool rd_sum_has_key(IntPtr rd_sum, string lookup_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr rd_sum_get_unit_system(IntPtr rd_sum);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_sum_get_restart_step(IntPtr rd_sum);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_sum_get_last_report_step(IntPtr rd_sum);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_sum_get_first_report_step(IntPtr rd_sum);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern long rd_sum_get_report_time(IntPtr rd_sum, int report_step);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern long rd_sum_iget_sim_time(IntPtr rd_sum, int index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_sum_iget_sim_days(IntPtr rd_sum, int time_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_sum_iget_report_step(IntPtr rd_sum, int internal_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern long rd_sum_get_data_start(IntPtr rd_sum);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern long rd_sum_get_end_time(IntPtr rd_sum);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern long rd_sum_get_start_time(IntPtr p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_sum_get_sim_length(IntPtr rd_sum);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_sum_get_first_day(IntPtr rd_sum);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern IntPtr rd_sum_identify_var_type(string var);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_sum_iget_report_end(IntPtr rd_sum, int report_step);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void rd_sum_set_case(IntPtr rd_sum, string input_arg);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_sum_fwrite(IntPtr rd_sum);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_sum_can_write(IntPtr rd_sum);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\rd_sum.hpp");
            try { var r = rd_sum_time2days(IntPtr.Zero, 0L); Console.WriteLine("rd_sum_time2days -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_time2days threw: " + ex.Message); }
            try { var r = rd_sum_get_report_step_from_time(IntPtr.Zero, 0L); Console.WriteLine("rd_sum_get_report_step_from_time -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_get_report_step_from_time threw: " + ex.Message); }
            try { var r = rd_sum_get_report_step_from_days(IntPtr.Zero, 0.0); Console.WriteLine("rd_sum_get_report_step_from_days -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_get_report_step_from_days threw: " + ex.Message); }
            try { var r = rd_sum_check_sim_time(IntPtr.Zero, 0L); Console.WriteLine("rd_sum_check_sim_time -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_check_sim_time threw: " + ex.Message); }
            try { var r = rd_sum_check_sim_days(IntPtr.Zero, 0.0); Console.WriteLine("rd_sum_check_sim_days -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_check_sim_days threw: " + ex.Message); }
            try { var r = rd_sum_iget(IntPtr.Zero, 0, 0); Console.WriteLine("rd_sum_iget -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_iget threw: " + ex.Message); }
            try { var r = rd_sum_get_data_length(IntPtr.Zero); Console.WriteLine("rd_sum_get_data_length -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_get_data_length threw: " + ex.Message); }
            try { rd_sum_free(IntPtr.Zero); Console.WriteLine("rd_sum_free -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_sum_free threw: " + ex.Message); }
            try { var r = rd_sum_has_general_var(IntPtr.Zero, null); Console.WriteLine("rd_sum_has_general_var -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_has_general_var threw: " + ex.Message); }
            try { var r = rd_sum_has_key(IntPtr.Zero, null); Console.WriteLine("rd_sum_has_key -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_has_key threw: " + ex.Message); }
            try { var r = rd_sum_get_unit_system(IntPtr.Zero); Console.WriteLine("rd_sum_get_unit_system -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_get_unit_system threw: " + ex.Message); }
            try { var r = rd_sum_get_restart_step(IntPtr.Zero); Console.WriteLine("rd_sum_get_restart_step -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_get_restart_step threw: " + ex.Message); }
            try { var r = rd_sum_get_last_report_step(IntPtr.Zero); Console.WriteLine("rd_sum_get_last_report_step -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_get_last_report_step threw: " + ex.Message); }
            try { var r = rd_sum_get_first_report_step(IntPtr.Zero); Console.WriteLine("rd_sum_get_first_report_step -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_get_first_report_step threw: " + ex.Message); }
            try { var r = rd_sum_get_report_time(IntPtr.Zero, 0); Console.WriteLine("rd_sum_get_report_time -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_get_report_time threw: " + ex.Message); }
            try { var r = rd_sum_iget_sim_time(IntPtr.Zero, 0); Console.WriteLine("rd_sum_iget_sim_time -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_iget_sim_time threw: " + ex.Message); }
            try { var r = rd_sum_iget_sim_days(IntPtr.Zero, 0); Console.WriteLine("rd_sum_iget_sim_days -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_iget_sim_days threw: " + ex.Message); }
            try { var r = rd_sum_iget_report_step(IntPtr.Zero, 0); Console.WriteLine("rd_sum_iget_report_step -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_iget_report_step threw: " + ex.Message); }
            try { var r = rd_sum_get_data_start(IntPtr.Zero); Console.WriteLine("rd_sum_get_data_start -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_get_data_start threw: " + ex.Message); }
            try { var r = rd_sum_get_end_time(IntPtr.Zero); Console.WriteLine("rd_sum_get_end_time -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_get_end_time threw: " + ex.Message); }
            try { var r = rd_sum_get_start_time(IntPtr.Zero); Console.WriteLine("rd_sum_get_start_time -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_get_start_time threw: " + ex.Message); }
            try { var r = rd_sum_get_sim_length(IntPtr.Zero); Console.WriteLine("rd_sum_get_sim_length -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_get_sim_length threw: " + ex.Message); }
            try { var r = rd_sum_get_first_day(IntPtr.Zero); Console.WriteLine("rd_sum_get_first_day -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_get_first_day threw: " + ex.Message); }
            try { var r = rd_sum_identify_var_type(null); Console.WriteLine("rd_sum_identify_var_type -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_identify_var_type threw: " + ex.Message); }
            try { var r = rd_sum_iget_report_end(IntPtr.Zero, 0); Console.WriteLine("rd_sum_iget_report_end -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_iget_report_end threw: " + ex.Message); }
            try { rd_sum_set_case(IntPtr.Zero, null); Console.WriteLine("rd_sum_set_case -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_sum_set_case threw: " + ex.Message); }
            try { rd_sum_fwrite(IntPtr.Zero); Console.WriteLine("rd_sum_fwrite -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_sum_fwrite threw: " + ex.Message); }
            try { var r = rd_sum_can_write(IntPtr.Zero); Console.WriteLine("rd_sum_can_write -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_can_write threw: " + ex.Message); }
        }
    }
}
