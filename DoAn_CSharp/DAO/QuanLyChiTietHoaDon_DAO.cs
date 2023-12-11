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
    internal class QuanLyChiTietHoaDon_DAO
    {
        private Database.Database db;
        public QuanLyChiTietHoaDon_DAO()
        {
            db = new Database.Database();

        }
        public DataTable LayDanhSachChiTietDH(QuanLyChiTietHoaDon_DTO quanLyChiTietHoaDon_DTO)
        {
            try
            {
                string strSQL = $"SELECT * FROM chitiethd where MaHD =N'{quanLyChiTietHoaDon_DTO.MaHD}' ";
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
