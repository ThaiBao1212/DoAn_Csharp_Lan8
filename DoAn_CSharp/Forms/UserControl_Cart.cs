using DoAn_CSharp.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DoAn_CSharp.Forms
{
    // Modify your UserControl_Cart class
    public partial class UserControl_Cart : UserControl
    {
        public string ProductId { get; set; }
        public string SizeId { get; set; } // Add this property to store the size ID

        private DAO.QuanLyBanHang_DAO quanLyBanHang_DAO = new QuanLyBanHang_DAO();

        public int Quantity { get; set; } // Assuming you have a property like this

        // Existing code...

        // Constructor that initializes properties
        public UserControl_Cart(string productId, string tenSP, string donGia, string idSize, string quantity)
        {
            InitializeComponent();
            this.ProductId = productId;
            this.SizeId = idSize; // Assign the size ID
            lblTenSP.Text = tenSP;
            lblGia.Text = donGia;
            numericUpDownSoLuong.Text = quantity;

            // Load size options into cbSizes
            LoadSizes(); // Add this method to load size options

            cbSizes.DisplayMember = "TenSize";
            cbSizes.ValueMember = "MaSize";
            cbSizes.SelectedValue = idSize; // Set the selected value
        }


      
        private void LoadSizes()
        {
            try
            {
                // Assuming quanLyBanHang_DAO.LayDanhSachSizes() returns a DataTable
                DataTable dt = quanLyBanHang_DAO.LayDanhSachSizes();

                // Check if the DataTable is not null
                if (dt != null)
                {
                    cbSizes.Items.Clear();
                    // Set the DataSource for cbSizes and specify display and value members
                    cbSizes.DataSource = dt;
                    cbSizes.DisplayMember = "TenSize";
                    cbSizes.ValueMember = "MaSize";

                }
                else
                {
                    // Handle the case where the DataTable is null
                    MessageBox.Show("Error loading sizes.");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        public void UpdateQuantity(int newQuantity)
        {
            // Update the control to display the new quantity
            numericUpDownSoLuong.Value = newQuantity;
        }

        private void tbnXoa_Click(object sender, EventArgs e)
        {
            var parentContainer = this.Parent;

            // Check if the parent container is the flowLayoutPanel_Cart
            if (parentContainer is FlowLayoutPanel flowLayoutPanel)
            {
                // Remove this UserControl_Cart from the flowLayoutPanel
                flowLayoutPanel.Controls.Remove(this);
            }

        }



        // Existing code...
    }

}
