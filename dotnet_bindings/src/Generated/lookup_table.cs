// Auto-generated from ert\util\lookup_table.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_lookup_table {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void lookup_table_append(IntPtr lt, double x, double y);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void lookup_table_free(IntPtr lt);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double lookup_table_interp(IntPtr lt, double x);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double lookup_table_get_max_value(IntPtr lookup_table);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double lookup_table_get_min_value(IntPtr lookup_table);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double lookup_table_get_max_arg(IntPtr lookup_table);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double lookup_table_get_min_arg(IntPtr lookup_table);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int lookup_table_get_size(IntPtr lt);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void lookup_table_set_low_limit(IntPtr lt, double limit);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool lookup_table_has_low_limit(IntPtr lt);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void lookup_table_set_high_limit(IntPtr lt, double limit);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool lookup_table_has_high_limit(IntPtr lt);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: ert\\util\\lookup_table.hpp");
            try { lookup_table_append(IntPtr.Zero, 0.0, 0.0); Console.WriteLine("lookup_table_append -> (void)"); } catch(Exception ex) { Console.WriteLine("lookup_table_append threw: " + ex.Message); }
            try { lookup_table_free(IntPtr.Zero); Console.WriteLine("lookup_table_free -> (void)"); } catch(Exception ex) { Console.WriteLine("lookup_table_free threw: " + ex.Message); }
            try { var r = lookup_table_interp(IntPtr.Zero, 0.0); Console.WriteLine("lookup_table_interp -> " + r); } catch(Exception ex) { Console.WriteLine("lookup_table_interp threw: " + ex.Message); }
            try { var r = lookup_table_get_max_value(IntPtr.Zero); Console.WriteLine("lookup_table_get_max_value -> " + r); } catch(Exception ex) { Console.WriteLine("lookup_table_get_max_value threw: " + ex.Message); }
            try { var r = lookup_table_get_min_value(IntPtr.Zero); Console.WriteLine("lookup_table_get_min_value -> " + r); } catch(Exception ex) { Console.WriteLine("lookup_table_get_min_value threw: " + ex.Message); }
            try { var r = lookup_table_get_max_arg(IntPtr.Zero); Console.WriteLine("lookup_table_get_max_arg -> " + r); } catch(Exception ex) { Console.WriteLine("lookup_table_get_max_arg threw: " + ex.Message); }
            try { var r = lookup_table_get_min_arg(IntPtr.Zero); Console.WriteLine("lookup_table_get_min_arg -> " + r); } catch(Exception ex) { Console.WriteLine("lookup_table_get_min_arg threw: " + ex.Message); }
            try { var r = lookup_table_get_size(IntPtr.Zero); Console.WriteLine("lookup_table_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("lookup_table_get_size threw: " + ex.Message); }
            try { lookup_table_set_low_limit(IntPtr.Zero, 0.0); Console.WriteLine("lookup_table_set_low_limit -> (void)"); } catch(Exception ex) { Console.WriteLine("lookup_table_set_low_limit threw: " + ex.Message); }
            try { var r = lookup_table_has_low_limit(IntPtr.Zero); Console.WriteLine("lookup_table_has_low_limit -> " + r); } catch(Exception ex) { Console.WriteLine("lookup_table_has_low_limit threw: " + ex.Message); }
            try { lookup_table_set_high_limit(IntPtr.Zero, 0.0); Console.WriteLine("lookup_table_set_high_limit -> (void)"); } catch(Exception ex) { Console.WriteLine("lookup_table_set_high_limit threw: " + ex.Message); }
            try { var r = lookup_table_has_high_limit(IntPtr.Zero); Console.WriteLine("lookup_table_has_high_limit -> " + r); } catch(Exception ex) { Console.WriteLine("lookup_table_has_high_limit threw: " + ex.Message); }
        }
    }
}
