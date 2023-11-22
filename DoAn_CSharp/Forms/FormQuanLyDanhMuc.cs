using DoAn_CSharp.DAO;
using DoAn_CSharp.Databsase;
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
   
    public partial class FormQuanLyDanhMuc : Form
    {
        private Database db;
        private DAO.QuanLyDanhMuc_DAO ql_danhmuc_DAO = new DAO.QuanLyDanhMuc_DAO();
        private DTO.QuanLyDanhMuc_DTO ql_danhmuc_DTO = new DTO.QuanLyDanhMuc_DTO();

        public FormQuanLyDanhMuc()
        {
            InitializeComponent();
            HienThiDanhMuc();
        }
        private void HienThiDanhMuc()
        {

            DataTable dt = ql_danhmuc_DAO.LayDanhSachDanhMuc();
            dtgvDanhSachDanhMuc.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dtgvDanhSachDanhMuc.Rows.Add(row.ItemArray);
            }

        }
        private void Setnull()
        {
            txtMaDanhMuc.Text = "";
            txtTenDanhMuc.Text = "";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if ( string.IsNullOrEmpty(txtTenDanhMuc.Text))
                {
                    MessageBox.Show("Vui lòng nhập đúng thông tin danh mục.");
                    return;
                }
                ql_danhmuc_DTO.tenDM = txtTenDanhMuc.Text;

                ql_danhmuc_DAO.ThemDanhMuc(ql_danhmuc_DTO);



                HienThiDanhMuc(); // Refresh the danh muc list in the DataGridView

                Setnull(); // Clear the input fields


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }



        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dtgvDanhSachDanhMuc.SelectedRows.Count == 1)
            {
                try
                {
                    string tenDanhMucMoi = txtTenDanhMuc.Text.Trim();

                    if (string.IsNullOrEmpty(tenDanhMucMoi))
                    {
                        MessageBox.Show("Vui lòng nhập đúng thông tin danh mục.");
                        return;
                    }

                    // Lấy mã danh mục được chọn
                    int maDanhMuc = Convert.ToInt32(dtgvDanhSachDanhMuc.SelectedRows[0].Cells["MaDanhMuc"].Value);

                    // Kiểm tra xem danh mục mới đã tồn tại chưa
                    if (ql_danhmuc_DAO.DanhMucDaTonTai(tenDanhMucMoi))
                    {
                        MessageBox.Show("Danh mục này đã tồn tại. Vui lòng chọn tên khác.");
                        return;
                    }

                    // Cập nhật thông tin danh mục
                    ql_danhmuc_DTO.maDanhMuc = maDanhMuc;
                    ql_danhmuc_DTO.tenDM = tenDanhMucMoi;
                    ql_danhmuc_DAO.CapNhap(ql_danhmuc_DTO);

                    // Hiển thị lại danh sách danh mục
                    HienThiDanhMuc();

                    // Thiết lập các giá trị về null hoặc giá trị mặc định
                    Setnull();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Vui lòng chọn một danh mục để cập nhật.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chỉ chọn một danh mục để cập nhật.", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvDanhSachDanhMuc.SelectedRows.Count == 1)
            {
                try
                {
                    // Lấy mã danh mục từ dòng được chọn
                    int maDanhMuc = Convert.ToInt32(dtgvDanhSachDanhMuc.SelectedRows[0].Cells["MaDanhMuc"].Value);

                    // Gọi hàm xóa danh mục từ DAO
                    ql_danhmuc_DTO.maDanhMuc = maDanhMuc;
                    ql_danhmuc_DAO.XoaDanhMuc(ql_danhmuc_DTO);
                    // Refresh danh sách sau khi xóa
                    HienThiDanhMuc();
                    Setnull();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi xóa danh mục: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chỉ chọn một danh mục để xóa.", "Thông báo");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Setnull();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {

        }

        private void dtgvDanhSachDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
               DataGridViewRow selectedRow = dtgvDanhSachDanhMuc.Rows[e.RowIndex];
                txtMaDanhMuc.Text = selectedRow.Cells["MaDanhMuc"].Value.ToString();
                txtTenDanhMuc.Text = selectedRow.Cells["TenDM"].Value.ToString();

            }

        }

        
    }
    

}
