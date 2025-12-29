// Auto-generated from ert\util\test_util.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_test_util {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool test_check_string_equal(string s1, string s2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void test_assert_int_equal__(int i1, int i2, string file, int line);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void test_assert_int_not_equal__(int i1, int i2, string file, int line);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void test_assert_long_equal__(IntPtr i1, IntPtr i2, string file, IntPtr line);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool test_check_double_equal(double d1, double d2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void test_assert_float_equal__(float d1, float d2, string file, int line);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool test_check_float_equal(float d1, float d2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void test_assert_bool_equal__(bool b1, bool b2, string file, int line);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void test_assert_bool_not_equal__(bool b1, bool b2, string file, int line);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void test_assert_true__(bool value, string file, int line);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void test_assert_false__(bool value, string file, int line);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void test_assert_NULL__(IntPtr p, string file, int line);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void test_assert_not_NULL__(IntPtr p, string file, int line);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void test_install_SIGNALS();

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: ert\\util\\test_util.hpp");
            try { var r = test_check_string_equal(null, null); Console.WriteLine("test_check_string_equal -> " + r); } catch(Exception ex) { Console.WriteLine("test_check_string_equal threw: " + ex.Message); }
            try { test_assert_int_equal__(0, 0, null, 0); Console.WriteLine("test_assert_int_equal__ -> (void)"); } catch(Exception ex) { Console.WriteLine("test_assert_int_equal__ threw: " + ex.Message); }
            try { test_assert_int_not_equal__(0, 0, null, 0); Console.WriteLine("test_assert_int_not_equal__ -> (void)"); } catch(Exception ex) { Console.WriteLine("test_assert_int_not_equal__ threw: " + ex.Message); }
            try { test_assert_long_equal__(IntPtr.Zero, IntPtr.Zero, null, IntPtr.Zero); Console.WriteLine("test_assert_long_equal__ -> (void)"); } catch(Exception ex) { Console.WriteLine("test_assert_long_equal__ threw: " + ex.Message); }
            try { var r = test_check_double_equal(0.0, 0.0); Console.WriteLine("test_check_double_equal -> " + r); } catch(Exception ex) { Console.WriteLine("test_check_double_equal threw: " + ex.Message); }
            try { test_assert_float_equal__(0.0f, 0.0f, null, 0); Console.WriteLine("test_assert_float_equal__ -> (void)"); } catch(Exception ex) { Console.WriteLine("test_assert_float_equal__ threw: " + ex.Message); }
            try { var r = test_check_float_equal(0.0f, 0.0f); Console.WriteLine("test_check_float_equal -> " + r); } catch(Exception ex) { Console.WriteLine("test_check_float_equal threw: " + ex.Message); }
            try { test_assert_bool_equal__(false, false, null, 0); Console.WriteLine("test_assert_bool_equal__ -> (void)"); } catch(Exception ex) { Console.WriteLine("test_assert_bool_equal__ threw: " + ex.Message); }
            try { test_assert_bool_not_equal__(false, false, null, 0); Console.WriteLine("test_assert_bool_not_equal__ -> (void)"); } catch(Exception ex) { Console.WriteLine("test_assert_bool_not_equal__ threw: " + ex.Message); }
            try { test_assert_true__(false, null, 0); Console.WriteLine("test_assert_true__ -> (void)"); } catch(Exception ex) { Console.WriteLine("test_assert_true__ threw: " + ex.Message); }
            try { test_assert_false__(false, null, 0); Console.WriteLine("test_assert_false__ -> (void)"); } catch(Exception ex) { Console.WriteLine("test_assert_false__ threw: " + ex.Message); }
            try { test_assert_NULL__(IntPtr.Zero, null, 0); Console.WriteLine("test_assert_NULL__ -> (void)"); } catch(Exception ex) { Console.WriteLine("test_assert_NULL__ threw: " + ex.Message); }
            try { test_assert_not_NULL__(IntPtr.Zero, null, 0); Console.WriteLine("test_assert_not_NULL__ -> (void)"); } catch(Exception ex) { Console.WriteLine("test_assert_not_NULL__ threw: " + ex.Message); }
            try { test_install_SIGNALS(); Console.WriteLine("test_install_SIGNALS -> (void)"); } catch(Exception ex) { Console.WriteLine("test_install_SIGNALS threw: " + ex.Message); }
        }
    }
}
