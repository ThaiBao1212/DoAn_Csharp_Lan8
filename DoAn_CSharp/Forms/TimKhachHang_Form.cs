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
    }
}
