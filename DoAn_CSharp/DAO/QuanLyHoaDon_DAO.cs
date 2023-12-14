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
    internal class QuanLyHoaDon_DAO
    {
        private Database.Database db;

        // Constructor mặc định
        public QuanLyHoaDon_DAO()
        {
            db = new Database.Database();
        }

        // Constructor nhận một đối tượng Database khác
        public QuanLyHoaDon_DAO(Database.Database otherDatabase)
        {
            db = otherDatabase;
        }

        // Các phương thức khác của lớp DAO
        public DataTable LayDanhSachHoaDon()
        {
            try
            {
                string strSQL = "SELECT * FROM hoadon where TrangThaiHD=N'Mở'";
                DataTable dt = db.Execute(strSQL);
                return dt;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                return null;
            }
        }
        public int InsertHoaDon(int maKH, int maNV, DateTime ngayLapHD)
        {
            try
            {
                // Define the SQL query for inserting a new record into the hoadon table
                string strSQL = "INSERT INTO hoadon (MaKH, MaNV, NgayLapHD) VALUES (@MaKH, @MaNV, @NgayLapHD); SELECT SCOPE_IDENTITY();";

                // Set up the parameters for the query
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@MaKH", maKH),
            new SqlParameter("@MaNV", maNV),
            new SqlParameter("@NgayLapHD", ngayLapHD)
                };

                // Execute the query and retrieve the newly inserted ID
                int newHoaDonID = Convert.ToInt32(db.ExecuteScalar(strSQL, parameters));

                return newHoaDonID;
            }
            catch (Exception ex)
            {
                // Handle the exception (log, display an error message, etc.)
                Console.WriteLine($"Error inserting HoaDon: {ex.Message}");
                return -1; // Or throw an exception
            }
        }




    }
}
