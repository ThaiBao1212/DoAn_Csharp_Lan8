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
    public partial class FormBanHang : Form
    {
        private DTO.QuanLySanPham_DTO quanLySanPham_DTO= new DTO.QuanLySanPham_DTO();
        private DAO.QuanLySanPham_DAO quanLySanPham_DAO = new DAO.QuanLySanPham_DAO();

        public FormBanHang()
        {
            InitializeComponent();
            HienThiDanhSachSanPham();
 
        }

        private void DtgvDanhSachSanPham_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void HienThiDanhSachSanPham()
        {
            List<QuanLySanPham_DTO> danhSachSanPham = quanLySanPham_DAO.LayDanhSachSanPhamBan();

            // Clear controls trong groupBox1 trước khi thêm dữ liệu mới
            groupBox1.Controls.Clear();

            int rowIndex = 0;

            foreach (QuanLySanPham_DTO sanPham in danhSachSanPham)
            {
                // Tạo các controls để hiển thị thông tin sản phẩm
                Label lblMaSP = new Label();
                lblMaSP.Text = sanPham.MaSP.ToString();
                lblMaSP.Dock = DockStyle.Top;
                lblMaSP.Click += (sender, e) => HandleProductClick(sanPham.MaSP); // Handle click event

                Label lblTenSP = new Label();
                lblTenSP.Text = sanPham.TenSP;
                lblTenSP.Dock = DockStyle.Top;

                Label lblDonGia = new Label();
                lblDonGia.Text = sanPham.DonGia.ToString("C");
                lblDonGia.Dock = DockStyle.Top;

                PictureBox picHinhAnh = new PictureBox();
                // Đặt hình ảnh cho PictureBox (sanPham.AnhSP là đường dẫn đến hình ảnh)
                picHinhAnh.ImageLocation = sanPham.AnhSP;
                picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
                picHinhAnh.Dock = DockStyle.Top;

                // ... other controls

                // Thêm controls vào groupBox1
                groupBox1.Controls.Add(lblMaSP);
                groupBox1.Controls.Add(lblTenSP);
                groupBox1.Controls.Add(lblDonGia);
                groupBox1.Controls.Add(picHinhAnh);
                // ... add other controls

                rowIndex++;
            }
        }

        private void HandleProductClick(int maSP)
        {
            // Implement your logic to handle the click event
            MessageBox.Show($"Clicked on product with ID: {maSP}");

            // If you want to open a detailed view, pass the maSP to the detailed view form
            // Example: var detailedViewForm = new DetailedViewForm(maSP);
            // detailedViewForm.Show();
        }

    }


  
}
