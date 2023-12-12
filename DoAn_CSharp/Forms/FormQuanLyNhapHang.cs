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
    public partial class FormQuanLyNhapHang : Form
    {
        public FormQuanLyNhapHang()
        {
            InitializeComponent();
        }

        private QuanLyNhapHang_DTO ql_NhapHang_DTO = new QuanLyNhapHang_DTO();
        private QuanLyNhapHang_DAO phieuNhap_DAO = new QuanLyNhapHang_DAO();

        string TrangThaiPN = "Đóng";


        private void FormQuanLyNhapHang_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
            LoadDataToComBoBoxTimKiem();
            dataPN_load();
        }

        private void AdjustDataGridViewColumns()
        {
            // Tự động canh chỉnh kích thước của các cột để fill DataGridView
            foreach (DataGridViewColumn column in dtgvDanhSachPhieuNhap.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void LoadDataToDataGridView()   
        {
            List<QuanLyNhapHang_DTO> list_PN = phieuNhap_DAO.GetPhieuNhap();

            // Xóa các cột hiện tại trong DataGridView
            dtgvDanhSachPhieuNhap.Columns.Clear();

            // Thêm các cột mới vào DataGridView
            dtgvDanhSachPhieuNhap.Columns.Add("MaPhieuNhap", "Mã Phiếu Nhập");
            dtgvDanhSachPhieuNhap.Columns.Add("MaNV", "Mã Nhân Viên");
            dtgvDanhSachPhieuNhap.Columns.Add("NgayLapPhieu", "Ngày Lập Phiếu");
            

            // Ánh xạ dữ liệu từ danh sách vào DataGridView
            foreach (QuanLyNhapHang_DTO phieuNhap in list_PN)
            {
                dtgvDanhSachPhieuNhap.Rows.Add(
                    phieuNhap.MaPhieuNhap,
                    phieuNhap.MaNV,
                    phieuNhap.NgayLapPhieu,
                    phieuNhap.TrangThaiPN
                );
            }

            AdjustDataGridViewColumns();
        }

        private void InitializeDataGridViewColumns()
        {
            // Xác định số cột và tên cột
            string[] columnNames = {"MaCTPN","MaPhieuNhap","MaSP","TenSP","SoLuongNhap" };

            // Thêm cột vào DataGridView và cấu hình AutoSizeMode
            foreach (string columnName in columnNames)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.Name = columnName;
                column.HeaderText = columnName;
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Cấu hình giãn đều

                dtgvChiTietPhieuNhap.Columns.Add(column);
            }
        }


        private void dataPN_load()
        {
            dtgvDanhSachPhieuNhap.SelectionChanged += dtgvDanhSachPhieuNhap_SelectionChanged;
            dtgvDanhSachPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvDanhSachPhieuNhap.ReadOnly = true;
            LoadDataToDataGridView();
        }
        private void dtgvDanhSachPhieuNhap_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvDanhSachPhieuNhap.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgvDanhSachPhieuNhap.SelectedRows[0];

                // Sử dụng tên cột chính xác để truy xuất giá trị từ ô
                ql_NhapHang_DTO.MaPhieuNhap = Convert.ToInt32(selectedRow.Cells["MaPhieuNhap"].Value);
                ql_NhapHang_DTO.MaNV = Convert.ToInt32(selectedRow.Cells["MaNV"].Value);
                ql_NhapHang_DTO.NgayLapPhieu = Convert.ToDateTime(selectedRow.Cells["NgayLapPhieu"].Value);
                

                ql_NhapHang_DTO.MaPhieuNhap = ql_NhapHang_DTO.MaPhieuNhap;
                HienThiChiTietPhieuNhap();
                
            }
        }


        private void HienThiChiTietPhieuNhap()
        {
            // Kiểm tra và khởi tạo cột nếu chưa có
            if (dtgvChiTietPhieuNhap.Columns.Count == 0)
            {
                InitializeDataGridViewColumns();
            }
            else
            {
                // Nếu có cột, xóa cả dòng và cột
                dtgvChiTietPhieuNhap.Rows.Clear();
                dtgvChiTietPhieuNhap.Columns.Clear();
                InitializeDataGridViewColumns(); // Khởi tạo lại cột sau khi xóa
            }

            DataTable dt = phieuNhap_DAO.LayDanhSachChiTietPhieuNhap(ql_NhapHang_DTO);

            foreach (DataRow row in dt.Rows)
            {
                dtgvChiTietPhieuNhap.Rows.Add(
                    row["MaCTPN"],
                    row["MaPhieuNhap"],
                    row["MaSP"],
                    row["TenSP"],
                    row["SoLuongNhap"]
                );
            }
        }

        private void txtTimKiemQLPN_TextChanged(object sender, EventArgs e)
        {
            TimKiemPhieuNhap();
        }

        private void cbTimKiemQLPN_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiemPhieuNhap();
        }

        private void dateTimePickerTuNgay_ValueChanged(object sender, EventArgs e)
        {
            TimKiemPhieuNhap();
        }

        private void dateTimePickerDenNgay_ValueChanged(object sender, EventArgs e)
        {
            TimKiemPhieuNhap();
        }

        private void TimKiemPhieuNhap()
        {
            // Lấy thông tin tìm kiếm từ ô nhập và combobox
            string tuKhoa = txtTimKiemQLPN.Text.Trim();
            string loaiTimKiem = cbTimKiemQLPN.SelectedItem?.ToString();
            DateTime tuNgay = dateTimePickerTuNgay.Value;
            DateTime denNgay = dateTimePickerDenNgay.Value;

            // Kiểm tra xem đã chọn loại tìm kiếm chưa
            if (string.IsNullOrEmpty(loaiTimKiem))
                return;

            // Thực hiện tìm kiếm và cập nhật DataGridView
            List<QuanLyNhapHang_DTO> ketQuaTimKiem = new List<QuanLyNhapHang_DTO>();

            // Xóa tất cả các cột hiện tại và dữ liệu trong DataGridView
            dtgvDanhSachPhieuNhap.Columns.Clear();
            dtgvDanhSachPhieuNhap.Rows.Clear();

            // Thêm các cột mới vào DataGridView
            dtgvDanhSachPhieuNhap.Columns.Add("MaPhieuNhap", "Mã Phiếu Nhập");
            dtgvDanhSachPhieuNhap.Columns.Add("MaNV", "Mã Nhân Viên");
            dtgvDanhSachPhieuNhap.Columns.Add("NgayLapPhieu", "Ngày Lập Phiếu");
            
            AdjustDataGridViewColumns();

            switch (loaiTimKiem)
            {
                case "Tất cả":
                    ketQuaTimKiem = phieuNhap_DAO.TimKiemPhieuNhapTatCa(tuKhoa);
                    break;
                case "Mã Nhân Viên":
                    ketQuaTimKiem = phieuNhap_DAO.TimKiemPhieuNhapTheoMaNhanVien(tuKhoa);
                    break;

                case "Lọc Theo Ngày Lập Phiếu":
                    ketQuaTimKiem = phieuNhap_DAO.TimKiemPhieuNhapTheoNgayLapPhieu(tuNgay, denNgay);
                    break;


                // Thêm các trường hợp tìm kiếm khác ở đây nếu cần
                default:
                    break;
            }

            // Cập nhật DataGridView với kết quả tìm kiếm
            foreach (var item in ketQuaTimKiem)
            {
                dtgvDanhSachPhieuNhap.Rows.Add(item.MaPhieuNhap, item.MaNV, item.NgayLapPhieu, item.TrangThaiPN);
            }
        }


        private void LoadDataToComBoBoxTimKiem()
        {
            cbTimKiemQLPN.Items.Add("Tất cả");
            cbTimKiemQLPN.Items.Add("Mã Nhân Viên");
            cbTimKiemQLPN.Items.Add("Lọc Theo Ngày Lập Phiếu");
            
            if (cbTimKiemQLPN.Items.Count > 0)
            {
                cbTimKiemQLPN.SelectedIndex = 0;
            }
        }


    }
}
