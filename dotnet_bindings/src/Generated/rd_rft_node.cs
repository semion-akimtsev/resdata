// Auto-generated from resdata\rd_rft_node.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_rd_rft_node {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_rft_node_free(SafeRdRftNodeTypeHandle? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern long rd_rft_node_get_date(SafeRdRftNodeTypeHandle? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_rft_node_get_size(SafeRdRftNodeTypeHandle? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_rft_node_is_RFT(SafeRftNodeHandle? rft_node);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_rft_node_is_PLT(SafeRftNodeHandle? rft_node);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_rft_node_is_SEGMENT(SafeRftNodeHandle? rft_node);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_rft_node_is_MSW(SafeRftNodeHandle? rft_node);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_node_iget_pressure(SafeRftNodeHandle? rft_node, int index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_node_iget_depth(SafeRftNodeHandle? rft_node, int index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_node_iget_wrat(SafeRftNodeHandle? rft_node, int index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_node_iget_grat(SafeRftNodeHandle? rft_node, int index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_node_iget_orat(SafeRftNodeHandle? rft_node, int index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_node_iget_swat(SafeRftNodeHandle? rft_node, int index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_node_iget_sgas(SafeRftNodeHandle? rft_node, int index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_node_iget_soil(SafeRftNodeHandle? rft_node, int index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_rft_node_get_days(SafeRftNodeHandle? rft_node);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr rd_rft_node_get_type(SafeRftNodeHandle? rft_node);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\rd_rft_node.hpp");
            try { rd_rft_node_free((SafeRdRftNodeTypeHandle?)null); Console.WriteLine("rd_rft_node_free -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_rft_node_free threw: " + ex.Message); }
            try { var r = rd_rft_node_get_date((SafeRdRftNodeTypeHandle?)null); Console.WriteLine("rd_rft_node_get_date -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_node_get_date threw: " + ex.Message); }
            try { var r = rd_rft_node_get_size((SafeRdRftNodeTypeHandle?)null); Console.WriteLine("rd_rft_node_get_size -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_node_get_size threw: " + ex.Message); }
            try { var r = rd_rft_node_is_RFT((SafeRftNodeHandle?)null); Console.WriteLine("rd_rft_node_is_RFT -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_node_is_RFT threw: " + ex.Message); }
            try { var r = rd_rft_node_is_PLT((SafeRftNodeHandle?)null); Console.WriteLine("rd_rft_node_is_PLT -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_node_is_PLT threw: " + ex.Message); }
            try { var r = rd_rft_node_is_SEGMENT((SafeRftNodeHandle?)null); Console.WriteLine("rd_rft_node_is_SEGMENT -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_node_is_SEGMENT threw: " + ex.Message); }
            try { var r = rd_rft_node_is_MSW((SafeRftNodeHandle?)null); Console.WriteLine("rd_rft_node_is_MSW -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_node_is_MSW threw: " + ex.Message); }
            try { var r = rd_rft_node_iget_pressure((SafeRftNodeHandle?)null, 0); Console.WriteLine("rd_rft_node_iget_pressure -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_node_iget_pressure threw: " + ex.Message); }
            try { var r = rd_rft_node_iget_depth((SafeRftNodeHandle?)null, 0); Console.WriteLine("rd_rft_node_iget_depth -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_node_iget_depth threw: " + ex.Message); }
            try { var r = rd_rft_node_iget_wrat((SafeRftNodeHandle?)null, 0); Console.WriteLine("rd_rft_node_iget_wrat -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_node_iget_wrat threw: " + ex.Message); }
            try { var r = rd_rft_node_iget_grat((SafeRftNodeHandle?)null, 0); Console.WriteLine("rd_rft_node_iget_grat -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_node_iget_grat threw: " + ex.Message); }
            try { var r = rd_rft_node_iget_orat((SafeRftNodeHandle?)null, 0); Console.WriteLine("rd_rft_node_iget_orat -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_node_iget_orat threw: " + ex.Message); }
            try { var r = rd_rft_node_iget_swat((SafeRftNodeHandle?)null, 0); Console.WriteLine("rd_rft_node_iget_swat -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_node_iget_swat threw: " + ex.Message); }
            try { var r = rd_rft_node_iget_sgas((SafeRftNodeHandle?)null, 0); Console.WriteLine("rd_rft_node_iget_sgas -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_node_iget_sgas threw: " + ex.Message); }
            try { var r = rd_rft_node_iget_soil((SafeRftNodeHandle?)null, 0); Console.WriteLine("rd_rft_node_iget_soil -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_node_iget_soil threw: " + ex.Message); }
            try { var r = rd_rft_node_get_days((SafeRftNodeHandle?)null); Console.WriteLine("rd_rft_node_get_days -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_node_get_days threw: " + ex.Message); }
            try { var r = rd_rft_node_get_type((SafeRftNodeHandle?)null); Console.WriteLine("rd_rft_node_get_type -> " + r); } catch(Exception ex) { Console.WriteLine("rd_rft_node_get_type threw: " + ex.Message); }
        }
    }
}
