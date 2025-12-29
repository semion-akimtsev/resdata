// Auto-generated from resdata\well\well_info.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_well_info {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void well_info_free(SafeWellInfoHandle? well_info);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int well_info_get_num_wells(SafeWellInfoHandle? well_info);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool well_info_has_well(SafeWellInfoHandle? well_info, string? well_name);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\well\\well_info.hpp");
            try { well_info_free((SafeWellInfoHandle?)null); Console.WriteLine("well_info_free -> (void)"); } catch(Exception ex) { Console.WriteLine("well_info_free threw: " + ex.Message); }
            try { var r = well_info_get_num_wells((SafeWellInfoHandle?)null); Console.WriteLine("well_info_get_num_wells -> " + r); } catch(Exception ex) { Console.WriteLine("well_info_get_num_wells threw: " + ex.Message); }
            try { var r = well_info_has_well((SafeWellInfoHandle?)null, (string?)null); Console.WriteLine("well_info_has_well -> " + r); } catch(Exception ex) { Console.WriteLine("well_info_has_well threw: " + ex.Message); }
        }
    }
}
