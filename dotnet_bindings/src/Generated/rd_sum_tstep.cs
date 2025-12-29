// Auto-generated from resdata\rd_sum_tstep.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_rd_sum_tstep {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_sum_tstep_free(SafeMinistepHandle? ministep);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_sum_tstep_free__(SafeMinistepHandle? __ministep);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_sum_tstep_iget(SafeMinistepHandle? ministep, int index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern long rd_sum_tstep_get_sim_time(SafeMinistepHandle? ministep);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_sum_tstep_get_sim_days(SafeMinistepHandle? ministep);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_sum_tstep_get_sim_seconds(SafeMinistepHandle? ministep);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_sum_tstep_get_report(SafeMinistepHandle? ministep);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_sum_tstep_get_ministep(SafeMinistepHandle? ministep);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_sum_tstep_iset(SafeTstepHandle? tstep, int index, float value);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool rd_sum_tstep_has_key(SafeTstepHandle? tstep, string? gen_key);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\rd_sum_tstep.hpp");
            try { rd_sum_tstep_free((SafeMinistepHandle?)null); Console.WriteLine("rd_sum_tstep_free -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_sum_tstep_free threw: " + ex.Message); }
            try { rd_sum_tstep_free__((SafeMinistepHandle?)null); Console.WriteLine("rd_sum_tstep_free__ -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_sum_tstep_free__ threw: " + ex.Message); }
            try { var r = rd_sum_tstep_iget((SafeMinistepHandle?)null, 0); Console.WriteLine("rd_sum_tstep_iget -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_tstep_iget threw: " + ex.Message); }
            try { var r = rd_sum_tstep_get_sim_time((SafeMinistepHandle?)null); Console.WriteLine("rd_sum_tstep_get_sim_time -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_tstep_get_sim_time threw: " + ex.Message); }
            try { var r = rd_sum_tstep_get_sim_days((SafeMinistepHandle?)null); Console.WriteLine("rd_sum_tstep_get_sim_days -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_tstep_get_sim_days threw: " + ex.Message); }
            try { var r = rd_sum_tstep_get_sim_seconds((SafeMinistepHandle?)null); Console.WriteLine("rd_sum_tstep_get_sim_seconds -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_tstep_get_sim_seconds threw: " + ex.Message); }
            try { var r = rd_sum_tstep_get_report((SafeMinistepHandle?)null); Console.WriteLine("rd_sum_tstep_get_report -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_tstep_get_report threw: " + ex.Message); }
            try { var r = rd_sum_tstep_get_ministep((SafeMinistepHandle?)null); Console.WriteLine("rd_sum_tstep_get_ministep -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_tstep_get_ministep threw: " + ex.Message); }
            try { rd_sum_tstep_iset((SafeTstepHandle?)null, 0, 0.0f); Console.WriteLine("rd_sum_tstep_iset -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_sum_tstep_iset threw: " + ex.Message); }
            try { var r = rd_sum_tstep_has_key((SafeTstepHandle?)null, (string?)null); Console.WriteLine("rd_sum_tstep_has_key -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_tstep_has_key threw: " + ex.Message); }
        }
    }
}
