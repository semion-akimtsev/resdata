// Auto-generated from ert\util\test_work_area.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_test_work_area {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void test_work_area_free(SafeWorkAreaHandle? work_area);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: ert\\util\\test_work_area.hpp");
            try { test_work_area_free((SafeWorkAreaHandle?)null); Console.WriteLine("test_work_area_free -> (void)"); } catch(Exception ex) { Console.WriteLine("test_work_area_free threw: " + ex.Message); }
        }
    }
}
