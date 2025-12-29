// Auto-generated from resdata\well\well_segment.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_well_segment {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void well_segment_free(IntPtr segment);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool well_segment_active(IntPtr segment);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool well_segment_main_stem(IntPtr segment);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool well_segment_nearest_wellhead(IntPtr segment);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int well_segment_get_link_count(IntPtr segment);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int well_segment_get_branch_id(IntPtr segment);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int well_segment_get_outlet_id(IntPtr segment);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int well_segment_get_id(IntPtr segment);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool well_segment_has_global_grid_connections(IntPtr segment);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_segment_get_depth(IntPtr segment);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_segment_get_length(IntPtr segment);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_segment_get_total_length(IntPtr segment);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_segment_get_diameter(IntPtr segment);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\well\\well_segment.hpp");
            try { well_segment_free(IntPtr.Zero); Console.WriteLine("well_segment_free -> (void)"); } catch(Exception ex) { Console.WriteLine("well_segment_free threw: " + ex.Message); }
            try { var r = well_segment_active(IntPtr.Zero); Console.WriteLine("well_segment_active -> " + r); } catch(Exception ex) { Console.WriteLine("well_segment_active threw: " + ex.Message); }
            try { var r = well_segment_main_stem(IntPtr.Zero); Console.WriteLine("well_segment_main_stem -> " + r); } catch(Exception ex) { Console.WriteLine("well_segment_main_stem threw: " + ex.Message); }
            try { var r = well_segment_nearest_wellhead(IntPtr.Zero); Console.WriteLine("well_segment_nearest_wellhead -> " + r); } catch(Exception ex) { Console.WriteLine("well_segment_nearest_wellhead threw: " + ex.Message); }
            try { var r = well_segment_get_link_count(IntPtr.Zero); Console.WriteLine("well_segment_get_link_count -> " + r); } catch(Exception ex) { Console.WriteLine("well_segment_get_link_count threw: " + ex.Message); }
            try { var r = well_segment_get_branch_id(IntPtr.Zero); Console.WriteLine("well_segment_get_branch_id -> " + r); } catch(Exception ex) { Console.WriteLine("well_segment_get_branch_id threw: " + ex.Message); }
            try { var r = well_segment_get_outlet_id(IntPtr.Zero); Console.WriteLine("well_segment_get_outlet_id -> " + r); } catch(Exception ex) { Console.WriteLine("well_segment_get_outlet_id threw: " + ex.Message); }
            try { var r = well_segment_get_id(IntPtr.Zero); Console.WriteLine("well_segment_get_id -> " + r); } catch(Exception ex) { Console.WriteLine("well_segment_get_id threw: " + ex.Message); }
            try { var r = well_segment_has_global_grid_connections(IntPtr.Zero); Console.WriteLine("well_segment_has_global_grid_connections -> " + r); } catch(Exception ex) { Console.WriteLine("well_segment_has_global_grid_connections threw: " + ex.Message); }
            try { var r = well_segment_get_depth(IntPtr.Zero); Console.WriteLine("well_segment_get_depth -> " + r); } catch(Exception ex) { Console.WriteLine("well_segment_get_depth threw: " + ex.Message); }
            try { var r = well_segment_get_length(IntPtr.Zero); Console.WriteLine("well_segment_get_length -> " + r); } catch(Exception ex) { Console.WriteLine("well_segment_get_length threw: " + ex.Message); }
            try { var r = well_segment_get_total_length(IntPtr.Zero); Console.WriteLine("well_segment_get_total_length -> " + r); } catch(Exception ex) { Console.WriteLine("well_segment_get_total_length threw: " + ex.Message); }
            try { var r = well_segment_get_diameter(IntPtr.Zero); Console.WriteLine("well_segment_get_diameter -> " + r); } catch(Exception ex) { Console.WriteLine("well_segment_get_diameter threw: " + ex.Message); }
        }
    }
}
