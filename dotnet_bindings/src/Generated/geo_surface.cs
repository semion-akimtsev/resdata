// Auto-generated from ert\geometry\geo_surface.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_geo_surface {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_surface_free(IntPtr geo_surface);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double geo_surface_iget_zvalue(IntPtr surface, int index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int geo_surface_get_size(IntPtr surface);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int geo_surface_get_nx(IntPtr surface);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int geo_surface_get_ny(IntPtr surface);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_surface_shift(IntPtr src, double value);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_surface_scale(IntPtr src, double value);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_surface_isub(IntPtr self, IntPtr other);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_surface_assign_value(IntPtr src, double value);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_surface_iadd(IntPtr self, IntPtr other);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_surface_imul(IntPtr self, IntPtr other);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_surface_isqrt(IntPtr surface);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: ert\\geometry\\geo_surface.hpp");
            try { geo_surface_free(IntPtr.Zero); Console.WriteLine("geo_surface_free -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_surface_free threw: " + ex.Message); }
            try { var r = geo_surface_iget_zvalue(IntPtr.Zero, 0); Console.WriteLine("geo_surface_iget_zvalue -> " + r); } catch(Exception ex) { Console.WriteLine("geo_surface_iget_zvalue threw: " + ex.Message); }
            try { var r = geo_surface_get_size(IntPtr.Zero); Console.WriteLine("geo_surface_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("geo_surface_get_size threw: " + ex.Message); }
            try { var r = geo_surface_get_nx(IntPtr.Zero); Console.WriteLine("geo_surface_get_nx -> " + r); } catch(Exception ex) { Console.WriteLine("geo_surface_get_nx threw: " + ex.Message); }
            try { var r = geo_surface_get_ny(IntPtr.Zero); Console.WriteLine("geo_surface_get_ny -> " + r); } catch(Exception ex) { Console.WriteLine("geo_surface_get_ny threw: " + ex.Message); }
            try { geo_surface_shift(IntPtr.Zero, 0.0); Console.WriteLine("geo_surface_shift -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_surface_shift threw: " + ex.Message); }
            try { geo_surface_scale(IntPtr.Zero, 0.0); Console.WriteLine("geo_surface_scale -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_surface_scale threw: " + ex.Message); }
            try { geo_surface_isub(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("geo_surface_isub -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_surface_isub threw: " + ex.Message); }
            try { geo_surface_assign_value(IntPtr.Zero, 0.0); Console.WriteLine("geo_surface_assign_value -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_surface_assign_value threw: " + ex.Message); }
            try { geo_surface_iadd(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("geo_surface_iadd -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_surface_iadd threw: " + ex.Message); }
            try { geo_surface_imul(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("geo_surface_imul -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_surface_imul threw: " + ex.Message); }
            try { geo_surface_isqrt(IntPtr.Zero); Console.WriteLine("geo_surface_isqrt -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_surface_isqrt threw: " + ex.Message); }
        }
    }
}
