// Auto-generated from resdata\rd_kw.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_rd_kw {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr rd_kw_fortio_size(IntPtr rd_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_set_data_ptr(IntPtr rd_kw, IntPtr data);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_fwrite_data(IntPtr _rd_kw, IntPtr fortio);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_kw_fread_realloc_data(IntPtr rd_kw, IntPtr fortio);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr rd_kw_get_data_type(IntPtr p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr rd_kw_fread_header(IntPtr p0, IntPtr p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void rd_kw_set_header_name(IntPtr p0, string p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool rd_kw_fseek_kw(string p0, bool p1, bool p2, IntPtr p3);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_fskip(IntPtr p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_kw_fread_realloc(IntPtr p0, IntPtr p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_free(IntPtr p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_resize(IntPtr rd_kw, int new_size);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_memcpy(IntPtr p0, IntPtr p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_get_memcpy_data(IntPtr p0, IntPtr p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_set_memcpy_data(IntPtr p0, IntPtr p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_kw_fwrite(IntPtr p0, IntPtr p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_iget(IntPtr p0, int p1, IntPtr p2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_iset(IntPtr rd_kw, int i, IntPtr iptr);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void rd_kw_iset_char_ptr(IntPtr rd_kw, int index, string s);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void rd_kw_iset_string8(IntPtr rd_kw, int index, string s8);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void rd_kw_iset_string_ptr(IntPtr p0, int p1, string p2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_kw_get_size(IntPtr p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_summarize(IntPtr rd_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_kw_iget_as_double(IntPtr rd_kw, int i);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_kw_equal(IntPtr rd_kw1, IntPtr rd_kw2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_kw_data_equal(IntPtr rd_kw, IntPtr data);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_kw_content_equal(IntPtr rd_kw1, IntPtr rd_kw2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_kw_fskip_data__(IntPtr p0, int p1, IntPtr p2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_kw_fskip_data(IntPtr rd_kw, IntPtr fortio);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_fskip_header(IntPtr fortio);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_kw_inplace_safe_div(IntPtr target_kw, IntPtr divisor);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_inplace_sqrt(IntPtr kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_kw_element_sum_int(IntPtr rd_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_kw_element_sum_float(IntPtr rd_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_element_sum(IntPtr p0, IntPtr p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_max_min(IntPtr p0, IntPtr p1, IntPtr p2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void rd_kw_fprintf_data(IntPtr rd_kw, string fmt, IntPtr stream);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_memcpy_data(IntPtr target, IntPtr src);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_scalar_set_float_or_double(IntPtr rd_kw, double value);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_inplace_add_squared(IntPtr target_kw, IntPtr add_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_inplace_add(IntPtr target_kw, IntPtr add_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_inplace_sub(IntPtr target_kw, IntPtr sub_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_inplace_div(IntPtr target_kw, IntPtr div_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_inplace_mul(IntPtr target_kw, IntPtr mul_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_inplace_abs(IntPtr kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_kw_assert_binary_numeric(IntPtr kw1, IntPtr kw2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_kw_assert_numeric(IntPtr kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_kw_assert_binary(IntPtr kw1, IntPtr kw2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_scale_float_or_double(IntPtr rd_kw, double scale_factor);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_shift_float_or_double(IntPtr rd_kw, double shift_value);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_kw_iget_bool(IntPtr rd_kw, int i);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_iset_bool(IntPtr rd_kw, int i, bool bool_value);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr rd_kw_get_type(IntPtr p0);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\rd_kw.hpp");
            try { var r = rd_kw_fortio_size(IntPtr.Zero); Console.WriteLine("rd_kw_fortio_size -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_fortio_size threw: " + ex.Message); }
            try { rd_kw_set_data_ptr(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_kw_set_data_ptr -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_set_data_ptr threw: " + ex.Message); }
            try { rd_kw_fwrite_data(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_kw_fwrite_data -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_fwrite_data threw: " + ex.Message); }
            try { var r = rd_kw_fread_realloc_data(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_kw_fread_realloc_data -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_fread_realloc_data threw: " + ex.Message); }
            try { var r = rd_kw_get_data_type(IntPtr.Zero); Console.WriteLine("rd_kw_get_data_type -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_get_data_type threw: " + ex.Message); }
            try { var r = rd_kw_fread_header(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_kw_fread_header -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_fread_header threw: " + ex.Message); }
            try { rd_kw_set_header_name(IntPtr.Zero, null); Console.WriteLine("rd_kw_set_header_name -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_set_header_name threw: " + ex.Message); }
            try { var r = rd_kw_fseek_kw(null, false, false, IntPtr.Zero); Console.WriteLine("rd_kw_fseek_kw -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_fseek_kw threw: " + ex.Message); }
            try { rd_kw_fskip(IntPtr.Zero); Console.WriteLine("rd_kw_fskip -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_fskip threw: " + ex.Message); }
            try { var r = rd_kw_fread_realloc(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_kw_fread_realloc -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_fread_realloc threw: " + ex.Message); }
            try { rd_kw_free(IntPtr.Zero); Console.WriteLine("rd_kw_free -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_free threw: " + ex.Message); }
            try { rd_kw_resize(IntPtr.Zero, 0); Console.WriteLine("rd_kw_resize -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_resize threw: " + ex.Message); }
            try { rd_kw_memcpy(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_kw_memcpy -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_memcpy threw: " + ex.Message); }
            try { rd_kw_get_memcpy_data(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_kw_get_memcpy_data -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_get_memcpy_data threw: " + ex.Message); }
            try { rd_kw_set_memcpy_data(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_kw_set_memcpy_data -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_set_memcpy_data threw: " + ex.Message); }
            try { var r = rd_kw_fwrite(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_kw_fwrite -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_fwrite threw: " + ex.Message); }
            try { rd_kw_iget(IntPtr.Zero, 0, IntPtr.Zero); Console.WriteLine("rd_kw_iget -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_iget threw: " + ex.Message); }
            try { rd_kw_iset(IntPtr.Zero, 0, IntPtr.Zero); Console.WriteLine("rd_kw_iset -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_iset threw: " + ex.Message); }
            try { rd_kw_iset_char_ptr(IntPtr.Zero, 0, null); Console.WriteLine("rd_kw_iset_char_ptr -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_iset_char_ptr threw: " + ex.Message); }
            try { rd_kw_iset_string8(IntPtr.Zero, 0, null); Console.WriteLine("rd_kw_iset_string8 -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_iset_string8 threw: " + ex.Message); }
            try { rd_kw_iset_string_ptr(IntPtr.Zero, 0, null); Console.WriteLine("rd_kw_iset_string_ptr -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_iset_string_ptr threw: " + ex.Message); }
            try { var r = rd_kw_get_size(IntPtr.Zero); Console.WriteLine("rd_kw_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_get_size threw: " + ex.Message); }
            try { rd_kw_summarize(IntPtr.Zero); Console.WriteLine("rd_kw_summarize -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_summarize threw: " + ex.Message); }
            try { var r = rd_kw_iget_as_double(IntPtr.Zero, 0); Console.WriteLine("rd_kw_iget_as_double -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_iget_as_double threw: " + ex.Message); }
            try { var r = rd_kw_equal(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_kw_equal -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_equal threw: " + ex.Message); }
            try { var r = rd_kw_data_equal(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_kw_data_equal -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_data_equal threw: " + ex.Message); }
            try { var r = rd_kw_content_equal(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_kw_content_equal -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_content_equal threw: " + ex.Message); }
            try { var r = rd_kw_fskip_data__(IntPtr.Zero, 0, IntPtr.Zero); Console.WriteLine("rd_kw_fskip_data__ -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_fskip_data__ threw: " + ex.Message); }
            try { var r = rd_kw_fskip_data(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_kw_fskip_data -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_fskip_data threw: " + ex.Message); }
            try { rd_kw_fskip_header(IntPtr.Zero); Console.WriteLine("rd_kw_fskip_header -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_fskip_header threw: " + ex.Message); }
            try { var r = rd_kw_inplace_safe_div(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_kw_inplace_safe_div -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_inplace_safe_div threw: " + ex.Message); }
            try { rd_kw_inplace_sqrt(IntPtr.Zero); Console.WriteLine("rd_kw_inplace_sqrt -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_inplace_sqrt threw: " + ex.Message); }
            try { var r = rd_kw_element_sum_int(IntPtr.Zero); Console.WriteLine("rd_kw_element_sum_int -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_element_sum_int threw: " + ex.Message); }
            try { var r = rd_kw_element_sum_float(IntPtr.Zero); Console.WriteLine("rd_kw_element_sum_float -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_element_sum_float threw: " + ex.Message); }
            try { rd_kw_element_sum(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_kw_element_sum -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_element_sum threw: " + ex.Message); }
            try { rd_kw_max_min(IntPtr.Zero, IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_kw_max_min -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_max_min threw: " + ex.Message); }
            try { rd_kw_fprintf_data(IntPtr.Zero, null, IntPtr.Zero); Console.WriteLine("rd_kw_fprintf_data -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_fprintf_data threw: " + ex.Message); }
            try { rd_kw_memcpy_data(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_kw_memcpy_data -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_memcpy_data threw: " + ex.Message); }
            try { rd_kw_scalar_set_float_or_double(IntPtr.Zero, 0.0); Console.WriteLine("rd_kw_scalar_set_float_or_double -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_scalar_set_float_or_double threw: " + ex.Message); }
            try { rd_kw_inplace_add_squared(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_kw_inplace_add_squared -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_inplace_add_squared threw: " + ex.Message); }
            try { rd_kw_inplace_add(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_kw_inplace_add -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_inplace_add threw: " + ex.Message); }
            try { rd_kw_inplace_sub(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_kw_inplace_sub -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_inplace_sub threw: " + ex.Message); }
            try { rd_kw_inplace_div(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_kw_inplace_div -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_inplace_div threw: " + ex.Message); }
            try { rd_kw_inplace_mul(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_kw_inplace_mul -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_inplace_mul threw: " + ex.Message); }
            try { rd_kw_inplace_abs(IntPtr.Zero); Console.WriteLine("rd_kw_inplace_abs -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_inplace_abs threw: " + ex.Message); }
            try { var r = rd_kw_assert_binary_numeric(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_kw_assert_binary_numeric -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_assert_binary_numeric threw: " + ex.Message); }
            try { var r = rd_kw_assert_numeric(IntPtr.Zero); Console.WriteLine("rd_kw_assert_numeric -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_assert_numeric threw: " + ex.Message); }
            try { var r = rd_kw_assert_binary(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_kw_assert_binary -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_assert_binary threw: " + ex.Message); }
            try { rd_kw_scale_float_or_double(IntPtr.Zero, 0.0); Console.WriteLine("rd_kw_scale_float_or_double -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_scale_float_or_double threw: " + ex.Message); }
            try { rd_kw_shift_float_or_double(IntPtr.Zero, 0.0); Console.WriteLine("rd_kw_shift_float_or_double -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_shift_float_or_double threw: " + ex.Message); }
            try { var r = rd_kw_iget_bool(IntPtr.Zero, 0); Console.WriteLine("rd_kw_iget_bool -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_iget_bool threw: " + ex.Message); }
            try { rd_kw_iset_bool(IntPtr.Zero, 0, false); Console.WriteLine("rd_kw_iset_bool -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_iset_bool threw: " + ex.Message); }
            try { var r = rd_kw_get_type(IntPtr.Zero); Console.WriteLine("rd_kw_get_type -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_get_type threw: " + ex.Message); }
        }
    }
}
