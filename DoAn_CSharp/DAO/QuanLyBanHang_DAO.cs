using DoAn_CSharp.Databsase;
using DoAn_CSharp.DTO;
using System.Collections.Generic;
using System.Data;
using System;

namespace DoAn_CSharp.DAO
{
    internal class QuanLyBanHang_DAO
    {
        private Database db;

        public QuanLyBanHang_DAO()
        {
            db = new Database();
        }

        public List<QuanLyBanHang_DTO> LayDanhSachSanPhamDanhMuc(int maDanhMuc)
        {
            try
            {
                string strSQL = $"SELECT * FROM sanpham WHERE MaDM = {maDanhMuc}";
                DataTable dt = db.Execute(strSQL);

                List<QuanLyBanHang_DTO> danhSachSanPham = new List<QuanLyBanHang_DTO>();

                foreach (DataRow row in dt.Rows)
                {
                    QuanLyBanHang_DTO sanPham = new QuanLyBanHang_DTO
                    {
                        MaSP = Convert.ToInt32(row["MaSP"]),
                        MaNCC = Convert.ToInt32(row["MaNCC"]),
                        MaDM = Convert.ToInt32(row["MaDM"]),
                        TenSP = row["TenSP"].ToString(),
                        SizeSP = row["SizeSP"].ToString(),
                        SoLuongSP = Convert.ToInt32(row["SoLuongSP"]),
                        MieuTaSP = row["MieuTaSP"].ToString(),
                        DonGia = Convert.ToDecimal(row["DonGia"]),
                        TrangThaiSP = row["TrangThaiSP"].ToString(),
                        AnhSP = row["AnhSP"].ToString()
                    };

                    danhSachSanPham.Add(sanPham);
                }

                return danhSachSanPham;
            }
            catch (Exception ex)
            {
                // Handle exception
                return null;
            }
        }
    }
}
