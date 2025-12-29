// Auto-generated from resdata\well\well_conn.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_well_conn {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void well_conn_free(SafeConnHandle? conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool well_conn_MSW(SafeConnHandle? conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int well_conn_get_i(SafeConnHandle? conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int well_conn_get_j(SafeConnHandle? conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int well_conn_get_k(SafeConnHandle? conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr well_conn_get_dir(SafeConnHandle? conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool well_conn_open(SafeConnHandle? conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int well_conn_get_segment_id(SafeConnHandle? conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool well_conn_fracture_connection(SafeConnHandle? conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool well_conn_matrix_connection(SafeConnHandle? conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool well_conn_equal(SafeConn1Handle? conn1, SafeConn2Handle? conn2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_conn_get_connection_factor(SafeConnHandle? conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_conn_get_oil_rate(SafeConnHandle? conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_conn_get_gas_rate(SafeConnHandle? conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_conn_get_water_rate(SafeConnHandle? conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_conn_get_volume_rate(SafeConnHandle? conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_conn_get_oil_rate_si(SafeConnHandle? conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_conn_get_gas_rate_si(SafeConnHandle? conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_conn_get_water_rate_si(SafeConnHandle? conn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_conn_get_volume_rate_si(SafeConnHandle? conn);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\well\\well_conn.hpp");
            try { well_conn_free((SafeConnHandle?)null); Console.WriteLine("well_conn_free -> (void)"); } catch(Exception ex) { Console.WriteLine("well_conn_free threw: " + ex.Message); }
            try { var r = well_conn_MSW((SafeConnHandle?)null); Console.WriteLine("well_conn_MSW -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_MSW threw: " + ex.Message); }
            try { var r = well_conn_get_i((SafeConnHandle?)null); Console.WriteLine("well_conn_get_i -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_get_i threw: " + ex.Message); }
            try { var r = well_conn_get_j((SafeConnHandle?)null); Console.WriteLine("well_conn_get_j -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_get_j threw: " + ex.Message); }
            try { var r = well_conn_get_k((SafeConnHandle?)null); Console.WriteLine("well_conn_get_k -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_get_k threw: " + ex.Message); }
            try { var r = well_conn_get_dir((SafeConnHandle?)null); Console.WriteLine("well_conn_get_dir -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_get_dir threw: " + ex.Message); }
            try { var r = well_conn_open((SafeConnHandle?)null); Console.WriteLine("well_conn_open -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_open threw: " + ex.Message); }
            try { var r = well_conn_get_segment_id((SafeConnHandle?)null); Console.WriteLine("well_conn_get_segment_id -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_get_segment_id threw: " + ex.Message); }
            try { var r = well_conn_fracture_connection((SafeConnHandle?)null); Console.WriteLine("well_conn_fracture_connection -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_fracture_connection threw: " + ex.Message); }
            try { var r = well_conn_matrix_connection((SafeConnHandle?)null); Console.WriteLine("well_conn_matrix_connection -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_matrix_connection threw: " + ex.Message); }
            try { var r = well_conn_equal((SafeConn1Handle?)null, (SafeConn2Handle?)null); Console.WriteLine("well_conn_equal -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_equal threw: " + ex.Message); }
            try { var r = well_conn_get_connection_factor((SafeConnHandle?)null); Console.WriteLine("well_conn_get_connection_factor -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_get_connection_factor threw: " + ex.Message); }
            try { var r = well_conn_get_oil_rate((SafeConnHandle?)null); Console.WriteLine("well_conn_get_oil_rate -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_get_oil_rate threw: " + ex.Message); }
            try { var r = well_conn_get_gas_rate((SafeConnHandle?)null); Console.WriteLine("well_conn_get_gas_rate -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_get_gas_rate threw: " + ex.Message); }
            try { var r = well_conn_get_water_rate((SafeConnHandle?)null); Console.WriteLine("well_conn_get_water_rate -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_get_water_rate threw: " + ex.Message); }
            try { var r = well_conn_get_volume_rate((SafeConnHandle?)null); Console.WriteLine("well_conn_get_volume_rate -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_get_volume_rate threw: " + ex.Message); }
            try { var r = well_conn_get_oil_rate_si((SafeConnHandle?)null); Console.WriteLine("well_conn_get_oil_rate_si -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_get_oil_rate_si threw: " + ex.Message); }
            try { var r = well_conn_get_gas_rate_si((SafeConnHandle?)null); Console.WriteLine("well_conn_get_gas_rate_si -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_get_gas_rate_si threw: " + ex.Message); }
            try { var r = well_conn_get_water_rate_si((SafeConnHandle?)null); Console.WriteLine("well_conn_get_water_rate_si -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_get_water_rate_si threw: " + ex.Message); }
            try { var r = well_conn_get_volume_rate_si((SafeConnHandle?)null); Console.WriteLine("well_conn_get_volume_rate_si -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_get_volume_rate_si threw: " + ex.Message); }
        }
    }
}
