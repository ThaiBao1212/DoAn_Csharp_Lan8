using DoAn_CSharp.DTO;
using System.Data;
using System.Data.SqlClient;

namespace DoAn_CSharp.DAO
{
    internal class GiamGia_DAO
    {
        private readonly Database.Database db;

        public GiamGia_DAO()
        {
            db = new Database.Database();
        }

        public DataTable LayDanhSachGiamGia(GiamGia_DTO giamGia_DTO)
        {
            string strSQL = "SELECT * FROM giamgia WHERE SoLuongGG > 0 AND DieuKienGiamGia <= @DieuKienGiamGia";

            // Use parameterized query to prevent SQL injection
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@DieuKienGiamGia", giamGia_DTO.DieuKienGiamGia)
            };

            DataTable dt = db.Execute(strSQL, parameters);

            return dt;
        }
    }
}
