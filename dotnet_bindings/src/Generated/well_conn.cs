// Auto-generated from resdata\well\well_conn.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_well_conn {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void well_conn_free(IntPtr conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool well_conn_MSW(IntPtr conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int well_conn_get_i(IntPtr conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int well_conn_get_j(IntPtr conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int well_conn_get_k(IntPtr conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr well_conn_get_dir(IntPtr conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool well_conn_open(IntPtr conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int well_conn_get_segment_id(IntPtr conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool well_conn_fracture_connection(IntPtr conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool well_conn_matrix_connection(IntPtr conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool well_conn_equal(IntPtr conn1, IntPtr conn2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_conn_get_connection_factor(IntPtr conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_conn_get_oil_rate(IntPtr conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_conn_get_gas_rate(IntPtr conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_conn_get_water_rate(IntPtr conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_conn_get_volume_rate(IntPtr conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_conn_get_oil_rate_si(IntPtr conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_conn_get_gas_rate_si(IntPtr conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_conn_get_water_rate_si(IntPtr conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_conn_get_volume_rate_si(IntPtr conn);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\well\\well_conn.hpp");
            try { well_conn_free(IntPtr.Zero); Console.WriteLine("well_conn_free -> (void)"); } catch(Exception ex) { Console.WriteLine("well_conn_free threw: " + ex.Message); }
            try { var r = well_conn_MSW(IntPtr.Zero); Console.WriteLine("well_conn_MSW -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_MSW threw: " + ex.Message); }
            try { var r = well_conn_get_i(IntPtr.Zero); Console.WriteLine("well_conn_get_i -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_get_i threw: " + ex.Message); }
            try { var r = well_conn_get_j(IntPtr.Zero); Console.WriteLine("well_conn_get_j -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_get_j threw: " + ex.Message); }
            try { var r = well_conn_get_k(IntPtr.Zero); Console.WriteLine("well_conn_get_k -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_get_k threw: " + ex.Message); }
            try { var r = well_conn_get_dir(IntPtr.Zero); Console.WriteLine("well_conn_get_dir -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_get_dir threw: " + ex.Message); }
            try { var r = well_conn_open(IntPtr.Zero); Console.WriteLine("well_conn_open -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_open threw: " + ex.Message); }
            try { var r = well_conn_get_segment_id(IntPtr.Zero); Console.WriteLine("well_conn_get_segment_id -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_get_segment_id threw: " + ex.Message); }
            try { var r = well_conn_fracture_connection(IntPtr.Zero); Console.WriteLine("well_conn_fracture_connection -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_fracture_connection threw: " + ex.Message); }
            try { var r = well_conn_matrix_connection(IntPtr.Zero); Console.WriteLine("well_conn_matrix_connection -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_matrix_connection threw: " + ex.Message); }
            try { var r = well_conn_equal(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("well_conn_equal -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_equal threw: " + ex.Message); }
            try { var r = well_conn_get_connection_factor(IntPtr.Zero); Console.WriteLine("well_conn_get_connection_factor -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_get_connection_factor threw: " + ex.Message); }
            try { var r = well_conn_get_oil_rate(IntPtr.Zero); Console.WriteLine("well_conn_get_oil_rate -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_get_oil_rate threw: " + ex.Message); }
            try { var r = well_conn_get_gas_rate(IntPtr.Zero); Console.WriteLine("well_conn_get_gas_rate -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_get_gas_rate threw: " + ex.Message); }
            try { var r = well_conn_get_water_rate(IntPtr.Zero); Console.WriteLine("well_conn_get_water_rate -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_get_water_rate threw: " + ex.Message); }
            try { var r = well_conn_get_volume_rate(IntPtr.Zero); Console.WriteLine("well_conn_get_volume_rate -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_get_volume_rate threw: " + ex.Message); }
            try { var r = well_conn_get_oil_rate_si(IntPtr.Zero); Console.WriteLine("well_conn_get_oil_rate_si -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_get_oil_rate_si threw: " + ex.Message); }
            try { var r = well_conn_get_gas_rate_si(IntPtr.Zero); Console.WriteLine("well_conn_get_gas_rate_si -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_get_gas_rate_si threw: " + ex.Message); }
            try { var r = well_conn_get_water_rate_si(IntPtr.Zero); Console.WriteLine("well_conn_get_water_rate_si -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_get_water_rate_si threw: " + ex.Message); }
            try { var r = well_conn_get_volume_rate_si(IntPtr.Zero); Console.WriteLine("well_conn_get_volume_rate_si -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_get_volume_rate_si threw: " + ex.Message); }
        }
    }
}
