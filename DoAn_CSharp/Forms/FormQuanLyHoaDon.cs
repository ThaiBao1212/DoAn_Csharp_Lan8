using DoAn_CSharp.DAO;
using DoAn_CSharp.Databsase;
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
 
        private DAO.QuanLyHoaDon_DAO ql_hoadon_DAO = new DAO.QuanLyHoaDon_DAO();
        private DTO.QuanLyHoaDon_DTO ql_hoadon_DTO = new DTO.QuanLyHoaDon_DTO();
        private DTO.QuanLyChiTietHoaDon_DTO quanLyChiTietHoaDon_DTO = new DTO.QuanLyChiTietHoaDon_DTO();
        private DAO.QuanLyChiTietHoaDon_DAO quanLyChiTietHoaDon_DAO = new DAO.QuanLyChiTietHoaDon_DAO();
        public FormQuanLyHoaDon()
        {
            InitializeComponent();
            HienThiHoaDon();
            dtgvDanhSachHoaDon.SelectionChanged += dtgvDanhSachHoaDon_SelectionChanged;


        }

        private void FormQuanLyHoaDon_Load(object sender, EventArgs e)
        {

            this.reportViewerHoaDon.RefreshReport();
        }
        private void HienThiHoaDon()
        {
            DataTable dt = ql_hoadon_DAO.LayDanhSachHoaDon();
            dtgvDanhSachHoaDon.Rows.Clear();
            foreach (DataRow row in dt.Rows) {
                dtgvDanhSachHoaDon.Rows.Add(row.ItemArray);
            }

        }
        private void dtgvDanhSachHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvDanhSachHoaDon.SelectedRows.Count > 0)
            {
                int maHD = Convert.ToInt32(dtgvDanhSachHoaDon.SelectedRows[0].Cells["MaHD"].Value);
                quanLyChiTietHoaDon_DTO.MaHD = maHD;
                HienThiChiTietHD();
            }
        }
        private void HienThiChiTietHD()
        {
            // Xóa tất cả dữ liệu hiện tại trong dtgvChiTietHD
            dtgvChiTietHD.Rows.Clear();

            // Lấy danh sách chi tiết hóa đơn theo mã hóa đơn
            DataTable dt = quanLyChiTietHoaDon_DAO.LayDanhSachChiTietDH(quanLyChiTietHoaDon_DTO);

            // Thêm dữ liệu vào dtgvChiTietHD
            foreach (DataRow row in dt.Rows)
            {
                dtgvChiTietHD.Rows.Add(row.ItemArray);
            }
        }


    }
}
