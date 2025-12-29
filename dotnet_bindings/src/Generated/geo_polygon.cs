// Auto-generated from ert\geometry\geo_polygon.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_geo_polygon {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_polygon_free(SafePolygonHandle? polygon);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_polygon_free__(SafeArgHandle? arg);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_polygon_add_point(SafePolygonHandle? polygon, double x, double y);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_polygon_add_point_front(SafePolygonHandle? polygon, double x, double y);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_polygon_reset(SafePolygonHandle? polygon);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_polygon_close(SafePolygoonHandle? polygoon);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int geo_polygon_get_size(SafePolygonHandle? polygon);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void geo_polygon_set_name(SafePolygonHandle? polygon, string? name);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double geo_polygon_get_length(SafePolygonHandle? polygon);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: ert\\geometry\\geo_polygon.hpp");
            try { geo_polygon_free((SafePolygonHandle?)null); Console.WriteLine("geo_polygon_free -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_polygon_free threw: " + ex.Message); }
            try { geo_polygon_free__((SafeArgHandle?)null); Console.WriteLine("geo_polygon_free__ -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_polygon_free__ threw: " + ex.Message); }
            try { geo_polygon_add_point((SafePolygonHandle?)null, 0.0, 0.0); Console.WriteLine("geo_polygon_add_point -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_polygon_add_point threw: " + ex.Message); }
            try { geo_polygon_add_point_front((SafePolygonHandle?)null, 0.0, 0.0); Console.WriteLine("geo_polygon_add_point_front -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_polygon_add_point_front threw: " + ex.Message); }
            try { geo_polygon_reset((SafePolygonHandle?)null); Console.WriteLine("geo_polygon_reset -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_polygon_reset threw: " + ex.Message); }
            try { geo_polygon_close((SafePolygoonHandle?)null); Console.WriteLine("geo_polygon_close -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_polygon_close threw: " + ex.Message); }
            try { var r = geo_polygon_get_size((SafePolygonHandle?)null); Console.WriteLine("geo_polygon_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("geo_polygon_get_size threw: " + ex.Message); }
            try { geo_polygon_set_name((SafePolygonHandle?)null, (string?)null); Console.WriteLine("geo_polygon_set_name -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_polygon_set_name threw: " + ex.Message); }
            try { var r = geo_polygon_get_length((SafePolygonHandle?)null); Console.WriteLine("geo_polygon_get_length -> " + r); } catch(Exception ex) { Console.WriteLine("geo_polygon_get_length threw: " + ex.Message); }
        }
    }
}
