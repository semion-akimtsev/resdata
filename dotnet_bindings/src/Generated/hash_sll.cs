// Auto-generated from ert\util\hash_sll.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_hash_sll {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void hash_sll_del_node(SafeHashSllTypeHandle? p0, SafeHashNodeTypeHandle? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void hash_sll_add_node(SafeHashSllTypeHandle? p0, SafeHashNodeTypeHandle? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void hash_sll_free(SafeHashSllTypeHandle? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool hash_sll_empty(SafeHashSllHandle? hash_sll);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: ert\\util\\hash_sll.hpp");
            try { hash_sll_del_node((SafeHashSllTypeHandle?)null, (SafeHashNodeTypeHandle?)null); Console.WriteLine("hash_sll_del_node -> (void)"); } catch(Exception ex) { Console.WriteLine("hash_sll_del_node threw: " + ex.Message); }
            try { hash_sll_add_node((SafeHashSllTypeHandle?)null, (SafeHashNodeTypeHandle?)null); Console.WriteLine("hash_sll_add_node -> (void)"); } catch(Exception ex) { Console.WriteLine("hash_sll_add_node threw: " + ex.Message); }
            try { hash_sll_free((SafeHashSllTypeHandle?)null); Console.WriteLine("hash_sll_free -> (void)"); } catch(Exception ex) { Console.WriteLine("hash_sll_free threw: " + ex.Message); }
            try { var r = hash_sll_empty((SafeHashSllHandle?)null); Console.WriteLine("hash_sll_empty -> " + r); } catch(Exception ex) { Console.WriteLine("hash_sll_empty threw: " + ex.Message); }
        }
    }
}
