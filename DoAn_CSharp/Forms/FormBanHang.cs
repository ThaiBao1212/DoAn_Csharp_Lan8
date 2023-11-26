using DoAn_CSharp.DAO;
using DoAn_CSharp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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

                // Add the UserControlProduct_item to the FlowLayoutPanel
                flowLayoutPanelProducts_item.Controls.Add(productItem);
            }
        }

        private void HienThiDanhSachSanPham()
        {
            // Get the selected value of cbLocDanhMuc


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

                flowLayoutPanelProducts_item.Controls.Add(productItem);
            }
        }
        private void FormBanHang_Load(object sender, EventArgs e)
        {
            foreach (Control control in flowLayoutPanelProducts_item.Controls)
            {
                if (control is UserControlProduct_item productItem)
                {
                    productItem.ProductClick += ProductItem_ProductClick;
                }
            }
        }

        private void ProductItem_ProductClick(object sender, EventArgs e)
        {
            // Handle the product click event here
            UserControlProduct_item productItem = (UserControlProduct_item)sender;

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

        private void ChiTietSanPham()
        {
            // Add debugging statements
            Debug.WriteLine($"Fetching details for product with ID: {quanLySanPham_DTO.MaSP}");

            QuanLySanPham_DTO productDetails = quanLySanPham_DAO.LayChiTietSanPham(quanLySanPham_DTO.MaSP);

            if (productDetails != null)
            {
                // Update your UI controls with the details
                txtNhaCungCap.Text = productDetails.MaNCC.ToString();
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



        private void cbTenNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle Nha Cung Cap selection change
        }

     
    }
}
