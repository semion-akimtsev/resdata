// Auto-generated from resdata\well\well_rseg_loader.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_well_rseg_loader {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void well_rseg_loader_free(SafeWellRsegLoaderHandle? well_rseg_loader);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\well\\well_rseg_loader.hpp");
            try { well_rseg_loader_free((SafeWellRsegLoaderHandle?)null); Console.WriteLine("well_rseg_loader_free -> (void)"); } catch(Exception ex) { Console.WriteLine("well_rseg_loader_free threw: " + ex.Message); }
        }
    }
}
