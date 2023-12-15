using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_CSharp.Forms
{
    public partial class FormQuanLyNhapHang : Form
    {
        private DAO.QuanLyDanhMuc_DAO ql_danhmuc_DAO = new DAO.QuanLyDanhMuc_DAO();
        private DTO.QuanLyDanhMuc_DTO ql_danhmuc_DTO = new DTO.QuanLyDanhMuc_DTO();
        private DAO.QuanLyNhaCungCap_DAO ql_cungcap_DAO = new DAO.QuanLyNhaCungCap_DAO();

        private DAO.QuanLySanPham_DAO ql_sanpham_DAO = new DAO.QuanLySanPham_DAO();
        private DTO.QuanLySanPham_DTO ql_sanpham_DTO = new DTO.QuanLySanPham_DTO();
        public FormQuanLyNhapHang()
        {
            InitializeComponent();
            HienThiSanPham();
            dtgvDanhSachSanPham.CellClick += DtgvDanhSachSanPham_CellClick;


            dtgvDanhSachSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvDanhSachSanPham.ReadOnly = true;




        }
        private void HienThiSanPham()
        {

            DataTable dt = ql_sanpham_DAO.LayDanhSachSanPham();
            dtgvDanhSachSanPham.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dtgvDanhSachSanPham.Rows.Add(row.ItemArray);
            }
        }
        private void DtgvDanhSachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is not a header cell
            if (e.RowIndex >= 0)
            {
                // Access the data only if it's not a header cell
                DataGridViewRow selectedRow = dtgvDanhSachSanPham.Rows[e.RowIndex];

            }
        }

        private void btnChuyenQua_Click(object sender, EventArgs e)
        {
            if (dtgvDanhSachSanPham.SelectedRows.Count == 1)
            {
                // Get maSP and tenSP from the selected row
                DataGridViewRow selectedRow = dtgvDanhSachSanPham.SelectedRows[0];
                int maSP = Convert.ToInt32(selectedRow.Cells["MaSP"].Value);
                string tenSP = selectedRow.Cells["TenSP"].Value?.ToString();

                // Open SanPhamsSize_Form and pass maSP and tenSP
                SanPhamsSize_Form sanPhamsSizeForm = new SanPhamsSize_Form(maSP, tenSP);

                // Set the StartPosition to CenterScreen
                sanPhamsSizeForm.StartPosition = FormStartPosition.CenterScreen;

                // Show the form
                sanPhamsSizeForm.ShowDialog();

                // Retrieve selected data
                int selectedMaSP = sanPhamsSizeForm.SelectedMaSP;
                string selectedTenSP = sanPhamsSizeForm.SelectedTenSP;
                string selectedSize = sanPhamsSizeForm.SelectedSize;
                int selectedSoLuong = sanPhamsSizeForm.SelectedSoLuong;
  

                // Add the data to your dtgvChiTietNhapHang (example)
                dtgvChiTietNhapHang.Rows.Add(selectedMaSP, selectedTenSP, selectedSoLuong, selectedSize);
            }
            else
            {
                MessageBox.Show("Please select a row before opening the form.", "Warning");
            }
        }
    }
}
    


