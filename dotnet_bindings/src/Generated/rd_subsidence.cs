// Auto-generated from resdata\rd_subsidence.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_rd_subsidence {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_subsidence_free(SafeRdSubsidenceConfigHandle? rd_subsidence_config);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\rd_subsidence.hpp");
            try { rd_subsidence_free((SafeRdSubsidenceConfigHandle?)null); Console.WriteLine("rd_subsidence_free -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_subsidence_free threw: " + ex.Message); }
        }
    }
}
