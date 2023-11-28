using DoAn_CSharp.DAO;
using DoAn_CSharp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace DoAn_CSharp.Forms
{
    public partial class FormBanHang : Form
    {
        private DTO.QuanLySanPham_DTO quanLySanPham_DTO = new DTO.QuanLySanPham_DTO();
        private DAO.QuanLySanPham_DAO quanLySanPham_DAO = new DAO.QuanLySanPham_DAO();

        private DTO.QuanLyDanhMuc_DTO ql_danhmuc_DTO = new DTO.QuanLyDanhMuc_DTO();
        private DAO.QuanLyDanhMuc_DAO ql_danhmuc_DAO = new DAO.QuanLyDanhMuc_DAO();

        private DTO.QuanLyNhaCungCap_DTO quanLyNhaCungCap_DTO = new DTO.QuanLyNhaCungCap_DTO();
        private DAO.QuanLyNhaCungCap_DAO quanLyNhaCungCap_DAO = new DAO.QuanLyNhaCungCap_DAO();
        private DAO.QuanLyBanHang_DAO quanLyBanHang_DAO = new QuanLyBanHang_DAO();

        private List<ShoppingCartItem_DTO> shoppingCart = new List<ShoppingCartItem_DTO>();
        public FormBanHang()
        {
            InitializeComponent();
            HienThiDanhSachSanPhamfull();
            LoadDanhMucToComboBox();
            cbLocDanhMuc.SelectedIndexChanged += CbLocDanhMuc_SelectedIndexChanged;

   





        }

        private void CbLocDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiDanhSachSanPham();


        }

        private void LoadDanhMucToComboBox()
        {
            DataTable dt = ql_danhmuc_DAO.LayDanhSachDanhMuc();
            cbLocDanhMuc.DisplayMember = "TenDM"; 
            cbLocDanhMuc.ValueMember = "MaDanhMuc";
            cbLocDanhMuc.DataSource = dt;
      
        }

        private void HienThiDanhSachSanPhamfull()
        {
            List<QuanLySanPham_DTO> danhSachSanPham = quanLySanPham_DAO.LayDanhSachSanPhamBan();

            // Clear controls trong groupBox1 trước khi thêm dữ liệu mới
            flowLayoutPanelProducts_item.Controls.Clear();

            foreach (QuanLySanPham_DTO sanPham in danhSachSanPham)
            {
                // Create an instance of UserControlProduct_item for each product
                var productItem = new UserControlProduct_item(
                    sanPham.MaSP.ToString(),
                    sanPham.TenSP,
                    sanPham.DonGia.ToString("C"),
                    sanPham.AnhSP
                );

                // Subscribe to the ProductClick event
                productItem.ProductClick += ProductItem_ProductClick;

                // Add the UserControlProduct_item to the FlowLayoutPanel
                flowLayoutPanelProducts_item.Controls.Add(productItem);
            }
        }

        private void ProductItem_ProductClick(object sender, EventArgs e)
        {
            // Handle the product click event here
            if (sender is UserControlProduct_item productItem)
            {
                // Use int.TryParse for safe parsing
                if (int.TryParse(productItem.ProductId, out int maSP))
                {
                    quanLySanPham_DTO.MaSP = maSP;
                    ChiTietSanPham();
                }
                else
                {
                    // Handle the case where parsing fails
                    MessageBox.Show("Invalid Product ID");
                }
            }
        }

        private void ChiTietSanPham()
        {
  
            QuanLySanPham_DTO productDetails = quanLySanPham_DAO.LayChiTietSanPham(quanLySanPham_DTO.MaSP);

            if (productDetails != null)
            {
                // Update your UI controls with the details

                txtMaSanPham.Text = productDetails.MaSP.ToString();
                txtSanPham.Text = productDetails.TenSP.ToString();
                txtTenNhaCungCap.Text = productDetails.TenNCC.ToString();
                txtTenDanhMuc.Text = productDetails.TenDM.ToString();
      
                txtSoLuong.Text = productDetails.SoLuongSP.ToString();

                txtSize.Text = productDetails.SizeSP;
                txtDonGia.Text = productDetails.DonGia.ToString("C");

                // Load the image from resources and update PictureBox
                picAnhChiTietSanPham.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(productDetails.AnhSP);
                picAnhChiTietSanPham.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                // Handle the case where product details are not available
                MessageBox.Show("Product details not found");
            }
        }


        private void HienThiDanhSachSanPham()
        {
            // Get the selected value of cbLocDanhMuc
            flowLayoutPanelProducts_item.Controls.Clear();


            int maDanhMuc = Convert.ToInt32(cbLocDanhMuc.SelectedValue);

            // Call LayDanhSachSanPhamDanhMuc with the selected MaDanhMuc
            List<QuanLyBanHang_DTO> danhSachSanPham = quanLyBanHang_DAO.LayDanhSachSanPhamDanhMuc(maDanhMuc);

            foreach (QuanLyBanHang_DTO sanPham in danhSachSanPham)
            {
                var productItem = new UserControlProduct_item(
                    sanPham.MaSP.ToString(),
                    sanPham.TenSP,
                    sanPham.DonGia.ToString("C"),
                    sanPham.AnhSP
                );
                productItem.ProductClick += ProductItem_ProductClick;

                flowLayoutPanelProducts_item.Controls.Add(productItem);
            }
        }
        private void tbtGioHang_Click(object sender, EventArgs e)
        {
            string productId = txtMaSanPham.Text;
            string productName = txtSanPham.Text;

            // Try to parse the price, handle invalid input
            if (!decimal.TryParse(txtDonGia.Text, out decimal price))
            {
                MessageBox.Show("Invalid price format.");
                return;
            }

            // Check if the product is already in the shopping cart
            var existingItem = shoppingCart.FirstOrDefault(item => item.ProductId == productId);

            if (existingItem != null)
            {
                // Product already in cart, increase quantity
                existingItem.Quantity++;
                // Update the corresponding UserControl_Cart
                UpdateCartUI(existingItem);
            }
            else
            {
                // Product not in cart, add a new item
                var newItem = new ShoppingCartItem_DTO
                {
                    ProductId = productId,
                    ProductName = productName,
                    Quantity = 1,
                    Price = price
                };

                // Add the new item to the shopping cart
                shoppingCart.Add(newItem);

                // Create a new UserControl_Cart
                var cart = new UserControl_Cart();
                // Set information using properties or methods
                cart.ProductId = newItem.ProductId;
                cart.ProductName = newItem.ProductName;
                cart.Quantity = newItem.Quantity;
                cart.Sizes = newItem.Size;
                cart.Price = newItem.Price;

                // Add the UserControl_Cart to the flowLayoutPanel_Cart
                flowLayoutPanel_Cart.Controls.Add(cart);
            }
        }

        private void UpdateCartUI(ShoppingCartItem_DTO item)
        {
            var cartControl = flowLayoutPanel_Cart.Controls.OfType<UserControl_Cart>()
                .FirstOrDefault(cart => cart.ProductId == item.ProductId && cart.Sizes == item.Size);

            if (cartControl != null)
            {
                cartControl.Quantity = item.Quantity;
            }
        }






    }
}
