using DoAn_CSharp.Database;
using DoAn_CSharp.DTO;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DoAn_CSharp.DAO
{
    internal class QuanLyChiTietHoaDon_DAO
    {
        private Database.Database db;

        public QuanLyChiTietHoaDon_DAO()
        {
            db = new Database.Database();
        }

        // Other methods...

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
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }
         public void InsertChiTietHoaDon(int maHD, int maSP, int soLuong, float donGia)
        {
            try
            {
                // Open the connection before executing the command
                db.GetConnection().Open();

                // Assume you have a stored procedure or SQL command to insert a new order
                SqlCommand command = new SqlCommand("INSERT INTO chitiethd (MaHD, MaSP, DonGia, SoLuongSP, ThanhTien) VALUES (@MaHD, @MaSP, @DonGia, @SoLuongSP, @ThanhTien);", db.GetConnection());

                // Parameters
                command.Parameters.AddWithValue("@MaHD", maHD);
                command.Parameters.AddWithValue("@MaSP", maSP);
                command.Parameters.AddWithValue("@DonGia", donGia);
                command.Parameters.AddWithValue("@SoLuongSP", soLuong);
                command.Parameters.AddWithValue("@ThanhTien", donGia * soLuong);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                // Close the connection in the finally block to ensure it's closed even if an exception occurs
                if (db.GetConnection().State == ConnectionState.Open)
                {
                    db.GetConnection().Close();
                }
            }
        }


    }
}
