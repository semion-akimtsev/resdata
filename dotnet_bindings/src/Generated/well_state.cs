// Auto-generated from resdata\well\well_state.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_well_state {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool well_state_is_MSW(SafeWellStateHandle? well_state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool well_state_has_segment_data(SafeWellStateHandle? well_state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void well_state_free(SafeWellHandle? well);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int well_state_get_report_nr(SafeWellStateHandle? well_state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern long well_state_get_sim_time(SafeWellStateHandle? well_state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr well_state_get_type(SafeWellStateHandle? well_state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool well_state_is_open(SafeWellStateHandle? well_state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int well_state_get_well_nr(SafeWellStateHandle? well_state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr well_state_translate_rd_type_int(int int_type);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool well_state_has_global_connections(SafeWellStateHandle? well_state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_state_get_oil_rate(SafeWellStateHandle? well_state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_state_get_gas_rate(SafeWellStateHandle? well_state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_state_get_water_rate(SafeWellStateHandle? well_state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_state_get_volume_rate(SafeWellStateHandle? well_state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_state_get_water_rate_si(SafeWellStateHandle? well_state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_state_get_oil_rate_si(SafeWellStateHandle? well_state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_state_get_volume_rate_si(SafeWellStateHandle? well_state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_state_get_gas_rate_si(SafeWellStateHandle? well_state);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\well\\well_state.hpp");
            try { var r = well_state_is_MSW((SafeWellStateHandle?)null); Console.WriteLine("well_state_is_MSW -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_is_MSW threw: " + ex.Message); }
            try { var r = well_state_has_segment_data((SafeWellStateHandle?)null); Console.WriteLine("well_state_has_segment_data -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_has_segment_data threw: " + ex.Message); }
            try { well_state_free((SafeWellHandle?)null); Console.WriteLine("well_state_free -> (void)"); } catch(Exception ex) { Console.WriteLine("well_state_free threw: " + ex.Message); }
            try { var r = well_state_get_report_nr((SafeWellStateHandle?)null); Console.WriteLine("well_state_get_report_nr -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_get_report_nr threw: " + ex.Message); }
            try { var r = well_state_get_sim_time((SafeWellStateHandle?)null); Console.WriteLine("well_state_get_sim_time -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_get_sim_time threw: " + ex.Message); }
            try { var r = well_state_get_type((SafeWellStateHandle?)null); Console.WriteLine("well_state_get_type -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_get_type threw: " + ex.Message); }
            try { var r = well_state_is_open((SafeWellStateHandle?)null); Console.WriteLine("well_state_is_open -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_is_open threw: " + ex.Message); }
            try { var r = well_state_get_well_nr((SafeWellStateHandle?)null); Console.WriteLine("well_state_get_well_nr -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_get_well_nr threw: " + ex.Message); }
            try { var r = well_state_translate_rd_type_int(0); Console.WriteLine("well_state_translate_rd_type_int -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_translate_rd_type_int threw: " + ex.Message); }
            try { var r = well_state_has_global_connections((SafeWellStateHandle?)null); Console.WriteLine("well_state_has_global_connections -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_has_global_connections threw: " + ex.Message); }
            try { var r = well_state_get_oil_rate((SafeWellStateHandle?)null); Console.WriteLine("well_state_get_oil_rate -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_get_oil_rate threw: " + ex.Message); }
            try { var r = well_state_get_gas_rate((SafeWellStateHandle?)null); Console.WriteLine("well_state_get_gas_rate -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_get_gas_rate threw: " + ex.Message); }
            try { var r = well_state_get_water_rate((SafeWellStateHandle?)null); Console.WriteLine("well_state_get_water_rate -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_get_water_rate threw: " + ex.Message); }
            try { var r = well_state_get_volume_rate((SafeWellStateHandle?)null); Console.WriteLine("well_state_get_volume_rate -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_get_volume_rate threw: " + ex.Message); }
            try { var r = well_state_get_water_rate_si((SafeWellStateHandle?)null); Console.WriteLine("well_state_get_water_rate_si -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_get_water_rate_si threw: " + ex.Message); }
            try { var r = well_state_get_oil_rate_si((SafeWellStateHandle?)null); Console.WriteLine("well_state_get_oil_rate_si -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_get_oil_rate_si threw: " + ex.Message); }
            try { var r = well_state_get_volume_rate_si((SafeWellStateHandle?)null); Console.WriteLine("well_state_get_volume_rate_si -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_get_volume_rate_si threw: " + ex.Message); }
            try { var r = well_state_get_gas_rate_si((SafeWellStateHandle?)null); Console.WriteLine("well_state_get_gas_rate_si -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_get_gas_rate_si threw: " + ex.Message); }
        }
    }
}
