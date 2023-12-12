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
    public partial class FormQuanLyHoaDon : Form
    {
        public FormQuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void FormQuanLyHoaDon_Load(object sender, EventArgs e)
        {

            this.reportViewerHoaDon.RefreshReport();
            LoadDataToDataGridView();
        }

        private QuanLyHoaDon_DTO ql_HoaDon_DTO = new QuanLyHoaDon_DTO();
        private QuanLyHoaDon_DAO hoaDon_DAO = new QuanLyHoaDon_DAO();
        private ChiTietHoaDon_DTO chiTietHD_DTO = new ChiTietHoaDon_DTO();
        private void AdjustDataGridViewColumns()
        {
            // Tự động canh chỉnh kích thước của các cột để fill DataGridView
            foreach (DataGridViewColumn column in dtgvDanhSachHoaDon.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void LoadDataToDataGridView()
        {
            List<QuanLyHoaDon_DTO> list_HD = hoaDon_DAO.GetHoaDon();

            // Xóa các cột hiện tại trong DataGridView
            dtgvDanhSachHoaDon.Columns.Clear();

            // Thêm các cột mới vào DataGridView
            dtgvDanhSachHoaDon.Columns.Add("MaHD", "Mã Hóa Đơn");
            dtgvDanhSachHoaDon.Columns.Add("MaNV", "Mã Nhân Viên");
            dtgvDanhSachHoaDon.Columns.Add("MaKH", "Mã Khách Hàng");
            dtgvDanhSachHoaDon.Columns.Add("NgayLapHD", "Ngày Lập HD");


            // Ánh xạ dữ liệu từ danh sách vào DataGridView
            foreach (QuanLyHoaDon_DTO hoadon in list_HD)
            {
                dtgvDanhSachHoaDon.Rows.Add(
                    hoadon.MaHD,
                    hoadon.MaNV,
                    hoadon.MaKH,
                    hoadon.NgayLapHD
                    
                );
            }

            AdjustDataGridViewColumns();
        }


        private void InitializeDataGridViewColumns()
        {
            // Xác định số cột và tên cột
            string[] columnNames = { "MaSP", "TenSP", "SizeSP", "SoLuongSP", "DonGia" , "ThanhTien" };

            // Thêm cột vào DataGridView và cấu hình AutoSizeMode
            foreach (string columnName in columnNames)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.Name = columnName;
                column.HeaderText = columnName;
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Cấu hình giãn đều

                dtgvChiTietHoaDon.Columns.Add(column);
            }
        }


        private void HienThiChiTietHoaDon()
        {
            // Kiểm tra và khởi tạo cột nếu chưa có
            if (dtgvChiTietHoaDon.Columns.Count == 0)
            {
                InitializeDataGridViewColumns();
            }
            else
            {
                // Nếu có cột, xóa cả dòng và cột
                dtgvChiTietHoaDon.Rows.Clear();
                dtgvChiTietHoaDon.Columns.Clear();
                InitializeDataGridViewColumns(); // Khởi tạo lại cột sau khi xóa
            }

            DataTable dt = hoaDon_DAO.GetChiTietHoaDon(chiTietHD_DTO);

            foreach (DataRow row in dt.Rows)
            {
                dtgvChiTietHoaDon.Rows.Add(
                    row["MaSP"],
                    row["TenSP"],
                    row["SizeSP"],
                    row["SoLuongSP"],
                    row["DonGia"],
                    row["ThanhTien"]
                );
            }
        }

        private void dtgvDanhSachHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            /*if (dtgvDanhSachHoaDon.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgvDanhSachHoaDon.SelectedRows[0];

                // Sử dụng tên cột chính xác để truy xuất giá trị từ ô
                ql_HoaDon_DTO.MaHD = Convert.ToInt32(selectedRow.Cells["MaPhieuNhap"].Value);
                ql_HoaDon_DTO.MaNV = Convert.ToInt32(selectedRow.Cells["MaNV"].Value);
                ql_HoaDon_DTO.NgayLapPhieu = Convert.ToDateTime(selectedRow.Cells["NgayLapPhieu"].Value);


                ql_NhapHang_DTO.MaPhieuNhap = ql_NhapHang_DTO.MaPhieuNhap;
                HienThiChiTietPhieuNhap();

            }*/
        }

    }
}
