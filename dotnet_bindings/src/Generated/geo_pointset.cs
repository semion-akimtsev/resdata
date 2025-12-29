// Auto-generated from ert\geometry\geo_pointset.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_geo_pointset {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_pointset_free(IntPtr pointset);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int geo_pointset_get_size(IntPtr pointset);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double geo_pointset_iget_z(IntPtr pointset, int index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_pointset_iset_z(IntPtr pointset, int index, double value);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_pointset_shift_z(IntPtr pointset, double value);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_pointset_assign_z(IntPtr pointset, double value);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_pointset_scale_z(IntPtr pointset, double value);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_pointset_isub(IntPtr self, IntPtr other);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void geo_pointset_isqrt(IntPtr pointset);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: ert\\geometry\\geo_pointset.hpp");
            try { geo_pointset_free(IntPtr.Zero); Console.WriteLine("geo_pointset_free -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_pointset_free threw: " + ex.Message); }
            try { var r = geo_pointset_get_size(IntPtr.Zero); Console.WriteLine("geo_pointset_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("geo_pointset_get_size threw: " + ex.Message); }
            try { var r = geo_pointset_iget_z(IntPtr.Zero, 0); Console.WriteLine("geo_pointset_iget_z -> " + r); } catch(Exception ex) { Console.WriteLine("geo_pointset_iget_z threw: " + ex.Message); }
            try { geo_pointset_iset_z(IntPtr.Zero, 0, 0.0); Console.WriteLine("geo_pointset_iset_z -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_pointset_iset_z threw: " + ex.Message); }
            try { geo_pointset_shift_z(IntPtr.Zero, 0.0); Console.WriteLine("geo_pointset_shift_z -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_pointset_shift_z threw: " + ex.Message); }
            try { geo_pointset_assign_z(IntPtr.Zero, 0.0); Console.WriteLine("geo_pointset_assign_z -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_pointset_assign_z threw: " + ex.Message); }
            try { geo_pointset_scale_z(IntPtr.Zero, 0.0); Console.WriteLine("geo_pointset_scale_z -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_pointset_scale_z threw: " + ex.Message); }
            try { geo_pointset_isub(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("geo_pointset_isub -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_pointset_isub threw: " + ex.Message); }
            try { geo_pointset_isqrt(IntPtr.Zero); Console.WriteLine("geo_pointset_isqrt -> (void)"); } catch(Exception ex) { Console.WriteLine("geo_pointset_isqrt threw: " + ex.Message); }
        }
    }
}
