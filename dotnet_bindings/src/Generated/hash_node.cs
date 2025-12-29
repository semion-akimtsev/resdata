// Auto-generated from ert\util\hash_node.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_hash_node {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool hash_node_key_eq(IntPtr p0, IntPtr p1, string p2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void hash_node_set_next(IntPtr p0, IntPtr p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr hash_node_get_table_index(IntPtr p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void hash_node_free(IntPtr p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr hash_node_set_table_index(IntPtr p0, IntPtr p1);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: ert\\util\\hash_node.hpp");
            try { var r = hash_node_key_eq(IntPtr.Zero, IntPtr.Zero, null); Console.WriteLine("hash_node_key_eq -> " + r); } catch(Exception ex) { Console.WriteLine("hash_node_key_eq threw: " + ex.Message); }
            try { hash_node_set_next(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("hash_node_set_next -> (void)"); } catch(Exception ex) { Console.WriteLine("hash_node_set_next threw: " + ex.Message); }
            try { var r = hash_node_get_table_index(IntPtr.Zero); Console.WriteLine("hash_node_get_table_index -> " + r); } catch(Exception ex) { Console.WriteLine("hash_node_get_table_index threw: " + ex.Message); }
            try { hash_node_free(IntPtr.Zero); Console.WriteLine("hash_node_free -> (void)"); } catch(Exception ex) { Console.WriteLine("hash_node_free threw: " + ex.Message); }
            try { var r = hash_node_set_table_index(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("hash_node_set_table_index -> " + r); } catch(Exception ex) { Console.WriteLine("hash_node_set_table_index threw: " + ex.Message); }
        }
    }
}
