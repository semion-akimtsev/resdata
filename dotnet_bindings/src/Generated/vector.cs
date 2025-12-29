// Auto-generated from ert\util\vector.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_vector {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int vector_append_ref(IntPtr p0, IntPtr p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int vector_append_owned_ref(IntPtr p0, IntPtr p1, IntPtr del);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void vector_iset_ref(IntPtr p0, int p1, IntPtr p2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void vector_iset_owned_ref(IntPtr p0, int p1, IntPtr p2, IntPtr del);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void vector_clear(IntPtr vector);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void vector_free(IntPtr p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void vector_free__(IntPtr arg);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void vector_append_buffer(IntPtr p0, IntPtr p1, int p2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void vector_idel(IntPtr vector, int index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void vector_shrink(IntPtr vector, int new_size);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int vector_get_size(IntPtr p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void vector_sort(IntPtr vector, IntPtr cmp);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void vector_permute(IntPtr vector, IntPtr perm_vector);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void vector_inplace_reverse(IntPtr vector);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: ert\\util\\vector.hpp");
            try { var r = vector_append_ref(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("vector_append_ref -> " + r); } catch(Exception ex) { Console.WriteLine("vector_append_ref threw: " + ex.Message); }
            try { var r = vector_append_owned_ref(IntPtr.Zero, IntPtr.Zero, IntPtr.Zero); Console.WriteLine("vector_append_owned_ref -> " + r); } catch(Exception ex) { Console.WriteLine("vector_append_owned_ref threw: " + ex.Message); }
            try { vector_iset_ref(IntPtr.Zero, 0, IntPtr.Zero); Console.WriteLine("vector_iset_ref -> (void)"); } catch(Exception ex) { Console.WriteLine("vector_iset_ref threw: " + ex.Message); }
            try { vector_iset_owned_ref(IntPtr.Zero, 0, IntPtr.Zero, IntPtr.Zero); Console.WriteLine("vector_iset_owned_ref -> (void)"); } catch(Exception ex) { Console.WriteLine("vector_iset_owned_ref threw: " + ex.Message); }
            try { vector_clear(IntPtr.Zero); Console.WriteLine("vector_clear -> (void)"); } catch(Exception ex) { Console.WriteLine("vector_clear threw: " + ex.Message); }
            try { vector_free(IntPtr.Zero); Console.WriteLine("vector_free -> (void)"); } catch(Exception ex) { Console.WriteLine("vector_free threw: " + ex.Message); }
            try { vector_free__(IntPtr.Zero); Console.WriteLine("vector_free__ -> (void)"); } catch(Exception ex) { Console.WriteLine("vector_free__ threw: " + ex.Message); }
            try { vector_append_buffer(IntPtr.Zero, IntPtr.Zero, 0); Console.WriteLine("vector_append_buffer -> (void)"); } catch(Exception ex) { Console.WriteLine("vector_append_buffer threw: " + ex.Message); }
            try { vector_idel(IntPtr.Zero, 0); Console.WriteLine("vector_idel -> (void)"); } catch(Exception ex) { Console.WriteLine("vector_idel threw: " + ex.Message); }
            try { vector_shrink(IntPtr.Zero, 0); Console.WriteLine("vector_shrink -> (void)"); } catch(Exception ex) { Console.WriteLine("vector_shrink threw: " + ex.Message); }
            try { var r = vector_get_size(IntPtr.Zero); Console.WriteLine("vector_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("vector_get_size threw: " + ex.Message); }
            try { vector_sort(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("vector_sort -> (void)"); } catch(Exception ex) { Console.WriteLine("vector_sort threw: " + ex.Message); }
            try { vector_permute(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("vector_permute -> (void)"); } catch(Exception ex) { Console.WriteLine("vector_permute threw: " + ex.Message); }
            try { vector_inplace_reverse(IntPtr.Zero); Console.WriteLine("vector_inplace_reverse -> (void)"); } catch(Exception ex) { Console.WriteLine("vector_inplace_reverse threw: " + ex.Message); }
        }
    }
}
