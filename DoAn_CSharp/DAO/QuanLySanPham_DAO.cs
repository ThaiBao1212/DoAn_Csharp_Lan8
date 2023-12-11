
using DoAn_CSharp.Database;
using DoAn_CSharp.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace DoAn_CSharp.DAO
{
    internal class QuanLySanPham_DAO
    {
        private readonly Database.Database db;

        public QuanLySanPham_DAO()
        {
            db = new Database.Database();
        }

        public DataTable LayDanhSachSanPham()
        {
            string strSQL = "Select * from sanpham";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public QuanLySanPham_DTO LayChiTietSanPham(int maSP)
        {
            try
            {
                string strSQL = $"SELECT sp.MaSP, TenSP, ncc.TenNCC, dm.TenDM, sp.DonGia, sp.AnhSP, sp.MieuTaSP, sp.TrangThaiSP " +
                 "FROM sanpham sp " +
                 "JOIN nhacungcap ncc ON sp.MaNCC = ncc.MaNCC " +
                 "JOIN danhmuc dm ON dm.MaDanhMuc = sp.MaDM " +
                 $"WHERE MaSP = '{maSP}'";

                DataTable dt = db.Execute(strSQL);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    // Map DataRow to QuanLySanPham_DTO
                    QuanLySanPham_DTO sanPham = new QuanLySanPham_DTO
                    {
                        MaSP = Convert.ToInt32(row["MaSP"]),
                        TenSP = row["TenSP"].ToString(),
                        TenNCC = row["TenNCC"].ToString(),
                        TenDM = row["TenDM"].ToString(),
                        MieuTaSP = row["MieuTaSP"].ToString(),
                        DonGia = Convert.ToDecimal(row["DonGia"]),
                        TrangThaiSP = row["TrangThaiSP"].ToString(),
                        AnhSP = row["AnhSP"].ToString()
                    };

                    return sanPham;
                }

                return null;
            }
            catch (Exception ex)
            {
                // Handle exception
                return null;
            }
        }
      


        public List<QuanLySanPham_DTO> LayDanhSachSanPhamDanhMuc(int maDanhMuc)
        {
            try
            {
                string strSQL = $"SELECT * FROM sanpham WHERE MaDM = {maDanhMuc}";
                DataTable dt = db.Execute(strSQL);

                // Convert DataTable to a list of QuanLySanPham_DTO objects
                List<QuanLySanPham_DTO> danhSachSanPham = new List<QuanLySanPham_DTO>();
                foreach (DataRow row in dt.Rows)
                {
                    // Map DataRow to QuanLySanPham_DTO
                    QuanLySanPham_DTO sanPham = new QuanLySanPham_DTO
                    {
                        MaSP = Convert.ToInt32(row["MaSP"]),
                        // Map other properties
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

        public List<QuanLySanPham_DTO> LayDanhSachSanPhamBan()
        {
            try
            {
                string strSQL = "SELECT * FROM sanpham";
                DataTable dt = db.Execute(strSQL);

                // Chuyển đổi DataTable thành List<QuanLySanPham_DTO>
                List<QuanLySanPham_DTO> danhSachSanPham = new List<QuanLySanPham_DTO>();

                foreach (DataRow row in dt.Rows)
                {
                    QuanLySanPham_DTO sanPham = new QuanLySanPham_DTO
                    {
                        MaSP = Convert.ToInt32(row["MaSP"]),
                        MaNCC = Convert.ToInt32(row["MaNCC"]),
                        MaDM = Convert.ToInt32(row["MaDM"]),
                        TenSP = row["TenSP"].ToString(),
                      
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
