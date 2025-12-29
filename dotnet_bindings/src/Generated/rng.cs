// Auto-generated from ert\util\rng.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_rng {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rng_free(IntPtr rng);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr rng_forward(IntPtr rng);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rng_get_double(IntPtr rng);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rng_init(IntPtr rng, IntPtr init_mode);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rng_state_size(IntPtr rng);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void rng_save_state(IntPtr rng, string filename);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void rng_load_state(IntPtr rng, string filename);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void rng_set_state(IntPtr rng, string state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void rng_get_state(IntPtr rng, string state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rng_get_int(IntPtr rng, int max_value);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr rng_get_max_int(IntPtr rng);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: ert\\util\\rng.hpp");
            try { rng_free(IntPtr.Zero); Console.WriteLine("rng_free -> (void)"); } catch(Exception ex) { Console.WriteLine("rng_free threw: " + ex.Message); }
            try { var r = rng_forward(IntPtr.Zero); Console.WriteLine("rng_forward -> " + r); } catch(Exception ex) { Console.WriteLine("rng_forward threw: " + ex.Message); }
            try { var r = rng_get_double(IntPtr.Zero); Console.WriteLine("rng_get_double -> " + r); } catch(Exception ex) { Console.WriteLine("rng_get_double threw: " + ex.Message); }
            try { rng_init(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rng_init -> (void)"); } catch(Exception ex) { Console.WriteLine("rng_init threw: " + ex.Message); }
            try { var r = rng_state_size(IntPtr.Zero); Console.WriteLine("rng_state_size -> " + r); } catch(Exception ex) { Console.WriteLine("rng_state_size threw: " + ex.Message); }
            try { rng_save_state(IntPtr.Zero, null); Console.WriteLine("rng_save_state -> (void)"); } catch(Exception ex) { Console.WriteLine("rng_save_state threw: " + ex.Message); }
            try { rng_load_state(IntPtr.Zero, null); Console.WriteLine("rng_load_state -> (void)"); } catch(Exception ex) { Console.WriteLine("rng_load_state threw: " + ex.Message); }
            try { rng_set_state(IntPtr.Zero, null); Console.WriteLine("rng_set_state -> (void)"); } catch(Exception ex) { Console.WriteLine("rng_set_state threw: " + ex.Message); }
            try { rng_get_state(IntPtr.Zero, null); Console.WriteLine("rng_get_state -> (void)"); } catch(Exception ex) { Console.WriteLine("rng_get_state threw: " + ex.Message); }
            try { var r = rng_get_int(IntPtr.Zero, 0); Console.WriteLine("rng_get_int -> " + r); } catch(Exception ex) { Console.WriteLine("rng_get_int threw: " + ex.Message); }
            try { var r = rng_get_max_int(IntPtr.Zero); Console.WriteLine("rng_get_max_int -> " + r); } catch(Exception ex) { Console.WriteLine("rng_get_max_int threw: " + ex.Message); }
        }
    }
}
