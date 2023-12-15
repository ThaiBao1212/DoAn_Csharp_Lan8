using DoAn_CSharp.DTO;
/*using DoAn_CSharp.Forms.Edit_Forms;*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_CSharp.Forms
{


    public partial class FormQuanLySanPham : Form
    {
        QuanLySanPham_DTO sanpham = new QuanLySanPham_DTO();
        QuanLySanPham_DTO sp_selected = new QuanLySanPham_DTO();
        QuanLySanPham_DTO sp_selected_edit = new QuanLySanPham_DTO();
        string imageUpload = "";
        /* string connString = "Data Source=LAPTOP-PDE9TC1I\\SQLEXPRESS;Initial Catalog=QuanLyBanGiay;Integrated Security=true";*/
        //string connString = "Data Source=DESKTOP-7R66M1N\\THAIBAOSERVER;Initial Catalog=QuanLyBanGiay;Integrated Security=True";
        //string connString = "Data Source=DESKTOP-7R66M1N\\THAIBAOSERVER;Initial Catalog=QuanLyBanGiay1;Integrated Security=True";
        string connString = "Data Source=LAPTOP-PDE9TC1I\\SQLEXPRESS; Initial Catalog=QuanLyBanGiay2; Integrated Security=True";


        public FormQuanLySanPham()
        {
            InitializeComponent();

        }

        private void cbMaChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)sp_ncc.SelectedItem;
            int maNCC = (int)(selectedRow["MaNCC"]);
            sanpham.MaNCC = maNCC;
        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            sanpham.TenSP = sp_name.Text;
        }

        private void FormQuanLySanPham_Load(object sender, EventArgs e)
        {
            NCC_load();
            DM_load();
            listSP_load();
            dataListSP_load();
            imagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            detail_image.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void dataListSP_load()
        {
            listSP.SelectionChanged += DataGridView_SelectionChanged;
            listSP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listSP.ReadOnly = true;
        }


        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {

            if (listSP.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = listSP.SelectedRows[0];
                sp_selected.MaSP = (int)selectedRow.Cells["MaSP"].Value;
                sp_selected.MaNCC = (int)selectedRow.Cells["MaNCC"].Value;
                sp_selected.MaDM = (int)selectedRow.Cells["MaDM"].Value;
                sp_selected.TenSP = (string)selectedRow.Cells["TenSP"].Value;
               /* sp_selected.SizeSP = (string)selectedRow.Cells["SizeSP"].Value;*/
              /*  sp_selected.SoLuongSP = (int)selectedRow.Cells["SoLuongSP"].Value;*/
                sp_selected.DonGia = (decimal)selectedRow.Cells["DonGia"].Value;
                sp_selected.MieuTaSP = (string)selectedRow.Cells["MieuTaSP"].Value;
                sp_selected.TrangThaiSP = (string)selectedRow.Cells["TrangThaiSP"].Value;
                sp_selected.AnhSP = (string)selectedRow.Cells["AnhSP"].Value;

                sp_selected_edit = sp_selected;
                sanpham_selected();
            }
        }


        private void listSP_load()
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    // Mở kết nối
                    connection.Open();

                    // Xây dựng câu truy vấn SQL để lấy dữ liệu từ bảng
                    string query = "SELECT * FROM sanpham";

                    // Tạo đối tượng SqlDataAdapter và DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    // Đổ dữ liệu từ cơ sở dữ liệu vào DataTable
                    adapter.Fill(dataTable);

                    // Gán DataTable làm nguồn dữ liệu cho DataGridView
                    listSP.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi kết nối và lấy dữ liệu từ cơ sở dữ liệu: " + ex.Message);
                }
            }
        }

        private void NCC_load()
        {
            string query = "SELECT MaNCC, TenNCC FROM nhacungcap";

            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                sp_ncc.DisplayMember = "TenNCC";
                sp_ncc.ValueMember = "MaNCC";
                sp_ncc.DataSource = dataTable;

                detail_ncc.DisplayMember = "TenNCC";
                detail_ncc.ValueMember = "MaNCC";
                detail_ncc.DataSource = dataTable;
            }
        }

        private void DM_load()
        {
            string query = "SELECT MaDanhMuc, TenDM FROM danhmuc";

            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                sp_dm.DisplayMember = "TenDM";
                sp_dm.ValueMember = "MaDanhMuc";
                sp_dm.DataSource = dataTable;


                detail_dm.DisplayMember = "TenDM";
                detail_dm.ValueMember = "MaDanhMuc";
                detail_dm.DataSource = dataTable;
            }
        }

        private void sp_dm_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)sp_dm.SelectedItem;
            int maDM = (int)(selectedRow["MaDanhMuc"]);
            sanpham.MaDM = maDM;
        }

        private void sp_size_TextChanged(object sender, EventArgs e)
        {
/*            sanpham.SizeSP = sp_size.Text;*/
        }

        private void sp_description_TextChanged(object sender, EventArgs e)
        {
            sanpham.MieuTaSP = sp_description.Text;
        }

        private void sp_price_TextChanged(object sender, EventArgs e)
        {
            if (sp_price.Text != "")
                sanpham.DonGia = decimal.Parse(sp_price.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO sanpham (MaNCC,MaDM,TenSP,SizeSP,SoLuongSP,MieuTaSP, DonGia, TrangThaiSP, AnhSP) VALUES (@MaNCC,@MaDM,@TenSP,@SizeSP,@SoLuongSP,@MieuTaSP,@DonGia,@TrangThaiSP,@AnhSP)";


            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@MaNCC", sanpham.MaNCC);
                        command.Parameters.AddWithValue("@MaDM", sanpham.MaDM);
                        command.Parameters.AddWithValue("@TenSP", sanpham.TenSP);
                        /*command.Parameters.AddWithValue("@SizeSP", sanpham.SizeSP);
                        command.Parameters.AddWithValue("@SoLuongSP", sanpham.SoLuongSP);*/
                        command.Parameters.AddWithValue("@MieuTaSP", sanpham.MieuTaSP);
                        command.Parameters.AddWithValue("@DonGia", sanpham.DonGia);
                        command.Parameters.AddWithValue("@TrangThaiSP", sanpham.TrangThaiSP);
                        command.Parameters.AddWithValue("@AnhSP", imageUpload);
                        if (sanpham.AnhSP == "" || sanpham.AnhSP == null)
                        {
                            sanpham.AnhSP = "";
                        };


                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if the insertion was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm sản phẩm thành công.");
                            clearForm();
                            listSP_load();
                            sanpham = new QuanLySanPham_DTO();
                        }
                        else
                        {
                            MessageBox.Show("Thêm sản phẩm thất bại.");
                        }
                    }
                }
                catch (Exception )
                {
                    MessageBox.Show("Đã xảy ra lỗi khi lưu sản phẩm. Vui lòng kiểm tra và điền đầy đủ thông tin cho sản phẩm mới !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Create a SqlCommand object with the query and connection

            }
        }

        private void clearForm()
        {
            sp_name.Text = "";
            sp_ncc.SelectedIndex = 0;
            sp_dm.SelectedIndex = 0;
            sp_status.Checked = false;
            sp_price.Text = "";
            sp_quantity.Text = "";
            sp_description.Text = "";
            sp_size.Text = "";
        }

        private void sp_quantity_TextChanged(object sender, EventArgs e)
        {
/*            if (sp_quantity.Text != "")
                sanpham.SoLuongSP = int.Parse(sp_quantity.Text);*/
        }

        private void sp_status_CheckedChanged(object sender, EventArgs e)
        {
            bool check = sp_status.Checked;
            if (check)
            {
                sanpham.TrangThaiSP = "Mở";
            }
            else
            {
                sanpham.TrangThaiSP = "Đóng";
            }
        }

        private void dtgvQuanLyNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (sp_selected.TenSP != "" || sp_selected.TenSP != null)
            {
                string deleteQuery = "DELETE FROM sanpham WHERE MaSP = @MaSP";
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            command.Parameters.AddWithValue("@MaSP", sp_selected.MaSP);

                            // Thực thi câu truy vấn để xóa hàng
                            command.ExecuteNonQuery();
                            MessageBox.Show("Đã xóa: " + sp_selected.TenSP);
                            listSP_load();
                        }
                        else
                        {
                            // Người dùng đã chọn No hoặc đóng hộp thoại

                        }
                    }
                     // Đóng kết nối cơ sở dữ liệu
                    connection.Close();
                }
            }
        }

        private void sanpham_selected()
        {
            QuanLySanPham_DTO sq_select_edit = new QuanLySanPham_DTO();
            detail_name.Text = sp_selected_edit.TenSP;
            detail_price.Text = sp_selected_edit.DonGia.ToString();
/*            detail_quantity.Text = sp_selected_edit.SoLuongSP.ToString();
            detail_size.Text = sp_selected_edit.SizeSP;*/
            detail_description.Text = sp_selected_edit.MieuTaSP;
            detail_image.ImageLocation = sp_selected_edit.AnhSP;


            for (int i = 0; i < detail_ncc.Items.Count; i++)
            {
                DataRowView item = (DataRowView)detail_ncc.Items[i];
                if ((int)item["MaNCC"] == sp_selected_edit.MaNCC)
                {
                    detail_ncc.SelectedIndex = i;
                    break;
                }
            }




            for (int i = 0; i < detail_dm.Items.Count; i++)
            {
                DataRowView item = (DataRowView)detail_dm.Items[i];
                if ((int)item["MaDanhMuc"] == sp_selected_edit.MaDM)
                {
                    detail_dm.SelectedIndex = i;
                    break;
                }
            }
        }

        private void detail_ncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)detail_ncc.SelectedItem;
            int maNCC = (int)(selectedRow["MaNCC"]);
            sp_selected_edit.MaNCC = maNCC;
        }

        private void detail_name_TextChanged(object sender, EventArgs e)
        {
            sp_selected_edit.TenSP = detail_name.Text;

        }

        private void detail_dm_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)detail_dm.SelectedItem;
            int maDM = (int)(selectedRow["MaDanhMuc"]);
            sp_selected_edit.MaDM = maDM;
        }

        private void detail_size_TextChanged(object sender, EventArgs e)
        {
/*            sp_selected_edit.SizeSP = detail_size.Text;*/
        }

        private void detail_description_TextChanged(object sender, EventArgs e)
        {
            sp_selected_edit.MieuTaSP = detail_description.Text;
        }

        private void detail_price_TextChanged(object sender, EventArgs e)
        {
            if (detail_price.Text != "")
                sp_selected_edit.DonGia = decimal.Parse(detail_price.Text);
        }

        private void detail_quantity_TextChanged(object sender, EventArgs e)
        {
/*            if (detail_quantity.Text != "")
                sp_selected_edit.SoLuongSP = int.Parse(detail_quantity.Text);*/
        }

        private void detail_status_CheckedChanged(object sender, EventArgs e)
        {
            bool check = detail_status.Checked;
            if (check)
            {
                sp_selected_edit.TrangThaiSP = "Mở";
            }
            else
            {
                sp_selected_edit.TrangThaiSP = "Đóng";
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sp_selected_edit = sp_selected;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "UPDATE sanpham SET MaNCC=@MaNCC,MaDM=@MaDM,TenSP=@TenSP,SizeSP=@SizeSP,SoLuongSP=@SoLuongSP,MieuTaSP=@MieuTaSP,DonGia=@DonGia,TrangThaiSP=@TrangThaiSP,AnhSP=@AnhSP WHERE MaSP = @MaSP";
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaSP", sp_selected_edit.MaSP);
                command.Parameters.AddWithValue("@MaNCC", sp_selected_edit.MaNCC);
                command.Parameters.AddWithValue("@MaDM", sp_selected_edit.MaDM);
                command.Parameters.AddWithValue("@TenSP", sp_selected_edit.TenSP);
/*                command.Parameters.AddWithValue("@SizeSP", sp_selected_edit.SizeSP);
                command.Parameters.AddWithValue("@SoLuongSP", sp_selected_edit.SoLuongSP);*/
                command.Parameters.AddWithValue("@MieuTaSP", sp_selected_edit.MieuTaSP);
                command.Parameters.AddWithValue("@DonGia", sp_selected_edit.DonGia);
                command.Parameters.AddWithValue("@AnhSP", sp_selected_edit.AnhSP);
                if (detail_status.Checked)
                {
                    command.Parameters.AddWithValue("@TrangThaiSP", "Mở");
                }
                else
                {
                    command.Parameters.AddWithValue("@TrangThaiSP", "Đóng");
                }

                MessageBox.Show("Cập nhật san pham thành công.");



                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                listSP_load();

            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg, *.png, *.gif)|*.jpg;*.png;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    string destinationFolder = Path.Combine(Application.StartupPath, "Images");

                    // Create the "Images" folder if it doesn't exist
                    if (!Directory.Exists(destinationFolder))
                        Directory.CreateDirectory(destinationFolder);

                    string destinationPath = Path.Combine(destinationFolder, Path.GetFileName(imagePath));
                    File.Copy(imagePath, destinationPath, true);
                    imagePictureBox.ImageLocation = destinationPath;
                    imageUpload = destinationPath;

                }
            }
        }

        private void btnThemNhaCungCapNhanh_Click(object sender, EventArgs e)
        {
            ThemNhaCungCap_Form f = new ThemNhaCungCap_Form();

            f.Show();

        }
        private void ThemNhaCungCap_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Gọi hàm cập nhật dữ liệu cho cbNhaCungCap sau khi form ThemNhaCungCap_Form được đóng
            CapNhatDanhSachNhaCungCap();
        }
        private void CapNhatDanhSachNhaCungCap()
        {


        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ThemDanhMuc_Form f = new ThemDanhMuc_Form();
            f.Show();
        }
    }
}
