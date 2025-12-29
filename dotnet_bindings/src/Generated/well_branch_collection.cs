// Auto-generated from resdata\well\well_branch_collection.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_well_branch_collection {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void well_branch_collection_free(SafeBranchesHandle? branches);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\well\\well_branch_collection.hpp");
            try { well_branch_collection_free((SafeBranchesHandle?)null); Console.WriteLine("well_branch_collection_free -> (void)"); } catch(Exception ex) { Console.WriteLine("well_branch_collection_free threw: " + ex.Message); }
        }
    }
}
