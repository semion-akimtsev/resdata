// Auto-generated from resdata\fault_block_layer.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_fault_block_layer {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void fault_block_layer_free(IntPtr layer);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void fault_block_layer_del_block(IntPtr layer, int block_id);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int fault_block_layer_get_max_id(IntPtr layer);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int fault_block_layer_get_next_id(IntPtr layer);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int fault_block_layer_get_size(IntPtr layer);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int fault_block_layer_get_k(IntPtr layer);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\fault_block_layer.hpp");
            try { fault_block_layer_free(IntPtr.Zero); Console.WriteLine("fault_block_layer_free -> (void)"); } catch(Exception ex) { Console.WriteLine("fault_block_layer_free threw: " + ex.Message); }
            try { fault_block_layer_del_block(IntPtr.Zero, 0); Console.WriteLine("fault_block_layer_del_block -> (void)"); } catch(Exception ex) { Console.WriteLine("fault_block_layer_del_block threw: " + ex.Message); }
            try { var r = fault_block_layer_get_max_id(IntPtr.Zero); Console.WriteLine("fault_block_layer_get_max_id -> " + r); } catch(Exception ex) { Console.WriteLine("fault_block_layer_get_max_id threw: " + ex.Message); }
            try { var r = fault_block_layer_get_next_id(IntPtr.Zero); Console.WriteLine("fault_block_layer_get_next_id -> " + r); } catch(Exception ex) { Console.WriteLine("fault_block_layer_get_next_id threw: " + ex.Message); }
            try { var r = fault_block_layer_get_size(IntPtr.Zero); Console.WriteLine("fault_block_layer_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("fault_block_layer_get_size threw: " + ex.Message); }
            try { var r = fault_block_layer_get_k(IntPtr.Zero); Console.WriteLine("fault_block_layer_get_k -> " + r); } catch(Exception ex) { Console.WriteLine("fault_block_layer_get_k threw: " + ex.Message); }
        }
    }
}
