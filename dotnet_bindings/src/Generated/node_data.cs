// Auto-generated from ert\util\node_data.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_node_data {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void node_data_free(IntPtr p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void node_data_free_container(IntPtr p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int node_data_get_int(IntPtr p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double node_data_get_double(IntPtr p0);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: ert\\util\\node_data.hpp");
            try { node_data_free(IntPtr.Zero); Console.WriteLine("node_data_free -> (void)"); } catch(Exception ex) { Console.WriteLine("node_data_free threw: " + ex.Message); }
            try { node_data_free_container(IntPtr.Zero); Console.WriteLine("node_data_free_container -> (void)"); } catch(Exception ex) { Console.WriteLine("node_data_free_container threw: " + ex.Message); }
            try { var r = node_data_get_int(IntPtr.Zero); Console.WriteLine("node_data_get_int -> " + r); } catch(Exception ex) { Console.WriteLine("node_data_get_int threw: " + ex.Message); }
            try { var r = node_data_get_double(IntPtr.Zero); Console.WriteLine("node_data_get_double -> " + r); } catch(Exception ex) { Console.WriteLine("node_data_get_double threw: " + ex.Message); }
        }
    }
}
