// Auto-generated from ert\util\hash.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_hash {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void hash_free(IntPtr p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void hash_insert_ref(IntPtr p0, string p1, IntPtr p2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void hash_insert_string(IntPtr p0, string p1, string p2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool hash_has_key(IntPtr p0, string p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int hash_get_size(IntPtr p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void hash_resize(IntPtr hash, int new_size);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void hash_insert_int(IntPtr p0, string p1, int p2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern int hash_get_int(IntPtr p0, string p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void hash_insert_double(IntPtr p0, string p1, double p2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern double hash_get_double(IntPtr p0, string p1);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: ert\\util\\hash.hpp");
            try { hash_free(IntPtr.Zero); Console.WriteLine("hash_free -> (void)"); } catch(Exception ex) { Console.WriteLine("hash_free threw: " + ex.Message); }
            try { hash_insert_ref(IntPtr.Zero, null, IntPtr.Zero); Console.WriteLine("hash_insert_ref -> (void)"); } catch(Exception ex) { Console.WriteLine("hash_insert_ref threw: " + ex.Message); }
            try { hash_insert_string(IntPtr.Zero, null, null); Console.WriteLine("hash_insert_string -> (void)"); } catch(Exception ex) { Console.WriteLine("hash_insert_string threw: " + ex.Message); }
            try { var r = hash_has_key(IntPtr.Zero, null); Console.WriteLine("hash_has_key -> " + r); } catch(Exception ex) { Console.WriteLine("hash_has_key threw: " + ex.Message); }
            try { var r = hash_get_size(IntPtr.Zero); Console.WriteLine("hash_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("hash_get_size threw: " + ex.Message); }
            try { hash_resize(IntPtr.Zero, 0); Console.WriteLine("hash_resize -> (void)"); } catch(Exception ex) { Console.WriteLine("hash_resize threw: " + ex.Message); }
            try { hash_insert_int(IntPtr.Zero, null, 0); Console.WriteLine("hash_insert_int -> (void)"); } catch(Exception ex) { Console.WriteLine("hash_insert_int threw: " + ex.Message); }
            try { var r = hash_get_int(IntPtr.Zero, null); Console.WriteLine("hash_get_int -> " + r); } catch(Exception ex) { Console.WriteLine("hash_get_int threw: " + ex.Message); }
            try { hash_insert_double(IntPtr.Zero, null, 0.0); Console.WriteLine("hash_insert_double -> (void)"); } catch(Exception ex) { Console.WriteLine("hash_insert_double threw: " + ex.Message); }
            try { var r = hash_get_double(IntPtr.Zero, null); Console.WriteLine("hash_get_double -> " + r); } catch(Exception ex) { Console.WriteLine("hash_get_double threw: " + ex.Message); }
        }
    }
}
