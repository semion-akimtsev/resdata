// Auto-generated from ert\geometry\geo_region.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_geo_region {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_region_free(IntPtr region);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_region_reset(IntPtr region);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: ert\\geometry\\geo_region.hpp");
            try { geo_region_free(IntPtr.Zero); Console.WriteLine("geo_region_free -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_region_free threw: " + ex.Message); }
            try { geo_region_reset(IntPtr.Zero); Console.WriteLine("geo_region_reset -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_region_reset threw: " + ex.Message); }
        }
    }
}
