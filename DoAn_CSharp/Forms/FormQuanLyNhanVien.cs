using DoAn_CSharp.DAO;
using DoAn_CSharp.Database;
using DoAn_CSharp.Databsase;
using DoAn_CSharp.DTO;
using DoAn_CSharp.Report;
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

        TripleDES_Class baomat = new TripleDES_Class();

        MD5Hash md5hash = new MD5Hash();

        AESEncryptionEx aes = new AESEncryptionEx();

        private string anhNV;
        private QuanLyNhanVien_DAO nhanVien_DAO = new QuanLyNhanVien_DAO();
        private BindingSource bindingSource = new BindingSource();

        public FormQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void FormQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
            LoadDataToComboBoxMaChucVu();
            LoadDataToComBoBoxGioiTinh();
            LoadDataToComBoBoxTimKiem();
            bindingSource.DataSource = typeof(List<QuanLyNhanVien_DTO>);

            // Load ảnh nhân viên hiển thị đầy đủ

            pictureBoxAnhNhanVien.SizeMode = PictureBoxSizeMode.StretchImage;


            // Chọn giá trị đầu tiên của combobox mã chức vụ 
            if (cbMaChucVu.Items.Count > 0)
            {
                cbMaChucVu.SelectedIndex = 0;
            }

            // Chọn giá trị đầu tiên của combobox giới tính 
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

            if (cbGioiTinh.Items.Count > 0)
            {
                cbGioiTinh.SelectedIndex = 0;
            }
        }

        private void LoadDataToComBoBoxTimKiem()
        {

            cbTimKiem.Items.Add("MaNV");
            cbTimKiem.Items.Add("TenTaiKhoanNV");
            cbTimKiem.Items.Add("HoTenNV");
            cbTimKiem.Items.Add("TenCV");
            cbTimKiem.Items.Add("DiaChiNV");
            cbTimKiem.Items.Add("SDTNV");
            cbTimKiem.Items.Add("EmailNV");

            if (cbTimKiem.Items.Count > 0)
            {
                cbTimKiem.SelectedIndex = 0;
            }



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
                //string sdtNV =baomat.GiaiMa(row.Cells["SDTNV"].Value.ToString());
                string sdtNV = row.Cells["SDTNV"].Value.ToString();
                string cmnd = row.Cells["CMNDNV"].Value.ToString();


                string anhNVPath = row.Cells["AnhNV"].Value.ToString();
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

                if (System.IO.File.Exists(anhNVPath))
                {
                    pictureBoxAnhNhanVien.Image = Image.FromFile(anhNVPath);
                    pictureBoxAnhNhanVien.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hình ảnh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                anhNV = anhNVPath;
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



        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các controls trên form
            string maCV = cbMaChucVu.SelectedItem.ToString();
            string tenTaiKhoanNV = txtTenTaiKhoan.Text;
           // string matKhauNV = baomat.MaHoa(txtMatKhau.Text);
            string matKhauNV = MD5Hash.CalculateMD5Hash(txtMatKhau.Text) ;
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

            if (!KiemTra_DAO.IsValidUsername(tenTaiKhoanNV))
            {
                MessageBox.Show("Tên tài khoản chỉ được nhập bằng chữ.Viết Liền không dấu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

/*            if (!KiemTra_DAO.IsStrongPassword(matKhauNV))
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự, chứa ít nhất một chữ hoa, một chữ số và một ký tự đặc biệt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }*/

            // Kiểm tra tên tài khoản chỉ được nhập bằng chữ



            if (!KiemTra_DAO.IsValidName(hoTenNV))
            {
                MessageBox.Show("Họ tên chỉ được nhập bằng chữ và có thể nhập bằng dấu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!KiemTra_DAO.IsValidEmail(emailNV))
            {
                MessageBox.Show("Tên Email không hợp lệ , Ví dụ : 'admin@gmail.com'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!KiemTra_DAO.IsValidCCCD(cmndNV))
            {
                MessageBox.Show("Số CCCD chỉ được nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!KiemTra_DAO.IsValidPhoneNumber(sdtNV))
            {
                MessageBox.Show("Số điện thoại không hợp lệ , số điện thoại chỉ được nhập 10 số !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                // Lưu ảnh vào thư mục "Images" trong dự án
                string targetFolder = Path.Combine(Application.StartupPath, "Images");
                string targetPath = Path.Combine(targetFolder, Path.GetFileName(selectedImagePath));

                // Kiểm tra và tạo thư mục nếu nó chưa tồn tại
                if (!Directory.Exists(targetFolder))
                {
                    Directory.CreateDirectory(targetFolder);
                }

                // Copy ảnh vào thư mục "Images"
                File.Copy(selectedImagePath, targetPath, true);

                // Hiển thị hình ảnh trong PictureBox
                pictureBoxAnhNhanVien.Image = Image.FromFile(targetPath);
                pictureBoxAnhNhanVien.SizeMode = PictureBoxSizeMode.StretchImage;

                // Lưu đường dẫn tương đối cho ảnh
                anhNV = "Images\\" + Path.GetFileName(selectedImagePath);
            }
        }
        /*        private void btnChonAnh_Click(object sender, EventArgs e)
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
                }*/

        private void cbMaChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMaChucVu = cbMaChucVu.SelectedItem.ToString();

            // Gọi phương thức từ DAO để lấy tên chức vụ tương ứng

            string tenChucVu = nhanVien_DAO.GetTenChucVu(selectedMaChucVu);
            // Hiển thị tên chức vụ tương ứng trong TextBox txtTenChucVu

            txtTenChucVu.Text = tenChucVu;
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các controls trên form
            string maNV = txtMaNhanVien.Text; // Bạn cần có một cách nào đó để lấy mã nhân viên đã chọn

            string maCV = cbMaChucVu.SelectedItem.ToString();
            string tenTaiKhoanNV = txtTenTaiKhoan.Text;
            //string matKhauNV = baomat.MaHoa(txtMatKhau.Text);
            string matKhauNV = MD5Hash.CalculateMD5Hash(txtMatKhau.Text) ;
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

            // Kiểm tra xem tên tài khoản có bị trùng lắp không
            if (nhanVien_DAO.IsTenTaiKhoanExists(maNV, tenTaiKhoanNV))
            {
                MessageBox.Show("Tên tài khoản đã tồn tại. Vui lòng chọn tên tài khoản khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!KiemTra_DAO.IsValidUsername(tenTaiKhoanNV))
            {
                MessageBox.Show("Tên tài khoản chỉ được nhập bằng chữ.Viết Liền không dấu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

/*            if (!KiemTra_DAO.IsStrongPassword(matKhauNV))
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự, chứa ít nhất một chữ hoa, một chữ số và một ký tự đặc biệt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }*/

            // Kiểm tra tên tài khoản chỉ được nhập bằng chữ
            if (!KiemTra_DAO.IsValidName(hoTenNV))
            {
                MessageBox.Show("Họ tên chỉ được nhập bằng chữ và có thể nhập bằng dấu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!KiemTra_DAO.IsValidEmail(emailNV))
            {
                MessageBox.Show("Tên Email không hợp lệ , Ví dụ : 'admin@gmail.com'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!KiemTra_DAO.IsValidCCCD(cmndNV))
            {
                MessageBox.Show("Số CCCD chỉ được nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!KiemTra_DAO.IsValidPhoneNumber(sdtNV))
            {
                MessageBox.Show("Số điện thoại không hợp lệ , số điện thoại chỉ được nhập 10 số !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thực hiện cập nhật thông tin nhân viên vào cơ sở dữ liệu
            bool isSuccess = nhanVien_DAO.UpdateNhanVien(maNV, maCV, tenTaiKhoanNV, matKhauNV, hoTenNV, gioiTinhNV, ngaySinhNV, diaChiNV, emailNV, sdtNV, cmndNV, anhNV);

            // Kiểm tra kết quả cập nhật nhân viên
            if (isSuccess)
            {
                MessageBox.Show("Cập nhật nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sau khi cập nhật thành công, cập nhật lại DataGridView
                LoadDataToDataGridView();
            }
            else
            {
                MessageBox.Show("Cập nhật nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearInput();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Lấy mã nhân viên cần xóa từ TextBox txtMaNhanVien
            string maNV = txtMaNhanVien.Text;

            // Kiểm tra xem mã nhân viên có được nhập không
            if (string.IsNullOrWhiteSpace(maNV))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị hộp thoại xác nhận xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Thực hiện xóa nhân viên
                bool isSuccess = nhanVien_DAO.DeleteNhanVien(maNV);

                // Kiểm tra kết quả xóa nhân viên
                if (isSuccess)
                {
                    MessageBox.Show("Xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Sau khi xóa thành công, cập nhật lại DataGridView
                    LoadDataToDataGridView();
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Làm sạch các trường nhập liệu
                ClearInput();
            }
        }


        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            // Gọi phương thức để thực hiện tìm kiếm
            TimKiemNhanVien();
        }

        private void cbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Gọi phương thức để thực hiện tìm kiếm khi có sự thay đổi trong ComboBox
            TimKiemNhanVien();
        }
        private void TimKiemNhanVien()
        {
            // Lấy văn bản tìm kiếm và cột cần tìm kiếm
            string tuKhoa = txtTimKiem.Text.Trim();
            string cotTimKiem = cbTimKiem.SelectedItem?.ToString();

            // Kiểm tra xem cả hai điều kiện tìm kiếm đều đã được nhập
            if (!string.IsNullOrEmpty(tuKhoa) && !string.IsNullOrEmpty(cotTimKiem))
            {
                // Thực hiện tìm kiếm
                List<QuanLyNhanVien_DTO> ketQuaTimKiem = nhanVien_DAO.TimKiemNhanVien(cotTimKiem, tuKhoa);

                // Gán danh sách kết quả tìm kiếm cho BindingSource
                bindingSource.DataSource = ketQuaTimKiem;

                // Gán BindingSource cho DataGridView
                dtgvQuanLyNhanVien.DataSource = bindingSource;
            }
            else
            {
                // Nếu một trong hai điều kiện không được nhập, hiển thị tất cả nhân viên
                LoadDataToDataGridView();
            }
        }


        private void btnNhapExcel_Click(object sender, EventArgs e)
        {
           
        }

     

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            fDanhSachNhanVien f = new fDanhSachNhanVien();
            /*f.MdiParent = this;*/
            f.Show();
        }
       
    }
}






















/*private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            // Gọi phương thức tìm kiếm khi nội dung trong ô tìm kiếm thay đổi
            TimKiemNhanVien();
        }

        private void cbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Gọi phương thức tìm kiếm khi lựa chọn trong combobox thay đổi
            TimKiemNhanVien();
        }

        private void TimKiemNhanVien()
        {
            // Lấy thông tin tìm kiếm từ ô nhập và combobox
            string tuKhoa = txtTimKiem.Text.Trim();
            string loaiTimKiem = cbTimKiem.SelectedItem?.ToString();

            // Kiểm tra xem đã chọn loại tìm kiếm chưa
            if (string.IsNullOrEmpty(loaiTimKiem))
                return;

            // Thực hiện tìm kiếm và cập nhật DataGridView
            List<QuanLyNhanVien_DTO> ketQuaTimKiem = new List<QuanLyNhanVien_DTO>();
            switch (loaiTimKiem)
            {
                case "Tất Cả":
                    ketQuaTimKiem = nhanVien_DAO.TimKiemNhanVienTatCa(tuKhoa);
                    break;
                *//*case "Họ Tên Khách Hàng":
                    ketQuaTimKiem = nhanVien_DAO.TimKiemKhachHangTheoHoTen(tuKhoa);
                    break;
                case "Mã Khách Hàng":
                    ketQuaTimKiem = nhanVien_DAO.TimKiemKhachHangTheoMaKH(tuKhoa);
                    break;
                case "SĐT Khách Hàng":
                    ketQuaTimKiem = nhanVien_DAO.TimKiemKhachHangTheoSDTKH(tuKhoa);
                    break;
                case "Địa Chỉ Khách Hàng":
                    ketQuaTimKiem = nhanVien_DAO.TimKiemKhachHangTheoDiaChiKH(tuKhoa);
                    break;
                case "CMND/CCCDKH":
                    ketQuaTimKiem = nhanVien_DAO.TimKiemKhachHangTheoCMNDKH(tuKhoa);
                    break;
                case "Gioi Tinh KH":
                    ketQuaTimKiem = nhanVien_DAO.TimKiemKhachHangTheoGioiTinhKH(tuKhoa);
                    break;
                case "Trạng Thái KH":
                    ketQuaTimKiem = nhanVien_DAO.TimKiemKhachHangTheoTrangThaiKH(tuKhoa);
                    break;*//*

                // Thêm các trường hợp tìm kiếm khác ở đây nếu cần

                default:
                    break;
            }

            // Cập nhật DataGridView với kết quả tìm kiếm
            dtgvQuanLyNhanVien.DataSource = ketQuaTimKiem;
        }*/
