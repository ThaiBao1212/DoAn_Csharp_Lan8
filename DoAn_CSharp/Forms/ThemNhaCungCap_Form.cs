using DoAn_CSharp.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_CSharp.Forms
{
    public partial class ThemNhaCungCap_Form : Form
    {
        public ThemNhaCungCap_Form()
        {
            InitializeComponent();
        }

        private DAO.QuanLyNhaCungCap_DAO ql_NhaCungCap_DAO = new DAO.QuanLyNhaCungCap_DAO();
        private DTO.QuanLyNhaCungCap_DTO ql_NhaCungCap_DTO = new DTO.QuanLyNhaCungCap_DTO();


        public event EventHandler ThemNhaCungCapCompleted;



        private void btnThem_Click_1(object sender, EventArgs e)
        {
            // Lấy thông tin từ các controls trên form
            string tenNCC = txtTenNhaCungCap.Text;
            string diaChiNCC = txtDiaChiNhaCungCap.Text;
            string sdtNCC = txtSDTNhaCungCap.Text;
            string email = txtEmail.Text;


            // Kiểm tra xem tất cả các trường thông tin đã được nhập đầy đủ chưa
            if (string.IsNullOrWhiteSpace(tenNCC) || string.IsNullOrWhiteSpace(diaChiNCC) ||
                string.IsNullOrWhiteSpace(sdtNCC) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Nhà Cung Cấp ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            bool isSuccess = ql_NhaCungCap_DAO.ThemNhaCungCapNhanh(new QuanLyNhaCungCap_DTO
            {
                TenNCC = tenNCC,
                DiaChiNCC = diaChiNCC,
                SDTNCC = sdtNCC,
                Email = email,

            });

            // Kiểm tra kết quả thêm khách hàng
            if (isSuccess)
            {
                MessageBox.Show("Thêm Nhà Cung Cấp  thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Thêm Nhà Cung Cấp Thất Bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ThemNhaCungCap_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
