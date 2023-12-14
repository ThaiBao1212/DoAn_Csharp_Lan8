
using DoAn_CSharp.Database;
using DoAn_CSharp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace DoAn_CSharp.DAO
{
    internal class QuanLySanPham_DAO
    {
        private readonly Database.Database db;

        public QuanLySanPham_DAO()
        {
            db = new Database.Database();
        }

        public DataTable LayDanhSachSanPham()
        {
            string strSQL = "SELECT * FROM sanpham";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public void ThemSanPham(QuanLySanPham_DTO sanpham)
        {
            try
            {
                string strSQL = $"INSERT INTO sanpham (MaNCC, MaDM, TenSP, MieuTaSP, DonGia, AnhSP) " +
                                $"VALUES ({sanpham.MaNCC},{sanpham.MaDM},N'{sanpham.TenSP}',N'{sanpham.MieuTaSP}',{sanpham.DonGia},N'{sanpham.AnhSP}')";

                db.ExecuteNonQuery(strSQL);

                MessageBox.Show("Thêm Sản Phẩm Thành Công");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Thêm Thất Bại: {ex.Message}");
            }
        }
        public void CapNhatSanPham(QuanLySanPham_DTO sanpham)
        {
            try
            {
                string strSQL = "UPDATE sanpham " +
                                "SET MaNCC = @MaNCC, MaDM = @MaDM, " +
                                "TenSP = @TenSP, MieuTaSP = @MieuTaSP, " +
                                "DonGia = @DonGia, AnhSP = @AnhSP " +
                                "WHERE MaSP = @MaSP";

                // Use parameterized query to prevent SQL injection
                var parameters = new SqlParameter[]
                {
            new SqlParameter("@MaNCC", sanpham.MaNCC),
            new SqlParameter("@MaDM", sanpham.MaDM),
            new SqlParameter("@TenSP", sanpham.TenSP),
            new SqlParameter("@MieuTaSP", sanpham.MieuTaSP),
            new SqlParameter("@DonGia", sanpham.DonGia),
            new SqlParameter("@AnhSP", sanpham.AnhSP),
            new SqlParameter("@MaSP", sanpham.MaSP)
                };

                db.ExecuteNonQuery(strSQL, parameters);

                MessageBox.Show("Cập Nhật Sản Phẩm Thành Công");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cập Nhật Thất Bại: {ex.Message}");
            }
        }



        public QuanLySanPham_DTO LayChiTietSanPham(int maSP)
        {
            try
            {
                string strSQL = $"SELECT sp.MaSP, TenSP, ncc.TenNCC, dm.TenDM, sp.DonGia, sp.AnhSP, sp.MieuTaSP, sp.TrangThaiSP " +
                                "FROM sanpham sp " +
                                "JOIN nhacungcap ncc ON sp.MaNCC = ncc.MaNCC " +
                                "JOIN danhmuc dm ON dm.MaDanhMuc = sp.MaDM " +
                                $"WHERE MaSP = '{maSP}'";

                DataTable dt = db.Execute(strSQL);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    // Map DataRow to QuanLySanPham_DTO
                    QuanLySanPham_DTO sanPham = new QuanLySanPham_DTO
                    {
                        MaSP = Convert.ToInt32(row["MaSP"]),
                        TenSP = row["TenSP"].ToString(),
                        TenNCC = row["TenNCC"].ToString(),
                        TenDM = row["TenDM"].ToString(),
                        MieuTaSP = row["MieuTaSP"].ToString(),
                        DonGia = Convert.ToDecimal(row["DonGia"]),
                        TrangThaiSP = row["TrangThaiSP"].ToString(),
                        AnhSP = row["AnhSP"].ToString()
                    };

                    return sanPham;
                }

                return null;
            }
            catch (Exception ex)
            {
                // Handle exception
                return null;
            }
        }



        public List<QuanLySanPham_DTO> LayDanhSachSanPhamDanhMuc(int maDanhMuc)
        {
            try
            {
                string strSQL = $"SELECT * FROM sanpham WHERE MaDM = {maDanhMuc}";
                DataTable dt = db.Execute(strSQL);

                // Convert DataTable to a list of QuanLySanPham_DTO objects
                List<QuanLySanPham_DTO> danhSachSanPham = new List<QuanLySanPham_DTO>();
                foreach (DataRow row in dt.Rows)
                {
                    // Map DataRow to QuanLySanPham_DTO
                    QuanLySanPham_DTO sanPham = new QuanLySanPham_DTO
                    {
                        MaSP = Convert.ToInt32(row["MaSP"]),
                        // Map other properties
                    };

                    danhSachSanPham.Add(sanPham);
                }

                return danhSachSanPham;
            }
            catch (Exception ex)
            {
                // Handle exception
                return null;
            }
        }
        public void HienThiSanPham()
        {
            // Your code to display or refresh the list of products
            DataTable dt = LayDanhSachSanPham();
            // Additional logic...
        }

        public void XoaSanPham(int maSP)
        {
            try
            {
                string strSQL = $"DELETE FROM sanpham WHERE MaSP = {maSP}";
                db.ExecuteNonQuery(strSQL);
                MessageBox.Show("Xóa Sản Phẩm Thành Công");

                // Refresh the DataGridView to reflect the changes
                HienThiSanPham();
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show($"Xóa Sản Phẩm Thất Bại: {ex.Message}\n\nBạn có muốn khóa sản phẩm không?", "Lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (result == DialogResult.Yes)
                {
                    // Update the product status to "Khóa" in the database
                    KhoaSanPham(maSP);

                    // Refresh the DataGridView to reflect the changes
                    HienThiSanPham();
                }
            }
        }

        private void KhoaSanPham(int maSP)
        {
            try
            {
                string strSQL = $"UPDATE sanpham SET TrangThaiSP = 'Khóa' WHERE MaSP = {maSP}";
                db.ExecuteNonQuery(strSQL);
                MessageBox.Show("Khóa Sản Phẩm Thành Công");
            }
            catch (Exception ex)
            {
                // Handle exception
                MessageBox.Show($"Khóa Sản Phẩm Thất Bại: {ex.Message}");
            }
        }


        public List<QuanLySanPham_DTO> LayDanhSachSanPhamBan()
        {
            try
            {
                string strSQL = "SELECT * FROM sanpham";
                DataTable dt = db.Execute(strSQL);

                // Chuyển đổi DataTable thành List<QuanLySanPham_DTO>
                List<QuanLySanPham_DTO> danhSachSanPham = new List<QuanLySanPham_DTO>();

                foreach (DataRow row in dt.Rows)
                {
                    QuanLySanPham_DTO sanPham = new QuanLySanPham_DTO
                    {
                        MaSP = Convert.ToInt32(row["MaSP"]),
                        MaNCC = Convert.ToInt32(row["MaNCC"]),
                        MaDM = Convert.ToInt32(row["MaDM"]),
                        TenSP = row["TenSP"].ToString(),
                      
                        MieuTaSP = row["MieuTaSP"].ToString(),
                        DonGia = Convert.ToDecimal(row["DonGia"]),
                        TrangThaiSP = row["TrangThaiSP"].ToString(),
                        AnhSP = row["AnhSP"].ToString()
                    };

                    danhSachSanPham.Add(sanPham);
                }

                return danhSachSanPham;
            }
            catch (Exception ex)
            {
                // Handle exception
                return null;
            }
        }
    }
}
