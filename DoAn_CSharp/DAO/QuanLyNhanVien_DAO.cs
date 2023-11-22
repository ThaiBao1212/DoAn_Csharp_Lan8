using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DoAn_CSharp.Databsase;

namespace DoAn_CSharp.DAO
{
    public class QuanLyNhanVien_DAO
    {
        private DataProvider1 provider = new DataProvider1();
        public DataTable GetNhanVien()
        {
            string query = "SELECT nv.MaNV, nv.MaCV, cv.TenCV, nv.TenTaiKhoanNV, nv.MatKhauNV, nv.HoTenNV, nv.GioiTinhNV, nv.NgaySinh, nv.DiaChiNV, nv.EmailNV, nv.AnhNV, nv.SDTNV, nv.TrangThaiNV FROM nhanvien nv INNER JOIN chucvu cv ON nv.MaCV = cv.MaCV";
            return provider.ExecuteQuery(query);
        }



    }

}
