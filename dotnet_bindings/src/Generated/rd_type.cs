// Auto-generated from resdata\rd_type.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_rd_type {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern IntPtr rd_type_create_from_name(string? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr rd_type_create(IntPtr rd_type_enum, IntPtr p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr rd_type_create_from_type(IntPtr rd_type_enum);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr rd_type_get_type(IntPtr rd_data_type);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_type_get_sizeof_ctype(IntPtr rd_data_type);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_type_get_sizeof_iotype(IntPtr rd_data_type);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_type_is_equal(IntPtr rd_data_type, IntPtr rd_data_type_1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_type_is_numeric(IntPtr rd_data_type);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_type_is_alpha(IntPtr rd_data_type);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_type_is_char(IntPtr rd_data_type);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_type_is_int(IntPtr rd_data_type);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_type_is_float(IntPtr rd_data_type);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_type_is_double(IntPtr rd_data_type);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_type_is_mess(IntPtr rd_data_type);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_type_is_bool(IntPtr rd_data_type);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_type_is_string(IntPtr rd_data_type);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\rd_type.hpp");
            try { var r = rd_type_create_from_name((string?)null); Console.WriteLine("rd_type_create_from_name -> " + r); } catch(Exception ex) { Console.WriteLine("rd_type_create_from_name threw: " + ex.Message); }
            try { var r = rd_type_create(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_type_create -> " + r); } catch(Exception ex) { Console.WriteLine("rd_type_create threw: " + ex.Message); }
            try { var r = rd_type_create_from_type(IntPtr.Zero); Console.WriteLine("rd_type_create_from_type -> " + r); } catch(Exception ex) { Console.WriteLine("rd_type_create_from_type threw: " + ex.Message); }
            try { var r = rd_type_get_type(IntPtr.Zero); Console.WriteLine("rd_type_get_type -> " + r); } catch(Exception ex) { Console.WriteLine("rd_type_get_type threw: " + ex.Message); }
            try { var r = rd_type_get_sizeof_ctype(IntPtr.Zero); Console.WriteLine("rd_type_get_sizeof_ctype -> " + r); } catch(Exception ex) { Console.WriteLine("rd_type_get_sizeof_ctype threw: " + ex.Message); }
            try { var r = rd_type_get_sizeof_iotype(IntPtr.Zero); Console.WriteLine("rd_type_get_sizeof_iotype -> " + r); } catch(Exception ex) { Console.WriteLine("rd_type_get_sizeof_iotype threw: " + ex.Message); }
            try { var r = rd_type_is_equal(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_type_is_equal -> " + r); } catch(Exception ex) { Console.WriteLine("rd_type_is_equal threw: " + ex.Message); }
            try { var r = rd_type_is_numeric(IntPtr.Zero); Console.WriteLine("rd_type_is_numeric -> " + r); } catch(Exception ex) { Console.WriteLine("rd_type_is_numeric threw: " + ex.Message); }
            try { var r = rd_type_is_alpha(IntPtr.Zero); Console.WriteLine("rd_type_is_alpha -> " + r); } catch(Exception ex) { Console.WriteLine("rd_type_is_alpha threw: " + ex.Message); }
            try { var r = rd_type_is_char(IntPtr.Zero); Console.WriteLine("rd_type_is_char -> " + r); } catch(Exception ex) { Console.WriteLine("rd_type_is_char threw: " + ex.Message); }
            try { var r = rd_type_is_int(IntPtr.Zero); Console.WriteLine("rd_type_is_int -> " + r); } catch(Exception ex) { Console.WriteLine("rd_type_is_int threw: " + ex.Message); }
            try { var r = rd_type_is_float(IntPtr.Zero); Console.WriteLine("rd_type_is_float -> " + r); } catch(Exception ex) { Console.WriteLine("rd_type_is_float threw: " + ex.Message); }
            try { var r = rd_type_is_double(IntPtr.Zero); Console.WriteLine("rd_type_is_double -> " + r); } catch(Exception ex) { Console.WriteLine("rd_type_is_double threw: " + ex.Message); }
            try { var r = rd_type_is_mess(IntPtr.Zero); Console.WriteLine("rd_type_is_mess -> " + r); } catch(Exception ex) { Console.WriteLine("rd_type_is_mess threw: " + ex.Message); }
            try { var r = rd_type_is_bool(IntPtr.Zero); Console.WriteLine("rd_type_is_bool -> " + r); } catch(Exception ex) { Console.WriteLine("rd_type_is_bool threw: " + ex.Message); }
            try { var r = rd_type_is_string(IntPtr.Zero); Console.WriteLine("rd_type_is_string -> " + r); } catch(Exception ex) { Console.WriteLine("rd_type_is_string threw: " + ex.Message); }
        }
    }
}
