// Auto-generated from resdata\rd_sum_tstep.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_rd_sum_tstep {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_sum_tstep_free(IntPtr ministep);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_sum_tstep_free__(IntPtr __ministep);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_sum_tstep_iget(IntPtr ministep, int index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern long rd_sum_tstep_get_sim_time(IntPtr ministep);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_sum_tstep_get_sim_days(IntPtr ministep);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_sum_tstep_get_sim_seconds(IntPtr ministep);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_sum_tstep_get_report(IntPtr ministep);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_sum_tstep_get_ministep(IntPtr ministep);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_sum_tstep_iset(IntPtr tstep, int index, float value);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool rd_sum_tstep_has_key(IntPtr tstep, string gen_key);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\rd_sum_tstep.hpp");
            try { rd_sum_tstep_free(IntPtr.Zero); Console.WriteLine("rd_sum_tstep_free -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_sum_tstep_free threw: " + ex.Message); }
            try { rd_sum_tstep_free__(IntPtr.Zero); Console.WriteLine("rd_sum_tstep_free__ -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_sum_tstep_free__ threw: " + ex.Message); }
            try { var r = rd_sum_tstep_iget(IntPtr.Zero, 0); Console.WriteLine("rd_sum_tstep_iget -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_tstep_iget threw: " + ex.Message); }
            try { var r = rd_sum_tstep_get_sim_time(IntPtr.Zero); Console.WriteLine("rd_sum_tstep_get_sim_time -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_tstep_get_sim_time threw: " + ex.Message); }
            try { var r = rd_sum_tstep_get_sim_days(IntPtr.Zero); Console.WriteLine("rd_sum_tstep_get_sim_days -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_tstep_get_sim_days threw: " + ex.Message); }
            try { var r = rd_sum_tstep_get_sim_seconds(IntPtr.Zero); Console.WriteLine("rd_sum_tstep_get_sim_seconds -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_tstep_get_sim_seconds threw: " + ex.Message); }
            try { var r = rd_sum_tstep_get_report(IntPtr.Zero); Console.WriteLine("rd_sum_tstep_get_report -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_tstep_get_report threw: " + ex.Message); }
            try { var r = rd_sum_tstep_get_ministep(IntPtr.Zero); Console.WriteLine("rd_sum_tstep_get_ministep -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_tstep_get_ministep threw: " + ex.Message); }
            try { rd_sum_tstep_iset(IntPtr.Zero, 0, 0.0f); Console.WriteLine("rd_sum_tstep_iset -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_sum_tstep_iset threw: " + ex.Message); }
            try { var r = rd_sum_tstep_has_key(IntPtr.Zero, null); Console.WriteLine("rd_sum_tstep_has_key -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_tstep_has_key threw: " + ex.Message); }
        }
    }
}
