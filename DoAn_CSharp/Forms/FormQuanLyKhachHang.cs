using DoAn_CSharp.DAO;
using DoAn_CSharp.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_CSharp.Forms
{
    public partial class FormQuanLyKhachHang : Form
    {
        public FormQuanLyKhachHang()
        {
            InitializeComponent();

        }

        private QuanLyKhachHang_DTO KH_Selected = new QuanLyKhachHang_DTO();
        private QuanLyKhachHang_DAO khachHang_DAO = new QuanLyKhachHang_DAO();
        
        string TrangThaiKH = "Đóng";


        private void checkBoxTrangThai_CheckedChanged(object sender, EventArgs e)
        {
            bool check = checkBoxTrangThai.Checked;
            if (check)
            {
                this.TrangThaiKH = "Mở";
            }
            else
            {
                this.TrangThaiKH = "Đóng";
            }
        
        }

        private void FormQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
            dataKH_load();
            LoadDataToComBoBoxGioiTinh();
            LoadDataToComBoBoxTimKiem();

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
            cbTimKiem.Items.Add("Tất cả");
            cbTimKiem.Items.Add("Mã Khách Hàng");
            cbTimKiem.Items.Add("Họ Tên Khách Hàng");
            cbTimKiem.Items.Add("Địa Chỉ Khách Hàng");
            cbTimKiem.Items.Add("SĐT Khách Hàng");
            cbTimKiem.Items.Add("CMND/CCCDKH");
            cbTimKiem.Items.Add("Gioi Tinh KH");
            cbTimKiem.Items.Add("Trạng Thái KH");
           




            if (cbTimKiem.Items.Count > 0)
            {
                cbTimKiem.SelectedIndex = 0;
            }
        }
        private void LoadDataToDataGridView()
        {
            List<QuanLyKhachHang_DTO> list_KH = khachHang_DAO.GetKhachHang();
            dtgvQuanLyKhachHang.DataSource = list_KH;


        }
        private void dataKH_load()
        {
            dtgvQuanLyKhachHang.SelectionChanged += dtgvQuanLyKhachHang_SelectionChanged;
            dtgvQuanLyKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvQuanLyKhachHang.ReadOnly = true;
        }

        private void dtgvQuanLyKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvQuanLyKhachHang.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgvQuanLyKhachHang.SelectedRows[0];

                KH_Selected.MaKH = (string)selectedRow.Cells["MaKH"].Value;
                KH_Selected.HoTenKH = (string)selectedRow.Cells["HoTenKH"].Value;
                KH_Selected.DiaChiKH = (string)selectedRow.Cells["DiaChiKH"].Value;
                KH_Selected.SDTKH = (string)selectedRow.Cells["SDTKH"].Value;
                KH_Selected.CMNDKH = (string)selectedRow.Cells["CMNDKH"].Value;
                KH_Selected.GioiTinhKH = (string)selectedRow.Cells["GioiTinhKH"].Value;
                KH_Selected.TrangThaiKH = (string)selectedRow.Cells["TrangThaiKH"].Value;

                // add lên các text box

                txtMaKhachHang.Text  = KH_Selected.MaKH;
                txtHoTen.Text = KH_Selected.HoTenKH;
                txtDiaChi.Text = KH_Selected.DiaChiKH;
                txtSDT.Text = KH_Selected.SDTKH;
                txtCCCD.Text = KH_Selected.CMNDKH;
                cbGioiTinh.SelectedItem = KH_Selected.GioiTinhKH;
                checkBoxTrangThai.Checked = KH_Selected.TrangThaiKH == "Mở";

                if (cbGioiTinh.Items.Contains(KH_Selected.GioiTinhKH))
                {
                    cbGioiTinh.SelectedItem = KH_Selected.GioiTinhKH;
                }
                else
                {
                    cbGioiTinh.SelectedIndex = -1; // Nếu không tìm thấy giới tính, chọn giá trị mặc định hoặc để không chọn
                }


            }
        }

        private void ClearInputFields()
        {
            // Xóa nội dung các controls trên form
            txtMaKhachHang.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtCCCD.Clear();
            cbGioiTinh.SelectedIndex = 0;
            checkBoxTrangThai.Checked = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }




        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các controls trên form
            string hoTenKH = txtHoTen.Text;
            string diaChiKH = txtDiaChi.Text;
            string sdtKH = txtSDT.Text;
            string cmndKH = txtCCCD.Text;
            string gioiTinhKH = cbGioiTinh.SelectedItem?.ToString(); // Tránh lỗi null
            string trangThaiKH = checkBoxTrangThai.Checked ? "Mở" : "Đóng";

            // Kiểm tra xem tất cả các trường thông tin đã được nhập đầy đủ chưa
            if (string.IsNullOrWhiteSpace(hoTenKH) || string.IsNullOrWhiteSpace(diaChiKH) ||
                string.IsNullOrWhiteSpace(sdtKH) || string.IsNullOrWhiteSpace(cmndKH) ||
                string.IsNullOrWhiteSpace(gioiTinhKH))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Khách Hàng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kiểm tra tên khách hàng 

            if (khachHang_DAO.IsTenKhachHangExists(hoTenKH))
            {
                MessageBox.Show("Tên Khách Hàng  đã tồn tại. Vui lòng chọn tên Khách Hàng  khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!KiemTra_DAO.IsValidName(hoTenKH))
            {
                MessageBox.Show("Họ tên chỉ được nhập bằng chữ và có thể nhập bằng dấu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!KiemTra_DAO.IsValidPhoneNumber(sdtKH))
            {
                MessageBox.Show("Số điện thoại không hợp lệ , số điện thoại chỉ được nhập 10 số !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!KiemTra_DAO.IsValidCCCD(cmndKH))
            {
                MessageBox.Show("Số CCCD chỉ được nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thực hiện thêm khách hàng vào cơ sở dữ liệu
            bool isSuccess = khachHang_DAO.ThemKhachHang(new QuanLyKhachHang_DTO
            {
                HoTenKH = hoTenKH,
                DiaChiKH = diaChiKH,
                SDTKH = sdtKH,
                CMNDKH = cmndKH,
                GioiTinhKH = gioiTinhKH,
                TrangThaiKH = trangThaiKH
            });

            // Kiểm tra kết quả thêm khách hàng
            if (isSuccess)
            {
                MessageBox.Show("Thêm Khách Hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sau khi thêm thành công, cập nhật lại DataGridView
                LoadDataToDataGridView();
            }
            else
            {
                MessageBox.Show("Thêm Khách Hàng Thất Bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearInputFields();
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các controls trên form
            string maKH = KH_Selected.MaKH;
            string hoTenKH = txtHoTen.Text;
            string diaChiKH = txtDiaChi.Text;
            string sdtKH = txtSDT.Text;
            string cmndKH = txtCCCD.Text;
            string gioiTinhKH = cbGioiTinh.SelectedItem?.ToString(); // Tránh lỗi null
            string trangThaiKH = checkBoxTrangThai.Checked ? "Mở" : "Đóng";

            // Kiểm tra xem tất cả các trường thông tin đã được nhập đầy đủ chưa
            if (string.IsNullOrWhiteSpace(hoTenKH) || string.IsNullOrWhiteSpace(diaChiKH) ||
                string.IsNullOrWhiteSpace(sdtKH) || string.IsNullOrWhiteSpace(cmndKH) ||
                string.IsNullOrWhiteSpace(gioiTinhKH))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Khách Hàng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (khachHang_DAO.IsTenKhachHangExists(maKH, hoTenKH))
            {
                MessageBox.Show("Tên Khách Hàng  đã tồn tại. Vui lòng chọn tên Khách Hàng  khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!KiemTra_DAO.IsValidName(hoTenKH))
            {
                MessageBox.Show("Họ tên chỉ được nhập bằng chữ và có thể nhập bằng dấu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!KiemTra_DAO.IsValidPhoneNumber(sdtKH))
            {
                MessageBox.Show("Số điện thoại không hợp lệ , số điện thoại chỉ được nhập 10 số !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!KiemTra_DAO.IsValidCCCD(cmndKH))
            {
                MessageBox.Show("Số CCCD chỉ được nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Thực hiện cập nhật khách hàng vào cơ sở dữ liệu
            bool isSuccess = khachHang_DAO.UpdateKhachHang(maKH, hoTenKH, diaChiKH, sdtKH, cmndKH, gioiTinhKH, trangThaiKH);

            // Kiểm tra kết quả cập nhật khách hàng
            if (isSuccess)
            {
                MessageBox.Show("Cập nhật Khách Hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sau khi cập nhật thành công, cập nhật lại DataGridView
                LoadDataToDataGridView();
            }
            else
            {
                MessageBox.Show("Cập nhật Khách Hàng Thất Bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearInputFields();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(KH_Selected.MaKH))
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa thông tin khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Gọi phương thức xóa từ DAO
                    bool deleted = khachHang_DAO.DeleteKhachHang(KH_Selected.MaKH);

                    if (deleted)
                    {
                        MessageBox.Show("Đã xóa khách hàng có mã " + KH_Selected.MaKH);
                        LoadDataToDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Xóa khách hàng thất bại. Có thể có sản phẩm liên quan đến khách hàng này.");
                    }
                }
            }
        }


        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            // Gọi phương thức tìm kiếm khi nội dung trong ô tìm kiếm thay đổi
            TimKiemKhachHang();
        }

        private void cbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Gọi phương thức tìm kiếm khi lựa chọn trong combobox thay đổi
            TimKiemKhachHang();
        }

        private void TimKiemKhachHang()
        {
            // Lấy thông tin tìm kiếm từ ô nhập và combobox
            string tuKhoa = txtTimKiem.Text.Trim();
            string loaiTimKiem = cbTimKiem.SelectedItem?.ToString();

            // Kiểm tra xem đã chọn loại tìm kiếm chưa
            if (string.IsNullOrEmpty(loaiTimKiem))
                return;

            // Thực hiện tìm kiếm và cập nhật DataGridView
            List<QuanLyKhachHang_DTO> ketQuaTimKiem = new List<QuanLyKhachHang_DTO>();
            switch (loaiTimKiem)
            {
                case "Tất cả":
                    ketQuaTimKiem = khachHang_DAO.TimKiemKhachHangTatCa(tuKhoa);
                    break;
                case "Họ Tên Khách Hàng":
                    ketQuaTimKiem = khachHang_DAO.TimKiemKhachHangTheoHoTen(tuKhoa);
                    break;
                case "Mã Khách Hàng":
                    ketQuaTimKiem = khachHang_DAO.TimKiemKhachHangTheoMaKH(tuKhoa);
                    break;
                case "SĐT Khách Hàng":
                    ketQuaTimKiem = khachHang_DAO.TimKiemKhachHangTheoSDTKH(tuKhoa);
                    break;
                case "Địa Chỉ Khách Hàng":
                    ketQuaTimKiem = khachHang_DAO.TimKiemKhachHangTheoDiaChiKH(tuKhoa);
                    break;
                case "CMND/CCCDKH":
                    ketQuaTimKiem = khachHang_DAO.TimKiemKhachHangTheoCMNDKH(tuKhoa);
                    break;
                case "Gioi Tinh KH":
                    ketQuaTimKiem = khachHang_DAO.TimKiemKhachHangTheoGioiTinhKH(tuKhoa);
                    break;
                case "Trạng Thái KH":
                    ketQuaTimKiem = khachHang_DAO.TimKiemKhachHangTheoTrangThaiKH(tuKhoa);
                    break;

                // Thêm các trường hợp tìm kiếm khác ở đây nếu cần

                default:
                    break;
            }

            // Cập nhật DataGridView với kết quả tìm kiếm
            dtgvQuanLyKhachHang.DataSource = ketQuaTimKiem;
        }

    }
}
