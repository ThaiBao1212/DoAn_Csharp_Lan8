using DoAn_CSharp.Database;
using DoAn_CSharp.DTO;
using Microsoft.ReportingServices.Diagnostics.Internal;
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
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }
        // In the QuanLyHoaDon_DAO class
        public int InsertHoaDon(int maKH, int maNV)
        {
            try
            {
                // Assume you have a stored procedure or SQL command to insert a new order
                SqlCommand command = new SqlCommand("INSERT INTO hoadon (MaKH, MaNV, NgayLapHD) VALUES (@MaKH, @MaNV, @NgayLapHD); SELECT SCOPE_IDENTITY();", db.GetConnection());

                // Parameters
                command.Parameters.AddWithValue("@MaKH", maKH);
                command.Parameters.AddWithValue("@MaNV", maNV);
                command.Parameters.AddWithValue("@NgayLapHD", DateTime.Now);

                // Open the connection before executing the command
                db.GetConnection().Open();

                int maHD = Convert.ToInt32(command.ExecuteScalar());
                return maHD;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return -1;
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
