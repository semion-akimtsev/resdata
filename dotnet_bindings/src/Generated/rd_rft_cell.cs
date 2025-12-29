// Auto-generated from resdata\rd_rft_cell.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_rd_rft_cell {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_rft_cell_free(SafeCellHandle? cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_rft_cell_ijk_equal(SafeCellHandle? cell, int i, int j, int k);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_rft_cell_get_ijk(SafeCellHandle? cell, SafeIHandle? i, SafeJHandle? j, SafeKHandle? k);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_rft_cell_get_i(SafeCellHandle? cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_rft_cell_get_j(SafeCellHandle? cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_rft_cell_get_k(SafeCellHandle? cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_cell_get_depth(SafeCellHandle? cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_cell_get_pressure(SafeCellHandle? cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_cell_get_swat(SafeCellHandle? cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_cell_get_sgas(SafeCellHandle? cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_cell_get_soil(SafeCellHandle? cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_cell_get_wrat(SafeCellHandle? cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_cell_get_grat(SafeCellHandle? cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_cell_get_orat(SafeCellHandle? cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_cell_get_connection_start(SafeCellHandle? cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_cell_get_connection_end(SafeCellHandle? cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_cell_get_flowrate(SafeCellHandle? cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_cell_get_oil_flowrate(SafeCellHandle? cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_cell_get_gas_flowrate(SafeCellHandle? cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_cell_get_water_flowrate(SafeCellHandle? cell);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\rd_rft_cell.hpp");
            try { rd_rft_cell_free((SafeCellHandle?)null); Console.WriteLine("rd_rft_cell_free -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_free threw: " + ex.Message); }
            try { var r = rd_rft_cell_ijk_equal((SafeCellHandle?)null, 0, 0, 0); Console.WriteLine("rd_rft_cell_ijk_equal -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_ijk_equal threw: " + ex.Message); }
            try { rd_rft_cell_get_ijk((SafeCellHandle?)null, (SafeIHandle?)null, (SafeJHandle?)null, (SafeKHandle?)null); Console.WriteLine("rd_rft_cell_get_ijk -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_ijk threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_i((SafeCellHandle?)null); Console.WriteLine("rd_rft_cell_get_i -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_i threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_j((SafeCellHandle?)null); Console.WriteLine("rd_rft_cell_get_j -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_j threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_k((SafeCellHandle?)null); Console.WriteLine("rd_rft_cell_get_k -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_k threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_depth((SafeCellHandle?)null); Console.WriteLine("rd_rft_cell_get_depth -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_depth threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_pressure((SafeCellHandle?)null); Console.WriteLine("rd_rft_cell_get_pressure -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_pressure threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_swat((SafeCellHandle?)null); Console.WriteLine("rd_rft_cell_get_swat -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_swat threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_sgas((SafeCellHandle?)null); Console.WriteLine("rd_rft_cell_get_sgas -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_sgas threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_soil((SafeCellHandle?)null); Console.WriteLine("rd_rft_cell_get_soil -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_soil threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_wrat((SafeCellHandle?)null); Console.WriteLine("rd_rft_cell_get_wrat -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_wrat threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_grat((SafeCellHandle?)null); Console.WriteLine("rd_rft_cell_get_grat -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_grat threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_orat((SafeCellHandle?)null); Console.WriteLine("rd_rft_cell_get_orat -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_orat threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_connection_start((SafeCellHandle?)null); Console.WriteLine("rd_rft_cell_get_connection_start -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_connection_start threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_connection_end((SafeCellHandle?)null); Console.WriteLine("rd_rft_cell_get_connection_end -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_connection_end threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_flowrate((SafeCellHandle?)null); Console.WriteLine("rd_rft_cell_get_flowrate -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_flowrate threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_oil_flowrate((SafeCellHandle?)null); Console.WriteLine("rd_rft_cell_get_oil_flowrate -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_oil_flowrate threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_gas_flowrate((SafeCellHandle?)null); Console.WriteLine("rd_rft_cell_get_gas_flowrate -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_gas_flowrate threw: " + ex.Message); }
            try { var r = rd_rft_cell_get_water_flowrate((SafeCellHandle?)null); Console.WriteLine("rd_rft_cell_get_water_flowrate -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_cell_get_water_flowrate threw: " + ex.Message); }
        }
    }
}
