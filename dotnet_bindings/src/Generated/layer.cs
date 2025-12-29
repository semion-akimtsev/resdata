// Auto-generated from resdata\layer.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_layer {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool layer_iget_left_barrier(IntPtr layer, int i, int j);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool layer_iget_bottom_barrier(IntPtr layer, int i, int j);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int layer_get_nx(IntPtr layer);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int layer_get_ny(IntPtr layer);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void layer_free(IntPtr layer);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int layer_replace_cell_values(IntPtr layer, int old_value, int new_value);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool layer_iget_active(IntPtr layer, int i, int j);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int layer_iget_cell_value(IntPtr layer, int i, int j);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void layer_iset_cell_value(IntPtr layer, int i, int j, int value);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool layer_cell_on_edge(IntPtr layer, int i, int j);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int layer_get_cell_sum(IntPtr layer);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void layer_add_interp_barrier(IntPtr layer, int c1, int c2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void layer_add_ijbarrier(IntPtr layer, int i1, int j1, int i2, int j2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void layer_add_barrier(IntPtr layer, int c1, int c2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void layer_memcpy(IntPtr target_layer, IntPtr src_layer);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void layer_update_active(IntPtr layer, IntPtr grid, int k);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void layer_clear_cells(IntPtr layer);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void layer_assign(IntPtr layer, int value);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int layer_count_equal(IntPtr layer, int value);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\layer.hpp");
            try { var r = layer_iget_left_barrier(IntPtr.Zero, 0, 0); Console.WriteLine("layer_iget_left_barrier -> " + r); } catch(Exception ex) { Console.WriteLine("layer_iget_left_barrier threw: " + ex.Message); }
            try { var r = layer_iget_bottom_barrier(IntPtr.Zero, 0, 0); Console.WriteLine("layer_iget_bottom_barrier -> " + r); } catch(Exception ex) { Console.WriteLine("layer_iget_bottom_barrier threw: " + ex.Message); }
            try { var r = layer_get_nx(IntPtr.Zero); Console.WriteLine("layer_get_nx -> " + r); } catch(Exception ex) { Console.WriteLine("layer_get_nx threw: " + ex.Message); }
            try { var r = layer_get_ny(IntPtr.Zero); Console.WriteLine("layer_get_ny -> " + r); } catch(Exception ex) { Console.WriteLine("layer_get_ny threw: " + ex.Message); }
            try { layer_free(IntPtr.Zero); Console.WriteLine("layer_free -> (void)"); } catch(Exception ex) { Console.WriteLine("layer_free threw: " + ex.Message); }
            try { var r = layer_replace_cell_values(IntPtr.Zero, 0, 0); Console.WriteLine("layer_replace_cell_values -> " + r); } catch(Exception ex) { Console.WriteLine("layer_replace_cell_values threw: " + ex.Message); }
            try { var r = layer_iget_active(IntPtr.Zero, 0, 0); Console.WriteLine("layer_iget_active -> " + r); } catch(Exception ex) { Console.WriteLine("layer_iget_active threw: " + ex.Message); }
            try { var r = layer_iget_cell_value(IntPtr.Zero, 0, 0); Console.WriteLine("layer_iget_cell_value -> " + r); } catch(Exception ex) { Console.WriteLine("layer_iget_cell_value threw: " + ex.Message); }
            try { layer_iset_cell_value(IntPtr.Zero, 0, 0, 0); Console.WriteLine("layer_iset_cell_value -> (void)"); } catch(Exception ex) { Console.WriteLine("layer_iset_cell_value threw: " + ex.Message); }
            try { var r = layer_cell_on_edge(IntPtr.Zero, 0, 0); Console.WriteLine("layer_cell_on_edge -> " + r); } catch(Exception ex) { Console.WriteLine("layer_cell_on_edge threw: " + ex.Message); }
            try { var r = layer_get_cell_sum(IntPtr.Zero); Console.WriteLine("layer_get_cell_sum -> " + r); } catch(Exception ex) { Console.WriteLine("layer_get_cell_sum threw: " + ex.Message); }
            try { layer_add_interp_barrier(IntPtr.Zero, 0, 0); Console.WriteLine("layer_add_interp_barrier -> (void)"); } catch(Exception ex) { Console.WriteLine("layer_add_interp_barrier threw: " + ex.Message); }
            try { layer_add_ijbarrier(IntPtr.Zero, 0, 0, 0, 0); Console.WriteLine("layer_add_ijbarrier -> (void)"); } catch(Exception ex) { Console.WriteLine("layer_add_ijbarrier threw: " + ex.Message); }
            try { layer_add_barrier(IntPtr.Zero, 0, 0); Console.WriteLine("layer_add_barrier -> (void)"); } catch(Exception ex) { Console.WriteLine("layer_add_barrier threw: " + ex.Message); }
            try { layer_memcpy(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("layer_memcpy -> (void)"); } catch(Exception ex) { Console.WriteLine("layer_memcpy threw: " + ex.Message); }
            try { layer_update_active(IntPtr.Zero, IntPtr.Zero, 0); Console.WriteLine("layer_update_active -> (void)"); } catch(Exception ex) { Console.WriteLine("layer_update_active threw: " + ex.Message); }
            try { layer_clear_cells(IntPtr.Zero); Console.WriteLine("layer_clear_cells -> (void)"); } catch(Exception ex) { Console.WriteLine("layer_clear_cells threw: " + ex.Message); }
            try { layer_assign(IntPtr.Zero, 0); Console.WriteLine("layer_assign -> (void)"); } catch(Exception ex) { Console.WriteLine("layer_assign threw: " + ex.Message); }
            try { var r = layer_count_equal(IntPtr.Zero, 0); Console.WriteLine("layer_count_equal -> " + r); } catch(Exception ex) { Console.WriteLine("layer_count_equal threw: " + ex.Message); }
        }
    }
}
