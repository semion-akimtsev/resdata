// Auto-generated from resdata\rd_grid.hpp
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Resdata.Bindings.Generated {
    public static class Native_rd_grid {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_grid_have_coarse_cells(SafeMainGridHandle? main_grid);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_num_coarse_groups(SafeMainGridHandle? main_grid);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_grid_get_cell_dx1A(SafeGridHandle? grid, int active_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_grid_get_cell_dy1A(SafeGridHandle? grid, int active_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_grid_get_cell_dz1A(SafeGridHandle? grid, int active_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_grid_get_cell_dx1(SafeGridHandle? grid, int global_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_grid_get_cell_dy1(SafeGridHandle? grid, int global_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_grid_get_cell_dz1(SafeGridHandle? grid, int global_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_grid_get_cell_thickness1(SafeGridHandle? grid, int global_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_grid_get_cdepth1A(SafeGridHandle? grid, int active_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_grid_get_cdepth1(SafeGridHandle? grid, int global_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_grid_get_cell_volume1(SafeRdGridHandle? rd_grid, int global_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_grid_get_cell_volume1A(SafeRdGridHandle? rd_grid, int active_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_active_index3(SafeRdGridHandle? rd_grid, int i, int j, int k);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_active_index1(SafeRdGridHandle? rd_grid, int global_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_grid_cell_active3(SafeRdGridTypeHandle? p0, int p1, int p2, int p3);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_grid_cell_active1(SafeRdGridTypeHandle? p0, int p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_grid_ijk_valid(SafeRdGridTypeHandle? p0, int p1, int p2, int p3);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_global_index3(SafeRdGridTypeHandle? p0, int p1, int p2, int p3);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_global_index1A(SafeRdGridHandle? rd_grid, int active_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_grid_add_self_nnc(SafeGrid1Handle? grid1, int g1, int g2, int nnc_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool rd_grid_exists(string? case_input);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_grid_free(SafeRdGridTypeHandle? p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_grid_get_dims(SafeRdGridTypeHandle? p0, SafeIntHandle? p1, SafeIntHandle? p2, SafeIntHandle? p3, SafeIntHandle? p4);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_nz(SafeGridHandle? grid);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_nx(SafeGridHandle? grid);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_ny(SafeGridHandle? grid);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_nactive(SafeGridHandle? grid);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_nactive_fracture(SafeGridHandle? grid);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_active_index(SafeRdGridTypeHandle? p0, int p1, int p2, int p3);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_global_size(SafeRdGridHandle? rd_grid);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_active_size(SafeRdGridHandle? rd_grid);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_grid_get_top1A(SafeGridHandle? grid, int active_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_grid_get_top2(SafeGridHandle? grid, int i, int j);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_grid_get_bottom2(SafeGridHandle? grid, int i, int j);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_locate_depth(SafeGridHandle? grid, double depth, int i, int j);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_grid_cell_invalid1(SafeRdGridHandle? rd_grid, int global_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_grid_cell_valid1(SafeRdGridHandle? rd_grid, int global_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_num_lgr(SafeMainGridHandle? main_grid);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_lgr_nr(SafeRdGridHandle? rd_grid);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern int rd_grid_get_lgr_nr_from_name(SafeGridHandle? grid, string? name);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool rd_grid_has_lgr(SafeMainGridHandle? main_grid, string? __lgr_name);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_grid_has_lgr_nr(SafeMainGridHandle? main_grid, int lgr_nr);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_grid_test_lgr_consistency(SafeRdGridHandle? rd_grid);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_zcorn_index__(int nx, int ny, int i, int j, int k, int c);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_grid_dual_grid(SafeRdGridHandle? rd_grid);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_grid_cell_regular1(SafeRdGridHandle? rd_grid, int global_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_grid_init_zcorn_data(SafeGridHandle? grid, SafeZcornHandle? zcorn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_grid_init_zcorn_data_double(SafeGridHandle? grid, SafeZcornHandle? zcorn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_zcorn_size(SafeGridHandle? grid);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_grid_init_coord_data(SafeGridHandle? grid, SafeCoordHandle? coord);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_grid_init_coord_data_double(SafeGridHandle? grid, SafeCoordHandle? coord);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_coord_size(SafeRdGridHandle? rd_grid);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_grid_init_actnum_data(SafeGridHandle? grid, SafeActnumHandle? actnum);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_grid_use_mapaxes(SafeGridHandle? grid);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_grid_reset_actnum(SafeGridHandle? grid, SafeActnumHandle? actnum);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr rd_grid_get_unit_system(SafeGridHandle? grid);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\rd_grid.hpp");
            try { var r = rd_grid_have_coarse_cells((SafeMainGridHandle?)null); Console.WriteLine("rd_grid_have_coarse_cells -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_have_coarse_cells threw: " + ex.Message); }
            try { var r = rd_grid_get_num_coarse_groups((SafeMainGridHandle?)null); Console.WriteLine("rd_grid_get_num_coarse_groups -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_num_coarse_groups threw: " + ex.Message); }
            try { var r = rd_grid_get_cell_dx1A((SafeGridHandle?)null, 0); Console.WriteLine("rd_grid_get_cell_dx1A -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_cell_dx1A threw: " + ex.Message); }
            try { var r = rd_grid_get_cell_dy1A((SafeGridHandle?)null, 0); Console.WriteLine("rd_grid_get_cell_dy1A -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_cell_dy1A threw: " + ex.Message); }
            try { var r = rd_grid_get_cell_dz1A((SafeGridHandle?)null, 0); Console.WriteLine("rd_grid_get_cell_dz1A -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_cell_dz1A threw: " + ex.Message); }
            try { var r = rd_grid_get_cell_dx1((SafeGridHandle?)null, 0); Console.WriteLine("rd_grid_get_cell_dx1 -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_cell_dx1 threw: " + ex.Message); }
            try { var r = rd_grid_get_cell_dy1((SafeGridHandle?)null, 0); Console.WriteLine("rd_grid_get_cell_dy1 -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_cell_dy1 threw: " + ex.Message); }
            try { var r = rd_grid_get_cell_dz1((SafeGridHandle?)null, 0); Console.WriteLine("rd_grid_get_cell_dz1 -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_cell_dz1 threw: " + ex.Message); }
            try { var r = rd_grid_get_cell_thickness1((SafeGridHandle?)null, 0); Console.WriteLine("rd_grid_get_cell_thickness1 -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_cell_thickness1 threw: " + ex.Message); }
            try { var r = rd_grid_get_cdepth1A((SafeGridHandle?)null, 0); Console.WriteLine("rd_grid_get_cdepth1A -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_cdepth1A threw: " + ex.Message); }
            try { var r = rd_grid_get_cdepth1((SafeGridHandle?)null, 0); Console.WriteLine("rd_grid_get_cdepth1 -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_cdepth1 threw: " + ex.Message); }
            try { var r = rd_grid_get_cell_volume1((SafeRdGridHandle?)null, 0); Console.WriteLine("rd_grid_get_cell_volume1 -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_cell_volume1 threw: " + ex.Message); }
            try { var r = rd_grid_get_cell_volume1A((SafeRdGridHandle?)null, 0); Console.WriteLine("rd_grid_get_cell_volume1A -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_cell_volume1A threw: " + ex.Message); }
            try { var r = rd_grid_get_active_index3((SafeRdGridHandle?)null, 0, 0, 0); Console.WriteLine("rd_grid_get_active_index3 -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_active_index3 threw: " + ex.Message); }
            try { var r = rd_grid_get_active_index1((SafeRdGridHandle?)null, 0); Console.WriteLine("rd_grid_get_active_index1 -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_active_index1 threw: " + ex.Message); }
            try { var r = rd_grid_cell_active3((SafeRdGridTypeHandle?)null, 0, 0, 0); Console.WriteLine("rd_grid_cell_active3 -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_cell_active3 threw: " + ex.Message); }
            try { var r = rd_grid_cell_active1((SafeRdGridTypeHandle?)null, 0); Console.WriteLine("rd_grid_cell_active1 -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_cell_active1 threw: " + ex.Message); }
            try { var r = rd_grid_ijk_valid((SafeRdGridTypeHandle?)null, 0, 0, 0); Console.WriteLine("rd_grid_ijk_valid -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_ijk_valid threw: " + ex.Message); }
            try { var r = rd_grid_get_global_index3((SafeRdGridTypeHandle?)null, 0, 0, 0); Console.WriteLine("rd_grid_get_global_index3 -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_global_index3 threw: " + ex.Message); }
            try { var r = rd_grid_get_global_index1A((SafeRdGridHandle?)null, 0); Console.WriteLine("rd_grid_get_global_index1A -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_global_index1A threw: " + ex.Message); }
            try { rd_grid_add_self_nnc((SafeGrid1Handle?)null, 0, 0, 0); Console.WriteLine("rd_grid_add_self_nnc -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_grid_add_self_nnc threw: " + ex.Message); }
            try { var r = rd_grid_exists((string?)null); Console.WriteLine("rd_grid_exists -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_exists threw: " + ex.Message); }
            try { rd_grid_free((SafeRdGridTypeHandle?)null); Console.WriteLine("rd_grid_free -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_grid_free threw: " + ex.Message); }
            try { rd_grid_get_dims((SafeRdGridTypeHandle?)null, (SafeIntHandle?)null, (SafeIntHandle?)null, (SafeIntHandle?)null, (SafeIntHandle?)null); Console.WriteLine("rd_grid_get_dims -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_grid_get_dims threw: " + ex.Message); }
            try { var r = rd_grid_get_nz((SafeGridHandle?)null); Console.WriteLine("rd_grid_get_nz -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_nz threw: " + ex.Message); }
            try { var r = rd_grid_get_nx((SafeGridHandle?)null); Console.WriteLine("rd_grid_get_nx -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_nx threw: " + ex.Message); }
            try { var r = rd_grid_get_ny((SafeGridHandle?)null); Console.WriteLine("rd_grid_get_ny -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_ny threw: " + ex.Message); }
            try { var r = rd_grid_get_nactive((SafeGridHandle?)null); Console.WriteLine("rd_grid_get_nactive -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_nactive threw: " + ex.Message); }
            try { var r = rd_grid_get_nactive_fracture((SafeGridHandle?)null); Console.WriteLine("rd_grid_get_nactive_fracture -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_nactive_fracture threw: " + ex.Message); }
            try { var r = rd_grid_get_active_index((SafeRdGridTypeHandle?)null, 0, 0, 0); Console.WriteLine("rd_grid_get_active_index -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_active_index threw: " + ex.Message); }
            try { var r = rd_grid_get_global_size((SafeRdGridHandle?)null); Console.WriteLine("rd_grid_get_global_size -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_global_size threw: " + ex.Message); }
            try { var r = rd_grid_get_active_size((SafeRdGridHandle?)null); Console.WriteLine("rd_grid_get_active_size -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_active_size threw: " + ex.Message); }
            try { var r = rd_grid_get_top1A((SafeGridHandle?)null, 0); Console.WriteLine("rd_grid_get_top1A -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_top1A threw: " + ex.Message); }
            try { var r = rd_grid_get_top2((SafeGridHandle?)null, 0, 0); Console.WriteLine("rd_grid_get_top2 -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_top2 threw: " + ex.Message); }
            try { var r = rd_grid_get_bottom2((SafeGridHandle?)null, 0, 0); Console.WriteLine("rd_grid_get_bottom2 -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_bottom2 threw: " + ex.Message); }
            try { var r = rd_grid_locate_depth((SafeGridHandle?)null, 0.0, 0, 0); Console.WriteLine("rd_grid_locate_depth -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_locate_depth threw: " + ex.Message); }
            try { var r = rd_grid_cell_invalid1((SafeRdGridHandle?)null, 0); Console.WriteLine("rd_grid_cell_invalid1 -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_cell_invalid1 threw: " + ex.Message); }
            try { var r = rd_grid_cell_valid1((SafeRdGridHandle?)null, 0); Console.WriteLine("rd_grid_cell_valid1 -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_cell_valid1 threw: " + ex.Message); }
            try { var r = rd_grid_get_num_lgr((SafeMainGridHandle?)null); Console.WriteLine("rd_grid_get_num_lgr -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_num_lgr threw: " + ex.Message); }
            try { var r = rd_grid_get_lgr_nr((SafeRdGridHandle?)null); Console.WriteLine("rd_grid_get_lgr_nr -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_lgr_nr threw: " + ex.Message); }
            try { var r = rd_grid_get_lgr_nr_from_name((SafeGridHandle?)null, (string?)null); Console.WriteLine("rd_grid_get_lgr_nr_from_name -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_lgr_nr_from_name threw: " + ex.Message); }
            try { var r = rd_grid_has_lgr((SafeMainGridHandle?)null, (string?)null); Console.WriteLine("rd_grid_has_lgr -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_has_lgr threw: " + ex.Message); }
            try { var r = rd_grid_has_lgr_nr((SafeMainGridHandle?)null, 0); Console.WriteLine("rd_grid_has_lgr_nr -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_has_lgr_nr threw: " + ex.Message); }
            try { var r = rd_grid_test_lgr_consistency((SafeRdGridHandle?)null); Console.WriteLine("rd_grid_test_lgr_consistency -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_test_lgr_consistency threw: " + ex.Message); }
            try { var r = rd_grid_zcorn_index__(0, 0, 0, 0, 0, 0); Console.WriteLine("rd_grid_zcorn_index__ -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_zcorn_index__ threw: " + ex.Message); }
            try { var r = rd_grid_dual_grid((SafeRdGridHandle?)null); Console.WriteLine("rd_grid_dual_grid -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_dual_grid threw: " + ex.Message); }
            try { var r = rd_grid_cell_regular1((SafeRdGridHandle?)null, 0); Console.WriteLine("rd_grid_cell_regular1 -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_cell_regular1 threw: " + ex.Message); }
            try { rd_grid_init_zcorn_data((SafeGridHandle?)null, (SafeZcornHandle?)null); Console.WriteLine("rd_grid_init_zcorn_data -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_grid_init_zcorn_data threw: " + ex.Message); }
            try { rd_grid_init_zcorn_data_double((SafeGridHandle?)null, (SafeZcornHandle?)null); Console.WriteLine("rd_grid_init_zcorn_data_double -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_grid_init_zcorn_data_double threw: " + ex.Message); }
            try { var r = rd_grid_get_zcorn_size((SafeGridHandle?)null); Console.WriteLine("rd_grid_get_zcorn_size -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_zcorn_size threw: " + ex.Message); }
            try { rd_grid_init_coord_data((SafeGridHandle?)null, (SafeCoordHandle?)null); Console.WriteLine("rd_grid_init_coord_data -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_grid_init_coord_data threw: " + ex.Message); }
            try { rd_grid_init_coord_data_double((SafeGridHandle?)null, (SafeCoordHandle?)null); Console.WriteLine("rd_grid_init_coord_data_double -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_grid_init_coord_data_double threw: " + ex.Message); }
            try { var r = rd_grid_get_coord_size((SafeRdGridHandle?)null); Console.WriteLine("rd_grid_get_coord_size -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_coord_size threw: " + ex.Message); }
            try { rd_grid_init_actnum_data((SafeGridHandle?)null, (SafeActnumHandle?)null); Console.WriteLine("rd_grid_init_actnum_data -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_grid_init_actnum_data threw: " + ex.Message); }
            try { var r = rd_grid_use_mapaxes((SafeGridHandle?)null); Console.WriteLine("rd_grid_use_mapaxes -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_use_mapaxes threw: " + ex.Message); }
            try { rd_grid_reset_actnum((SafeGridHandle?)null, (SafeActnumHandle?)null); Console.WriteLine("rd_grid_reset_actnum -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_grid_reset_actnum threw: " + ex.Message); }
            try { var r = rd_grid_get_unit_system((SafeGridHandle?)null); Console.WriteLine("rd_grid_get_unit_system -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_unit_system threw: " + ex.Message); }
        }
    }
}
