﻿using DoAn_CSharp.DAO;
using DoAn_CSharp.Databsase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_CSharp.Forms
{
    public partial class FormLogin : Form
    {
        private int maChucVu = -1;
        public FormLogin()
        {
            InitializeComponent();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int WMsg, int wParam, int lParam);

        private void FormLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            string userName = txtUserName.Text;
            string passWord = txtPassword.Text;
            if (Login(userName, passWord))
            {
                maChucVu = GetMaChucVu(userName);

                // Kiểm tra và enable/disable các controls dựa trên mã chức vụ
                CheckUserRole();

                FormMainMenu f = new FormMainMenu();
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu !");
            }
        }
        bool Login(string userName, string passWord)
        {
            return Account_DAO.Instance.Login(userName, passWord);
        }


        private int GetMaChucVu(string userName)
        {
            string query = "SELECT MaCV FROM dbo.nhanvien WHERE TenTaiKhoanNV = @UserName";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName });

            if (result.Rows.Count > 0)
            {
                return Convert.ToInt32(result.Rows[0]["MaCV"]);
            }

            // Trả về -1 hoặc giá trị không hợp lệ nếu không tìm thấy
            return -1;
        }

        private void CheckUserRole()
        {

            if (maChucVu == 1) // Admin
            {
                FormMainMenu f = new FormMainMenu();
                f.EnableAdminControls();
                this.Hide();
                f.ShowDialog();
            }
            else if (maChucVu == 2) // Nhân viên bán hàng
            {
                FormMainMenu f = new FormMainMenu();
                f.EnableEmployeeControls();
                this.Hide();
                f.ShowDialog();
            }
        }






    }
}
