using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Windows.Forms;

namespace DoAn_CSharp
{
    public partial class UserControlProduct_item : UserControl
    {
        public string ImagePath { get; private set; }
        public UserControlProduct_item(string maSP, string tenSP, string donGia, string tenAnhSP)
        {
            InitializeComponent();

            // Initialize the control with product information
            lblMaSP.Text = maSP;
            lblTenSP.Text = tenSP;
            lblDonGia.Text = donGia;
            ImagePath = tenAnhSP;

            // Load the image from resources
            picHinhAnh.Image = (Image)Properties.Resources.ResourceManager.GetObject(tenAnhSP);
            picHinhAnh.SizeMode = PictureBoxSizeMode.CenterImage;




        }



    }
}
