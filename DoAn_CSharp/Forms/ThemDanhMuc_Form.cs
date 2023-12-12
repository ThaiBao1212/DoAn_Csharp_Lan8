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
    public partial class ThemDanhMuc_Form : Form
    {
        public ThemDanhMuc_Form()
        {
            InitializeComponent();
        }
        private DAO.QuanLyDanhMuc_DAO ql_danhmuc_DAO = new DAO.QuanLyDanhMuc_DAO();
        private DTO.QuanLyDanhMuc_DTO ql_danhmuc_DTO = new DTO.QuanLyDanhMuc_DTO();

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTenDanhMuc.Text))
                {
                    MessageBox.Show("Vui lòng nhập đúng thông tin danh mục.");
                    return;
                }
                ql_danhmuc_DTO.tenDM = txtTenDanhMuc.Text;

                ql_danhmuc_DAO.ThemDanhMuc(ql_danhmuc_DTO);


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }



    }
}
