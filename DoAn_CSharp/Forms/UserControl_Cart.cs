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
    // Modify your UserControl_Cart class
    public partial class UserControl_Cart : UserControl
    {
        public UserControl_Cart()
        {
            InitializeComponent();
        }

        // Add properties or methods to set information
        public string ProductId
        {
            get { return lblMaSP.Text; }
            set { lblMaSP.Text = value; }
        }

        public string ProductName
        {
            get { return lblTenSP.Text; }
            set { lblTenSP.Text = value; }
        }

        public int Quantity
        {
            get { return (int)numericUpDownSize.Value; }
            set { numericUpDownSize.Value = value; }
        }

        public string Sizes
        {
            get { return cbSizes.Text; }
            set { cbSizes.Text = value; }
        }

        public decimal Price
        {
            get { return decimal.Parse(lblGia.Text, System.Globalization.NumberStyles.Currency); }
            set { lblGia.Text = value.ToString("C"); }
        }
    }



}
