// Auto-generated from ert\geometry\geo_polygon.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_geo_polygon {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_polygon_free(IntPtr polygon);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_polygon_free__(IntPtr arg);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_polygon_add_point(IntPtr polygon, double x, double y);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_polygon_add_point_front(IntPtr polygon, double x, double y);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_polygon_reset(IntPtr polygon);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_polygon_close(IntPtr polygoon);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int geo_polygon_get_size(IntPtr polygon);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void geo_polygon_set_name(IntPtr polygon, string name);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double geo_polygon_get_length(IntPtr polygon);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: ert\\geometry\\geo_polygon.hpp");
            try { geo_polygon_free(IntPtr.Zero); Console.WriteLine("geo_polygon_free -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_polygon_free threw: " + ex.Message); }
            try { geo_polygon_free__(IntPtr.Zero); Console.WriteLine("geo_polygon_free__ -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_polygon_free__ threw: " + ex.Message); }
            try { geo_polygon_add_point(IntPtr.Zero, 0.0, 0.0); Console.WriteLine("geo_polygon_add_point -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_polygon_add_point threw: " + ex.Message); }
            try { geo_polygon_add_point_front(IntPtr.Zero, 0.0, 0.0); Console.WriteLine("geo_polygon_add_point_front -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_polygon_add_point_front threw: " + ex.Message); }
            try { geo_polygon_reset(IntPtr.Zero); Console.WriteLine("geo_polygon_reset -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_polygon_reset threw: " + ex.Message); }
            try { geo_polygon_close(IntPtr.Zero); Console.WriteLine("geo_polygon_close -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_polygon_close threw: " + ex.Message); }
            try { var r = geo_polygon_get_size(IntPtr.Zero); Console.WriteLine("geo_polygon_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("geo_polygon_get_size threw: " + ex.Message); }
            try { geo_polygon_set_name(IntPtr.Zero, null); Console.WriteLine("geo_polygon_set_name -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_polygon_set_name threw: " + ex.Message); }
            try { var r = geo_polygon_get_length(IntPtr.Zero); Console.WriteLine("geo_polygon_get_length -> " + r); } catch(Exception ex) { Console.WriteLine("geo_polygon_get_length threw: " + ex.Message); }
        }
    }
}
