// Auto-generated from ert\util\lookup_table.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_lookup_table {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void lookup_table_append(SafeLtHandle? lt, double x, double y);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void lookup_table_free(SafeLtHandle? lt);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double lookup_table_interp(SafeLtHandle? lt, double x);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double lookup_table_get_max_value(SafeLookupTableHandle? lookup_table);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double lookup_table_get_min_value(SafeLookupTableHandle? lookup_table);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double lookup_table_get_max_arg(SafeLookupTableHandle? lookup_table);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double lookup_table_get_min_arg(SafeLookupTableHandle? lookup_table);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int lookup_table_get_size(SafeLtHandle? lt);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void lookup_table_set_low_limit(SafeLtHandle? lt, double limit);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool lookup_table_has_low_limit(SafeLtHandle? lt);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void lookup_table_set_high_limit(SafeLtHandle? lt, double limit);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool lookup_table_has_high_limit(SafeLtHandle? lt);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: ert\\util\\lookup_table.hpp");
            try { lookup_table_append((SafeLtHandle?)null, 0.0, 0.0); Console.WriteLine("lookup_table_append -> (void)"); } catch(Exception ex) { Console.WriteLine("lookup_table_append threw: " + ex.Message); }
            try { lookup_table_free((SafeLtHandle?)null); Console.WriteLine("lookup_table_free -> (void)"); } catch(Exception ex) { Console.WriteLine("lookup_table_free threw: " + ex.Message); }
            try { var r = lookup_table_interp((SafeLtHandle?)null, 0.0); Console.WriteLine("lookup_table_interp -> " + r); } catch(Exception ex) { Console.WriteLine("lookup_table_interp threw: " + ex.Message); }
            try { var r = lookup_table_get_max_value((SafeLookupTableHandle?)null); Console.WriteLine("lookup_table_get_max_value -> " + r); } catch(Exception ex) { Console.WriteLine("lookup_table_get_max_value threw: " + ex.Message); }
            try { var r = lookup_table_get_min_value((SafeLookupTableHandle?)null); Console.WriteLine("lookup_table_get_min_value -> " + r); } catch(Exception ex) { Console.WriteLine("lookup_table_get_min_value threw: " + ex.Message); }
            try { var r = lookup_table_get_max_arg((SafeLookupTableHandle?)null); Console.WriteLine("lookup_table_get_max_arg -> " + r); } catch(Exception ex) { Console.WriteLine("lookup_table_get_max_arg threw: " + ex.Message); }
            try { var r = lookup_table_get_min_arg((SafeLookupTableHandle?)null); Console.WriteLine("lookup_table_get_min_arg -> " + r); } catch(Exception ex) { Console.WriteLine("lookup_table_get_min_arg threw: " + ex.Message); }
            try { var r = lookup_table_get_size((SafeLtHandle?)null); Console.WriteLine("lookup_table_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("lookup_table_get_size threw: " + ex.Message); }
            try { lookup_table_set_low_limit((SafeLtHandle?)null, 0.0); Console.WriteLine("lookup_table_set_low_limit -> (void)"); } catch(Exception ex) { Console.WriteLine("lookup_table_set_low_limit threw: " + ex.Message); }
            try { var r = lookup_table_has_low_limit((SafeLtHandle?)null); Console.WriteLine("lookup_table_has_low_limit -> " + r); } catch(Exception ex) { Console.WriteLine("lookup_table_has_low_limit threw: " + ex.Message); }
            try { lookup_table_set_high_limit((SafeLtHandle?)null, 0.0); Console.WriteLine("lookup_table_set_high_limit -> (void)"); } catch(Exception ex) { Console.WriteLine("lookup_table_set_high_limit threw: " + ex.Message); }
            try { var r = lookup_table_has_high_limit((SafeLtHandle?)null); Console.WriteLine("lookup_table_has_high_limit -> " + r); } catch(Exception ex) { Console.WriteLine("lookup_table_has_high_limit threw: " + ex.Message); }
        }
    }
}
