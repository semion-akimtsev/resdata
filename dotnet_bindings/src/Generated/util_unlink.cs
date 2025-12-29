// Auto-generated from ert\util\util_unlink.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_util_unlink {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern int util_unlink(string filename);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: ert\\util\\util_unlink.hpp");
            try { var r = util_unlink(null); Console.WriteLine("util_unlink -> " + r); } catch(Exception ex) { Console.WriteLine("util_unlink threw: " + ex.Message); }
        }
    }
}
