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


        public List<DTO.QuanLyNhanVien_DTO> GetNhanVien()
        {
            List<DTO.QuanLyNhanVien_DTO> listNhanVien = new List<DTO.QuanLyNhanVien_DTO>();
            string query = "SELECT nv.MaNV, nv.MaCV, cv.TenCV, nv.TenTaiKhoanNV, nv.MatKhauNV, nv.HoTenNV, nv.GioiTinhNV, nv.NgaySinh, nv.DiaChiNV, nv.EmailNV, nv.AnhNV, nv.SDTNV, nv.TrangThaiNV FROM nhanvien nv INNER JOIN chucvu cv ON nv.MaCV = cv.MaCV";
            DataTable data = provider.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                DTO.QuanLyNhanVien_DTO nhanVien = new DTO.QuanLyNhanVien_DTO()
                {
                    MaNV = row["MaNV"].ToString(),
                    MaCV = row["MaCV"].ToString(),
                    TenCV = row["TenCV"].ToString(),
                    TenTaiKhoanNV = row["TenTaiKhoanNV"].ToString(),
                    MatKhauNV = row["MatKhauNV"].ToString(),
                    HoTenNV = row["HoTenNV"].ToString(),
                    GioiTinhNV = row["GioiTinhNV"].ToString(),
                    NgaySinh = Convert.ToDateTime(row["NgaySinh"]),
                    DiaChiNV = row["DiaChiNV"].ToString(),
                    EmailNV = row["EmailNV"].ToString(),
                    AnhNV = row["AnhNV"].ToString(),
                    SDTNV = row["SDTNV"].ToString()
                    
                };
                listNhanVien.Add(nhanVien);
            }

            return listNhanVien;
        }


    }

}
