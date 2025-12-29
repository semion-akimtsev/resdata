// Auto-generated from resdata\rd_sum_vector.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_rd_sum_vector {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_sum_vector_free(IntPtr keylist);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool rd_sum_vector_add_key(IntPtr keylist, string key);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void rd_sum_vector_add_keys(IntPtr keylist, string pattern);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_sum_vector_get_size(IntPtr rd_sum_vector);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\rd_sum_vector.hpp");
            try { rd_sum_vector_free(IntPtr.Zero); Console.WriteLine("rd_sum_vector_free -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_sum_vector_free threw: " + ex.Message); }
            try { var r = rd_sum_vector_add_key(IntPtr.Zero, null); Console.WriteLine("rd_sum_vector_add_key -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_vector_add_key threw: " + ex.Message); }
            try { rd_sum_vector_add_keys(IntPtr.Zero, null); Console.WriteLine("rd_sum_vector_add_keys -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_sum_vector_add_keys threw: " + ex.Message); }
            try { var r = rd_sum_vector_get_size(IntPtr.Zero); Console.WriteLine("rd_sum_vector_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("rd_sum_vector_get_size threw: " + ex.Message); }
        }
    }
}
