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
    public class QuanLyNhaCungCap_DAO
    {

        private Database.Database db;
        public QuanLyNhaCungCap_DAO()
        {
            db = new Database.Database();

        }
        public DataTable LayDanhSachSanPhamTrongNhaCungCap(QuanLyNhaCungCap_DTO ql_NhaCungCap_DTO)
        {
            // Sử dụng thẳng giá trị MaNCC trong câu lệnh SQL
            string strSQL = $"SELECT * FROM sanpham WHERE MaNCC = {ql_NhaCungCap_DTO.MaNCC}";

            DataTable dt = db.Execute(strSQL);
            return dt;
        }


    }
}