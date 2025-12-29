// Auto-generated from resdata\rd_region.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_rd_region {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_reset(SafeRdRegionHandle? rd_region);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_free(SafeRegionHandle? region);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_select_true(SafeRegionHandle? region, SafeRdKwHandle? rd_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_invert_selection(SafeRegionHandle? region);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_select_all(SafeRegionHandle? region);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_deselect_all(SafeRegionHandle? region);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_select_false(SafeRegionHandle? region, SafeRdKwHandle? rd_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_select_inactive_cells(SafeRegionHandle? region);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_deselect_inactive_cells(SafeRegionHandle? region);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_select_active_cells(SafeRegionHandle? region);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_deselect_active_cells(SafeRegionHandle? region);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_select_i1i2(SafeRegionHandle? region, int i1, int i2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_deselect_i1i2(SafeRegionHandle? region, int i1, int i2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_select_j1j2(SafeRegionHandle? region, int j1, int j2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_deselect_j1j2(SafeRegionHandle? region, int j1, int i2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_select_k1k2(SafeRegionHandle? region, int k1, int k2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_deselect_k1k2(SafeRegionHandle? region, int k1, int i2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_select_shallow_cells(SafeRegionHandle? region, double depth_limit);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_select_deep_cells(SafeRegionHandle? region, double depth_limit);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_deselect_deep_cells(SafeRegionHandle? region, double depth_limit);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_select_thin_cells(SafeRdRegionHandle? rd_region, double dz_limit);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_deselect_thin_cells(SafeRdRegionHandle? rd_region, double dz_limit);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_select_thick_cells(SafeRdRegionHandle? rd_region, double dz_limit);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_deselect_thick_cells(SafeRdRegionHandle? rd_region, double dz_limit);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_union(SafeRegionHandle? region, SafeNewRegionHandle? new_region);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_region_xor(SafeRegionHandle? region, SafeNewRegionHandle? new_region);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void rd_region_set_name(SafeRegionHandle? region, string? name);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\rd_region.hpp");
            try { rd_region_reset((SafeRdRegionHandle?)null); Console.WriteLine("rd_region_reset -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_reset threw: " + ex.Message); }
            try { rd_region_free((SafeRegionHandle?)null); Console.WriteLine("rd_region_free -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_free threw: " + ex.Message); }
            try { rd_region_select_true((SafeRegionHandle?)null, (SafeRdKwHandle?)null); Console.WriteLine("rd_region_select_true -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_select_true threw: " + ex.Message); }
            try { rd_region_invert_selection((SafeRegionHandle?)null); Console.WriteLine("rd_region_invert_selection -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_invert_selection threw: " + ex.Message); }
            try { rd_region_select_all((SafeRegionHandle?)null); Console.WriteLine("rd_region_select_all -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_select_all threw: " + ex.Message); }
            try { rd_region_deselect_all((SafeRegionHandle?)null); Console.WriteLine("rd_region_deselect_all -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_deselect_all threw: " + ex.Message); }
            try { rd_region_select_false((SafeRegionHandle?)null, (SafeRdKwHandle?)null); Console.WriteLine("rd_region_select_false -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_select_false threw: " + ex.Message); }
            try { rd_region_select_inactive_cells((SafeRegionHandle?)null); Console.WriteLine("rd_region_select_inactive_cells -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_select_inactive_cells threw: " + ex.Message); }
            try { rd_region_deselect_inactive_cells((SafeRegionHandle?)null); Console.WriteLine("rd_region_deselect_inactive_cells -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_deselect_inactive_cells threw: " + ex.Message); }
            try { rd_region_select_active_cells((SafeRegionHandle?)null); Console.WriteLine("rd_region_select_active_cells -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_select_active_cells threw: " + ex.Message); }
            try { rd_region_deselect_active_cells((SafeRegionHandle?)null); Console.WriteLine("rd_region_deselect_active_cells -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_deselect_active_cells threw: " + ex.Message); }
            try { rd_region_select_i1i2((SafeRegionHandle?)null, 0, 0); Console.WriteLine("rd_region_select_i1i2 -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_select_i1i2 threw: " + ex.Message); }
            try { rd_region_deselect_i1i2((SafeRegionHandle?)null, 0, 0); Console.WriteLine("rd_region_deselect_i1i2 -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_deselect_i1i2 threw: " + ex.Message); }
            try { rd_region_select_j1j2((SafeRegionHandle?)null, 0, 0); Console.WriteLine("rd_region_select_j1j2 -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_select_j1j2 threw: " + ex.Message); }
            try { rd_region_deselect_j1j2((SafeRegionHandle?)null, 0, 0); Console.WriteLine("rd_region_deselect_j1j2 -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_deselect_j1j2 threw: " + ex.Message); }
            try { rd_region_select_k1k2((SafeRegionHandle?)null, 0, 0); Console.WriteLine("rd_region_select_k1k2 -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_select_k1k2 threw: " + ex.Message); }
            try { rd_region_deselect_k1k2((SafeRegionHandle?)null, 0, 0); Console.WriteLine("rd_region_deselect_k1k2 -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_deselect_k1k2 threw: " + ex.Message); }
            try { rd_region_select_shallow_cells((SafeRegionHandle?)null, 0.0); Console.WriteLine("rd_region_select_shallow_cells -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_select_shallow_cells threw: " + ex.Message); }
            try { rd_region_select_deep_cells((SafeRegionHandle?)null, 0.0); Console.WriteLine("rd_region_select_deep_cells -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_select_deep_cells threw: " + ex.Message); }
            try { rd_region_deselect_deep_cells((SafeRegionHandle?)null, 0.0); Console.WriteLine("rd_region_deselect_deep_cells -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_deselect_deep_cells threw: " + ex.Message); }
            try { rd_region_select_thin_cells((SafeRdRegionHandle?)null, 0.0); Console.WriteLine("rd_region_select_thin_cells -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_select_thin_cells threw: " + ex.Message); }
            try { rd_region_deselect_thin_cells((SafeRdRegionHandle?)null, 0.0); Console.WriteLine("rd_region_deselect_thin_cells -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_deselect_thin_cells threw: " + ex.Message); }
            try { rd_region_select_thick_cells((SafeRdRegionHandle?)null, 0.0); Console.WriteLine("rd_region_select_thick_cells -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_select_thick_cells threw: " + ex.Message); }
            try { rd_region_deselect_thick_cells((SafeRdRegionHandle?)null, 0.0); Console.WriteLine("rd_region_deselect_thick_cells -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_deselect_thick_cells threw: " + ex.Message); }
            try { rd_region_union((SafeRegionHandle?)null, (SafeNewRegionHandle?)null); Console.WriteLine("rd_region_union -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_union threw: " + ex.Message); }
            try { rd_region_xor((SafeRegionHandle?)null, (SafeNewRegionHandle?)null); Console.WriteLine("rd_region_xor -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_xor threw: " + ex.Message); }
            try { rd_region_set_name((SafeRegionHandle?)null, (string?)null); Console.WriteLine("rd_region_set_name -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_region_set_name threw: " + ex.Message); }
        }
    }
}
