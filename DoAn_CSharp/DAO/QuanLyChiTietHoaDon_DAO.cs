using DoAn_CSharp.Database;
using DoAn_CSharp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_CSharp.DAO
{
    internal class QuanLyChiTietHoaDon_DAO
    {
        private Database.Database db;
        public QuanLyChiTietHoaDon_DAO()
        {
            db = new Database.Database();

        }
        public DataTable LayDanhSachChiTietDH(QuanLyChiTietHoaDon_DTO quanLyChiTietHoaDon_DTO)
        {
            try
            {
                string strSQL = $"SELECT * FROM chitiethd where MaHD =N'{quanLyChiTietHoaDon_DTO.MaHD}' ";
                DataTable dt = db.Execute(strSQL);
                return dt;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                return null;
            }
        }
        public bool InsertChiTietHoaDon(QuanLyChiTietHoaDon_DTO chiTietHoaDon)
        {
            try
            {
                // Assuming you have a chitiethd table with columns like MaHD, MaSP, SoLuong, DonGia, etc.

                // Use parameters to avoid SQL injection
                string strSQL = "INSERT INTO chitiethd (MaHD, MaSP, SoLuong, DonGia) " +
                                "VALUES (@MaHD, @MaSP, @SoLuong, @DonGia)";

                // Create an array of SqlParameter objects
                SqlParameter[] parameters =
                {
                    new SqlParameter("@MaHD", SqlDbType.Int) {Value = chiTietHoaDon.MaHD},
                    new SqlParameter("@MaSP", SqlDbType.Int) {Value = chiTietHoaDon.MaSP},
                    new SqlParameter("@SoLuong", SqlDbType.Int) {Value = chiTietHoaDon.SoLuong},
                    new SqlParameter("@DonGia", SqlDbType.Float) {Value = chiTietHoaDon.DonGia}
                    // Add more parameters as needed
                };

                // Execute the query with parameters
                int rowsAffected = db.ExecuteNonQuery(strSQL, parameters);

                // Check if the query was successful (rows affected > 0)
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                // Handle the exception
                return false;
            }
        }

    }
}
