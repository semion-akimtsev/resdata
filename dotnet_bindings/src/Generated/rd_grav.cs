// Auto-generated from resdata\rd_grav.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_rd_grav {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_grav_free(SafeRdGravConfigHandle? rd_grav_config);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\rd_grav.hpp");
            try { rd_grav_free((SafeRdGravConfigHandle?)null); Console.WriteLine("rd_grav_free -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_grav_free threw: " + ex.Message); }
        }
    }
}
