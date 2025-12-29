// Auto-generated from resdata\rd_kw.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_rd_kw {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern nuint rd_kw_fortio_size(SafeRdKwHandle? rd_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_set_data_ptr(SafeRdKwHandle? rd_kw, SafeDataHandle? data);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_fwrite_data(SafeRdKwHandle? _rd_kw, SafeFortioHandle? fortio);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_kw_fread_realloc_data(SafeRdKwHandle? rd_kw, SafeFortioHandle? fortio);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr rd_kw_get_data_type(SafeRdKwTypeHandle? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr rd_kw_fread_header(SafeRdKwTypeHandle? p0, SafeFortioTypeHandle? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void rd_kw_set_header_name(SafeRdKwTypeHandle? p0, string? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool rd_kw_fseek_kw(string? p0, bool p1, bool p2, SafeFortioTypeHandle? p3);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_fskip(SafeFortioTypeHandle? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_kw_fread_realloc(SafeRdKwTypeHandle? p0, SafeFortioTypeHandle? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_free(SafeRdKwTypeHandle? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_resize(SafeRdKwHandle? rd_kw, int new_size);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_memcpy(SafeRdKwTypeHandle? p0, SafeRdKwTypeHandle? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_get_memcpy_data(SafeRdKwTypeHandle? p0, SafeVoidHandle? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_set_memcpy_data(SafeRdKwTypeHandle? p0, SafeVoidHandle? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_kw_fwrite(SafeRdKwTypeHandle? p0, SafeFortioTypeHandle? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_iget(SafeRdKwTypeHandle? p0, int p1, SafeVoidHandle? p2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_iset(SafeRdKwHandle? rd_kw, int i, SafeIptrHandle? iptr);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void rd_kw_iset_char_ptr(SafeRdKwHandle? rd_kw, int index, string? s);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void rd_kw_iset_string8(SafeRdKwHandle? rd_kw, int index, string? s8);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void rd_kw_iset_string_ptr(SafeRdKwTypeHandle? p0, int p1, string? p2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_kw_get_size(SafeRdKwTypeHandle? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_summarize(SafeRdKwHandle? rd_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_kw_iget_as_double(SafeRdKwHandle? rd_kw, int i);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_kw_equal(SafeRdKw1Handle? rd_kw1, SafeRdKw2Handle? rd_kw2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_kw_data_equal(SafeRdKwHandle? rd_kw, SafeDataHandle? data);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_kw_content_equal(SafeRdKw1Handle? rd_kw1, SafeRdKw2Handle? rd_kw2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_kw_fskip_data__(IntPtr p0, int p1, SafeFortioTypeHandle? p2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_kw_fskip_data(SafeRdKwHandle? rd_kw, SafeFortioHandle? fortio);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_fskip_header(SafeFortioHandle? fortio);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_kw_inplace_safe_div(SafeTargetKwHandle? target_kw, SafeDivisorHandle? divisor);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_inplace_sqrt(SafeKwHandle? kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_kw_element_sum_int(SafeRdKwHandle? rd_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_kw_element_sum_float(SafeRdKwHandle? rd_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_element_sum(SafeRdKwTypeHandle? p0, SafeVoidHandle? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_max_min(SafeRdKwTypeHandle? p0, SafeVoidHandle? p1, SafeVoidHandle? p2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void rd_kw_fprintf_data(SafeRdKwHandle? rd_kw, string? fmt, SafeStreamHandle? stream);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_memcpy_data(SafeTargetHandle? target, SafeSrcHandle? src);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_scalar_set_float_or_double(SafeRdKwHandle? rd_kw, double value);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_inplace_add_squared(SafeTargetKwHandle? target_kw, SafeAddKwHandle? add_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_inplace_add(SafeTargetKwHandle? target_kw, SafeAddKwHandle? add_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_inplace_sub(SafeTargetKwHandle? target_kw, SafeSubKwHandle? sub_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_inplace_div(SafeTargetKwHandle? target_kw, SafeDivKwHandle? div_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_inplace_mul(SafeTargetKwHandle? target_kw, SafeMulKwHandle? mul_kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_inplace_abs(SafeKwHandle? kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_kw_assert_binary_numeric(SafeKw1Handle? kw1, SafeKw2Handle? kw2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_kw_assert_numeric(SafeKwHandle? kw);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_kw_assert_binary(SafeKw1Handle? kw1, SafeKw2Handle? kw2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_scale_float_or_double(SafeRdKwHandle? rd_kw, double scale_factor);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_shift_float_or_double(SafeRdKwHandle? rd_kw, double shift_value);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_kw_iget_bool(SafeRdKwHandle? rd_kw, int i);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_iset_bool(SafeRdKwHandle? rd_kw, int i, bool bool_value);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr rd_kw_get_type(SafeRdKwTypeHandle? p0);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\rd_kw.hpp");
            try { var r = rd_kw_fortio_size((SafeRdKwHandle?)null); Console.WriteLine("rd_kw_fortio_size -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_fortio_size threw: " + ex.Message); }
            try { rd_kw_set_data_ptr((SafeRdKwHandle?)null, (SafeDataHandle?)null); Console.WriteLine("rd_kw_set_data_ptr -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_set_data_ptr threw: " + ex.Message); }
            try { rd_kw_fwrite_data((SafeRdKwHandle?)null, (SafeFortioHandle?)null); Console.WriteLine("rd_kw_fwrite_data -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_fwrite_data threw: " + ex.Message); }
            try { var r = rd_kw_fread_realloc_data((SafeRdKwHandle?)null, (SafeFortioHandle?)null); Console.WriteLine("rd_kw_fread_realloc_data -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_fread_realloc_data threw: " + ex.Message); }
            try { var r = rd_kw_get_data_type((SafeRdKwTypeHandle?)null); Console.WriteLine("rd_kw_get_data_type -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_get_data_type threw: " + ex.Message); }
            try { var r = rd_kw_fread_header((SafeRdKwTypeHandle?)null, (SafeFortioTypeHandle?)null); Console.WriteLine("rd_kw_fread_header -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_fread_header threw: " + ex.Message); }
            try { rd_kw_set_header_name((SafeRdKwTypeHandle?)null, (string?)null); Console.WriteLine("rd_kw_set_header_name -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_set_header_name threw: " + ex.Message); }
            try { var r = rd_kw_fseek_kw((string?)null, false, false, (SafeFortioTypeHandle?)null); Console.WriteLine("rd_kw_fseek_kw -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_fseek_kw threw: " + ex.Message); }
            try { rd_kw_fskip((SafeFortioTypeHandle?)null); Console.WriteLine("rd_kw_fskip -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_fskip threw: " + ex.Message); }
            try { var r = rd_kw_fread_realloc((SafeRdKwTypeHandle?)null, (SafeFortioTypeHandle?)null); Console.WriteLine("rd_kw_fread_realloc -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_fread_realloc threw: " + ex.Message); }
            try { rd_kw_free((SafeRdKwTypeHandle?)null); Console.WriteLine("rd_kw_free -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_free threw: " + ex.Message); }
            try { rd_kw_resize((SafeRdKwHandle?)null, 0); Console.WriteLine("rd_kw_resize -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_resize threw: " + ex.Message); }
            try { rd_kw_memcpy((SafeRdKwTypeHandle?)null, (SafeRdKwTypeHandle?)null); Console.WriteLine("rd_kw_memcpy -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_memcpy threw: " + ex.Message); }
            try { rd_kw_get_memcpy_data((SafeRdKwTypeHandle?)null, (SafeVoidHandle?)null); Console.WriteLine("rd_kw_get_memcpy_data -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_get_memcpy_data threw: " + ex.Message); }
            try { rd_kw_set_memcpy_data((SafeRdKwTypeHandle?)null, (SafeVoidHandle?)null); Console.WriteLine("rd_kw_set_memcpy_data -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_set_memcpy_data threw: " + ex.Message); }
            try { var r = rd_kw_fwrite((SafeRdKwTypeHandle?)null, (SafeFortioTypeHandle?)null); Console.WriteLine("rd_kw_fwrite -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_fwrite threw: " + ex.Message); }
            try { rd_kw_iget((SafeRdKwTypeHandle?)null, 0, (SafeVoidHandle?)null); Console.WriteLine("rd_kw_iget -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_iget threw: " + ex.Message); }
            try { rd_kw_iset((SafeRdKwHandle?)null, 0, (SafeIptrHandle?)null); Console.WriteLine("rd_kw_iset -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_iset threw: " + ex.Message); }
            try { rd_kw_iset_char_ptr((SafeRdKwHandle?)null, 0, (string?)null); Console.WriteLine("rd_kw_iset_char_ptr -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_iset_char_ptr threw: " + ex.Message); }
            try { rd_kw_iset_string8((SafeRdKwHandle?)null, 0, (string?)null); Console.WriteLine("rd_kw_iset_string8 -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_iset_string8 threw: " + ex.Message); }
            try { rd_kw_iset_string_ptr((SafeRdKwTypeHandle?)null, 0, (string?)null); Console.WriteLine("rd_kw_iset_string_ptr -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_iset_string_ptr threw: " + ex.Message); }
            try { var r = rd_kw_get_size((SafeRdKwTypeHandle?)null); Console.WriteLine("rd_kw_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_get_size threw: " + ex.Message); }
            try { rd_kw_summarize((SafeRdKwHandle?)null); Console.WriteLine("rd_kw_summarize -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_summarize threw: " + ex.Message); }
            try { var r = rd_kw_iget_as_double((SafeRdKwHandle?)null, 0); Console.WriteLine("rd_kw_iget_as_double -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_iget_as_double threw: " + ex.Message); }
            try { var r = rd_kw_equal((SafeRdKw1Handle?)null, (SafeRdKw2Handle?)null); Console.WriteLine("rd_kw_equal -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_equal threw: " + ex.Message); }
            try { var r = rd_kw_data_equal((SafeRdKwHandle?)null, (SafeDataHandle?)null); Console.WriteLine("rd_kw_data_equal -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_data_equal threw: " + ex.Message); }
            try { var r = rd_kw_content_equal((SafeRdKw1Handle?)null, (SafeRdKw2Handle?)null); Console.WriteLine("rd_kw_content_equal -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_content_equal threw: " + ex.Message); }
            try { var r = rd_kw_fskip_data__(IntPtr.Zero, 0, (SafeFortioTypeHandle?)null); Console.WriteLine("rd_kw_fskip_data__ -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_fskip_data__ threw: " + ex.Message); }
            try { var r = rd_kw_fskip_data((SafeRdKwHandle?)null, (SafeFortioHandle?)null); Console.WriteLine("rd_kw_fskip_data -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_fskip_data threw: " + ex.Message); }
            try { rd_kw_fskip_header((SafeFortioHandle?)null); Console.WriteLine("rd_kw_fskip_header -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_fskip_header threw: " + ex.Message); }
            try { var r = rd_kw_inplace_safe_div((SafeTargetKwHandle?)null, (SafeDivisorHandle?)null); Console.WriteLine("rd_kw_inplace_safe_div -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_inplace_safe_div threw: " + ex.Message); }
            try { rd_kw_inplace_sqrt((SafeKwHandle?)null); Console.WriteLine("rd_kw_inplace_sqrt -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_inplace_sqrt threw: " + ex.Message); }
            try { var r = rd_kw_element_sum_int((SafeRdKwHandle?)null); Console.WriteLine("rd_kw_element_sum_int -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_element_sum_int threw: " + ex.Message); }
            try { var r = rd_kw_element_sum_float((SafeRdKwHandle?)null); Console.WriteLine("rd_kw_element_sum_float -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_element_sum_float threw: " + ex.Message); }
            try { rd_kw_element_sum((SafeRdKwTypeHandle?)null, (SafeVoidHandle?)null); Console.WriteLine("rd_kw_element_sum -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_element_sum threw: " + ex.Message); }
            try { rd_kw_max_min((SafeRdKwTypeHandle?)null, (SafeVoidHandle?)null, (SafeVoidHandle?)null); Console.WriteLine("rd_kw_max_min -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_max_min threw: " + ex.Message); }
            try { rd_kw_fprintf_data((SafeRdKwHandle?)null, (string?)null, (SafeStreamHandle?)null); Console.WriteLine("rd_kw_fprintf_data -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_fprintf_data threw: " + ex.Message); }
            try { rd_kw_memcpy_data((SafeTargetHandle?)null, (SafeSrcHandle?)null); Console.WriteLine("rd_kw_memcpy_data -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_memcpy_data threw: " + ex.Message); }
            try { rd_kw_scalar_set_float_or_double((SafeRdKwHandle?)null, 0.0); Console.WriteLine("rd_kw_scalar_set_float_or_double -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_scalar_set_float_or_double threw: " + ex.Message); }
            try { rd_kw_inplace_add_squared((SafeTargetKwHandle?)null, (SafeAddKwHandle?)null); Console.WriteLine("rd_kw_inplace_add_squared -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_inplace_add_squared threw: " + ex.Message); }
            try { rd_kw_inplace_add((SafeTargetKwHandle?)null, (SafeAddKwHandle?)null); Console.WriteLine("rd_kw_inplace_add -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_inplace_add threw: " + ex.Message); }
            try { rd_kw_inplace_sub((SafeTargetKwHandle?)null, (SafeSubKwHandle?)null); Console.WriteLine("rd_kw_inplace_sub -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_inplace_sub threw: " + ex.Message); }
            try { rd_kw_inplace_div((SafeTargetKwHandle?)null, (SafeDivKwHandle?)null); Console.WriteLine("rd_kw_inplace_div -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_inplace_div threw: " + ex.Message); }
            try { rd_kw_inplace_mul((SafeTargetKwHandle?)null, (SafeMulKwHandle?)null); Console.WriteLine("rd_kw_inplace_mul -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_inplace_mul threw: " + ex.Message); }
            try { rd_kw_inplace_abs((SafeKwHandle?)null); Console.WriteLine("rd_kw_inplace_abs -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_inplace_abs threw: " + ex.Message); }
            try { var r = rd_kw_assert_binary_numeric((SafeKw1Handle?)null, (SafeKw2Handle?)null); Console.WriteLine("rd_kw_assert_binary_numeric -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_assert_binary_numeric threw: " + ex.Message); }
            try { var r = rd_kw_assert_numeric((SafeKwHandle?)null); Console.WriteLine("rd_kw_assert_numeric -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_assert_numeric threw: " + ex.Message); }
            try { var r = rd_kw_assert_binary((SafeKw1Handle?)null, (SafeKw2Handle?)null); Console.WriteLine("rd_kw_assert_binary -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_assert_binary threw: " + ex.Message); }
            try { rd_kw_scale_float_or_double((SafeRdKwHandle?)null, 0.0); Console.WriteLine("rd_kw_scale_float_or_double -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_scale_float_or_double threw: " + ex.Message); }
            try { rd_kw_shift_float_or_double((SafeRdKwHandle?)null, 0.0); Console.WriteLine("rd_kw_shift_float_or_double -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_shift_float_or_double threw: " + ex.Message); }
            try { var r = rd_kw_iget_bool((SafeRdKwHandle?)null, 0); Console.WriteLine("rd_kw_iget_bool -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_iget_bool threw: " + ex.Message); }
            try { rd_kw_iset_bool((SafeRdKwHandle?)null, 0, false); Console.WriteLine("rd_kw_iset_bool -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_iset_bool threw: " + ex.Message); }
            try { var r = rd_kw_get_type((SafeRdKwTypeHandle?)null); Console.WriteLine("rd_kw_get_type -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_get_type threw: " + ex.Message); }
        }
    }
}
