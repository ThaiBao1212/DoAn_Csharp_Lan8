using DoAn_CSharp.DAO;
using DoAn_CSharp.Database;
using DoAn_CSharp.Databsase;
using DoAn_CSharp.DTO;
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
        private TripleDES_Class tripleDES = new TripleDES_Class();

        MD5Hash md5hash = new MD5Hash();

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
            //string passWord = tripleDES.MaHoa(txtPassword.Text);
            string passWord = MD5Hash.CalculateMD5Hash(txtPassword.Text);

            

            if (Login(userName, passWord))
            {
                Account_DTO loginAccount = Account_DAO.Instance.GetAccountByUserName(userName);
                maChucVu = GetMaChucVu(userName);

                // Kiểm tra và enable/disable các controls dựa trên mã chức vụ
                /*CheckUserRole();*/

                FormMainMenu f = new FormMainMenu(loginAccount);
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

        /*private void CheckUserRole()
        {

            if (maChucVu == 1) // Admin
            {
                FormMainMenu f = new FormMainMenu(loginAccount);
                f.EnableAdminControls();
                this.Hide();
                f.ShowDialog();
            }
            else if (maChucVu == 2) // Nhân viên bán hàng
            {
                FormMainMenu f = new FormMainMenu(loginAccount);
                f.EnableEmployeeControls();
                this.Hide();
                f.ShowDialog();
            }
        }*/






    }
}
