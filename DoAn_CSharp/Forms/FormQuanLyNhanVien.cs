using DoAn_CSharp.DAO;
using DoAn_CSharp.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_CSharp.Forms
{
    public partial class FormQuanLyNhanVien : Form
    {

        private string anhNV;
        private QuanLyNhanVien_DAO nhanVien_DAO = new QuanLyNhanVien_DAO() ;

        public FormQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void FormQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
            pictureBoxAnhNhanVien.SizeMode = PictureBoxSizeMode.StretchImage;
            LoadDataToComboBoxMaChucVu();
            LoadDataToComBoBoxGioiTinh();

            if (cbMaChucVu.Items.Count > 0)
            {
                cbMaChucVu.SelectedIndex = 0; // Chọn giá trị đầu tiên
            }

        }

        private void pictureBoxAnhNhanVien_BackgroundImageLayoutChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
            pictureBoxAnhNhanVien.SizeMode = PictureBoxSizeMode.StretchImage;
        }

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
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các controls trên form
            string maCV = cbMaChucVu.SelectedItem.ToString();
            string tenTaiKhoanNV = txtTenTaiKhoan.Text;
            string matKhauNV = txtMatKhau.Text;
            string hoTenNV = txtHoTen.Text;
            string gioiTinhNV = cbGioiTinh.SelectedItem.ToString();
            DateTime ngaySinhNV = dateTimePickerNgaySinh.Value;
            string diaChiNV = txtDiaChi.Text;
            string emailNV = txtEmail.Text;
            string sdtNV = txtSDT.Text;
            string cmndNV = txtCCCD.Text;


            // Kiểm tra xem tất cả các trường thông tin đã được nhập đầy đủ chưa
            if (string.IsNullOrWhiteSpace(maCV) || string.IsNullOrWhiteSpace(tenTaiKhoanNV) ||
                string.IsNullOrWhiteSpace(matKhauNV) || string.IsNullOrWhiteSpace(hoTenNV) ||
                string.IsNullOrWhiteSpace(gioiTinhNV) || string.IsNullOrWhiteSpace(diaChiNV) ||
                string.IsNullOrWhiteSpace(emailNV) || string.IsNullOrWhiteSpace(sdtNV) ||
                string.IsNullOrWhiteSpace(cmndNV))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem đã chọn ảnh nhân viên chưa
            if (string.IsNullOrEmpty(anhNV))
            {
                MessageBox.Show("Vui lòng chọn ảnh nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thực hiện thêm nhân viên vào cơ sở dữ liệu
            bool isSuccess = nhanVien_DAO.AddNhanVien(maCV, tenTaiKhoanNV, matKhauNV, hoTenNV, gioiTinhNV, ngaySinhNV, diaChiNV, emailNV, sdtNV, cmndNV, anhNV);

            // Kiểm tra kết quả thêm nhân viên
            if (isSuccess)
            {
                MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sau khi thêm thành công, cập nhật lại DataGridView
                LoadDataToDataGridView();
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearInput();
        }

        private void ClearInput()
        {
            // Xóa nội dung của các TextBox
            txtMaNhanVien.Text = string.Empty;
            txtTenTaiKhoan.Text = string.Empty;
            txtMatKhau.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtCCCD.Text = string.Empty;

            // Đặt giá trị mặc định cho ComboBox
            cbMaChucVu.SelectedIndex = 0;
            cbGioiTinh.SelectedIndex = 0;

            // Đặt giá trị mặc định cho DateTimePicker
            dateTimePickerNgaySinh.Value = DateTime.Now;

            // Xóa hình ảnh trong PictureBox
            pictureBoxAnhNhanVien.Image = null;
        }

        private void LoadDataToDataGridView()
        {
            List<QuanLyNhanVien_DTO> listNhanVien = nhanVien_DAO.GetNhanVien();
            dtgvQuanLyNhanVien.DataSource = listNhanVien;
        }
        private void LoadDataToComboBoxMaChucVu()
        {
            List<string> listMaChucVu = nhanVien_DAO.GetMaChucVu();

            // Load dữ liệu vào ComboBox MaChucVu
            cbMaChucVu.Items.AddRange(listMaChucVu.ToArray());
        }

        private void LoadDataToComBoBoxGioiTinh()
        {
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
            cbGioiTinh.Items.Add("Khác");

        }

        private void cbMaChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMaChucVu = cbMaChucVu.SelectedItem.ToString();

            // Gọi phương thức từ DAO để lấy tên chức vụ tương ứng

            string tenChucVu = nhanVien_DAO.GetTenChucVu(selectedMaChucVu); 
            // Hiển thị tên chức vụ tương ứng trong TextBox txtTenChucVu
            txtTenChucVu.Text = tenChucVu;
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
