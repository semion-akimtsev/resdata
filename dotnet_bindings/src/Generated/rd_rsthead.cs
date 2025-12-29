// Auto-generated from resdata\rd_rsthead.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_rd_rsthead {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_rsthead_free(SafeRstheadHandle? rsthead);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern long rd_rsthead_date(SafeInteheadKwHandle? intehead_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rsthead_get_sim_days(SafeHeaderHandle? header);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_rsthead_get_report_step(SafeHeaderHandle? header);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern long rd_rsthead_get_sim_time(SafeHeaderHandle? header);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_rsthead_get_nxconz(SafeRstheadHandle? rsthead);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_rsthead_get_ncwmax(SafeRstheadHandle? rsthead);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\rd_rsthead.hpp");
            try { rd_rsthead_free((SafeRstheadHandle?)null); Console.WriteLine("rd_rsthead_free -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_rsthead_free threw: " + ex.Message); }
            try { var r = rd_rsthead_date((SafeInteheadKwHandle?)null); Console.WriteLine("rd_rsthead_date -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rsthead_date threw: " + ex.Message); }
            try { var r = rd_rsthead_get_sim_days((SafeHeaderHandle?)null); Console.WriteLine("rd_rsthead_get_sim_days -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rsthead_get_sim_days threw: " + ex.Message); }
            try { var r = rd_rsthead_get_report_step((SafeHeaderHandle?)null); Console.WriteLine("rd_rsthead_get_report_step -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rsthead_get_report_step threw: " + ex.Message); }
            try { var r = rd_rsthead_get_sim_time((SafeHeaderHandle?)null); Console.WriteLine("rd_rsthead_get_sim_time -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rsthead_get_sim_time threw: " + ex.Message); }
            try { var r = rd_rsthead_get_nxconz((SafeRstheadHandle?)null); Console.WriteLine("rd_rsthead_get_nxconz -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rsthead_get_nxconz threw: " + ex.Message); }
            try { var r = rd_rsthead_get_ncwmax((SafeRstheadHandle?)null); Console.WriteLine("rd_rsthead_get_ncwmax -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rsthead_get_ncwmax threw: " + ex.Message); }
        }
    }
}
