using DoAn_CSharp.DAO;
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
using System.Xml.Serialization;
using DoAn_CSharp.Databsase;

namespace DoAn_CSharp.Forms
{
    public partial class FormThietLap : Form
    {
        MD5Hash md5Hash = new MD5Hash();

        private Account_DTO loginAccount;
        public Account_DTO LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }

        public FormThietLap(Account_DTO acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }

        private event EventHandler updateAccount;
        public event EventHandler UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }


        private void FormThietLap_Load(object sender, EventArgs e)
        {

        }

        void ChangeAccount (Account_DTO acc)
        {
            txtHoTen.Text = LoginAccount.HoTenNV;
            txtTenTaiKhoan.Text = loginAccount.TenTaiKhoanNV;
            
        }
 


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string hoTenNV = txtHoTen.Text;
            string tenTaiKhoanNV = txtTenTaiKhoan.Text;
            string matKhauNV  = MD5Hash.CalculateMD5Hash(txtMatKhau.Text);
            string matKhauMoi = MD5Hash.CalculateMD5Hash(txtMatKhauMoi.Text);
            string nhapLaiMatKhau = MD5Hash.CalculateMD5Hash(txtNhapLaiMatKhau.Text);

            if (!matKhauMoi.Equals(nhapLaiMatKhau))
            {
                MessageBox.Show("Vui Lòng Nhập Lại Mật Khẩu Đúng Với Mật Khẩu Mới !");
                txtNhapLaiMatKhau.Clear();
            }
            else 
            {
                try
                {
                    if (Account_DAO.Instance.UpdateAccount(tenTaiKhoanNV, hoTenNV, matKhauNV, matKhauMoi))
                    {
                        MessageBox.Show("Cập nhật thành công ");

                        ClearInput();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng điền đúng mật khẩu !");
                        txtMatKhau.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
           

        }


        

        public void ClearInput()
        {
            txtMatKhau.Clear();
            txtMatKhauMoi.Clear();
            txtNhapLaiMatKhau.Clear();
        }


    }
}
