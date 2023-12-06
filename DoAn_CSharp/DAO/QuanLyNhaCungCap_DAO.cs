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
        public DataTable LayDanhSachSanPhamTrongNhaCungCap(QuanLyNhaCungCap_DTO ql_NhaCungCap_DTO)
        {
            // Sử dụng thẳng giá trị MaNCC trong câu lệnh SQL
            string strSQL = $"SELECT * FROM sanpham WHERE MaNCC = {ql_NhaCungCap_DTO.MaNCC}";

            DataTable dt = db.Execute(strSQL);
            return dt;
        }


    }
}
