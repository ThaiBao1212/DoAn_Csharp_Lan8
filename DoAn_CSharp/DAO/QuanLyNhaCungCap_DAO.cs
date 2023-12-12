using DoAn_CSharp.Databsase;
using DoAn_CSharp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_CSharp.DAO
{
    public class QuanLyNhaCungCap_DAO
    {

        private Databsase.Database db;
        public QuanLyNhaCungCap_DAO()
        {
            db = new Databsase.Database();

        }

        Database_TB provider = new Database_TB();
        public DataTable LayDanhSachSanPhamTrongNhaCungCap(QuanLyNhaCungCap_DTO ql_NhaCungCap_DTO)
        {
            // Sử dụng thẳng giá trị MaNCC trong câu lệnh SQL
            string strSQL = $"SELECT * FROM sanpham WHERE MaNCC = {ql_NhaCungCap_DTO.MaNCC}";

            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public bool ThemNhaCungCapNhanh(QuanLyNhaCungCap_DTO nhacungcap)
        {
            try
            {
                // Thực hiện câu truy vấn thêm khách hàng vào cơ sở dữ liệu
                string query = $"INSERT INTO nhacungcap (TenNCC, DiaChiNCC, SDTNCC, Email) " +
                               $"VALUES (N'{nhacungcap.TenNCC}', N'{nhacungcap.DiaChiNCC}', N'{nhacungcap.SDTNCC}', " +
                               $"N'{nhacungcap.Email}')";

                // Gọi phương thức ExecuteNonQuery từ đối tượng Database để thực hiện câu truy vấn
                provider.ExecuteNonQuery(query);

                return true;
            }
            catch (Exception ex)
            {
                // Xử lý exception nếu có
                Console.WriteLine("Error adding customer: " + ex.Message);
                return false;
            }
        }

    }
}
