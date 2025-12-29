// Auto-generated from resdata\rd_grid.hpp
using System;
using System.Runtime.InteropServices;

namespace Resdata.Bindings.Generated {
    public static class Native_rd_grid {
        private const string LIB = "libresdata";

        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_grid_have_coarse_cells(IntPtr main_grid);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_num_coarse_groups(IntPtr main_grid);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_grid_get_cell_dx1A(IntPtr grid, int active_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_grid_get_cell_dy1A(IntPtr grid, int active_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_grid_get_cell_dz1A(IntPtr grid, int active_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_grid_get_cell_dx1(IntPtr grid, int global_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_grid_get_cell_dy1(IntPtr grid, int global_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_grid_get_cell_dz1(IntPtr grid, int global_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_grid_get_cell_thickness1(IntPtr grid, int global_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_grid_get_cdepth1A(IntPtr grid, int active_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_grid_get_cdepth1(IntPtr grid, int global_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_grid_get_cell_volume1(IntPtr rd_grid, int global_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_grid_get_cell_volume1A(IntPtr rd_grid, int active_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_active_index3(IntPtr rd_grid, int i, int j, int k);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_active_index1(IntPtr rd_grid, int global_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_grid_cell_active3(IntPtr p0, int p1, int p2, int p3);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_grid_cell_active1(IntPtr p0, int p1);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_grid_ijk_valid(IntPtr p0, int p1, int p2, int p3);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_global_index3(IntPtr p0, int p1, int p2, int p3);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_global_index1A(IntPtr rd_grid, int active_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_grid_add_self_nnc(IntPtr grid1, int g1, int g2, int nnc_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool rd_grid_exists(string case_input);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_grid_free(IntPtr p0);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_grid_get_dims(IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_nz(IntPtr grid);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_nx(IntPtr grid);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_ny(IntPtr grid);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_nactive(IntPtr grid);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_nactive_fracture(IntPtr grid);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_active_index(IntPtr p0, int p1, int p2, int p3);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_global_size(IntPtr rd_grid);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_active_size(IntPtr rd_grid);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_grid_get_top1A(IntPtr grid, int active_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_grid_get_top2(IntPtr grid, int i, int j);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern double rd_grid_get_bottom2(IntPtr grid, int i, int j);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_locate_depth(IntPtr grid, double depth, int i, int j);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_grid_cell_invalid1(IntPtr rd_grid, int global_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_grid_cell_valid1(IntPtr rd_grid, int global_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_num_lgr(IntPtr main_grid);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_lgr_nr(IntPtr rd_grid);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern int rd_grid_get_lgr_nr_from_name(IntPtr grid, string name);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, CharSet=CharSet.Ansi )]
        public static extern bool rd_grid_has_lgr(IntPtr main_grid, string __lgr_name);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_grid_has_lgr_nr(IntPtr main_grid, int lgr_nr);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_grid_test_lgr_consistency(IntPtr rd_grid);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_zcorn_index__(int nx, int ny, int i, int j, int k, int c);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_grid_dual_grid(IntPtr rd_grid);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_grid_cell_regular1(IntPtr rd_grid, int global_index);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_grid_init_zcorn_data(IntPtr grid, IntPtr zcorn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_grid_init_zcorn_data_double(IntPtr grid, IntPtr zcorn);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_zcorn_size(IntPtr grid);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_grid_init_coord_data(IntPtr grid, IntPtr coord);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_grid_init_coord_data_double(IntPtr grid, IntPtr coord);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern int rd_grid_get_coord_size(IntPtr rd_grid);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_grid_init_actnum_data(IntPtr grid, IntPtr actnum);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern bool rd_grid_use_mapaxes(IntPtr grid);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern void rd_grid_reset_actnum(IntPtr grid, IntPtr actnum);
        [DllImport(LIB, CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr rd_grid_get_unit_system(IntPtr grid);

        public static void ExecuteAll() {
            Console.WriteLine(@"Executing functions from: resdata\\rd_grid.hpp");
            try { var r = rd_grid_have_coarse_cells(IntPtr.Zero); Console.WriteLine("rd_grid_have_coarse_cells -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_have_coarse_cells threw: " + ex.Message); }
            try { var r = rd_grid_get_num_coarse_groups(IntPtr.Zero); Console.WriteLine("rd_grid_get_num_coarse_groups -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_num_coarse_groups threw: " + ex.Message); }
            try { var r = rd_grid_get_cell_dx1A(IntPtr.Zero, 0); Console.WriteLine("rd_grid_get_cell_dx1A -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_cell_dx1A threw: " + ex.Message); }
            try { var r = rd_grid_get_cell_dy1A(IntPtr.Zero, 0); Console.WriteLine("rd_grid_get_cell_dy1A -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_cell_dy1A threw: " + ex.Message); }
            try { var r = rd_grid_get_cell_dz1A(IntPtr.Zero, 0); Console.WriteLine("rd_grid_get_cell_dz1A -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_cell_dz1A threw: " + ex.Message); }
            try { var r = rd_grid_get_cell_dx1(IntPtr.Zero, 0); Console.WriteLine("rd_grid_get_cell_dx1 -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_cell_dx1 threw: " + ex.Message); }
            try { var r = rd_grid_get_cell_dy1(IntPtr.Zero, 0); Console.WriteLine("rd_grid_get_cell_dy1 -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_cell_dy1 threw: " + ex.Message); }
            try { var r = rd_grid_get_cell_dz1(IntPtr.Zero, 0); Console.WriteLine("rd_grid_get_cell_dz1 -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_cell_dz1 threw: " + ex.Message); }
            try { var r = rd_grid_get_cell_thickness1(IntPtr.Zero, 0); Console.WriteLine("rd_grid_get_cell_thickness1 -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_cell_thickness1 threw: " + ex.Message); }
            try { var r = rd_grid_get_cdepth1A(IntPtr.Zero, 0); Console.WriteLine("rd_grid_get_cdepth1A -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_cdepth1A threw: " + ex.Message); }
            try { var r = rd_grid_get_cdepth1(IntPtr.Zero, 0); Console.WriteLine("rd_grid_get_cdepth1 -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_cdepth1 threw: " + ex.Message); }
            try { var r = rd_grid_get_cell_volume1(IntPtr.Zero, 0); Console.WriteLine("rd_grid_get_cell_volume1 -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_cell_volume1 threw: " + ex.Message); }
            try { var r = rd_grid_get_cell_volume1A(IntPtr.Zero, 0); Console.WriteLine("rd_grid_get_cell_volume1A -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_cell_volume1A threw: " + ex.Message); }
            try { var r = rd_grid_get_active_index3(IntPtr.Zero, 0, 0, 0); Console.WriteLine("rd_grid_get_active_index3 -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_active_index3 threw: " + ex.Message); }
            try { var r = rd_grid_get_active_index1(IntPtr.Zero, 0); Console.WriteLine("rd_grid_get_active_index1 -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_active_index1 threw: " + ex.Message); }
            try { var r = rd_grid_cell_active3(IntPtr.Zero, 0, 0, 0); Console.WriteLine("rd_grid_cell_active3 -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_cell_active3 threw: " + ex.Message); }
            try { var r = rd_grid_cell_active1(IntPtr.Zero, 0); Console.WriteLine("rd_grid_cell_active1 -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_cell_active1 threw: " + ex.Message); }
            try { var r = rd_grid_ijk_valid(IntPtr.Zero, 0, 0, 0); Console.WriteLine("rd_grid_ijk_valid -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_ijk_valid threw: " + ex.Message); }
            try { var r = rd_grid_get_global_index3(IntPtr.Zero, 0, 0, 0); Console.WriteLine("rd_grid_get_global_index3 -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_global_index3 threw: " + ex.Message); }
            try { var r = rd_grid_get_global_index1A(IntPtr.Zero, 0); Console.WriteLine("rd_grid_get_global_index1A -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_global_index1A threw: " + ex.Message); }
            try { rd_grid_add_self_nnc(IntPtr.Zero, 0, 0, 0); Console.WriteLine("rd_grid_add_self_nnc -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_grid_add_self_nnc threw: " + ex.Message); }
            try { var r = rd_grid_exists(null); Console.WriteLine("rd_grid_exists -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_exists threw: " + ex.Message); }
            try { rd_grid_free(IntPtr.Zero); Console.WriteLine("rd_grid_free -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_grid_free threw: " + ex.Message); }
            try { rd_grid_get_dims(IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_grid_get_dims -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_grid_get_dims threw: " + ex.Message); }
            try { var r = rd_grid_get_nz(IntPtr.Zero); Console.WriteLine("rd_grid_get_nz -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_nz threw: " + ex.Message); }
            try { var r = rd_grid_get_nx(IntPtr.Zero); Console.WriteLine("rd_grid_get_nx -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_nx threw: " + ex.Message); }
            try { var r = rd_grid_get_ny(IntPtr.Zero); Console.WriteLine("rd_grid_get_ny -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_ny threw: " + ex.Message); }
            try { var r = rd_grid_get_nactive(IntPtr.Zero); Console.WriteLine("rd_grid_get_nactive -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_nactive threw: " + ex.Message); }
            try { var r = rd_grid_get_nactive_fracture(IntPtr.Zero); Console.WriteLine("rd_grid_get_nactive_fracture -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_nactive_fracture threw: " + ex.Message); }
            try { var r = rd_grid_get_active_index(IntPtr.Zero, 0, 0, 0); Console.WriteLine("rd_grid_get_active_index -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_active_index threw: " + ex.Message); }
            try { var r = rd_grid_get_global_size(IntPtr.Zero); Console.WriteLine("rd_grid_get_global_size -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_global_size threw: " + ex.Message); }
            try { var r = rd_grid_get_active_size(IntPtr.Zero); Console.WriteLine("rd_grid_get_active_size -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_active_size threw: " + ex.Message); }
            try { var r = rd_grid_get_top1A(IntPtr.Zero, 0); Console.WriteLine("rd_grid_get_top1A -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_top1A threw: " + ex.Message); }
            try { var r = rd_grid_get_top2(IntPtr.Zero, 0, 0); Console.WriteLine("rd_grid_get_top2 -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_top2 threw: " + ex.Message); }
            try { var r = rd_grid_get_bottom2(IntPtr.Zero, 0, 0); Console.WriteLine("rd_grid_get_bottom2 -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_bottom2 threw: " + ex.Message); }
            try { var r = rd_grid_locate_depth(IntPtr.Zero, 0.0, 0, 0); Console.WriteLine("rd_grid_locate_depth -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_locate_depth threw: " + ex.Message); }
            try { var r = rd_grid_cell_invalid1(IntPtr.Zero, 0); Console.WriteLine("rd_grid_cell_invalid1 -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_cell_invalid1 threw: " + ex.Message); }
            try { var r = rd_grid_cell_valid1(IntPtr.Zero, 0); Console.WriteLine("rd_grid_cell_valid1 -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_cell_valid1 threw: " + ex.Message); }
            try { var r = rd_grid_get_num_lgr(IntPtr.Zero); Console.WriteLine("rd_grid_get_num_lgr -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_num_lgr threw: " + ex.Message); }
            try { var r = rd_grid_get_lgr_nr(IntPtr.Zero); Console.WriteLine("rd_grid_get_lgr_nr -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_lgr_nr threw: " + ex.Message); }
            try { var r = rd_grid_get_lgr_nr_from_name(IntPtr.Zero, null); Console.WriteLine("rd_grid_get_lgr_nr_from_name -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_lgr_nr_from_name threw: " + ex.Message); }
            try { var r = rd_grid_has_lgr(IntPtr.Zero, null); Console.WriteLine("rd_grid_has_lgr -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_has_lgr threw: " + ex.Message); }
            try { var r = rd_grid_has_lgr_nr(IntPtr.Zero, 0); Console.WriteLine("rd_grid_has_lgr_nr -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_has_lgr_nr threw: " + ex.Message); }
            try { var r = rd_grid_test_lgr_consistency(IntPtr.Zero); Console.WriteLine("rd_grid_test_lgr_consistency -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_test_lgr_consistency threw: " + ex.Message); }
            try { var r = rd_grid_zcorn_index__(0, 0, 0, 0, 0, 0); Console.WriteLine("rd_grid_zcorn_index__ -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_zcorn_index__ threw: " + ex.Message); }
            try { var r = rd_grid_dual_grid(IntPtr.Zero); Console.WriteLine("rd_grid_dual_grid -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_dual_grid threw: " + ex.Message); }
            try { var r = rd_grid_cell_regular1(IntPtr.Zero, 0); Console.WriteLine("rd_grid_cell_regular1 -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_cell_regular1 threw: " + ex.Message); }
            try { rd_grid_init_zcorn_data(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_grid_init_zcorn_data -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_grid_init_zcorn_data threw: " + ex.Message); }
            try { rd_grid_init_zcorn_data_double(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_grid_init_zcorn_data_double -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_grid_init_zcorn_data_double threw: " + ex.Message); }
            try { var r = rd_grid_get_zcorn_size(IntPtr.Zero); Console.WriteLine("rd_grid_get_zcorn_size -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_zcorn_size threw: " + ex.Message); }
            try { rd_grid_init_coord_data(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_grid_init_coord_data -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_grid_init_coord_data threw: " + ex.Message); }
            try { rd_grid_init_coord_data_double(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_grid_init_coord_data_double -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_grid_init_coord_data_double threw: " + ex.Message); }
            try { var r = rd_grid_get_coord_size(IntPtr.Zero); Console.WriteLine("rd_grid_get_coord_size -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_coord_size threw: " + ex.Message); }
            try { rd_grid_init_actnum_data(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_grid_init_actnum_data -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_grid_init_actnum_data threw: " + ex.Message); }
            try { var r = rd_grid_use_mapaxes(IntPtr.Zero); Console.WriteLine("rd_grid_use_mapaxes -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_use_mapaxes threw: " + ex.Message); }
            try { rd_grid_reset_actnum(IntPtr.Zero, IntPtr.Zero); Console.WriteLine("rd_grid_reset_actnum -> (void)"); } catch(Exception ex) { Console.WriteLine("rd_grid_reset_actnum threw: " + ex.Message); }
            try { var r = rd_grid_get_unit_system(IntPtr.Zero); Console.WriteLine("rd_grid_get_unit_system -> " + r); } catch(Exception ex) { Console.WriteLine("rd_grid_get_unit_system threw: " + ex.Message); }
        }
    }
}
