// Auto-generated from resdata\well\well_ts.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_well_ts {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void well_ts_free(IntPtr well_ts);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void well_ts_add_well(IntPtr well_ts, IntPtr well_state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int well_ts_get_size(IntPtr well_ts);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\well\\well_ts.hpp");
            try { well_ts_free(IntPtr.Zero); Console.WriteLine("well_ts_free -> (void)"); } catch(Exception ex) { Console.WriteLine("well_ts_free threw: " + ex.Message); }
            try { well_ts_add_well(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("well_ts_add_well -> (void)"); } catch(Exception ex) { Console.WriteLine("well_ts_add_well threw: " + ex.Message); }
            try { var r = well_ts_get_size(IntPtr.Zero); Console.WriteLine("well_ts_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("well_ts_get_size threw: " + ex.Message); }
        }
    }
}
