using DoAn_CSharp.Databsase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_CSharp.DAO
{
    public class QuanLyDanhMuc_DAO
    {
        private Database db;
        public QuanLyDanhMuc_DAO()
        {
            db = new Database();
        }
        public DataTable LayDanhSachDanhMuc()
        {
            string strSQL = "Select * from danhmuc";
            DataTable dt = db.ExecuteQuery(strSQL);
            return dt;
        }
    }
}
