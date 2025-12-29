// Auto-generated from resdata\well\well_ts.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_well_ts {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void well_ts_free(SafeWellTsHandle? well_ts);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void well_ts_add_well(SafeWellTsHandle? well_ts, SafeWellStateHandle? well_state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int well_ts_get_size(SafeWellTsHandle? well_ts);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\well\\well_ts.hpp");
            try { well_ts_free((SafeWellTsHandle?)null); Console.WriteLine("well_ts_free -> (void)"); } catch(Exception ex) { Console.WriteLine("well_ts_free threw: " + ex.Message); }
            try { well_ts_add_well((SafeWellTsHandle?)null, (SafeWellStateHandle?)null); Console.WriteLine("well_ts_add_well -> (void)"); } catch(Exception ex) { Console.WriteLine("well_ts_add_well threw: " + ex.Message); }
            try { var r = well_ts_get_size((SafeWellTsHandle?)null); Console.WriteLine("well_ts_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("well_ts_get_size threw: " + ex.Message); }
        }
    }
}
