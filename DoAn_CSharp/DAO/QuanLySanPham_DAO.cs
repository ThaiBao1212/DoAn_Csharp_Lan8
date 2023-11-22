using DoAn_CSharp.Databsase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_CSharp.DAO
{
    internal class QuanLySanPham_DAO
    {
        private Database db;
        public QuanLySanPham_DAO()
        {
            db = new Database();

        }
        public DataTable LayDanhSachSanPham()
        {
            string strSQL = "Select * from sanpham";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
    }
}
