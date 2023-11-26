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
   
    public partial class FormQuanLyDanhMuc : Form
    {
        private Databsase.Database db;
        private DAO.QuanLyDanhMuc_DAO ql_danhmuc_DAO = new DAO.QuanLyDanhMuc_DAO();
        private DTO.QuanLyDanhMuc_DTO ql_danhmuc_DTO = new DTO.QuanLyDanhMuc_DTO();

        public FormQuanLyDanhMuc()
        {
            InitializeComponent();
            HienThiDanhMuc();
        }
        private void HienThiDanhMuc()
        {

            DataTable dt = ql_danhmuc_DAO.LayDanhSachDanhMuc();
            dtgvDanhSachDanhMuc.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dtgvDanhSachDanhMuc.Rows.Add(row.ItemArray);
            }

        }
        private void Setnull()
        {
            txtMaDanhMuc.Text = "";
            txtTenDanhMuc.Text = "";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Setnull();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {

        }

        private void dtgvDanhSachDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
               DataGridViewRow selectedRow = dtgvDanhSachDanhMuc.Rows[e.RowIndex];
                txtMaDanhMuc.Text = selectedRow.Cells["MaDanhMuc"].Value.ToString();
                txtTenDanhMuc.Text = selectedRow.Cells["TenDM"].Value.ToString();

            }

        }
    }
    

}
