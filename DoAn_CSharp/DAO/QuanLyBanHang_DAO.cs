using DoAn_CSharp.Database;
using DoAn_CSharp.DTO;
using System.Collections.Generic;
using System.Data;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAn_CSharp.DAO
{
    internal class QuanLyBanHang_DAO
    {
        private Database.Database db;

        public QuanLyBanHang_DAO()
        {
            db = new Database.Database();
        }

        public DataTable LayDanhSachSizes()
        {
            string strSQL = "Select * from Sizes";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public int LaySoLuongSanPhamSize(QuanLyBanHang_DTO quanLyBanHang_DTO)
        {
            try
            {
                string strSQL = $"SELECT SoLuongSP FROM SanPhamSize WHERE MaSP='{quanLyBanHang_DTO.MaSP}' AND MaSize='{quanLyBanHang_DTO.MaSize}'";
                object result = db.ExecuteScalar(strSQL);

                // Check if the result is not null
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }   

            // Return a default value or throw an exception based on your requirements
            return -1; // Change this to an appropriate default value
        }

        public List<QuanLyBanHang_DTO> LayDanhSachSanPhamDanhMuc(int maDanhMuc)
        {
            try
            {
                string strSQL = $"SELECT * FROM sanpham WHERE MaDM = {maDanhMuc}";
                DataTable dt = db.Execute(strSQL);

                List<QuanLyBanHang_DTO> danhSachSanPham = new List<QuanLyBanHang_DTO>();

                foreach (DataRow row in dt.Rows)
                {
                    QuanLyBanHang_DTO sanPham = new QuanLyBanHang_DTO
                    {
                        MaSP = Convert.ToInt32(row["MaSP"]),
                        MaNCC = Convert.ToInt32(row["MaNCC"]),
                        MaDM = Convert.ToInt32(row["MaDM"]),
                        TenSP = row["TenSP"].ToString(),
             /*           SizeSP = row["SizeSP"].ToString(),*/
               /*         SoLuongSP = Convert.ToInt32(row["SoLuongSP"]),*/
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
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }
        public List<GiamGia_DTO> LayDanhSachGiamGiaHieuLuc()
        {
            List<GiamGia_DTO> danhSachGiamGia = new List<GiamGia_DTO>();

            try
            {
                string strSQL = "SELECT * FROM giamgia WHERE NgayBatDau <= GETDATE() AND NgayKetThuc >= GETDATE()";
                DataTable dt = db.Execute(strSQL);

                foreach (DataRow row in dt.Rows)
                {
                    GiamGia_DTO giamGia = new GiamGia_DTO
                    {
                        MaGiamGia = Convert.ToInt32(row["MaGiamGia"]),
                        TenGiamGia = row["TenGiamGia"].ToString(),
                        SoLuongGG = Convert.ToInt32(row["SoLuongGG"]),
                        PhanTramGiam = Convert.ToInt32(row["PhanTramGiam"]),
                        NgayBatDau = Convert.ToDateTime(row["NgayBatDau"]),
                        NgayKetThuc = Convert.ToDateTime(row["NgayKetThuc"]),
                        DieuKienGiamGia = Convert.ToDecimal(row["DieuKienGiamGia"])
                       
                    };

                    danhSachGiamGia.Add(giamGia);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions according to your needs
                Console.WriteLine("Error: " + ex.Message);
            }

            return danhSachGiamGia;
        }

        public List<QuanLyBanHang_DTO> LayThongTinSanPham(string productId, string sizeId)
        {
            try
            {
                string strSQL = $"SELECT sp.TenSP, sz.TenSize, sp.DonGia " +
                                $"FROM sanpham sp " +
                                $"JOIN SanPhamSize ss ON sp.MaSP = ss.MaSP " +
                                $"JOIN Sizes sz ON ss.MaSize = sz.MaSize " +
                                $"WHERE sp.MaSP = {productId} AND sz.MaSize = {sizeId}";

                DataTable dt = db.Execute(strSQL);

                List<QuanLyBanHang_DTO> danhSachSanPham = new List<QuanLyBanHang_DTO>();

                foreach (DataRow row in dt.Rows)
                {
                    QuanLyBanHang_DTO sanPham = new QuanLyBanHang_DTO
                    {
                        TenSP = row["TenSP"].ToString(),
                        TenSize = row["TenSize"].ToString(),
                        DonGia = Convert.ToDecimal(row["DonGia"]),
                        // You might want to add other properties if needed
                    };

                    danhSachSanPham.Add(sanPham);
                }

                return danhSachSanPham;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }
        // Inside QuanLyBanHang_DAO class
        public DataTable LayDanhSachSizesWithQuantityGreaterThanOne(string maSP)
        {
            using (SqlConnection connection = new SqlConnection("Server=LAPTOP-PEQVO1V4\\ALINSBTC;Database=QuanLyBanGiay4;uid=sa;pwd=123"))
            {
                connection.Open();

                string query = "SELECT Sizes.MaSize, Sizes.TenSize FROM Sizes " +
                               "INNER JOIN SanPhamSize ON Sizes.MaSize = SanPhamSize.MaSize " +
                               "WHERE SanPhamSize.MaSP = @MaSP AND SanPhamSize.SoLuongSP > 1;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaSP", maSP);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }

        public int GetAvailableQuantity(int maSP, int maSize)
        {
            using (SqlConnection connection = new SqlConnection("Server=LAPTOP-PEQVO1V4\\ALINSBTC;Database=QuanLyBanGiay4;uid=sa;pwd=123"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT SoLuongSP FROM SanPhamSize WHERE MaSP = @MaSP AND MaSize = @MaSize;", connection);
                command.Parameters.AddWithValue("@MaSP", maSP);
                command.Parameters.AddWithValue("@MaSize", maSize);

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int availableQuantity))
                {
                    return availableQuantity;
                }
                else
                {
                    return 0; // Return 0 if there's an issue retrieving the quantity
                }
            }
        }






    }
}
