// Auto-generated from resdata\well\well_segment.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_well_segment {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void well_segment_free(SafeSegmentHandle? segment);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool well_segment_active(SafeSegmentHandle? segment);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool well_segment_main_stem(SafeSegmentHandle? segment);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool well_segment_nearest_wellhead(SafeSegmentHandle? segment);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int well_segment_get_link_count(SafeSegmentHandle? segment);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int well_segment_get_branch_id(SafeSegmentHandle? segment);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int well_segment_get_outlet_id(SafeSegmentHandle? segment);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int well_segment_get_id(SafeSegmentHandle? segment);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool well_segment_has_global_grid_connections(SafeSegmentHandle? segment);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_segment_get_depth(SafeSegmentHandle? segment);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_segment_get_length(SafeSegmentHandle? segment);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_segment_get_total_length(SafeSegmentHandle? segment);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double well_segment_get_diameter(SafeSegmentHandle? segment);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\well\\well_segment.hpp");
            try { well_segment_free((SafeSegmentHandle?)null); Console.WriteLine("well_segment_free -> (void)"); } catch(Exception ex) { Console.WriteLine("well_segment_free threw: " + ex.Message); }
            try { var r = well_segment_active((SafeSegmentHandle?)null); Console.WriteLine("well_segment_active -> " + r); } catch(Exception ex) { Console.WriteLine("well_segment_active threw: " + ex.Message); }
            try { var r = well_segment_main_stem((SafeSegmentHandle?)null); Console.WriteLine("well_segment_main_stem -> " + r); } catch(Exception ex) { Console.WriteLine("well_segment_main_stem threw: " + ex.Message); }
            try { var r = well_segment_nearest_wellhead((SafeSegmentHandle?)null); Console.WriteLine("well_segment_nearest_wellhead -> " + r); } catch(Exception ex) { Console.WriteLine("well_segment_nearest_wellhead threw: " + ex.Message); }
            try { var r = well_segment_get_link_count((SafeSegmentHandle?)null); Console.WriteLine("well_segment_get_link_count -> " + r); } catch(Exception ex) { Console.WriteLine("well_segment_get_link_count threw: " + ex.Message); }
            try { var r = well_segment_get_branch_id((SafeSegmentHandle?)null); Console.WriteLine("well_segment_get_branch_id -> " + r); } catch(Exception ex) { Console.WriteLine("well_segment_get_branch_id threw: " + ex.Message); }
            try { var r = well_segment_get_outlet_id((SafeSegmentHandle?)null); Console.WriteLine("well_segment_get_outlet_id -> " + r); } catch(Exception ex) { Console.WriteLine("well_segment_get_outlet_id threw: " + ex.Message); }
            try { var r = well_segment_get_id((SafeSegmentHandle?)null); Console.WriteLine("well_segment_get_id -> " + r); } catch(Exception ex) { Console.WriteLine("well_segment_get_id threw: " + ex.Message); }
            try { var r = well_segment_has_global_grid_connections((SafeSegmentHandle?)null); Console.WriteLine("well_segment_has_global_grid_connections -> " + r); } catch(Exception ex) { Console.WriteLine("well_segment_has_global_grid_connections threw: " + ex.Message); }
            try { var r = well_segment_get_depth((SafeSegmentHandle?)null); Console.WriteLine("well_segment_get_depth -> " + r); } catch(Exception ex) { Console.WriteLine("well_segment_get_depth threw: " + ex.Message); }
            try { var r = well_segment_get_length((SafeSegmentHandle?)null); Console.WriteLine("well_segment_get_length -> " + r); } catch(Exception ex) { Console.WriteLine("well_segment_get_length threw: " + ex.Message); }
            try { var r = well_segment_get_total_length((SafeSegmentHandle?)null); Console.WriteLine("well_segment_get_total_length -> " + r); } catch(Exception ex) { Console.WriteLine("well_segment_get_total_length threw: " + ex.Message); }
            try { var r = well_segment_get_diameter((SafeSegmentHandle?)null); Console.WriteLine("well_segment_get_diameter -> " + r); } catch(Exception ex) { Console.WriteLine("well_segment_get_diameter threw: " + ex.Message); }
        }
    }
}
