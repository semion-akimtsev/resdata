// Auto-generated from resdata\well\well_conn_collection.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_well_conn_collection {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void well_conn_collection_free(IntPtr wellcc);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int well_conn_collection_get_size(IntPtr wellcc);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\well\\well_conn_collection.hpp");
            try { well_conn_collection_free(IntPtr.Zero); Console.WriteLine("well_conn_collection_free -> (void)"); } catch(Exception ex) { Console.WriteLine("well_conn_collection_free threw: " + ex.Message); }
            try { var r = well_conn_collection_get_size(IntPtr.Zero); Console.WriteLine("well_conn_collection_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("well_conn_collection_get_size threw: " + ex.Message); }
        }
    }
}
