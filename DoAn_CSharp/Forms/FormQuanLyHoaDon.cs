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
        private Database db;
        private DAO.QuanLyHoaDon_DAO ql_hoadon_DAO = new DAO.QuanLyHoaDon_DAO();
        private DTO.QuanLyHoaDon_DTO ql_hoadon_DTO = new DTO.QuanLyHoaDon_DTO();
        private DTO.QuanLyChiTietHoaDon_DTO quanLyChiTietHoaDon_DTO = new DTO.QuanLyChiTietHoaDon_DTO();

        public FormQuanLyHoaDon()
        {
            InitializeComponent();
            HienThiHoaDon();
            HienThiChiTietHD();
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
        private void HienThiChiTietHD()
        {
            DataTable dt = ql_hoadon_DAO.LayDanhSachChiTietDH();
            dtgvChiTietHD.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dtgvChiTietHD.Rows.Add(row.ItemArray);
            }

        }


    }
}
