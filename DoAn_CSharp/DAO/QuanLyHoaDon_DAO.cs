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
    public class QuanLyHoaDon_DAO
    {

        private Database_TB provider = new Database_TB();

        public List<QuanLyHoaDon_DTO> GetHoaDon()
        {
            List<QuanLyHoaDon_DTO> list_HD = new List<QuanLyHoaDon_DTO>();

            string query = "SELECT * FROM hoadon";
            DataTable data = provider.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                QuanLyHoaDon_DTO hoadon = new QuanLyHoaDon_DTO()
                {
                    MaHD = Convert.ToInt32(row["MaHD"]),
                    MaNV = Convert.ToInt32(row["MaNV"]),
                    MaKH = Convert.ToInt32(row["MaKH"]),
                    NgayLapHD = Convert.ToDateTime(row["NgayLapHD"]),
                    TrangThaiHD = row["TrangThaiHD"].ToString()
                };

                // Kiểm tra MaHD có giá trị không
                if (hoadon.MaHD > 0)
                {
                    list_HD.Add(hoadon);
                }
            }
            return list_HD;
        }

        public DataTable GetChiTietHoaDon(ChiTietHoaDon_DTO ct_HoaDon_DTO)
        {
            // Sử dụng thẳng giá trị MaPhieuNhap trong câu lệnh SQL
            string query = $"SELECT cthd.MaCTHD, sp.MaSP, sp.TenSP, cthd.SizeSP, cthd.SoLuongSP, cthd.DonGia, cthd.ThanhTien " +
                           $"FROM chitiethd cthd " +
                           $"JOIN sanpham sp ON cthd.MaSP = sp.MaSP " +
                           $"WHERE cthd.MaHD = {ct_HoaDon_DTO.MaHD}";

            DataTable data = provider.ExecuteQuery(query);
            return data;
        }



    }
}
