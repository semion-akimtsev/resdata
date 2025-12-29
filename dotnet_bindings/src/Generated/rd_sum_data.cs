// Auto-generated from resdata\rd_sum_data.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_rd_sum_data {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_sum_data_can_write(SafeDataHandle? data);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_sum_data_time2days(SafeDataHandle? data, long sim_time);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_sum_data_check_sim_time(SafeDataHandle? data, long sim_time);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_sum_data_check_sim_days(SafeDataHandle? data, double sim_days);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern long rd_sum_data_get_data_start(SafeDataHandle? data);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_sum_data_get_first_day(SafeDataHandle? data);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern long rd_sum_data_get_sim_end(SafeDataHandle? data);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_sum_data_get_sim_length(SafeDataHandle? data);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_sum_data_iget_sim_days(SafeRdSumDataTypeHandle? p0, int p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern long rd_sum_data_iget_sim_time(SafeRdSumDataTypeHandle? p0, int p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_sum_data_has_report_step(SafeRdSumDataTypeHandle? p0, int p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_sum_data_free(SafeRdSumDataTypeHandle? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_sum_data_get_last_report_step(SafeDataHandle? data);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_sum_data_get_first_report_step(SafeDataHandle? data);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_sum_data_get_length(SafeDataHandle? data);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_sum_data_iget_report_end(SafeDataHandle? data, int report_step);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\rd_sum_data.hpp");
            try { var r = rd_sum_data_can_write((SafeDataHandle?)null); Console.WriteLine("rd_sum_data_can_write -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_data_can_write threw: " + ex.Message); }
            try { var r = rd_sum_data_time2days((SafeDataHandle?)null, 0L); Console.WriteLine("rd_sum_data_time2days -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_data_time2days threw: " + ex.Message); }
            try { var r = rd_sum_data_check_sim_time((SafeDataHandle?)null, 0L); Console.WriteLine("rd_sum_data_check_sim_time -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_data_check_sim_time threw: " + ex.Message); }
            try { var r = rd_sum_data_check_sim_days((SafeDataHandle?)null, 0.0); Console.WriteLine("rd_sum_data_check_sim_days -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_data_check_sim_days threw: " + ex.Message); }
            try { var r = rd_sum_data_get_data_start((SafeDataHandle?)null); Console.WriteLine("rd_sum_data_get_data_start -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_data_get_data_start threw: " + ex.Message); }
            try { var r = rd_sum_data_get_first_day((SafeDataHandle?)null); Console.WriteLine("rd_sum_data_get_first_day -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_data_get_first_day threw: " + ex.Message); }
            try { var r = rd_sum_data_get_sim_end((SafeDataHandle?)null); Console.WriteLine("rd_sum_data_get_sim_end -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_data_get_sim_end threw: " + ex.Message); }
            try { var r = rd_sum_data_get_sim_length((SafeDataHandle?)null); Console.WriteLine("rd_sum_data_get_sim_length -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_data_get_sim_length threw: " + ex.Message); }
            try { var r = rd_sum_data_iget_sim_days((SafeRdSumDataTypeHandle?)null, 0); Console.WriteLine("rd_sum_data_iget_sim_days -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_data_iget_sim_days threw: " + ex.Message); }
            try { var r = rd_sum_data_iget_sim_time((SafeRdSumDataTypeHandle?)null, 0); Console.WriteLine("rd_sum_data_iget_sim_time -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_data_iget_sim_time threw: " + ex.Message); }
            try { var r = rd_sum_data_has_report_step((SafeRdSumDataTypeHandle?)null, 0); Console.WriteLine("rd_sum_data_has_report_step -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_data_has_report_step threw: " + ex.Message); }
            try { rd_sum_data_free((SafeRdSumDataTypeHandle?)null); Console.WriteLine("rd_sum_data_free -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_sum_data_free threw: " + ex.Message); }
            try { var r = rd_sum_data_get_last_report_step((SafeDataHandle?)null); Console.WriteLine("rd_sum_data_get_last_report_step -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_data_get_last_report_step threw: " + ex.Message); }
            try { var r = rd_sum_data_get_first_report_step((SafeDataHandle?)null); Console.WriteLine("rd_sum_data_get_first_report_step -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_data_get_first_report_step threw: " + ex.Message); }
            try { var r = rd_sum_data_get_length((SafeDataHandle?)null); Console.WriteLine("rd_sum_data_get_length -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_data_get_length threw: " + ex.Message); }
            try { var r = rd_sum_data_iget_report_end((SafeDataHandle?)null, 0); Console.WriteLine("rd_sum_data_iget_report_end -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_data_iget_report_end threw: " + ex.Message); }
        }
    }
}
