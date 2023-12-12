using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_CSharp.Report
{
    public partial class fDanhSachNhanVien : Form
    {
        public fDanhSachNhanVien()
        {
            InitializeComponent();
        }

        private void fDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSQuanLyBanGiay.nhanvien' table. You can move, or remove it, as needed.
            this.nhanvienTableAdapter.Fill(this.dSQuanLyBanGiay.nhanvien);

            this.reportViewer1.RefreshReport();
        }
    }
}
