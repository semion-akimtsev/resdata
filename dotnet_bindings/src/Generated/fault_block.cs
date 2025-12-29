// Auto-generated from resdata\fault_block.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_fault_block {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void fault_block_free__(IntPtr arg);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int fault_block_get_size(IntPtr block);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double fault_block_get_xc(IntPtr fault_block);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double fault_block_get_yc(IntPtr fault_block);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int fault_block_get_id(IntPtr block);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void fault_block_assign_to_region(IntPtr fault_block, int region_id);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void fault_block_add_cell(IntPtr fault_block, int i, int j);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\fault_block.hpp");
            try { fault_block_free__(IntPtr.Zero); Console.WriteLine("fault_block_free__ -> (void)"); } catch(Exception ex) { Console.WriteLine("fault_block_free__ threw: " + ex.Message); }
            try { var r = fault_block_get_size(IntPtr.Zero); Console.WriteLine("fault_block_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("fault_block_get_size threw: " + ex.Message); }
            try { var r = fault_block_get_xc(IntPtr.Zero); Console.WriteLine("fault_block_get_xc -> " + r); } catch(Exception ex) { Console.WriteLine("fault_block_get_xc threw: " + ex.Message); }
            try { var r = fault_block_get_yc(IntPtr.Zero); Console.WriteLine("fault_block_get_yc -> " + r); } catch(Exception ex) { Console.WriteLine("fault_block_get_yc threw: " + ex.Message); }
            try { var r = fault_block_get_id(IntPtr.Zero); Console.WriteLine("fault_block_get_id -> " + r); } catch(Exception ex) { Console.WriteLine("fault_block_get_id threw: " + ex.Message); }
            try { fault_block_assign_to_region(IntPtr.Zero, 0); Console.WriteLine("fault_block_assign_to_region -> (void)"); } catch(Exception ex) { Console.WriteLine("fault_block_assign_to_region threw: " + ex.Message); }
            try { fault_block_add_cell(IntPtr.Zero, 0, 0); Console.WriteLine("fault_block_add_cell -> (void)"); } catch(Exception ex) { Console.WriteLine("fault_block_add_cell threw: " + ex.Message); }
        }
    }
}
