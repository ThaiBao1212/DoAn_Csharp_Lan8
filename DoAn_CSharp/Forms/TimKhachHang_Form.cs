using DoAn_CSharp.DAO;
using DoAn_CSharp.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DoAn_CSharp.Forms
{
    public partial class TimKhachHang_Form : Form
    {
        private QuanLyKhachHang_DAO khachHang_DAO = new QuanLyKhachHang_DAO();
        public string SelectedMaKhachHang { get; private set; }
        public string SelectedTenKhachHang { get; private set; }

        public TimKhachHang_Form()
        {
            InitializeComponent();

            // Call the method to load data when the form is loaded
            LoaddtgTimKhachHang();
        }

        private void LoaddtgTimKhachHang()
        {
            List<QuanLyKhachHang_DTO> list_KH = khachHang_DAO.GetKhachHang();
            dtgTimKhachHang.DataSource = list_KH;
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            // Set the DialogResult to OK
            DialogResult = DialogResult.OK;

            // Check if there is a selected row
            if (dtgTimKhachHang.SelectedRows.Count > 0)
            {
                // Get the selected customer's information from the DataGridView
                string maKhachHang = dtgTimKhachHang.SelectedRows[0].Cells["MaKH"].Value?.ToString();
                string tenKhachHang = dtgTimKhachHang.SelectedRows[0].Cells["HoTenKH"].Value?.ToString();

                // Assign values to the properties
                SelectedMaKhachHang = maKhachHang;
                SelectedTenKhachHang = tenKhachHang;
            }

            // Close the form
            Close();
        }
        private void TimKhachHang_Form_Load(object sender, EventArgs e)
        {
            LoadDataToComBoBoxTimKiem();
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
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            TimKiemKhachHang();
        }

        private void cbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            dtgTimKhachHang.DataSource = ketQuaTimKiem;
        }

    }
}
