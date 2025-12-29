// Auto-generated from ert\util\hash_sll.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_hash_sll {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void hash_sll_del_node(IntPtr p0, IntPtr p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void hash_sll_add_node(IntPtr p0, IntPtr p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void hash_sll_free(IntPtr p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool hash_sll_empty(IntPtr hash_sll);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: ert\\util\\hash_sll.hpp");
            try { hash_sll_del_node(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("hash_sll_del_node -> (void)"); } catch(Exception ex) { Console.WriteLine("hash_sll_del_node threw: " + ex.Message); }
            try { hash_sll_add_node(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("hash_sll_add_node -> (void)"); } catch(Exception ex) { Console.WriteLine("hash_sll_add_node threw: " + ex.Message); }
            try { hash_sll_free(IntPtr.Zero); Console.WriteLine("hash_sll_free -> (void)"); } catch(Exception ex) { Console.WriteLine("hash_sll_free threw: " + ex.Message); }
            try { var r = hash_sll_empty(IntPtr.Zero); Console.WriteLine("hash_sll_empty -> " + r); } catch(Exception ex) { Console.WriteLine("hash_sll_empty threw: " + ex.Message); }
        }
    }
}
