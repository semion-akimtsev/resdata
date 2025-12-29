// Auto-generated from resdata\well\well_state.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_well_state {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool well_state_is_MSW(IntPtr well_state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool well_state_has_segment_data(IntPtr well_state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void well_state_free(IntPtr well);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int well_state_get_report_nr(IntPtr well_state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern long well_state_get_sim_time(IntPtr well_state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr well_state_get_type(IntPtr well_state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool well_state_is_open(IntPtr well_state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int well_state_get_well_nr(IntPtr well_state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr well_state_translate_rd_type_int(int int_type);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool well_state_has_global_connections(IntPtr well_state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_state_get_oil_rate(IntPtr well_state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_state_get_gas_rate(IntPtr well_state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_state_get_water_rate(IntPtr well_state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_state_get_volume_rate(IntPtr well_state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_state_get_water_rate_si(IntPtr well_state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_state_get_oil_rate_si(IntPtr well_state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_state_get_volume_rate_si(IntPtr well_state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_state_get_gas_rate_si(IntPtr well_state);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\well\\well_state.hpp");
            try { var r = well_state_is_MSW(IntPtr.Zero); Console.WriteLine("well_state_is_MSW -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_is_MSW threw: " + ex.Message); }
            try { var r = well_state_has_segment_data(IntPtr.Zero); Console.WriteLine("well_state_has_segment_data -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_has_segment_data threw: " + ex.Message); }
            try { well_state_free(IntPtr.Zero); Console.WriteLine("well_state_free -> (void)"); } catch(Exception ex) { Console.WriteLine("well_state_free threw: " + ex.Message); }
            try { var r = well_state_get_report_nr(IntPtr.Zero); Console.WriteLine("well_state_get_report_nr -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_get_report_nr threw: " + ex.Message); }
            try { var r = well_state_get_sim_time(IntPtr.Zero); Console.WriteLine("well_state_get_sim_time -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_get_sim_time threw: " + ex.Message); }
            try { var r = well_state_get_type(IntPtr.Zero); Console.WriteLine("well_state_get_type -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_get_type threw: " + ex.Message); }
            try { var r = well_state_is_open(IntPtr.Zero); Console.WriteLine("well_state_is_open -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_is_open threw: " + ex.Message); }
            try { var r = well_state_get_well_nr(IntPtr.Zero); Console.WriteLine("well_state_get_well_nr -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_get_well_nr threw: " + ex.Message); }
            try { var r = well_state_translate_rd_type_int(0); Console.WriteLine("well_state_translate_rd_type_int -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_translate_rd_type_int threw: " + ex.Message); }
            try { var r = well_state_has_global_connections(IntPtr.Zero); Console.WriteLine("well_state_has_global_connections -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_has_global_connections threw: " + ex.Message); }
            try { var r = well_state_get_oil_rate(IntPtr.Zero); Console.WriteLine("well_state_get_oil_rate -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_get_oil_rate threw: " + ex.Message); }
            try { var r = well_state_get_gas_rate(IntPtr.Zero); Console.WriteLine("well_state_get_gas_rate -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_get_gas_rate threw: " + ex.Message); }
            try { var r = well_state_get_water_rate(IntPtr.Zero); Console.WriteLine("well_state_get_water_rate -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_get_water_rate threw: " + ex.Message); }
            try { var r = well_state_get_volume_rate(IntPtr.Zero); Console.WriteLine("well_state_get_volume_rate -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_get_volume_rate threw: " + ex.Message); }
            try { var r = well_state_get_water_rate_si(IntPtr.Zero); Console.WriteLine("well_state_get_water_rate_si -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_get_water_rate_si threw: " + ex.Message); }
            try { var r = well_state_get_oil_rate_si(IntPtr.Zero); Console.WriteLine("well_state_get_oil_rate_si -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_get_oil_rate_si threw: " + ex.Message); }
            try { var r = well_state_get_volume_rate_si(IntPtr.Zero); Console.WriteLine("well_state_get_volume_rate_si -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_get_volume_rate_si threw: " + ex.Message); }
            try { var r = well_state_get_gas_rate_si(IntPtr.Zero); Console.WriteLine("well_state_get_gas_rate_si -> " + r); } catch(Exception ex) { Console.WriteLine("well_state_get_gas_rate_si threw: " + ex.Message); }
        }
    }
}
