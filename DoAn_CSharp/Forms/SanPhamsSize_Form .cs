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
    public partial class SanPhamsSize_Form : Form
    {
        private DAO.QuanLyBanHang_DAO quanLyBanHang_DAO = new QuanLyBanHang_DAO();
        private DTO.QuanLyBanHang_DTO quanLyBanHang_DTO = new QuanLyBanHang_DTO();
        public int SelectedMaSP { get; private set; }
        public string SelectedTenSP { get; private set; }
        public int SelectedSoLuong { get; private set; }
        public string SelectedSize { get; private set; }

        // Modify the constructor to receive maSP and tenSP
        public SanPhamsSize_Form(int maSP, string tenSP)
        {
            InitializeComponent();
            LoadSiseToComboBox();

            // Set the selected data
            SelectedMaSP = maSP;
            SelectedTenSP = tenSP;
        }

        private void LoadSiseToComboBox()
        {
            DataTable dt = quanLyBanHang_DAO.LayDanhSachSizes();
            cbSizes.DisplayMember = "TenSize";
            cbSizes.ValueMember = "MaSize";
            cbSizes.DataSource = dt;

        }

        public Tuple<int, string, int, string> SelectedData { get; private set; }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Retrieve selected data from your controls
            SelectedSoLuong = (int)numericUpDownSoLuong.Value;
            SelectedSize = cbSizes.SelectedValue.ToString();

            // Close the form
            this.Close();
        }
    }
   
}
