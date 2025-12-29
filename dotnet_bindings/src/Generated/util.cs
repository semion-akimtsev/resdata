// Auto-generated from ert\util\util.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_util {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern long util_make_datetime_utc(int p0, int p1, int p2, int p3, int p4, int p5);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern long util_make_date_utc(int p0, int p1, int p2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void util_inplace_forward_seconds_utc(SafeTHandle? t, double seconds);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void util_inplace_forward_days_utc(SafeTHandle? t, double days);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double util_difftime(long p0, long p1, SafeIntHandle? p2, SafeIntHandle? p3, SafeIntHandle? p4, SafeIntHandle? p5);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double util_difftime_days(long p0, long p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double util_difftime_seconds(long start_time, long end_time);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool util_sscanf_isodate(string? p0, SafeTimeTHandle? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool util_entry_exists(string? entry);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool util_file_exists(string? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool util_is_abs_path(string? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool util_fmt_bit8(string? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool util_mkdir_p(string? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void util_make_path(string? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern double util_file_difftime(string? p0, string? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern nuint util_file_size(string? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern nuint util_fd_size(int fd);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void util_clear_directory(string? path, bool strict_uid, bool unlink_root);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void util_strupr(string? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool util_string_equal(string? s1, string? s2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool util_copy_file(string? p0, string? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool util_is_cwd(string? path);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool util_ftruncate(SafeStreamHandle? stream, IntPtr size);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int util_roundf(float x);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int util_round(double x);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr util_ftell(SafeStreamHandle? stream);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int util_fseek(SafeStreamHandle? stream, IntPtr offset, int whence);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void util_rewind(SafeStreamHandle? stream);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern int util_stat(string? filename, SafeStatInfoHandle? stat_info);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int util_fstat(int fileno, SafeStatInfoHandle? stat_info);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void util_copy_directory_content(string? src_path, string? target_path);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void util_copy_directory(string? p0, string? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int util_forward_line(SafeFileHandle? p0, SafeBoolHandle? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void util_rewind_line(SafeFileHandle? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool util_fopen_test(string? p0, string? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void util_alloc_file_components(string? p0, string? p1, string? p2, string? p3);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool util_sscanf_bool(string? p0, SafeBoolHandle? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern int util_strcmp_int(string? s1, string? s2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern int util_strcmp_float(string? s1, string? s2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool util_sscanf_int(string? p0, SafeIntHandle? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool util_sscanf_double(string? p0, SafeDoubleHandle? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void util_path_split(string? line, SafeTokensHandle? _tokens, string? _token_list);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern int util_string_replace_inplace(string? p0, string? p1, string? p2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void util_free_stringlist(string? p0, int p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool util_is_directory(string? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool util_is_file(string? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void util_set_date_values_utc(long p0, SafeIntHandle? p1, SafeIntHandle? p2, SafeIntHandle? p3);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr util_clock_seed();
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void util_fread_dev_random(int p0, string? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void util_fread_dev_urandom(int p0, string? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void util_abort_test_set_intercept_function(string? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void util_install_signals();
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void util_update_signals();
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void util_fwrite_string(string? p0, SafeFileHandle? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void util_endian_flip_vector(SafeDataHandle? data, int element_size, int elements);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void util_double_vector_max_min(int p0, SafeDoubleHandle? p1, SafeDoubleHandle? p2, SafeDoubleHandle? p3);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void util_update_double_max_min(double p0, SafeDoubleHandle? p1, SafeDoubleHandle? p2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void util_update_float_max_min(float p0, SafeFloatHandle? p1, SafeFloatHandle? p2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void util_update_int_max_min(int p0, SafeIntHandle? p1, SafeIntHandle? p2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int util_int_max(int p0, int p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double util_double_max(double p0, double p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern float util_float_max(float p0, float p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int util_int_min(int p0, int p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern nuint util_size_t_min(nuint a, nuint b);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern nuint util_size_t_max(nuint a, nuint b);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double util_double_min(double p0, double p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern float util_float_min(float p0, float p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void util_fskip_lines(SafeFileHandle? p0, int p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool util_same_file(string? p0, string? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void util_fread(SafeVoidHandle? p0, nuint p1, nuint p2, SafeFileHandle? p3, string? p4);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void util_fwrite(SafeVoidHandle? p0, nuint p1, nuint p2, SafeFileHandle? p3, string? p4);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int util_fread_int(SafeFileHandle? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void util_fwrite_offset(IntPtr p0, SafeFileHandle? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void util_fwrite_size_t(nuint p0, SafeFileHandle? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void util_fwrite_int(int p0, SafeFileHandle? p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int util_get_current_linenr(SafeStreamHandle? stream);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool util_files_equal(string? file1, string? file2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double util_kahan_sum(SafeDataHandle? data, nuint N);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool util_double_approx_equal(double d1, double d2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern int util_fnmatch(string? pattern, string? @string);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void util_time_utc(SafeTHandle? t, SafeTsHandle? ts);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern int util_chdir(string? path);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool util_access(string? entry, IntPtr mode);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool util_access(string? entry, int mode);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void util_set_abort_handler(SafeUtilAbortHandlerTHandle? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void util_abort_signal(int p0);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: ert\\util\\util.hpp");
            try { var r = util_make_datetime_utc(0, 0, 0, 0, 0, 0); Console.WriteLine("util_make_datetime_utc -> " + r); } catch(Exception ex) { Console.WriteLine("util_make_datetime_utc threw: " + ex.Message); }
            try { var r = util_make_date_utc(0, 0, 0); Console.WriteLine("util_make_date_utc -> " + r); } catch(Exception ex) { Console.WriteLine("util_make_date_utc threw: " + ex.Message); }
            try { util_inplace_forward_seconds_utc((SafeTHandle?)null, 0.0); Console.WriteLine("util_inplace_forward_seconds_utc -> (void)"); } catch(Exception ex) { Console.WriteLine("util_inplace_forward_seconds_utc threw: " + ex.Message); }
            try { util_inplace_forward_days_utc((SafeTHandle?)null, 0.0); Console.WriteLine("util_inplace_forward_days_utc -> (void)"); } catch(Exception ex) { Console.WriteLine("util_inplace_forward_days_utc threw: " + ex.Message); }
            try { var r = util_difftime(0L, 0L, (SafeIntHandle?)null, (SafeIntHandle?)null, (SafeIntHandle?)null, (SafeIntHandle?)null); Console.WriteLine("util_difftime -> " + r); } catch(Exception ex) { Console.WriteLine("util_difftime threw: " + ex.Message); }
            try { var r = util_difftime_days(0L, 0L); Console.WriteLine("util_difftime_days -> " + r); } catch(Exception ex) { Console.WriteLine("util_difftime_days threw: " + ex.Message); }
            try { var r = util_difftime_seconds(0L, 0L); Console.WriteLine("util_difftime_seconds -> " + r); } catch(Exception ex) { Console.WriteLine("util_difftime_seconds threw: " + ex.Message); }
            try { var r = util_sscanf_isodate((string?)null, (SafeTimeTHandle?)null); Console.WriteLine("util_sscanf_isodate -> " + r); } catch(Exception ex) { Console.WriteLine("util_sscanf_isodate threw: " + ex.Message); }
            try { var r = util_entry_exists((string?)null); Console.WriteLine("util_entry_exists -> " + r); } catch(Exception ex) { Console.WriteLine("util_entry_exists threw: " + ex.Message); }
            try { var r = util_file_exists((string?)null); Console.WriteLine("util_file_exists -> " + r); } catch(Exception ex) { Console.WriteLine("util_file_exists threw: " + ex.Message); }
            try { var r = util_is_abs_path((string?)null); Console.WriteLine("util_is_abs_path -> " + r); } catch(Exception ex) { Console.WriteLine("util_is_abs_path threw: " + ex.Message); }
            try { var r = util_fmt_bit8((string?)null); Console.WriteLine("util_fmt_bit8 -> " + r); } catch(Exception ex) { Console.WriteLine("util_fmt_bit8 threw: " + ex.Message); }
            try { var r = util_mkdir_p((string?)null); Console.WriteLine("util_mkdir_p -> " + r); } catch(Exception ex) { Console.WriteLine("util_mkdir_p threw: " + ex.Message); }
            try { util_make_path((string?)null); Console.WriteLine("util_make_path -> (void)"); } catch(Exception ex) { Console.WriteLine("util_make_path threw: " + ex.Message); }
            try { var r = util_file_difftime((string?)null, (string?)null); Console.WriteLine("util_file_difftime -> " + r); } catch(Exception ex) { Console.WriteLine("util_file_difftime threw: " + ex.Message); }
            try { var r = util_file_size((string?)null); Console.WriteLine("util_file_size -> " + r); } catch(Exception ex) { Console.WriteLine("util_file_size threw: " + ex.Message); }
            try { var r = util_fd_size(0); Console.WriteLine("util_fd_size -> " + r); } catch(Exception ex) { Console.WriteLine("util_fd_size threw: " + ex.Message); }
            try { util_clear_directory((string?)null, false, false); Console.WriteLine("util_clear_directory -> (void)"); } catch(Exception ex) { Console.WriteLine("util_clear_directory threw: " + ex.Message); }
            try { util_strupr((string?)null); Console.WriteLine("util_strupr -> (void)"); } catch(Exception ex) { Console.WriteLine("util_strupr threw: " + ex.Message); }
            try { var r = util_string_equal((string?)null, (string?)null); Console.WriteLine("util_string_equal -> " + r); } catch(Exception ex) { Console.WriteLine("util_string_equal threw: " + ex.Message); }
            try { var r = util_copy_file((string?)null, (string?)null); Console.WriteLine("util_copy_file -> " + r); } catch(Exception ex) { Console.WriteLine("util_copy_file threw: " + ex.Message); }
            try { var r = util_is_cwd((string?)null); Console.WriteLine("util_is_cwd -> " + r); } catch(Exception ex) { Console.WriteLine("util_is_cwd threw: " + ex.Message); }
            try { var r = util_ftruncate((SafeStreamHandle?)null, IntPtr.Zero); Console.WriteLine("util_ftruncate -> " + r); } catch(Exception ex) { Console.WriteLine("util_ftruncate threw: " + ex.Message); }
            try { var r = util_roundf(0.0f); Console.WriteLine("util_roundf -> " + r); } catch(Exception ex) { Console.WriteLine("util_roundf threw: " + ex.Message); }
            try { var r = util_round(0.0); Console.WriteLine("util_round -> " + r); } catch(Exception ex) { Console.WriteLine("util_round threw: " + ex.Message); }
            try { var r = util_ftell((SafeStreamHandle?)null); Console.WriteLine("util_ftell -> " + r); } catch(Exception ex) { Console.WriteLine("util_ftell threw: " + ex.Message); }
            try { var r = util_fseek((SafeStreamHandle?)null, IntPtr.Zero, 0); Console.WriteLine("util_fseek -> " + r); } catch(Exception ex) { Console.WriteLine("util_fseek threw: " + ex.Message); }
            try { util_rewind((SafeStreamHandle?)null); Console.WriteLine("util_rewind -> (void)"); } catch(Exception ex) { Console.WriteLine("util_rewind threw: " + ex.Message); }
            try { var r = util_stat((string?)null, (SafeStatInfoHandle?)null); Console.WriteLine("util_stat -> " + r); } catch(Exception ex) { Console.WriteLine("util_stat threw: " + ex.Message); }
            try { var r = util_fstat(0, (SafeStatInfoHandle?)null); Console.WriteLine("util_fstat -> " + r); } catch(Exception ex) { Console.WriteLine("util_fstat threw: " + ex.Message); }
            try { util_copy_directory_content((string?)null, (string?)null); Console.WriteLine("util_copy_directory_content -> (void)"); } catch(Exception ex) { Console.WriteLine("util_copy_directory_content threw: " + ex.Message); }
            try { util_copy_directory((string?)null, (string?)null); Console.WriteLine("util_copy_directory -> (void)"); } catch(Exception ex) { Console.WriteLine("util_copy_directory threw: " + ex.Message); }
            try { var r = util_forward_line((SafeFileHandle?)null, (SafeBoolHandle?)null); Console.WriteLine("util_forward_line -> " + r); } catch(Exception ex) { Console.WriteLine("util_forward_line threw: " + ex.Message); }
            try { util_rewind_line((SafeFileHandle?)null); Console.WriteLine("util_rewind_line -> (void)"); } catch(Exception ex) { Console.WriteLine("util_rewind_line threw: " + ex.Message); }
            try { var r = util_fopen_test((string?)null, (string?)null); Console.WriteLine("util_fopen_test -> " + r); } catch(Exception ex) { Console.WriteLine("util_fopen_test threw: " + ex.Message); }
            try { util_alloc_file_components((string?)null, (string?)null, (string?)null, (string?)null); Console.WriteLine("util_alloc_file_components -> (void)"); } catch(Exception ex) { Console.WriteLine("util_alloc_file_components threw: " + ex.Message); }
            try { var r = util_sscanf_bool((string?)null, (SafeBoolHandle?)null); Console.WriteLine("util_sscanf_bool -> " + r); } catch(Exception ex) { Console.WriteLine("util_sscanf_bool threw: " + ex.Message); }
            try { var r = util_strcmp_int((string?)null, (string?)null); Console.WriteLine("util_strcmp_int -> " + r); } catch(Exception ex) { Console.WriteLine("util_strcmp_int threw: " + ex.Message); }
            try { var r = util_strcmp_float((string?)null, (string?)null); Console.WriteLine("util_strcmp_float -> " + r); } catch(Exception ex) { Console.WriteLine("util_strcmp_float threw: " + ex.Message); }
            try { var r = util_sscanf_int((string?)null, (SafeIntHandle?)null); Console.WriteLine("util_sscanf_int -> " + r); } catch(Exception ex) { Console.WriteLine("util_sscanf_int threw: " + ex.Message); }
            try { var r = util_sscanf_double((string?)null, (SafeDoubleHandle?)null); Console.WriteLine("util_sscanf_double -> " + r); } catch(Exception ex) { Console.WriteLine("util_sscanf_double threw: " + ex.Message); }
            try { util_path_split((string?)null, (SafeTokensHandle?)null, (string?)null); Console.WriteLine("util_path_split -> (void)"); } catch(Exception ex) { Console.WriteLine("util_path_split threw: " + ex.Message); }
            try { var r = util_string_replace_inplace((string?)null, (string?)null, (string?)null); Console.WriteLine("util_string_replace_inplace -> " + r); } catch(Exception ex) { Console.WriteLine("util_string_replace_inplace threw: " + ex.Message); }
            try { util_free_stringlist((string?)null, 0); Console.WriteLine("util_free_stringlist -> (void)"); } catch(Exception ex) { Console.WriteLine("util_free_stringlist threw: " + ex.Message); }
            try { var r = util_is_directory((string?)null); Console.WriteLine("util_is_directory -> " + r); } catch(Exception ex) { Console.WriteLine("util_is_directory threw: " + ex.Message); }
            try { var r = util_is_file((string?)null); Console.WriteLine("util_is_file -> " + r); } catch(Exception ex) { Console.WriteLine("util_is_file threw: " + ex.Message); }
            try { util_set_date_values_utc(0L, (SafeIntHandle?)null, (SafeIntHandle?)null, (SafeIntHandle?)null); Console.WriteLine("util_set_date_values_utc -> (void)"); } catch(Exception ex) { Console.WriteLine("util_set_date_values_utc threw: " + ex.Message); }
            try { var r = util_clock_seed(); Console.WriteLine("util_clock_seed -> " + r); } catch(Exception ex) { Console.WriteLine("util_clock_seed threw: " + ex.Message); }
            try { util_fread_dev_random(0, (string?)null); Console.WriteLine("util_fread_dev_random -> (void)"); } catch(Exception ex) { Console.WriteLine("util_fread_dev_random threw: " + ex.Message); }
            try { util_fread_dev_urandom(0, (string?)null); Console.WriteLine("util_fread_dev_urandom -> (void)"); } catch(Exception ex) { Console.WriteLine("util_fread_dev_urandom threw: " + ex.Message); }
            try { util_abort_test_set_intercept_function((string?)null); Console.WriteLine("util_abort_test_set_intercept_function -> (void)"); } catch(Exception ex) { Console.WriteLine("util_abort_test_set_intercept_function threw: " + ex.Message); }
            try { util_install_signals(); Console.WriteLine("util_install_signals -> (void)"); } catch(Exception ex) { Console.WriteLine("util_install_signals threw: " + ex.Message); }
            try { util_update_signals(); Console.WriteLine("util_update_signals -> (void)"); } catch(Exception ex) { Console.WriteLine("util_update_signals threw: " + ex.Message); }
            try { util_fwrite_string((string?)null, (SafeFileHandle?)null); Console.WriteLine("util_fwrite_string -> (void)"); } catch(Exception ex) { Console.WriteLine("util_fwrite_string threw: " + ex.Message); }
            try { util_endian_flip_vector((SafeDataHandle?)null, 0, 0); Console.WriteLine("util_endian_flip_vector -> (void)"); } catch(Exception ex) { Console.WriteLine("util_endian_flip_vector threw: " + ex.Message); }
            try { util_double_vector_max_min(0, (SafeDoubleHandle?)null, (SafeDoubleHandle?)null, (SafeDoubleHandle?)null); Console.WriteLine("util_double_vector_max_min -> (void)"); } catch(Exception ex) { Console.WriteLine("util_double_vector_max_min threw: " + ex.Message); }
            try { util_update_double_max_min(0.0, (SafeDoubleHandle?)null, (SafeDoubleHandle?)null); Console.WriteLine("util_update_double_max_min -> (void)"); } catch(Exception ex) { Console.WriteLine("util_update_double_max_min threw: " + ex.Message); }
            try { util_update_float_max_min(0.0f, (SafeFloatHandle?)null, (SafeFloatHandle?)null); Console.WriteLine("util_update_float_max_min -> (void)"); } catch(Exception ex) { Console.WriteLine("util_update_float_max_min threw: " + ex.Message); }
            try { util_update_int_max_min(0, (SafeIntHandle?)null, (SafeIntHandle?)null); Console.WriteLine("util_update_int_max_min -> (void)"); } catch(Exception ex) { Console.WriteLine("util_update_int_max_min threw: " + ex.Message); }
            try { var r = util_int_max(0, 0); Console.WriteLine("util_int_max -> " + r); } catch(Exception ex) { Console.WriteLine("util_int_max threw: " + ex.Message); }
            try { var r = util_double_max(0.0, 0.0); Console.WriteLine("util_double_max -> " + r); } catch(Exception ex) { Console.WriteLine("util_double_max threw: " + ex.Message); }
            try { var r = util_float_max(0.0f, 0.0f); Console.WriteLine("util_float_max -> " + r); } catch(Exception ex) { Console.WriteLine("util_float_max threw: " + ex.Message); }
            try { var r = util_int_min(0, 0); Console.WriteLine("util_int_min -> " + r); } catch(Exception ex) { Console.WriteLine("util_int_min threw: " + ex.Message); }
            try { var r = util_size_t_min(0, 0); Console.WriteLine("util_size_t_min -> " + r); } catch(Exception ex) { Console.WriteLine("util_size_t_min threw: " + ex.Message); }
            try { var r = util_size_t_max(0, 0); Console.WriteLine("util_size_t_max -> " + r); } catch(Exception ex) { Console.WriteLine("util_size_t_max threw: " + ex.Message); }
            try { var r = util_double_min(0.0, 0.0); Console.WriteLine("util_double_min -> " + r); } catch(Exception ex) { Console.WriteLine("util_double_min threw: " + ex.Message); }
            try { var r = util_float_min(0.0f, 0.0f); Console.WriteLine("util_float_min -> " + r); } catch(Exception ex) { Console.WriteLine("util_float_min threw: " + ex.Message); }
            try { util_fskip_lines((SafeFileHandle?)null, 0); Console.WriteLine("util_fskip_lines -> (void)"); } catch(Exception ex) { Console.WriteLine("util_fskip_lines threw: " + ex.Message); }
            try { var r = util_same_file((string?)null, (string?)null); Console.WriteLine("util_same_file -> " + r); } catch(Exception ex) { Console.WriteLine("util_same_file threw: " + ex.Message); }
            try { util_fread((SafeVoidHandle?)null, 0, 0, (SafeFileHandle?)null, (string?)null); Console.WriteLine("util_fread -> (void)"); } catch(Exception ex) { Console.WriteLine("util_fread threw: " + ex.Message); }
            try { util_fwrite((SafeVoidHandle?)null, 0, 0, (SafeFileHandle?)null, (string?)null); Console.WriteLine("util_fwrite -> (void)"); } catch(Exception ex) { Console.WriteLine("util_fwrite threw: " + ex.Message); }
            try { var r = util_fread_int((SafeFileHandle?)null); Console.WriteLine("util_fread_int -> " + r); } catch(Exception ex) { Console.WriteLine("util_fread_int threw: " + ex.Message); }
            try { util_fwrite_offset(IntPtr.Zero, (SafeFileHandle?)null); Console.WriteLine("util_fwrite_offset -> (void)"); } catch(Exception ex) { Console.WriteLine("util_fwrite_offset threw: " + ex.Message); }
            try { util_fwrite_size_t(0, (SafeFileHandle?)null); Console.WriteLine("util_fwrite_size_t -> (void)"); } catch(Exception ex) { Console.WriteLine("util_fwrite_size_t threw: " + ex.Message); }
            try { util_fwrite_int(0, (SafeFileHandle?)null); Console.WriteLine("util_fwrite_int -> (void)"); } catch(Exception ex) { Console.WriteLine("util_fwrite_int threw: " + ex.Message); }
            try { var r = util_get_current_linenr((SafeStreamHandle?)null); Console.WriteLine("util_get_current_linenr -> " + r); } catch(Exception ex) { Console.WriteLine("util_get_current_linenr threw: " + ex.Message); }
            try { var r = util_files_equal((string?)null, (string?)null); Console.WriteLine("util_files_equal -> " + r); } catch(Exception ex) { Console.WriteLine("util_files_equal threw: " + ex.Message); }
            try { var r = util_kahan_sum((SafeDataHandle?)null, 0); Console.WriteLine("util_kahan_sum -> " + r); } catch(Exception ex) { Console.WriteLine("util_kahan_sum threw: " + ex.Message); }
            try { var r = util_double_approx_equal(0.0, 0.0); Console.WriteLine("util_double_approx_equal -> " + r); } catch(Exception ex) { Console.WriteLine("util_double_approx_equal threw: " + ex.Message); }
            try { var r = util_fnmatch((string?)null, (string?)null); Console.WriteLine("util_fnmatch -> " + r); } catch(Exception ex) { Console.WriteLine("util_fnmatch threw: " + ex.Message); }
            try { util_time_utc((SafeTHandle?)null, (SafeTsHandle?)null); Console.WriteLine("util_time_utc -> (void)"); } catch(Exception ex) { Console.WriteLine("util_time_utc threw: " + ex.Message); }
            try { var r = util_chdir((string?)null); Console.WriteLine("util_chdir -> " + r); } catch(Exception ex) { Console.WriteLine("util_chdir threw: " + ex.Message); }
            try { var r = util_access((string?)null, IntPtr.Zero); Console.WriteLine("util_access -> " + r); } catch(Exception ex) { Console.WriteLine("util_access threw: " + ex.Message); }
            try { var r = util_access((string?)null, 0); Console.WriteLine("util_access -> " + r); } catch(Exception ex) { Console.WriteLine("util_access threw: " + ex.Message); }
            try { util_set_abort_handler((SafeUtilAbortHandlerTHandle?)null); Console.WriteLine("util_set_abort_handler -> (void)"); } catch(Exception ex) { Console.WriteLine("util_set_abort_handler threw: " + ex.Message); }
            try { util_abort_signal(0); Console.WriteLine("util_abort_signal -> (void)"); } catch(Exception ex) { Console.WriteLine("util_abort_signal threw: " + ex.Message); }
        }
    }
}
