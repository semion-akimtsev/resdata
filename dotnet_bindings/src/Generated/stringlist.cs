// Auto-generated from ert\util\stringlist.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_stringlist {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void stringlist_free(SafeStringlistTypeHandle? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void stringlist_clear(SafeStringlistTypeHandle? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void stringlist_append_copy(SafeStringlistTypeHandle? p0, string? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void stringlist_iset_copy(SafeStringlistTypeHandle? p0, int index, string? p2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int stringlist_get_size(SafeStringlistTypeHandle? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool stringlist_equal(SafeStringlistTypeHandle? p0, SafeStringlistTypeHandle? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool stringlist_contains(SafeStringlistTypeHandle? p0, string? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern int stringlist_find_first(SafeStringlistTypeHandle? p0, string? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void stringlist_sort(SafeStringlistTypeHandle? p0, SafeStringCmpHandle? string_cmp);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void stringlist_reverse(SafeSHandle? s);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void stringlist_python_sort(SafeSHandle? s, int cmp_flag);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: ert\\util\\stringlist.hpp");
            try { stringlist_free((SafeStringlistTypeHandle?)null); Console.WriteLine("stringlist_free -> (void)"); } catch(Exception ex) { Console.WriteLine("stringlist_free threw: " + ex.Message); }
            try { stringlist_clear((SafeStringlistTypeHandle?)null); Console.WriteLine("stringlist_clear -> (void)"); } catch(Exception ex) { Console.WriteLine("stringlist_clear threw: " + ex.Message); }
            try { stringlist_append_copy((SafeStringlistTypeHandle?)null, (string?)null); Console.WriteLine("stringlist_append_copy -> (void)"); } catch(Exception ex) { Console.WriteLine("stringlist_append_copy threw: " + ex.Message); }
            try { stringlist_iset_copy((SafeStringlistTypeHandle?)null, 0, (string?)null); Console.WriteLine("stringlist_iset_copy -> (void)"); } catch(Exception ex) { Console.WriteLine("stringlist_iset_copy threw: " + ex.Message); }
            try { var r = stringlist_get_size((SafeStringlistTypeHandle?)null); Console.WriteLine("stringlist_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("stringlist_get_size threw: " + ex.Message); }
            try { var r = stringlist_equal((SafeStringlistTypeHandle?)null, (SafeStringlistTypeHandle?)null); Console.WriteLine("stringlist_equal -> " + r); } catch(Exception ex) { Console.WriteLine("stringlist_equal threw: " + ex.Message); }
            try { var r = stringlist_contains((SafeStringlistTypeHandle?)null, (string?)null); Console.WriteLine("stringlist_contains -> " + r); } catch(Exception ex) { Console.WriteLine("stringlist_contains threw: " + ex.Message); }
            try { var r = stringlist_find_first((SafeStringlistTypeHandle?)null, (string?)null); Console.WriteLine("stringlist_find_first -> " + r); } catch(Exception ex) { Console.WriteLine("stringlist_find_first threw: " + ex.Message); }
            try { stringlist_sort((SafeStringlistTypeHandle?)null, (SafeStringCmpHandle?)null); Console.WriteLine("stringlist_sort -> (void)"); } catch(Exception ex) { Console.WriteLine("stringlist_sort threw: " + ex.Message); }
            try { stringlist_reverse((SafeSHandle?)null); Console.WriteLine("stringlist_reverse -> (void)"); } catch(Exception ex) { Console.WriteLine("stringlist_reverse threw: " + ex.Message); }
            try { stringlist_python_sort((SafeSHandle?)null, 0); Console.WriteLine("stringlist_python_sort -> (void)"); } catch(Exception ex) { Console.WriteLine("stringlist_python_sort threw: " + ex.Message); }
        }
    }
}
