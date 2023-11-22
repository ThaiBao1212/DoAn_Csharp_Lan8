using DoAn_CSharp.DAO;
using DoAn_CSharp.DTO;
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
    public partial class FormQuanLyNhanVien : Form
    {

        private QuanLyNhanVien_DAO nhanVien_DAO = new QuanLyNhanVien_DAO() ;

        public FormQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void FormQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }

        private void dtgvQuanLyNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvQuanLyNhanVien.Rows[e.RowIndex];

                // Trích xuất thông tin từ dòng được chọn
                string maNV = row.Cells["MaNV"].Value.ToString();
                string maCV = row.Cells["TenCV"].Value.ToString();

                // Hiển thị thông tin lên các TextBox
                txtMaNhanVien.Text = maNV;
                txtTenChucVu.Text = maCV;

            }

        }
        private void LoadDataToDataGridView()
        {
            List<QuanLyNhanVien_DTO> listNhanVien = nhanVien_DAO.GetNhanVien();
            dtgvQuanLyNhanVien.DataSource = listNhanVien;
        }






        private void cbMaChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMaChucVu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxAnhNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {

        }


    }
}
