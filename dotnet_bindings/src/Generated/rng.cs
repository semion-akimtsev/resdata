// Auto-generated from ert\util\rng.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_rng {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rng_free(SafeRngHandle? rng);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr rng_forward(SafeRngHandle? rng);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rng_get_double(SafeRngHandle? rng);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rng_init(SafeRngHandle? rng, IntPtr init_mode);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rng_state_size(SafeRngHandle? rng);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void rng_save_state(SafeRngHandle? rng, string? filename);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void rng_load_state(SafeRngHandle? rng, string? filename);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void rng_set_state(SafeRngHandle? rng, string? state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void rng_get_state(SafeRngHandle? rng, string? state);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rng_get_int(SafeRngHandle? rng, int max_value);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr rng_get_max_int(SafeRngHandle? rng);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: ert\\util\\rng.hpp");
            try { rng_free((SafeRngHandle?)null); Console.WriteLine("rng_free -> (void)"); } catch(Exception ex) { Console.WriteLine("rng_free threw: " + ex.Message); }
            try { var r = rng_forward((SafeRngHandle?)null); Console.WriteLine("rng_forward -> " + r); } catch(Exception ex) { Console.WriteLine("rng_forward threw: " + ex.Message); }
            try { var r = rng_get_double((SafeRngHandle?)null); Console.WriteLine("rng_get_double -> " + r); } catch(Exception ex) { Console.WriteLine("rng_get_double threw: " + ex.Message); }
            try { rng_init((SafeRngHandle?)null, IntPtr.Zero); Console.WriteLine("rng_init -> (void)"); } catch(Exception ex) { Console.WriteLine("rng_init threw: " + ex.Message); }
            try { var r = rng_state_size((SafeRngHandle?)null); Console.WriteLine("rng_state_size -> " + r); } catch(Exception ex) { Console.WriteLine("rng_state_size threw: " + ex.Message); }
            try { rng_save_state((SafeRngHandle?)null, (string?)null); Console.WriteLine("rng_save_state -> (void)"); } catch(Exception ex) { Console.WriteLine("rng_save_state threw: " + ex.Message); }
            try { rng_load_state((SafeRngHandle?)null, (string?)null); Console.WriteLine("rng_load_state -> (void)"); } catch(Exception ex) { Console.WriteLine("rng_load_state threw: " + ex.Message); }
            try { rng_set_state((SafeRngHandle?)null, (string?)null); Console.WriteLine("rng_set_state -> (void)"); } catch(Exception ex) { Console.WriteLine("rng_set_state threw: " + ex.Message); }
            try { rng_get_state((SafeRngHandle?)null, (string?)null); Console.WriteLine("rng_get_state -> (void)"); } catch(Exception ex) { Console.WriteLine("rng_get_state threw: " + ex.Message); }
            try { var r = rng_get_int((SafeRngHandle?)null, 0); Console.WriteLine("rng_get_int -> " + r); } catch(Exception ex) { Console.WriteLine("rng_get_int threw: " + ex.Message); }
            try { var r = rng_get_max_int((SafeRngHandle?)null); Console.WriteLine("rng_get_max_int -> " + r); } catch(Exception ex) { Console.WriteLine("rng_get_max_int threw: " + ex.Message); }
        }
    }
}
