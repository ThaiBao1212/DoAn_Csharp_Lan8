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

        // In FormTimKhachHang
        private void btnOK_Click(object sender, EventArgs e)
        {
            // Set the DialogResult to OK
            DialogResult = DialogResult.OK;

            // Assign values to the properties
            SelectedMaKhachHang = "SomeValue"; // Replace with the actual value
            SelectedTenKhachHang = "SomeName"; // Replace with the actual value

            // Close the form
            Close();
        }

        private void dtgTimKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            // Check if there is a selected row
            if (dtgTimKhachHang.SelectedRows.Count > 0)
            {
                // Get the selected customer's name from the DataGridView
                string tenKhachHang = dtgTimKhachHang.SelectedRows[0].Cells["TenKhachHang"].Value?.ToString();

                if (!string.IsNullOrEmpty(tenKhachHang))
                {
                    // Pass the selected name to FormBanHang
                    FormBanHang formBanHang = Application.OpenForms["FormBanHang"] as FormBanHang;
                    if (formBanHang != null)
                    {
                        formBanHang.UpdateSelectedCustomerName(tenKhachHang);
                    }
                }
            }
        }
    }
}
