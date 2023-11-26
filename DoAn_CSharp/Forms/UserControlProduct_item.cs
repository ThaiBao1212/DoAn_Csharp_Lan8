using System;
using System.Drawing;
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

            // Set the image identifier
            ImageIdentifier = tenAnhSP;

            // Load the image from resources
            picHinhAnh.Image = (Image)Properties.Resources.ResourceManager.GetObject(tenAnhSP);
            picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;

            // Adjust the PictureBox size to the image size
            picHinhAnh.Size = new Size(212, 114);
        }
        private void UserControlProduct_item_Click(object sender, EventArgs e)
        {
            ProductClick?.Invoke(this, EventArgs.Empty);
        }

       

        private void UserControlProduct_item_MouseClick(object sender, MouseEventArgs e)
        {
            // Raise the ProductClick event
            ProductClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
