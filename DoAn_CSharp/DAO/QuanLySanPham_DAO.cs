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

                return null;
            }
        }
    }
}
