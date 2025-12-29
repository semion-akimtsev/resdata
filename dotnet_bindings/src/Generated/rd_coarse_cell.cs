// Auto-generated from resdata\rd_coarse_cell.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_rd_coarse_cell {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_coarse_cell_free(SafeCoarseCellHandle? coarse_cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_coarse_cell_free__(SafeArgHandle? arg);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_coarse_cell_get_size(SafeCoarseCellHandle? coarse_cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_coarse_cell_reset_active_index(SafeCoarseCellHandle? coarse_cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_coarse_cell_get_active_index(SafeCoarseCellHandle? coarse_cell);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_coarse_cell_get_num_active(SafeCoarseCellHandle? coarse_cell);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\rd_coarse_cell.hpp");
            try { rd_coarse_cell_free((SafeCoarseCellHandle?)null); Console.WriteLine("rd_coarse_cell_free -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_coarse_cell_free threw: " + ex.Message); }
            try { rd_coarse_cell_free__((SafeArgHandle?)null); Console.WriteLine("rd_coarse_cell_free__ -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_coarse_cell_free__ threw: " + ex.Message); }
            try { var r = rd_coarse_cell_get_size((SafeCoarseCellHandle?)null); Console.WriteLine("rd_coarse_cell_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("rd_coarse_cell_get_size threw: " + ex.Message); }
            try { rd_coarse_cell_reset_active_index((SafeCoarseCellHandle?)null); Console.WriteLine("rd_coarse_cell_reset_active_index -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_coarse_cell_reset_active_index threw: " + ex.Message); }
            try { var r = rd_coarse_cell_get_active_index((SafeCoarseCellHandle?)null); Console.WriteLine("rd_coarse_cell_get_active_index -> " + r); } catch(Exception ex) { Console.WriteLine("rd_coarse_cell_get_active_index threw: " + ex.Message); }
            try { var r = rd_coarse_cell_get_num_active((SafeCoarseCellHandle?)null); Console.WriteLine("rd_coarse_cell_get_num_active -> " + r); } catch(Exception ex) { Console.WriteLine("rd_coarse_cell_get_num_active threw: " + ex.Message); }
        }
    }
}
