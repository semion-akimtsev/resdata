// Auto-generated from resdata\well\well_info.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_well_info {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void well_info_free(IntPtr well_info);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int well_info_get_num_wells(IntPtr well_info);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool well_info_has_well(IntPtr well_info, string well_name);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\well\\well_info.hpp");
            try { well_info_free(IntPtr.Zero); Console.WriteLine("well_info_free -> (void)"); } catch(Exception ex) { Console.WriteLine("well_info_free threw: " + ex.Message); }
            try { var r = well_info_get_num_wells(IntPtr.Zero); Console.WriteLine("well_info_get_num_wells -> " + r); } catch(Exception ex) { Console.WriteLine("well_info_get_num_wells threw: " + ex.Message); }
            try { var r = well_info_has_well(IntPtr.Zero, null); Console.WriteLine("well_info_has_well -> " + r); } catch(Exception ex) { Console.WriteLine("well_info_has_well threw: " + ex.Message); }
        }
    }
}
