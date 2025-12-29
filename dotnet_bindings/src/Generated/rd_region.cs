// Auto-generated from resdata\rd_region.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_rd_region {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_reset(IntPtr rd_region);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_free(IntPtr region);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_select_true(IntPtr region, IntPtr rd_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_invert_selection(IntPtr region);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_select_all(IntPtr region);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_deselect_all(IntPtr region);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_select_false(IntPtr region, IntPtr rd_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_select_inactive_cells(IntPtr region);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_deselect_inactive_cells(IntPtr region);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_select_active_cells(IntPtr region);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_deselect_active_cells(IntPtr region);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_select_i1i2(IntPtr region, int i1, int i2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_deselect_i1i2(IntPtr region, int i1, int i2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_select_j1j2(IntPtr region, int j1, int j2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_deselect_j1j2(IntPtr region, int j1, int i2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_select_k1k2(IntPtr region, int k1, int k2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_deselect_k1k2(IntPtr region, int k1, int i2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_select_shallow_cells(IntPtr region, double depth_limit);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_select_deep_cells(IntPtr region, double depth_limit);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_deselect_deep_cells(IntPtr region, double depth_limit);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_select_thin_cells(IntPtr rd_region, double dz_limit);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_deselect_thin_cells(IntPtr rd_region, double dz_limit);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_select_thick_cells(IntPtr rd_region, double dz_limit);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_deselect_thick_cells(IntPtr rd_region, double dz_limit);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_union(IntPtr region, IntPtr new_region);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_xor(IntPtr region, IntPtr new_region);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void rd_region_set_name(IntPtr region, string name);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\rd_region.hpp");
            try { rd_region_reset(IntPtr.Zero); Console.WriteLine("rd_region_reset -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_reset threw: " + ex.Message); }
            try { rd_region_free(IntPtr.Zero); Console.WriteLine("rd_region_free -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_free threw: " + ex.Message); }
            try { rd_region_select_true(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_region_select_true -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_select_true threw: " + ex.Message); }
            try { rd_region_invert_selection(IntPtr.Zero); Console.WriteLine("rd_region_invert_selection -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_invert_selection threw: " + ex.Message); }
            try { rd_region_select_all(IntPtr.Zero); Console.WriteLine("rd_region_select_all -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_select_all threw: " + ex.Message); }
            try { rd_region_deselect_all(IntPtr.Zero); Console.WriteLine("rd_region_deselect_all -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_deselect_all threw: " + ex.Message); }
            try { rd_region_select_false(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_region_select_false -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_select_false threw: " + ex.Message); }
            try { rd_region_select_inactive_cells(IntPtr.Zero); Console.WriteLine("rd_region_select_inactive_cells -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_select_inactive_cells threw: " + ex.Message); }
            try { rd_region_deselect_inactive_cells(IntPtr.Zero); Console.WriteLine("rd_region_deselect_inactive_cells -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_deselect_inactive_cells threw: " + ex.Message); }
            try { rd_region_select_active_cells(IntPtr.Zero); Console.WriteLine("rd_region_select_active_cells -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_select_active_cells threw: " + ex.Message); }
            try { rd_region_deselect_active_cells(IntPtr.Zero); Console.WriteLine("rd_region_deselect_active_cells -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_deselect_active_cells threw: " + ex.Message); }
            try { rd_region_select_i1i2(IntPtr.Zero, 0, 0); Console.WriteLine("rd_region_select_i1i2 -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_select_i1i2 threw: " + ex.Message); }
            try { rd_region_deselect_i1i2(IntPtr.Zero, 0, 0); Console.WriteLine("rd_region_deselect_i1i2 -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_deselect_i1i2 threw: " + ex.Message); }
            try { rd_region_select_j1j2(IntPtr.Zero, 0, 0); Console.WriteLine("rd_region_select_j1j2 -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_select_j1j2 threw: " + ex.Message); }
            try { rd_region_deselect_j1j2(IntPtr.Zero, 0, 0); Console.WriteLine("rd_region_deselect_j1j2 -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_deselect_j1j2 threw: " + ex.Message); }
            try { rd_region_select_k1k2(IntPtr.Zero, 0, 0); Console.WriteLine("rd_region_select_k1k2 -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_select_k1k2 threw: " + ex.Message); }
            try { rd_region_deselect_k1k2(IntPtr.Zero, 0, 0); Console.WriteLine("rd_region_deselect_k1k2 -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_deselect_k1k2 threw: " + ex.Message); }
            try { rd_region_select_shallow_cells(IntPtr.Zero, 0.0); Console.WriteLine("rd_region_select_shallow_cells -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_select_shallow_cells threw: " + ex.Message); }
            try { rd_region_select_deep_cells(IntPtr.Zero, 0.0); Console.WriteLine("rd_region_select_deep_cells -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_select_deep_cells threw: " + ex.Message); }
            try { rd_region_deselect_deep_cells(IntPtr.Zero, 0.0); Console.WriteLine("rd_region_deselect_deep_cells -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_deselect_deep_cells threw: " + ex.Message); }
            try { rd_region_select_thin_cells(IntPtr.Zero, 0.0); Console.WriteLine("rd_region_select_thin_cells -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_select_thin_cells threw: " + ex.Message); }
            try { rd_region_deselect_thin_cells(IntPtr.Zero, 0.0); Console.WriteLine("rd_region_deselect_thin_cells -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_deselect_thin_cells threw: " + ex.Message); }
            try { rd_region_select_thick_cells(IntPtr.Zero, 0.0); Console.WriteLine("rd_region_select_thick_cells -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_select_thick_cells threw: " + ex.Message); }
            try { rd_region_deselect_thick_cells(IntPtr.Zero, 0.0); Console.WriteLine("rd_region_deselect_thick_cells -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_deselect_thick_cells threw: " + ex.Message); }
            try { rd_region_union(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_region_union -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_union threw: " + ex.Message); }
            try { rd_region_xor(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_region_xor -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_xor threw: " + ex.Message); }
            try { rd_region_set_name(IntPtr.Zero, null); Console.WriteLine("rd_region_set_name -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_set_name threw: " + ex.Message); }
        }
    }
}
