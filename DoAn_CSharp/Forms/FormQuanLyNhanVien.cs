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
                string maCV = row.Cells["MaCV"].Value.ToString();
                string tenCV = row.Cells["TenCV"].Value.ToString();
                string tenTaiKhoanNV = row.Cells["TenTaiKhoanNV"].Value.ToString();
                string matKhauNV = row.Cells["MatKhauNV"].Value.ToString();
                string hoTenNV = row.Cells["HoTenNV"].Value.ToString();
                string gioiTinhNV= row.Cells["GioiTinhNV"].Value.ToString();
                string ngaySinhNV = row.Cells["NgaySinh"].Value.ToString();
                string diaChiNV = row.Cells["DiaChiNV"].Value.ToString();
                string emailNV = row.Cells["EmailNV"].Value.ToString();           
                string sdtNV = row.Cells["SDTNV"].Value.ToString();
                string cmnd = row.Cells["CMNDNV"].Value.ToString();
                string anhNV = row.Cells["AnhNV"].Value.ToString();

                // Hiển thị thông tin lên các TextBox
                txtMaNhanVien.Text = maNV;
                cbMaChucVu.SelectedItem = maCV;
                txtTenChucVu.Text = tenCV;
                txtTenTaiKhoan.Text = tenTaiKhoanNV;
                txtMatKhau.Text = matKhauNV;
                txtHoTen.Text = hoTenNV;
                cbGioiTinh.SelectedItem = gioiTinhNV;
                dateTimePickerNgaySinh.Text = ngaySinhNV;
                txtDiaChi.Text = diaChiNV;
                txtEmail.Text = emailNV;
                txtSDT.Text = sdtNV;
                txtCCCD.Text = cmnd;
                pictureBoxAnhNhanVien.Image = Image.FromFile(anhNV);


            }
        }


        private void pictureBoxAnhNhanVien_Click(object sender, EventArgs e)
        {

        }

        private string anhNV;
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;

                // Hiển thị hình ảnh trong PictureBox
                pictureBoxAnhNhanVien.Image = Image.FromFile(selectedImagePath);
                pictureBoxAnhNhanVien.SizeMode = PictureBoxSizeMode.StretchImage;

                anhNV = selectedImagePath;
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





    }
}
