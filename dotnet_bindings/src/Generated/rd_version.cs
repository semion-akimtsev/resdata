// Auto-generated from ert\util\rd_version.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_rd_version {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_version_get_major_version();
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_version_get_minor_version();
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_version_is_ert_devel_version();

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: ert\\util\\rd_version.hpp");
            try { var r = rd_version_get_major_version(); Console.WriteLine("rd_version_get_major_version -> " + r); } catch(Exception ex) { Console.WriteLine("rd_version_get_major_version threw: " + ex.Message); }
            try { var r = rd_version_get_minor_version(); Console.WriteLine("rd_version_get_minor_version -> " + r); } catch(Exception ex) { Console.WriteLine("rd_version_get_minor_version threw: " + ex.Message); }
            try { var r = rd_version_is_ert_devel_version(); Console.WriteLine("rd_version_is_ert_devel_version -> " + r); } catch(Exception ex) { Console.WriteLine("rd_version_is_ert_devel_version threw: " + ex.Message); }
        }
    }
}
