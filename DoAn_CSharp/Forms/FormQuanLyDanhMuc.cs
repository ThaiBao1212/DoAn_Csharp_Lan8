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

    
    }
    

}
