using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DoAn_CSharp.Forms
{
    public partial class UserControlProduct_item : UserControl
    {
        public string ImageIdentifier { get; private set; }
        public string ProductId { get; private set; }

        // Add an event to notify the click
        public event EventHandler ProductClick;

        public UserControlProduct_item(string maSP, string tenSP, string donGia, string tenAnhSP)
        {
            InitializeComponent();
            // Initialize the control with product information
            lblMaSP.Text = maSP;
            lblTenSP.Text = tenSP;
            lblDonGia.Text = donGia;

            // Set the product ID
            ProductId = maSP;
            string imageFolderPath = Path.Combine(Application.StartupPath, "Image");

            if (Directory.Exists(imageFolderPath))
            {
                string imageName = tenAnhSP; // Thay thế bằng tên thực của hình ảnh
                string imagePath = Path.Combine(imageFolderPath, imageName);

                if (File.Exists(imagePath))
                {
                    // Load và hiển thị hình ảnh
                    picHinhAnh.Image = Image.FromFile(imagePath);
                    picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;

                    // Adjust the PictureBox size to the image size
                    picHinhAnh.Size = new Size(212, 114);
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


            // Subscribe to the click events of specific controls
            label1.Click += Control_Click;
            label2.Click += Control_Click;
            lblMaSP.Click += Control_Click;
            lblTenSP.Click += Control_Click;
            lblDonGia.Click += Control_Click;
            picHinhAnh.Click += Control_Click;

            // Subscribe to the click event of the entire UserControlProduct_item
            this.Click += UserControlProduct_item_Click;

            // Make sure ProductClick event is initialized
            ProductClick += (s, e) => { };
        }

        private void Control_Click(object sender, EventArgs e)
        {
            // Raise the ProductClick event when specific controls are clicked
            ProductClick?.Invoke(this, EventArgs.Empty);
        }

        private void UserControlProduct_item_Click(object sender, EventArgs e)
        {
            // Raise the ProductClick event when the entire UserControlProduct_item is clicked
            ProductClick?.Invoke(this, EventArgs.Empty);
        }
    }

}
