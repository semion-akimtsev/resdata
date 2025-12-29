// Auto-generated from ert\util\stringlist.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_stringlist {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void stringlist_free(IntPtr p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void stringlist_clear(IntPtr p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void stringlist_append_copy(IntPtr p0, string p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void stringlist_iset_copy(IntPtr p0, int index, string p2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int stringlist_get_size(IntPtr p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool stringlist_equal(IntPtr p0, IntPtr p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool stringlist_contains(IntPtr p0, string p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern int stringlist_find_first(IntPtr p0, string p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void stringlist_sort(IntPtr p0, IntPtr string_cmp);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void stringlist_reverse(IntPtr s);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void stringlist_python_sort(IntPtr s, int cmp_flag);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: ert\\util\\stringlist.hpp");
            try { stringlist_free(IntPtr.Zero); Console.WriteLine("stringlist_free -> (void)"); } catch(Exception ex) { Console.WriteLine("stringlist_free threw: " + ex.Message); }
            try { stringlist_clear(IntPtr.Zero); Console.WriteLine("stringlist_clear -> (void)"); } catch(Exception ex) { Console.WriteLine("stringlist_clear threw: " + ex.Message); }
            try { stringlist_append_copy(IntPtr.Zero, null); Console.WriteLine("stringlist_append_copy -> (void)"); } catch(Exception ex) { Console.WriteLine("stringlist_append_copy threw: " + ex.Message); }
            try { stringlist_iset_copy(IntPtr.Zero, 0, null); Console.WriteLine("stringlist_iset_copy -> (void)"); } catch(Exception ex) { Console.WriteLine("stringlist_iset_copy threw: " + ex.Message); }
            try { var r = stringlist_get_size(IntPtr.Zero); Console.WriteLine("stringlist_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("stringlist_get_size threw: " + ex.Message); }
            try { var r = stringlist_equal(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("stringlist_equal -> " + r); } catch(Exception ex) { Console.WriteLine("stringlist_equal threw: " + ex.Message); }
            try { var r = stringlist_contains(IntPtr.Zero, null); Console.WriteLine("stringlist_contains -> " + r); } catch(Exception ex) { Console.WriteLine("stringlist_contains threw: " + ex.Message); }
            try { var r = stringlist_find_first(IntPtr.Zero, null); Console.WriteLine("stringlist_find_first -> " + r); } catch(Exception ex) { Console.WriteLine("stringlist_find_first threw: " + ex.Message); }
            try { stringlist_sort(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("stringlist_sort -> (void)"); } catch(Exception ex) { Console.WriteLine("stringlist_sort threw: " + ex.Message); }
            try { stringlist_reverse(IntPtr.Zero); Console.WriteLine("stringlist_reverse -> (void)"); } catch(Exception ex) { Console.WriteLine("stringlist_reverse threw: " + ex.Message); }
            try { stringlist_python_sort(IntPtr.Zero, 0); Console.WriteLine("stringlist_python_sort -> (void)"); } catch(Exception ex) { Console.WriteLine("stringlist_python_sort threw: " + ex.Message); }
        }
    }
}
