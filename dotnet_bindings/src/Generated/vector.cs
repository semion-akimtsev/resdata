// Auto-generated from ert\util\vector.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_vector {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int vector_append_ref(SafeVectorTypeHandle? p0, SafeVoidHandle? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int vector_append_owned_ref(SafeVectorTypeHandle? p0, SafeVoidHandle? p1, SafeDelHandle? del);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void vector_iset_ref(SafeVectorTypeHandle? p0, int p1, SafeVoidHandle? p2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void vector_iset_owned_ref(SafeVectorTypeHandle? p0, int p1, SafeVoidHandle? p2, SafeDelHandle? del);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void vector_clear(SafeVectorHandle? vector);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void vector_free(SafeVectorTypeHandle? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void vector_free__(SafeArgHandle? arg);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void vector_append_buffer(SafeVectorTypeHandle? p0, SafeVoidHandle? p1, int p2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void vector_idel(SafeVectorHandle? vector, int index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void vector_shrink(SafeVectorHandle? vector, int new_size);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int vector_get_size(SafeVectorTypeHandle? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void vector_sort(SafeVectorHandle? vector, SafeCmpHandle? cmp);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void vector_permute(SafeVectorHandle? vector, SafePermVectorHandle? perm_vector);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void vector_inplace_reverse(SafeVectorHandle? vector);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: ert\\util\\vector.hpp");
            try { var r = vector_append_ref((SafeVectorTypeHandle?)null, (SafeVoidHandle?)null); Console.WriteLine("vector_append_ref -> " + r); } catch(Exception ex) { Console.WriteLine("vector_append_ref threw: " + ex.Message); }
            try { var r = vector_append_owned_ref((SafeVectorTypeHandle?)null, (SafeVoidHandle?)null, (SafeDelHandle?)null); Console.WriteLine("vector_append_owned_ref -> " + r); } catch(Exception ex) { Console.WriteLine("vector_append_owned_ref threw: " + ex.Message); }
            try { vector_iset_ref((SafeVectorTypeHandle?)null, 0, (SafeVoidHandle?)null); Console.WriteLine("vector_iset_ref -> (void)"); } catch(Exception ex) { Console.WriteLine("vector_iset_ref threw: " + ex.Message); }
            try { vector_iset_owned_ref((SafeVectorTypeHandle?)null, 0, (SafeVoidHandle?)null, (SafeDelHandle?)null); Console.WriteLine("vector_iset_owned_ref -> (void)"); } catch(Exception ex) { Console.WriteLine("vector_iset_owned_ref threw: " + ex.Message); }
            try { vector_clear((SafeVectorHandle?)null); Console.WriteLine("vector_clear -> (void)"); } catch(Exception ex) { Console.WriteLine("vector_clear threw: " + ex.Message); }
            try { vector_free((SafeVectorTypeHandle?)null); Console.WriteLine("vector_free -> (void)"); } catch(Exception ex) { Console.WriteLine("vector_free threw: " + ex.Message); }
            try { vector_free__((SafeArgHandle?)null); Console.WriteLine("vector_free__ -> (void)"); } catch(Exception ex) { Console.WriteLine("vector_free__ threw: " + ex.Message); }
            try { vector_append_buffer((SafeVectorTypeHandle?)null, (SafeVoidHandle?)null, 0); Console.WriteLine("vector_append_buffer -> (void)"); } catch(Exception ex) { Console.WriteLine("vector_append_buffer threw: " + ex.Message); }
            try { vector_idel((SafeVectorHandle?)null, 0); Console.WriteLine("vector_idel -> (void)"); } catch(Exception ex) { Console.WriteLine("vector_idel threw: " + ex.Message); }
            try { vector_shrink((SafeVectorHandle?)null, 0); Console.WriteLine("vector_shrink -> (void)"); } catch(Exception ex) { Console.WriteLine("vector_shrink threw: " + ex.Message); }
            try { var r = vector_get_size((SafeVectorTypeHandle?)null); Console.WriteLine("vector_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("vector_get_size threw: " + ex.Message); }
            try { vector_sort((SafeVectorHandle?)null, (SafeCmpHandle?)null); Console.WriteLine("vector_sort -> (void)"); } catch(Exception ex) { Console.WriteLine("vector_sort threw: " + ex.Message); }
            try { vector_permute((SafeVectorHandle?)null, (SafePermVectorHandle?)null); Console.WriteLine("vector_permute -> (void)"); } catch(Exception ex) { Console.WriteLine("vector_permute threw: " + ex.Message); }
            try { vector_inplace_reverse((SafeVectorHandle?)null); Console.WriteLine("vector_inplace_reverse -> (void)"); } catch(Exception ex) { Console.WriteLine("vector_inplace_reverse threw: " + ex.Message); }
        }
    }
}
