// Auto-generated from resdata\rd_rft_cell.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_rd_rft_cell {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_rft_cell_free(IntPtr cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_rft_cell_ijk_equal(IntPtr cell, int i, int j, int k);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_rft_cell_get_ijk(IntPtr cell, IntPtr i, IntPtr j, IntPtr k);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_rft_cell_get_i(IntPtr cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_rft_cell_get_j(IntPtr cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_rft_cell_get_k(IntPtr cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_cell_get_depth(IntPtr cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_cell_get_pressure(IntPtr cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_cell_get_swat(IntPtr cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_cell_get_sgas(IntPtr cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_cell_get_soil(IntPtr cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_cell_get_wrat(IntPtr cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_cell_get_grat(IntPtr cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_cell_get_orat(IntPtr cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_cell_get_connection_start(IntPtr cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_cell_get_connection_end(IntPtr cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_cell_get_flowrate(IntPtr cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_cell_get_oil_flowrate(IntPtr cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_cell_get_gas_flowrate(IntPtr cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_cell_get_water_flowrate(IntPtr cell);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\rd_rft_cell.hpp");
            try { rd_rft_cell_free(IntPtr.Zero); Console.WriteLine("rd_rft_cell_free -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_free threw: " + ex.Message); }
            try { var r = rd_rft_cell_ijk_equal(IntPtr.Zero, 0, 0, 0); Console.WriteLine("rd_rft_cell_ijk_equal -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_ijk_equal threw: " + ex.Message); }
            try { rd_rft_cell_get_ijk(IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_rft_cell_get_ijk -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_ijk threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_i(IntPtr.Zero); Console.WriteLine("rd_rft_cell_get_i -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_i threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_j(IntPtr.Zero); Console.WriteLine("rd_rft_cell_get_j -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_j threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_k(IntPtr.Zero); Console.WriteLine("rd_rft_cell_get_k -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_k threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_depth(IntPtr.Zero); Console.WriteLine("rd_rft_cell_get_depth -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_depth threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_pressure(IntPtr.Zero); Console.WriteLine("rd_rft_cell_get_pressure -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_pressure threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_swat(IntPtr.Zero); Console.WriteLine("rd_rft_cell_get_swat -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_swat threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_sgas(IntPtr.Zero); Console.WriteLine("rd_rft_cell_get_sgas -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_sgas threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_soil(IntPtr.Zero); Console.WriteLine("rd_rft_cell_get_soil -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_soil threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_wrat(IntPtr.Zero); Console.WriteLine("rd_rft_cell_get_wrat -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_wrat threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_grat(IntPtr.Zero); Console.WriteLine("rd_rft_cell_get_grat -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_grat threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_orat(IntPtr.Zero); Console.WriteLine("rd_rft_cell_get_orat -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_orat threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_connection_start(IntPtr.Zero); Console.WriteLine("rd_rft_cell_get_connection_start -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_connection_start threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_connection_end(IntPtr.Zero); Console.WriteLine("rd_rft_cell_get_connection_end -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_connection_end threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_flowrate(IntPtr.Zero); Console.WriteLine("rd_rft_cell_get_flowrate -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_flowrate threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_oil_flowrate(IntPtr.Zero); Console.WriteLine("rd_rft_cell_get_oil_flowrate -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_oil_flowrate threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_gas_flowrate(IntPtr.Zero); Console.WriteLine("rd_rft_cell_get_gas_flowrate -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_gas_flowrate threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_water_flowrate(IntPtr.Zero); Console.WriteLine("rd_rft_cell_get_water_flowrate -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_water_flowrate threw: " + ex.Message); }
        }
    }
}
