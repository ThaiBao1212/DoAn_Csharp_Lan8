using DoAn_CSharp.Databsase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_CSharp.DAO
{
    internal class QuanLyNhaCungCap_DAO
    {

        private Database db;
        public QuanLyNhaCungCap_DAO()
        {
            db = new Database ();
        }
        public DataTable LayDanhSachNhaCungCap()
        {
     
                string strSQL = $"Select * from nhacungcap";
               DataTable dt = db.Execute(strSQL);
                return dt;
                

            
         
        }
    }
}
