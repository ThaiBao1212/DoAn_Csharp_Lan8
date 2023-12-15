using DoAn_CSharp.DAO;
using DoAn_CSharp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Drawing;
using MessageBox = System.Windows.Forms.MessageBox;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using DoAn_CSharp.Database;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows;


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
        private DTO.QuanLyBanHang_DTO quanLyBanHang_DTO = new QuanLyBanHang_DTO();

        private DAO.GiamGia_DAO giamGia_DAO= new DAO.GiamGia_DAO();
        private DTO.GiamGia_DTO giamGia_DTO = new DTO.GiamGia_DTO();
    
        private List<ShoppingCartItem_DTO> shoppingCart = new List<ShoppingCartItem_DTO>();



        private Account_DTO loginAccount;

        private string maKhachHang;
        private QuanLyChiTietHoaDon_DAO chiTietHoaDonDAO = new QuanLyChiTietHoaDon_DAO();
        private QuanLyHoaDon_DAO hoaDonDAO = new QuanLyHoaDon_DAO();

        public Account_DTO LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; /* Optionally, perform additional actions when the login account is set */ }
        }




        public FormBanHang(Account_DTO acc)
        {
            InitializeComponent();
            HienThiDanhSachSanPhamfull();
            LoadDanhMucToComboBox();

            cbLocDanhMuc.SelectedIndexChanged += CbLocDanhMuc_SelectedIndexChanged;

            this.LoginAccount = acc;
            lblnhanvienbanhang.Text = " " + LoginAccount.HoTenNV;

            cbGiamGia.SelectedIndexChanged += cbGiamGia_SelectedIndexChanged;



        }

        private void CbLocDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiDanhSachSanPham();


        }
        private void LoadGiamGia()
        {
            // Assuming you have a GiamGia_DTO object with proper values
           
        }


        private void LoadDanhMucToComboBox()
        {
            DataTable dt = ql_danhmuc_DAO.LayDanhSachDanhMuc();
            cbLocDanhMuc.DisplayMember = "TenDM";
            cbLocDanhMuc.ValueMember = "MaDanhMuc";
            cbLocDanhMuc.DataSource = dt;

        }
        private void LoadSiseToComboBox()
        {
            DataTable dt = quanLyBanHang_DAO.LayDanhSachSizes();
            cbSizes.DisplayMember = "TenSize";
            cbSizes.ValueMember = "MaSize";
            cbSizes.DataSource = dt;

        }

        private void HienThiDanhSachSanPhamfull()
        {
            List<QuanLySanPham_DTO> danhSachSanPham = quanLySanPham_DAO.LayDanhSachSanPhamBan();

            // Check if danhSachSanPham is null
            if (danhSachSanPham != null)
            {
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
            else
            {
                // Handle the case where danhSachSanPham is null (e.g., display a message)
                MessageBox.Show("No products available.");
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
                    cbSizes.SelectedIndexChanged += cbSizes_SelectedIndexChanged;
                    LoadSiseToComboBox();
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
                txtDonGia.Text = productDetails.DonGia.ToString("C");


                string imageFolderPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "Image");


                if (Directory.Exists(imageFolderPath))
                {
                    // Nếu tồn tại, hiển thị một hình ảnh cụ thể (đây chỉ là một ví dụ)
                    string imageName = productDetails.AnhSP; // Thay thế bằng tên thực của hình ảnh
                    string imagePath = Path.Combine(imageFolderPath, imageName);

                    if (File.Exists(imagePath))
                    {
                        // Load và hiển thị hình ảnh
                        picAnhChiTietSanPham.Image = Image.FromFile(imagePath);
                        picAnhChiTietSanPham.SizeMode = PictureBoxSizeMode.Zoom;

                        // Adjust the PictureBox size to the image size
                        picAnhChiTietSanPham.Size = new System.Drawing.Size(212, 114);

                    }
                    else
                    {
                        MessageBox.Show("Image not found in the 'Image' folder.");
                    }
                }
                else
                {
                    MessageBox.Show("The 'Image' folder does not exist.");
                }

            }
            else
            {
                // Handle the case where product details are not available
                MessageBox.Show("Product details not found222");
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
            object selectedValue = cbSizes.SelectedValue;
            string soluongproduct = txtSoLuong.Text;

            // Check if a product is selected
            if (selectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.");
                return;
            }

            string sizeId = selectedValue.ToString();

            // Check if productId or sizeId is null
            if (productId == null || sizeId == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
                return;
            }
            // Check if quantity is not positive
            if (!int.TryParse(soluongproduct, out int soluong) || soluong <= 0)
            {
                MessageBox.Show("Số Lượng sản Phẩm đã hết.");
                return;
            }

            var existingCartControl = flowLayoutPanel_Cart.Controls
                .OfType<UserControl_Cart>()
                .FirstOrDefault(cart => cart.ProductId == productId && cart.SizeId == sizeId);

            if (existingCartControl != null)
            {
                existingCartControl.Quantity += 1;
                existingCartControl.UpdateQuantity(existingCartControl.Quantity);
            }
            else
            {
                var cart = new UserControl_Cart(
                    productId,
                    txtSanPham.Text,
                    decimal.Parse(txtDonGia.Text.Replace("₫", ""), System.Globalization.NumberStyles.Currency),

                    sizeId,
                    1
                );

                cart.QuantityChanged += (s, eventArgs) =>
                {
                    UpdateTotal();
                    UpdateDiscount();  // Add this line to recalculate discount when quantity changes
                };

                flowLayoutPanel_Cart.Controls.Add(cart);
            }
            LoadDiscountCodes();
                UpdateTotal();
            UpdateDiscount();  // Add this line to recalculate discount when adding a new item to the cart
                               // Calculate and display the total
            decimal tongTien = decimal.Parse(txtTamTinh.Text.Replace("₫", ""), System.Globalization.NumberStyles.Currency);
        }

        private List<GiamGia_DTO> danhSachGiamGia;

        // Call this method when your form is initialized to load discount codes initially
        private void UpdateDiscount()
        {

            decimal total = decimal.Parse(txtTamTinh.Text.Replace("₫", ""), System.Globalization.NumberStyles.Currency);
            decimal tongTien = decimal.Parse(txtTamTinh.Text.Replace("₫", ""), System.Globalization.NumberStyles.Currency);

            // Check if an item is selected in the cbGiamGia combo box
            if (cbGiamGia.SelectedItem is GiamGia_DTO selectedDiscount)
            {
                decimal phanTramGiam = selectedDiscount.PhanTramGiam;
                decimal tienGiam = total * phanTramGiam / 100;
                decimal tongTienSauGiam = total - tienGiam;

                // Update the combo box text, and corresponding text boxes
                cbGiamGia.Text = selectedDiscount.TenGiamGia;
                txtTienGiam.Text = tienGiam.ToString("C");
                txtTongTien.Text = tongTienSauGiam.ToString("C");
            }
            else
            {
                // If no item is selected, reset to default values
                cbGiamGia.Text = "Không Giảm Giá 11  ";
                txtTienGiam.Text = "₫0";
                txtTongTien.Text = total.ToString("C");
            }
        }

        private void cbGiamGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDiscount();
        }



        private void UpdateTotal()
        {
            decimal total = 0;

            foreach (UserControl_Cart cartControl in flowLayoutPanel_Cart.Controls)
            {
                decimal price = decimal.Parse(cartControl.LblGia.Text.Replace("₫", ""));
                total += price * cartControl.Quantity;
            }
            txtTamTinh.Text = total.ToString("C");
    
            UpdateDiscount();
         

        }
       

        private void LoadDiscountCodes()
        {
            UpdateTotal();
            try
            {
                // Retrieve the total amount to check for applicable discounts
                decimal tongTien = decimal.Parse(txtTamTinh.Text.Replace("₫", ""), System.Globalization.NumberStyles.Currency);
          

     
                // Get the list of applicable discount codes
                List<GiamGia_DTO> danhSachGiamGia = quanLyBanHang_DAO.LayDanhSachGiamGiaHieuLuc()
                    .Where(gg => gg.DieuKienGiamGia <= tongTien && gg.SoLuongGG > 0 && gg.NgayBatDau <= DateTime.Now && gg.NgayKetThuc >= DateTime.Now)
                    .ToList();

                if (danhSachGiamGia.Any())
                {
                    // Bind the list of discount codes to cbGiamGia
                    cbGiamGia.DisplayMember = "TenGiamGia";
                    cbGiamGia.ValueMember = "MaGiamGia";
                    cbGiamGia.DataSource = danhSachGiamGia;
                }
                else
                {
                    // No applicable discount codes, display a message
                    cbGiamGia.Text = "Không có mã giảm giá";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading discount codes: {ex.Message}");
            }
        }


        public void HandleCartItemRemoved(UserControl_Cart removedCart)
        {
            // Xóa UserControl_Cart khỏi FlowLayoutPanel
            flowLayoutPanel_Cart.Controls.Remove(removedCart);

            // Cập nhật tổng tiền sau khi xóa sản phẩm
            UpdateTotal();
        }
        private void UserControl_Cart_QuantityChanged(object sender, EventArgs e)
        {
            // Khi giá trị của numericUpDownSoLuong trong UserControl_Cart thay đổi,
            // cập nhật tổng tiền
            UpdateTotal();
        }
        private void cbSizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string productId = txtMaSanPham.Text;
                int selectedSizeId = Convert.ToInt32(cbSizes.SelectedValue);  // Rename 'maSP' to 'selectedSizeId'

                // Create a QuanLyBanHang_DTO object with the necessary information
                QuanLyBanHang_DTO quanLyBanHang_DTO = new QuanLyBanHang_DTO
                {
                    MaSP = Convert.ToInt32(productId),
                    MaSize = selectedSizeId  // Rename 'maSP' to 'selectedSizeId'
                };

                // Call the DAO method to get the quantity of the product for the selected size
                int newQuantity = quanLyBanHang_DAO.LaySoLuongSanPhamSize(quanLyBanHang_DTO);
                if (newQuantity > 0)
                {
                    txtSoLuong.Text = newQuantity.ToString();
                }
                else
                {
                    txtSoLuong.Text = "Sản phẩm Đã hết ";
                }

                // Update txtSoLuong with the new quantity

            }
            catch (Exception ex)
            {
                // Handle exception
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void UpdateSelectedCustomerName(string tenKhachHang)
        {
            txtTenKhachHang.Text = tenKhachHang;
        }


        private void btnTimKhachHang_Click(object sender, EventArgs e)
        {
            // Create an instance of FormTimKhachHang
            using (var timKhachHang_Form = new TimKhachHang_Form())
            {
                // Show FormTimKhachHang as a dialog
                DialogResult result = timKhachHang_Form.ShowDialog();

                // Check if the user clicked OK in FormTimKhachHang
                if (result == DialogResult.OK)
                {
                    // Retrieve the selected customer information
                    maKhachHang = timKhachHang_Form.SelectedMaKhachHang;
                    string tenKhachHang = timKhachHang_Form.SelectedTenKhachHang;

                    // Update the txtTenKhachHang in FormBanHang
                    txtTenKhachHang.Text = tenKhachHang;

                    // Optionally, you can also use the maKhachHang for further processing if needed
                    // ...
                }
            }
        }

        private void txtTienGiam_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maKhachHang))
            {
                MessageBox.Show("Vui lòng chọn khách hàng trước khi thanh toán.");
                return;
            }

            if (!int.TryParse(maKhachHang, out int maKH))
            {
                MessageBox.Show("Invalid customer ID format.");
                return;
            }

            if (!int.TryParse(LoginAccount.MaNV, out int maNV))
            {
                MessageBox.Show("Invalid employee ID format.");
                return;
            }

            if (!int.TryParse(txtMaSanPham.Text, out int maSP))
            {
                MessageBox.Show("Invalid product ID format.");
                return;
            }

            if (!float.TryParse(txtDonGia.Text.Replace("₫", "").Trim(), out float donGia))
            {
                MessageBox.Show("Invalid product price format.");
                return;
            }

            if (!int.TryParse(txtSoLuong.Text, out int soLuongSP))
            {
                MessageBox.Show("Invalid quantity format.");
                return;
            }

            if (!float.TryParse(txtTongTien.Text.Replace("₫", "").Trim(), out float thanhTien))
            {
                MessageBox.Show("Invalid total amount format.");
                return;
            }

            try
            {
                ProcessPayment(maKH, maNV, maSP, (int)donGia, soLuongSP, thanhTien);


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing payment: {ex.Message}");
            }
        }


        private void ProcessPayment(int maKH, int maNV, int maSP, int soLuong, float donGia, float thanhTien)
        {
            try
            {
                // Create a new order (hóa đơn)
                int maHD = hoaDonDAO.InsertHoaDon(maKH, maNV);

                // Check if the order creation was successful
                if (maHD > 0)
                {
                    // Iterate through the items in the shopping cart and add order details (chi tiết hóa đơn)
                    foreach (UserControl_Cart cartControl in flowLayoutPanel_Cart.Controls)
                    {
                        int selectedMaSP = Convert.ToInt32(cartControl.ProductId);
                        int selectedMaSize = Convert.ToInt32(cartControl.SizeId); // Get the MaSize from UserControl_Cart
                        int selectedSoLuong = cartControl.Quantity;
                        int availableQuantity = quanLyBanHang_DAO.GetAvailableQuantity(selectedMaSP, selectedMaSize);

                        // Check if the selected quantity exceeds the available quantity
                        if (selectedSoLuong > availableQuantity)
                        {
                            MessageBox.Show("Số lượng sản phẩm trong giỏ hàng vượt quá số lượng tồn kho.");
                            return;
                        }
                        float selectedDonGia = float.Parse(cartControl.LblGia.Text.Replace("₫", "").Trim());
                        // Add order details for each product in the shopping cart
                        chiTietHoaDonDAO.InsertChiTietHoaDon(maHD, selectedMaSP, selectedSoLuong, selectedDonGia);

                        // Update the quantity of the product in the SanPhamSize table
                        UpdateProductQuantity(selectedMaSP, selectedMaSize, selectedSoLuong);
                    }

                    // Display a success message
                    MessageBox.Show("Đã thanh toán thành công!");

                    // Optionally, you can clear the shopping cart and update UI
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi tạo hóa đơn. Vui lòng thử lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing payment: {ex.Message}");
            }
        }
        // Inside your DAO class (QuanLyBanHang_DAO.cs or similar)
        

        private void UpdateProductQuantity(int maSP, int maSize, int soLuong)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Server=LAPTOP-PEQVO1V4\\ALINSBTC;Database=QuanLyBanGiay4;uid=sa;pwd=123"))
                {
                    connection.Open();

                    // Update the quantity of the product in the SanPhamSize table
                    SqlCommand command = new SqlCommand("UPDATE SanPhamSize SET SoLuongSP = SoLuongSP - @SelectedSoLuong WHERE MaSP = @MaSP AND MaSize = @MaSize;", connection);
                    command.Parameters.AddWithValue("@MaSP", maSP);
                    command.Parameters.AddWithValue("@MaSize", maSize);
                    command.Parameters.AddWithValue("@SelectedSoLuong", soLuong);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating product quantity: {ex.Message}");
            }
        }



        private void ClearForm()
        {

            flowLayoutPanel_Cart.Controls.Clear();
 
        }


    }
}