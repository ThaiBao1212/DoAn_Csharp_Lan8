using DoAn_CSharp.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_CSharp.Forms
{

    public partial class FormQuanLyNhaCungCap : Form
    {
        string tenNCC, diachiNCC, SDTNCC, email;
        
        string TrangThaiNCC = "Đóng";
        private DAO.QuanLyNhaCungCap_DAO ql_NhaCungCap_DAO = new DAO.QuanLyNhaCungCap_DAO();
        private DTO.QuanLyNhaCungCap_DTO ql_NhaCungCap_DTO = new DTO.QuanLyNhaCungCap_DTO();
        private DTO.QuanLySanPham_DTO quanLySanPham_DTO = new DTO.QuanLySanPham_DTO();

        //string connString = "Data Source=LAPTOP-PDE9TC1I\\SQLEXPRESS;Initial Catalog=QuanLyBanGiay;Integrated Security=true";
        //string connString = "Data Source=DESKTOP-7R66M1N\\THAIBAOSERVER;Initial Catalog=QuanLyBanGiay;Integrated Security=True";
        string connString = "Data Source=DESKTOP-7R66M1N\\THAIBAOSERVER;Initial Catalog=QuanLyBanGiay1;Integrated Security=True";
        QuanLyNhaCungCap_DTO NCC_selected = new QuanLyNhaCungCap_DTO();
        List<QuanLyNhaCungCap_DTO> lsNCC = new List<QuanLyNhaCungCap_DTO>();

        private void txtDiaChiNhaCungCap_TextChanged(object sender, EventArgs e)
        {
            this.diachiNCC = txtDiaChiNhaCungCap.Text;
        }

        private void txtSDTNhaCungCap_TextChanged(object sender, EventArgs e)
        {
            this.SDTNCC = txtSDTNhaCungCap.Text;
        }

        private void txtTenNhaCungCap_TextChanged(object sender, EventArgs e)
        {
            this.tenNCC = txtTenNhaCungCap.Text;
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            this.email = txtEmail.Text;
        }


        public FormQuanLyNhaCungCap()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool check = TT_NCC.Checked;
            if (check)
            {
                this.TrangThaiNCC = "Mở";
            }
            else
            {
                this.TrangThaiNCC = "Đóng";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (NCC_selected.TenNCC != "" || NCC_selected.TenNCC != null)
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    if (KiemTraMaNCC(NCC_selected.MaNCC))
                    {
                        // Tạo câu truy vấn SQL để xóa hàng dựa trên ID
                        string deleteQuery = "DELETE FROM nhacungcap WHERE MaNCC = @MaNCC";
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa thông tin nhà cung cấp này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                command.Parameters.AddWithValue("@MaNCC", NCC_selected.MaNCC);

                                // Thực thi câu truy vấn để xóa hàng
                                command.ExecuteNonQuery();
                                MessageBox.Show("Đã xóa: " + NCC_selected.TenNCC);
                                listNCC_load();
                            }
                            else
                            {
                                // Người dùng đã chọn No hoặc đóng hộp thoại

                            }
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Phát hiện các sản phẩm có liên quan tới thông tin nhà cung cấp này. Xóa Nhà cung cấp sẽ thay đổi dữ liệu các sản phẩm liên quan tới nhà cung cấp này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {

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


        private bool KiemTraMaNCC(int MaNCC)
        {
            // Câu truy vấn SQL để kiểm tra mã nhà cung cấp
            string query = "SELECT TOP 1 1 FROM sanpham WHERE MaNCC = @MaNCC";

            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaNCC", MaNCC);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                bool isUsed = reader.HasRows;

                reader.Close();
                connection.Close();

                return !isUsed;
            }
        }

        private void dtgvQuanLyNhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormQuanLyNhaCungCap_Load(object sender, EventArgs e)
        {
            listNCC_load();
            dataNCC_load();
        }

        private void dataNCC_load()
        {
            listNCC.SelectionChanged += listNCC_SelectionChanged;
            listNCC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listNCC.ReadOnly = true;
        }




        private void detailForm_load()
        {
            detail_name.Text = NCC_selected.TenNCC;
            detail_address.Text = NCC_selected.DiaChiNCC;
            detail_phone.Text = NCC_selected.SDTNCC;
            detail_email.Text = NCC_selected.Email;
            if (NCC_selected.TrangThaiNCC == "Mở")
            {
                detail_status.Checked = true;
            }
            else
            {
                detail_status.Checked = false;
            }
        }

        private void txtMaNhaCungCap_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            NCC_selected.SDTNCC = detail_phone.Text;
        }

        private void detail_name_TextChanged(object sender, EventArgs e)
        {
            NCC_selected.TenNCC = detail_name.Text;
        }

        private void detail_address_TextChanged(object sender, EventArgs e)
        {
            NCC_selected.DiaChiNCC = detail_address.Text;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void detail_email_TextChanged(object sender, EventArgs e)
        {
            NCC_selected.Email = detail_email.Text;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string query = "UPDATE nhacungcap SET TenNCC=@TenNCC,DiaChiNCC=@DiaChiNCC,SDTNCC=@SDTNCC,Email = @Email ,TrangThaiNCC=@TrangThaiNCC  WHERE MaNCC = @MaNCC";
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenNCC", detail_name.Text);
                command.Parameters.AddWithValue("@DiaChiNCC", detail_address.Text);
                command.Parameters.AddWithValue("@Email", detail_email.Text);
                command.Parameters.AddWithValue("@SDTNCC", detail_phone.Text);

                if (detail_status.Checked)
                {
                    command.Parameters.AddWithValue("@TrangThaiNCC", "Mở");
                }
                else
                {
                    command.Parameters.AddWithValue("@TrangThaiNCC", "Đóng");
                }
                

                command.Parameters.AddWithValue("@MaNCC", NCC_selected.MaNCC);

                MessageBox.Show("Cập nhật nhà cung cấp thành công.");



                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                listNCC_load();
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            bool check = TT_NCC.Checked;
            if (check)
            {
                this.TrangThaiNCC = "Mở";
            }
            else
            {
                this.TrangThaiNCC = "Đóng";
            }
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO nhacungcap (tenNCC,diachiNCC,SDTNCC,Email,TrangThaiNCC) VALUES (@tenNCC,@diachiNCC,@SDTNCC,@Email,@TrangThaiNCC )";


            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@tenNCC", this.tenNCC);
                    command.Parameters.AddWithValue("@diachiNCC", this.diachiNCC);
                    command.Parameters.AddWithValue("@SDTNCC", this.SDTNCC);
                    command.Parameters.AddWithValue("@Email", this.email);
                    command.Parameters.AddWithValue("@TrangThaiNCC", this.TrangThaiNCC);

                    // Execute the query
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if the insertion was successful
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm nhà cung cấp thành công.");
                        listNCC_load();
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhà cung cấp thất bại.");
                    }
                }
            }
        }


        private void listNCC_load()
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    // Mở kết nối
                    connection.Open();

                    // Xây dựng câu truy vấn SQL để lấy dữ liệu từ bảng
                    string query = "SELECT * FROM nhacungcap";

                    // Tạo đối tượng SqlDataAdapter và DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    // Đổ dữ liệu từ cơ sở dữ liệu vào DataTable
                    adapter.Fill(dataTable);

                    // Gán DataTable làm nguồn dữ liệu cho DataGridView
                    listNCC.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi kết nối và lấy dữ liệu từ cơ sở dữ liệu: " + ex.Message);
                }
            }
        }



        private void listNCC_SelectionChanged(object sender, EventArgs e)
        {
            if (listNCC.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = listNCC.SelectedRows[0];
                NCC_selected.MaNCC = (int)selectedRow.Cells["MaNCC"].Value;
                NCC_selected.TenNCC = (string)selectedRow.Cells["TenNCC"].Value;
                NCC_selected.DiaChiNCC = (string)selectedRow.Cells["DiaChiNCC"].Value;
                NCC_selected.SDTNCC = (string)selectedRow.Cells["SDTNCC"].Value;
                NCC_selected.Email = (string)selectedRow.Cells["Email"].Value;
                NCC_selected.TrangThaiNCC = (string)selectedRow.Cells["TrangThaiNCC"].Value;
                detailForm_load();

                ql_NhaCungCap_DTO.MaNCC = NCC_selected.MaNCC; // Thêm dòng này để đảm bảo ql_NhaCungCap_DTO.MaNCC có giá trị

                HienThiSanPhamTrongNhaCungCap();
            }
        }

        private void InitializeDataGridViewColumns()
        {
            // Xác định số cột và tên cột
            string[] columnNames = { "MaSP", "TenNCC", "TenDM", "TenSize", "TenSP", "SoLuongSP", "DonGia", "TrangThaiSP" };

            // Thêm cột vào DataGridView và cấu hình AutoSizeMode
            foreach (string columnName in columnNames)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.Name = columnName;
                column.HeaderText = columnName;
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Cấu hình giãn đều

                dtgvSanPhamCuaNhaCungCap.Columns.Add(column);
            }
        }

        private void HienThiSanPhamTrongNhaCungCap()
        {
            // Kiểm tra null trước khi sử dụng
            if (ql_NhaCungCap_DTO == null || dtgvSanPhamCuaNhaCungCap == null || ql_NhaCungCap_DTO.MaNCC <= 0)
            {
                // Xử lý lỗi hoặc thoát khỏi phương thức nếu cần
                return;
            }

            // Kiểm tra xem cột đã được thêm chưa
            if (dtgvSanPhamCuaNhaCungCap.Columns.Count == 0)
            {
                InitializeDataGridViewColumns();
            }

            dtgvSanPhamCuaNhaCungCap.Rows.Clear();

            // Sử dụng using để tự động giải phóng tài nguyên của SqlConnection
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();

                    // Sử dụng Parameters
                    string query = "SELECT sp.MaSP, ncc.MaNCC,ncc.TenNCC, dm.TenDM, sp.TenSP, s.TenSize, sps.SoLuongSP, sp.DonGia, sp.TrangThaiSP " +
                                   "FROM sanpham sp " +
                                   "JOIN nhacungcap ncc ON sp.MaNCC = ncc.MaNCC " +
                                   "JOIN danhmuc dm ON sp.MaDM = dm.MaDanhMuc " +
                                   "JOIN SanPhamSize sps ON sp.MaSP = sps.MaSP " +
                                   "JOIN Sizes s ON sps.MaSize = s.MaSize " +
                                   "WHERE ncc.MaNCC = @MaNCC";

                    // Sử dụng using để tự động giải phóng tài nguyên của SqlCommand
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@MaNCC", SqlDbType.Int).Value = ql_NhaCungCap_DTO.MaNCC;

                        // Sử dụng using để tự động giải phóng tài nguyên của SqlDataReader
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Kiểm tra xem có dữ liệu hay không
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    // Thêm dữ liệu vào dtgvSanPhamCuaNhaCungCap
                                    dtgvSanPhamCuaNhaCungCap.Rows.Add(
                                        reader["MaSP"],
                                        reader["TenSP"],
                                        reader["TenNCC"],
                                        reader["TenDM"],
                                        reader["TenSize"],
                                        reader["SoLuongSP"],
                                        reader["DonGia"],
                                        reader["TrangThaiSP"]
                                    );
                                }
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log lỗi hoặc hiển thị thông báo lỗi
                    MessageBox.Show("Lỗi khi kết nối và lấy dữ liệu từ cơ sở dữ liệu:aaaa " + ex.Message);
                }
            }
        }



    }

}
