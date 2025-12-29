// Auto-generated from ert\geometry\geo_surface.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_geo_surface {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_surface_free(SafeGeoSurfaceHandle? geo_surface);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double geo_surface_iget_zvalue(SafeSurfaceHandle? surface, int index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int geo_surface_get_size(SafeSurfaceHandle? surface);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int geo_surface_get_nx(SafeSurfaceHandle? surface);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int geo_surface_get_ny(SafeSurfaceHandle? surface);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_surface_shift(SafeSrcHandle? src, double value);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_surface_scale(SafeSrcHandle? src, double value);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_surface_isub(SafeSelfHandle? self, SafeOtherHandle? other);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_surface_assign_value(SafeSrcHandle? src, double value);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_surface_iadd(SafeSelfHandle? self, SafeOtherHandle? other);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_surface_imul(SafeSelfHandle? self, SafeOtherHandle? other);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_surface_isqrt(SafeSurfaceHandle? surface);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: ert\\geometry\\geo_surface.hpp");
            try { geo_surface_free((SafeGeoSurfaceHandle?)null); Console.WriteLine("geo_surface_free -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_surface_free threw: " + ex.Message); }
            try { var r = geo_surface_iget_zvalue((SafeSurfaceHandle?)null, 0); Console.WriteLine("geo_surface_iget_zvalue -> " + r); } catch(Exception ex) { Console.WriteLine("geo_surface_iget_zvalue threw: " + ex.Message); }
            try { var r = geo_surface_get_size((SafeSurfaceHandle?)null); Console.WriteLine("geo_surface_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("geo_surface_get_size threw: " + ex.Message); }
            try { var r = geo_surface_get_nx((SafeSurfaceHandle?)null); Console.WriteLine("geo_surface_get_nx -> " + r); } catch(Exception ex) { Console.WriteLine("geo_surface_get_nx threw: " + ex.Message); }
            try { var r = geo_surface_get_ny((SafeSurfaceHandle?)null); Console.WriteLine("geo_surface_get_ny -> " + r); } catch(Exception ex) { Console.WriteLine("geo_surface_get_ny threw: " + ex.Message); }
            try { geo_surface_shift((SafeSrcHandle?)null, 0.0); Console.WriteLine("geo_surface_shift -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_surface_shift threw: " + ex.Message); }
            try { geo_surface_scale((SafeSrcHandle?)null, 0.0); Console.WriteLine("geo_surface_scale -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_surface_scale threw: " + ex.Message); }
            try { geo_surface_isub((SafeSelfHandle?)null, (SafeOtherHandle?)null); Console.WriteLine("geo_surface_isub -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_surface_isub threw: " + ex.Message); }
            try { geo_surface_assign_value((SafeSrcHandle?)null, 0.0); Console.WriteLine("geo_surface_assign_value -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_surface_assign_value threw: " + ex.Message); }
            try { geo_surface_iadd((SafeSelfHandle?)null, (SafeOtherHandle?)null); Console.WriteLine("geo_surface_iadd -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_surface_iadd threw: " + ex.Message); }
            try { geo_surface_imul((SafeSelfHandle?)null, (SafeOtherHandle?)null); Console.WriteLine("geo_surface_imul -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_surface_imul threw: " + ex.Message); }
            try { geo_surface_isqrt((SafeSurfaceHandle?)null); Console.WriteLine("geo_surface_isqrt -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_surface_isqrt threw: " + ex.Message); }
        }
    }
}
