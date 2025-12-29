// Auto-generated from ert\util\mzran.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_mzran {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void mzran_fscanf_state(SafeRngHandle? __rng, SafeStreamHandle? stream);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr mzran_forward(SafeRngHandle? __rng);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void mzran_set_state(SafeRngHandle? __rng, string? seed_buffer);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern void mzran_get_state(SafeRngHandle? __rng, string? state_buffer);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double mzran_get_double(SafeRngHandle? rng);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int mzran_get_int(SafeRngHandle? rng, int max);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void mzran_fprintf_state(SafeRngHandle? __rng, SafeStreamHandle? stream);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void mzran_free(SafeRngHandle? __rng);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: ert\\util\\mzran.hpp");
            try { mzran_fscanf_state((SafeRngHandle?)null, (SafeStreamHandle?)null); Console.WriteLine("mzran_fscanf_state -> (void)"); } catch(Exception ex) { Console.WriteLine("mzran_fscanf_state threw: " + ex.Message); }
            try { var r = mzran_forward((SafeRngHandle?)null); Console.WriteLine("mzran_forward -> " + r); } catch(Exception ex) { Console.WriteLine("mzran_forward threw: " + ex.Message); }
            try { mzran_set_state((SafeRngHandle?)null, (string?)null); Console.WriteLine("mzran_set_state -> (void)"); } catch(Exception ex) { Console.WriteLine("mzran_set_state threw: " + ex.Message); }
            try { mzran_get_state((SafeRngHandle?)null, (string?)null); Console.WriteLine("mzran_get_state -> (void)"); } catch(Exception ex) { Console.WriteLine("mzran_get_state threw: " + ex.Message); }
            try { var r = mzran_get_double((SafeRngHandle?)null); Console.WriteLine("mzran_get_double -> " + r); } catch(Exception ex) { Console.WriteLine("mzran_get_double threw: " + ex.Message); }
            try { var r = mzran_get_int((SafeRngHandle?)null, 0); Console.WriteLine("mzran_get_int -> " + r); } catch(Exception ex) { Console.WriteLine("mzran_get_int threw: " + ex.Message); }
            try { mzran_fprintf_state((SafeRngHandle?)null, (SafeStreamHandle?)null); Console.WriteLine("mzran_fprintf_state -> (void)"); } catch(Exception ex) { Console.WriteLine("mzran_fprintf_state threw: " + ex.Message); }
            try { mzran_free((SafeRngHandle?)null); Console.WriteLine("mzran_free -> (void)"); } catch(Exception ex) { Console.WriteLine("mzran_free threw: " + ex.Message); }
        }
    }
}
