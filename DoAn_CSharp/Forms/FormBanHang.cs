using DoAn_CSharp.DAO;
using DoAn_CSharp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Drawing;

using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using DoAn_CSharp.Database;

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


                string imageFolderPath = Path.Combine(Application.StartupPath, "Image");

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
                        picAnhChiTietSanPham.Size = new Size(212, 114);
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


                cart.QuantityChanged += (s, eventArgs) => UpdateTotal();

                flowLayoutPanel_Cart.Controls.Add(cart);
            }

            UpdateTotal();
            // Calculate and display the total
            decimal tongTien = decimal.Parse(txtTamTinh.Text.Replace("₫", ""), System.Globalization.NumberStyles.Currency);


         

          /*  // Lấy danh sách giảm giá hợp lệ
            List<GiamGia_DTO> danhSachGiamGia = quanLyBanHang_DAO.LayDanhSachGiamGiaHieuLuc();

            // Lọc danh sách giảm giá theo điều kiện và tổng tiền
            var giamGiaHieuLuc = danhSachGiamGia
                .Where(gg => gg.DieuKienGiamGia <= tongTien && 0 < gg.SoLuongGG && gg.NgayBatDau <= DateTime.Now && gg.NgayKetThuc >= DateTime.Now);
            if (giamGiaHieuLuc.Any())
            {
                GiamGia_DTO giamGia_DTO = new GiamGia_DTO();


                // Assign the parsed decimal value to the DieuKienGiamGia property
                giamGia_DTO.DieuKienGiamGia = tongTien;

                // Continue with the rest of your code...
                DataTable dt = giamGia_DAO.LayDanhSachGiamGia(giamGia_DTO);
                cbGiamGia.DisplayMember = "TenGiamGia";
                cbGiamGia.ValueMember = "MaGiamGia";
                cbGiamGia.DataSource = dt;


            }
            else
            {
                cbGiamGia.Text = "Không Giảm Giá";
            }*/

            // Calculate and display the total


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


            // Calculate and display the total
            decimal tongTien = total;

            GiamGia_DTO giamGia_DTO = new GiamGia_DTO();
            // Assign the parsed decimal value to the DieuKienGiamGia property
            giamGia_DTO.DieuKienGiamGia = tongTien;

            // Continue with the rest of your code...
            DataTable dt = giamGia_DAO.LayDanhSachGiamGia(giamGia_DTO);
            cbGiamGia.DisplayMember = "TenGiamGia";
            cbGiamGia.ValueMember = "MaGiamGia";
            cbGiamGia.DataSource = dt;

            // Lấy danh sách giảm giá hợp lệ
            List<GiamGia_DTO> danhSachGiamGia = quanLyBanHang_DAO.LayDanhSachGiamGiaHieuLuc();

            // Lọc danh sách giảm giá theo điều kiện và tổng tiền
            var giamGiaHieuLuc = danhSachGiamGia
                .Where(gg => gg.DieuKienGiamGia <= tongTien && 0 < gg.SoLuongGG && gg.NgayBatDau <= DateTime.Now && gg.NgayKetThuc >= DateTime.Now);

            if (giamGiaHieuLuc.Any())
            {
                var giamGiaToiNhat = giamGiaHieuLuc.OrderByDescending(gg => gg.PhanTramGiam).First();

                // Hiển thị thông tin giảm giá
                cbGiamGia.Text = giamGiaToiNhat.TenGiamGia;

                // Calculate and display the tiền giảm and tổng tiền
                decimal phanTramGiam = giamGiaToiNhat.PhanTramGiam;
                decimal tienGiam = total * phanTramGiam / 100;
                decimal tongTienSauGiam = total - tienGiam;

                txtTienGiam.Text = tienGiam.ToString("C");
                txtTongTien.Text = tongTienSauGiam.ToString("C");
            }
            else
            {
                cbGiamGia.Text = "Không Giảm Giá";
                txtTienGiam.Text = "₫0";
                txtTongTien.Text = total.ToString("C");
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
                int sizeId = Convert.ToInt32(cbSizes.SelectedValue);

                // Create a QuanLyBanHang_DTO object with the necessary information
                QuanLyBanHang_DTO quanLyBanHang_DTO = new QuanLyBanHang_DTO
                {
                    MaSP = Convert.ToInt32(productId),
                    MaSize = sizeId
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
                MessageBox.Show("Error:111  " + ex.Message);
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
                // Handle the case where 'maKhachHang' is not selected
                MessageBox.Show("Vui lòng chọn khách hàng trước khi thanh toán.");
                return;
            }
            int maKH = int.Parse(maKhachHang) ;

            int maNV = int.Parse(LoginAccount.MaNV);


            DateTime ngayLapHD = DateTime.Now; // Current date and time
            int maSP = int.Parse(txtMaSanPham.Text);
            float donGia = float.Parse(txtDonGia.Text.Replace("₫", "").Trim()); // Remove currency symbol
            int soLuongSP = int.Parse(txtSoLuong.Text);
            float thanhTien = float.Parse(txtTongTien.Text.Replace("₫", "").Trim()); // Remove currency symbol

            // Now, you can insert these values into your database tables (hoadon and chitiethd)
            // Use your database access layer or an ORM framework for this purpose

            // Example:
            // 1. Insert into hoadon table
            QuanLyHoaDon_DAO quanLyHoaDon_DAO = new QuanLyHoaDon_DAO();
            int maHD = quanLyHoaDon_DAO.InsertHoaDon(maKH, maNV, ngayLapHD);

            // 2. Insert into chitiethd table
            InsertChiTietHoaDon(maHD, maSP, donGia, soLuongSP, thanhTien);

            // Optionally, you may want to update your product quantity or perform other actions

            // Display a success message or perform any additional actions
            MessageBox.Show("Payment successful!");

            // Optionally, you can clear the UI or reset the form for the next transaction
            ClearForm();
        }
        private void ClearForm()
        {

            flowLayoutPanel_Cart.Controls.Clear();
 
        }


        // Add methods for database operations (e.g., InsertHoaDon and InsertChiTietHoaDon)
        // Use your database access layer or ORM framework to interact with the database

    }
}