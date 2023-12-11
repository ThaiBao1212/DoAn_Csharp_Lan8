using DoAn_CSharp.Database;
using DoAn_CSharp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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

      



    }
}
