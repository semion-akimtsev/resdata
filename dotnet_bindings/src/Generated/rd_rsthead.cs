// Auto-generated from resdata\rd_rsthead.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_rd_rsthead {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_rsthead_free(IntPtr rsthead);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern long rd_rsthead_date(IntPtr intehead_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rsthead_get_sim_days(IntPtr header);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_rsthead_get_report_step(IntPtr header);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern long rd_rsthead_get_sim_time(IntPtr header);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_rsthead_get_nxconz(IntPtr rsthead);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_rsthead_get_ncwmax(IntPtr rsthead);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\rd_rsthead.hpp");
            try { rd_rsthead_free(IntPtr.Zero); Console.WriteLine("rd_rsthead_free -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_rsthead_free threw: " + ex.Message); }
            try { var r = rd_rsthead_date(IntPtr.Zero); Console.WriteLine("rd_rsthead_date -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rsthead_date threw: " + ex.Message); }
            try { var r = rd_rsthead_get_sim_days(IntPtr.Zero); Console.WriteLine("rd_rsthead_get_sim_days -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rsthead_get_sim_days threw: " + ex.Message); }
            try { var r = rd_rsthead_get_report_step(IntPtr.Zero); Console.WriteLine("rd_rsthead_get_report_step -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rsthead_get_report_step threw: " + ex.Message); }
            try { var r = rd_rsthead_get_sim_time(IntPtr.Zero); Console.WriteLine("rd_rsthead_get_sim_time -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rsthead_get_sim_time threw: " + ex.Message); }
            try { var r = rd_rsthead_get_nxconz(IntPtr.Zero); Console.WriteLine("rd_rsthead_get_nxconz -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rsthead_get_nxconz threw: " + ex.Message); }
            try { var r = rd_rsthead_get_ncwmax(IntPtr.Zero); Console.WriteLine("rd_rsthead_get_ncwmax -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rsthead_get_ncwmax threw: " + ex.Message); }
        }
    }
}
