// Auto-generated from resdata\rd_kw_grdecl.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_rd_kw_grdecl {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool rd_kw_grdecl_fseek_kw(string p0, bool p1, IntPtr p2);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_kw_fprintf_grdecl(IntPtr rd_kw, IntPtr stream);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\rd_kw_grdecl.hpp");
            try { var r = rd_kw_grdecl_fseek_kw(null, false, IntPtr.Zero); Console.WriteLine("rd_kw_grdecl_fseek_kw -> " + r); } catch(Exception ex) { Console.WriteLine("rd_kw_grdecl_fseek_kw threw: " + ex.Message); }
            try { rd_kw_fprintf_grdecl(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_kw_fprintf_grdecl -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_kw_fprintf_grdecl threw: " + ex.Message); }
        }
    }
}
