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
            LoadDataToComboBoxMaChucVu();
            LoadDataToComBoBoxGioiTinh();

            // Load ảnh nhân viên hiển thị đầy đủ

            pictureBoxAnhNhanVien.SizeMode = PictureBoxSizeMode.StretchImage;


            // Chọn giá trị đầu tiên của combobox mã chức vụ 
            if (cbMaChucVu.Items.Count > 0)
            {
                cbMaChucVu.SelectedIndex = 0; 
            }


            // Chọn giá trị đầu tiên của combobox giới tính 
            if (cbGioiTinh.Items.Count > 0)
            {
                cbGioiTinh.SelectedIndex = 0;
            }    


        }


        private void pictureBoxAnhNhanVien_BackgroundImageLayoutChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        private void pictureBoxAnhNhanVien_Click(object sender, EventArgs e)
        {
            pictureBoxAnhNhanVien.SizeMode = PictureBoxSizeMode.StretchImage;
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
        }



        private void cbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                string gioiTinhNV = row.Cells["GioiTinhNV"].Value.ToString();
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

                if (cbGioiTinh.Items.Contains(gioiTinhNV))
                {
                    cbGioiTinh.SelectedItem = gioiTinhNV;
                }
                else
                {
                    cbGioiTinh.SelectedIndex = -1; // Nếu không tìm thấy giới tính, chọn giá trị mặc định hoặc để không chọn
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private bool IsAllLetters(string input)
        {
            return input.All(char.IsLetter);
        }
        private bool IsLettersAndDiacritics(string input)
        {
            // Kiểm tra xem tất cả ký tự trong chuỗi có phải là chữ hoặc dấu không
            return input.All(c => char.IsLetter(c) || char.IsWhiteSpace(c) || char.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.NonSpacingMark);
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
            // Kiểm tra xem tên tài khoản có bị trùng lắp không 

            if (nhanVien_DAO.IsTenTaiKhoanExists(tenTaiKhoanNV))
            {
                MessageBox.Show("Tên tài khoản đã tồn tại. Vui lòng chọn tên tài khoản khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra tên tài khoản chỉ được nhập bằng chữ
            if (!IsAllLetters(tenTaiKhoanNV))
            {
                MessageBox.Show("Tên tài khoản chỉ được nhập bằng chữ.Viết Liền không dấu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsLettersAndDiacritics(hoTenNV))
            {
                MessageBox.Show("Họ tên chỉ được nhập bằng chữ và có thể nhập bằng dấu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void cbMaChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMaChucVu = cbMaChucVu.SelectedItem.ToString();

            // Gọi phương thức từ DAO để lấy tên chức vụ tương ứng

            string tenChucVu = nhanVien_DAO.GetTenChucVu(selectedMaChucVu);
            // Hiển thị tên chức vụ tương ứng trong TextBox txtTenChucVu

            txtTenChucVu.Text = tenChucVu;
        }

    }
}
