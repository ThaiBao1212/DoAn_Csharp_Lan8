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
        public string SizeId { get; set; }
        public Label LblGia
        {
            get { return lblGia; }
        }
        public event EventHandler CartItemRemoved;
        public event EventHandler QuantityChanged;

        private DAO.QuanLyBanHang_DAO quanLyBanHang_DAO = new QuanLyBanHang_DAO();

        public int Quantity
        {
            get { return (int)numericUpDownSoLuong.Value; }
            set { numericUpDownSoLuong.Value = value; }
        }


        public UserControl_Cart(string productId, string tenSP, decimal donGia, string idSize, int quantity)
        {
            InitializeComponent();

            this.ProductId = productId;
            this.SizeId = idSize;
            lblTenSP.Text = tenSP;
            lblGia.Text = donGia.ToString("C");

            numericUpDownSoLuong.Value = quantity;

            LoadSizes();
            cbSizes.SelectedValue = idSize;
        }


        private void LoadSizes()
        {
            try
            {
                // Assuming you have columns MaSize and SoLuongSP in your table
                DataTable dt = quanLyBanHang_DAO.LayDanhSachSizesWithQuantityGreaterThanOne(ProductId);

                if (dt != null)
                {
                    cbSizes.Items.Clear();
                    cbSizes.DataSource = dt;
                    cbSizes.DisplayMember = "TenSize";
                    cbSizes.ValueMember = "MaSize";
                }
                else
                {
                    MessageBox.Show("Error loading sizes.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        public void UpdateQuantity(int newQuantity)
        {
            numericUpDownSoLuong.Value = newQuantity;
        }
        private void XoaCartSp()
        {
            var parentForm = FindForm();

            if (parentForm is FormBanHang formBanHang)
            {
                // Gọi phương thức xử lý sự kiện xóa sản phẩm từ FormBanHang
                formBanHang.HandleCartItemRemoved(this);
            }
        }
        private void tbnXoa_Click(object sender, EventArgs e)
        {
            XoaCartSp();
        }

        private void NumericUpDownSoLuong_ValueChanged(object sender, EventArgs e)
        {
            QuantityChanged?.Invoke(this, EventArgs.Empty);

        }
    }


}
