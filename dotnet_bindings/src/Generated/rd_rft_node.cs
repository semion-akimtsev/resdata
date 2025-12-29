// Auto-generated from resdata\rd_rft_node.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_rd_rft_node {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_rft_node_free(IntPtr p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern long rd_rft_node_get_date(IntPtr p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_rft_node_get_size(IntPtr p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_rft_node_is_RFT(IntPtr rft_node);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_rft_node_is_PLT(IntPtr rft_node);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_rft_node_is_SEGMENT(IntPtr rft_node);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_rft_node_is_MSW(IntPtr rft_node);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_node_iget_pressure(IntPtr rft_node, int index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_node_iget_depth(IntPtr rft_node, int index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_node_iget_wrat(IntPtr rft_node, int index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_node_iget_grat(IntPtr rft_node, int index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_node_iget_orat(IntPtr rft_node, int index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_node_iget_swat(IntPtr rft_node, int index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_node_iget_sgas(IntPtr rft_node, int index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_node_iget_soil(IntPtr rft_node, int index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_node_get_days(IntPtr rft_node);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr rd_rft_node_get_type(IntPtr rft_node);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\rd_rft_node.hpp");
            try { rd_rft_node_free(IntPtr.Zero); Console.WriteLine("rd_rft_node_free -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_rft_node_free threw: " + ex.Message); }
            try { var r = rd_rft_node_get_date(IntPtr.Zero); Console.WriteLine("rd_rft_node_get_date -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_node_get_date threw: " + ex.Message); }
            try { var r = rd_rft_node_get_size(IntPtr.Zero); Console.WriteLine("rd_rft_node_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_node_get_size threw: " + ex.Message); }
            try { var r = rd_rft_node_is_RFT(IntPtr.Zero); Console.WriteLine("rd_rft_node_is_RFT -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_node_is_RFT threw: " + ex.Message); }
            try { var r = rd_rft_node_is_PLT(IntPtr.Zero); Console.WriteLine("rd_rft_node_is_PLT -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_node_is_PLT threw: " + ex.Message); }
            try { var r = rd_rft_node_is_SEGMENT(IntPtr.Zero); Console.WriteLine("rd_rft_node_is_SEGMENT -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_node_is_SEGMENT threw: " + ex.Message); }
            try { var r = rd_rft_node_is_MSW(IntPtr.Zero); Console.WriteLine("rd_rft_node_is_MSW -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_node_is_MSW threw: " + ex.Message); }
            try { var r = rd_rft_node_iget_pressure(IntPtr.Zero, 0); Console.WriteLine("rd_rft_node_iget_pressure -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_node_iget_pressure threw: " + ex.Message); }
            try { var r = rd_rft_node_iget_depth(IntPtr.Zero, 0); Console.WriteLine("rd_rft_node_iget_depth -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_node_iget_depth threw: " + ex.Message); }
            try { var r = rd_rft_node_iget_wrat(IntPtr.Zero, 0); Console.WriteLine("rd_rft_node_iget_wrat -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_node_iget_wrat threw: " + ex.Message); }
            try { var r = rd_rft_node_iget_grat(IntPtr.Zero, 0); Console.WriteLine("rd_rft_node_iget_grat -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_node_iget_grat threw: " + ex.Message); }
            try { var r = rd_rft_node_iget_orat(IntPtr.Zero, 0); Console.WriteLine("rd_rft_node_iget_orat -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_node_iget_orat threw: " + ex.Message); }
            try { var r = rd_rft_node_iget_swat(IntPtr.Zero, 0); Console.WriteLine("rd_rft_node_iget_swat -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_node_iget_swat threw: " + ex.Message); }
            try { var r = rd_rft_node_iget_sgas(IntPtr.Zero, 0); Console.WriteLine("rd_rft_node_iget_sgas -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_node_iget_sgas threw: " + ex.Message); }
            try { var r = rd_rft_node_iget_soil(IntPtr.Zero, 0); Console.WriteLine("rd_rft_node_iget_soil -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_node_iget_soil threw: " + ex.Message); }
            try { var r = rd_rft_node_get_days(IntPtr.Zero); Console.WriteLine("rd_rft_node_get_days -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_node_get_days threw: " + ex.Message); }
            try { var r = rd_rft_node_get_type(IntPtr.Zero); Console.WriteLine("rd_rft_node_get_type -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_node_get_type threw: " + ex.Message); }
        }
    }
}
