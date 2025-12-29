// Auto-generated from ert\util\parser.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_parser {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void basic_parser_free(IntPtr parser);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: ert\\util\\parser.hpp");
            try { basic_parser_free(IntPtr.Zero); Console.WriteLine("basic_parser_free -> (void)"); } catch(Exception ex) { Console.WriteLine("basic_parser_free threw: " + ex.Message); }
        }
    }
}
