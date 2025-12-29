// Auto-generated from ert\geometry\geo_polygon_collection.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_geo_polygon_collection {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_polygon_collection_free(SafePolygonsHandle? polygons);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int geo_polygon_collection_size(SafePolygonsHandle? polygons);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: ert\\geometry\\geo_polygon_collection.hpp");
            try { geo_polygon_collection_free((SafePolygonsHandle?)null); Console.WriteLine("geo_polygon_collection_free -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_polygon_collection_free threw: " + ex.Message); }
            try { var r = geo_polygon_collection_size((SafePolygonsHandle?)null); Console.WriteLine("geo_polygon_collection_size -> " + r); } catch(Exception ex) { Console.WriteLine("geo_polygon_collection_size threw: " + ex.Message); }
        }
    }
}
