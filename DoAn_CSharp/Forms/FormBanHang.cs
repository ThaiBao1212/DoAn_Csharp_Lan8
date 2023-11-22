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
    public partial class FormBanHang : Form
    {
        private DTO.QuanLySanPham_DTO quanLySanPham_DTO= new DTO.QuanLySanPham_DTO();
        private DAO.QuanLySanPham_DAO quanLySanPham_DAO = new DAO.QuanLySanPham_DAO();

        public FormBanHang()
        {
            InitializeComponent();
            HienThiDanhSachSanPham();
            dtgvDanhSachSanPham.SelectionChanged += DtgvDanhSachSanPham_SelectionChanged;
        }

        private void DtgvDanhSachSanPham_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvDanhSachSanPham.SelectedRows.Count > 0)
            {
                int maSP = Convert.ToInt32(dtgvDanhSachSanPham.SelectedRows[0].Cells["MaSP"].Value);
              /*  quanLySanPham_DAO.LayDanhSachChiTietSanPham();*/


            }
        }

        private void HienThiDanhSachSanPham()
        {
            DataTable dt = quanLySanPham_DAO.LayDanhSachSanPham();
            dtgvDanhSachSanPham.Rows.Clear();
            foreach (DataRow row in dt.Rows) {
                dtgvDanhSachSanPham.Rows.Add(row.ItemArray);
            }
        }


    }
}
