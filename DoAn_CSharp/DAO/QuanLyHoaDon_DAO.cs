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

        public List<QuanLyHoaDon_DTO> TimKiemHoaDonTatCa(string tuKhoa = "")
        {
            string query = $"SELECT * FROM hoadon WHERE " +
                           $"MaHD LIKE '%{tuKhoa}%' OR " +
                           $"MaKH LIKE '%{tuKhoa}%' OR " +
                           $"MaNV LIKE '%{tuKhoa}%' OR " +
                           $"NgayLapHD LIKE N'%{tuKhoa}%'";

            DataTable data = provider.ExecuteQuery(query);

            List<QuanLyHoaDon_DTO> ketQua = new List<QuanLyHoaDon_DTO>();
            foreach (DataRow row in data.Rows)
            {
                QuanLyHoaDon_DTO hoadon = new QuanLyHoaDon_DTO();
                if (row["MaHD"] != DBNull.Value)
                    hoadon.MaHD = Convert.ToInt32(row["MaHD"]);
                if (row["MaKH"] != DBNull.Value)
                    hoadon.MaKH = Convert.ToInt32(row["MaKH"]);
                if (row["MaNV"] != DBNull.Value)
                    hoadon.MaNV = Convert.ToInt32(row["MaNV"]);
                if (row["NgayLapHD"] != DBNull.Value)
                    hoadon.NgayLapHD = Convert.ToDateTime(row["NgayLapHD"]);
                // Các trường khác nếu cần

                ketQua.Add(hoadon);
            }

            return ketQua;
        }


        public List<QuanLyHoaDon_DTO> TimKiemHoaDonTheoMaHD(string tuKhoa = "")
        {
            string query = $"SELECT * FROM hoadon WHERE " +
                           $"MaHD LIKE '%{tuKhoa}%'";

            DataTable data = provider.ExecuteQuery(query);

            List<QuanLyHoaDon_DTO> ketQua = new List<QuanLyHoaDon_DTO>();
            foreach (DataRow row in data.Rows)
            {
                QuanLyHoaDon_DTO hoadon = new QuanLyHoaDon_DTO();
                if (row["MaHD"] != DBNull.Value)
                    hoadon.MaHD = Convert.ToInt32(row["MaHD"]);
                if (row["MaKH"] != DBNull.Value)
                    hoadon.MaKH = Convert.ToInt32(row["MaKH"]);
                if (row["MaNV"] != DBNull.Value)
                    hoadon.MaNV = Convert.ToInt32(row["MaNV"]);
                if (row["NgayLapHD"] != DBNull.Value)
                    hoadon.NgayLapHD = Convert.ToDateTime(row["NgayLapHD"]);
                // Các trường khác nếu cần

                ketQua.Add(hoadon);
            }

            return ketQua;
        }

        public List<QuanLyHoaDon_DTO> TimKiemHoaDonTheoMaNV(string tuKhoa = "")
        {
            string query = $"SELECT * FROM hoadon WHERE " +
                           $"MaNV LIKE '%{tuKhoa}%'";

            DataTable data = provider.ExecuteQuery(query);

            List<QuanLyHoaDon_DTO> ketQua = new List<QuanLyHoaDon_DTO>();
            foreach (DataRow row in data.Rows)
            {
                QuanLyHoaDon_DTO hoadon = new QuanLyHoaDon_DTO();
                if (row["MaHD"] != DBNull.Value)
                    hoadon.MaHD = Convert.ToInt32(row["MaHD"]);
                if (row["MaKH"] != DBNull.Value)
                    hoadon.MaKH = Convert.ToInt32(row["MaKH"]);
                if (row["MaNV"] != DBNull.Value)
                    hoadon.MaNV = Convert.ToInt32(row["MaNV"]);
                if (row["NgayLapHD"] != DBNull.Value)
                    hoadon.NgayLapHD = Convert.ToDateTime(row["NgayLapHD"]);
                // Các trường khác nếu cần

                ketQua.Add(hoadon);
            }

            return ketQua;
        }

        public List<QuanLyHoaDon_DTO> TimKiemHoaDonTheoMaKH(string tuKhoa = "")
        {
            string query = $"SELECT * FROM hoadon WHERE " +
                           $"MaKH LIKE '%{tuKhoa}%'";

            DataTable data = provider.ExecuteQuery(query);

            List<QuanLyHoaDon_DTO> ketQua = new List<QuanLyHoaDon_DTO>();
            foreach (DataRow row in data.Rows)
            {
                QuanLyHoaDon_DTO hoadon = new QuanLyHoaDon_DTO();
                if (row["MaHD"] != DBNull.Value)
                    hoadon.MaHD = Convert.ToInt32(row["MaHD"]);
                if (row["MaKH"] != DBNull.Value)
                    hoadon.MaKH = Convert.ToInt32(row["MaKH"]);
                if (row["MaNV"] != DBNull.Value)
                    hoadon.MaNV = Convert.ToInt32(row["MaNV"]);
                if (row["NgayLapHD"] != DBNull.Value)
                    hoadon.NgayLapHD = Convert.ToDateTime(row["NgayLapHD"]);
                // Các trường khác nếu cần

                ketQua.Add(hoadon);
            }

            return ketQua;
        }

        public List<QuanLyHoaDon_DTO> TimKiemHoaDonTheoNgayLapHD(DateTime tuNgay, DateTime denNgay)
        {
            string query = $"SELECT * FROM hoadon WHERE " +
                           $"NgayLapHD BETWEEN '{tuNgay}' AND '{denNgay}'";

            DataTable data = provider.ExecuteQuery(query);

            List<QuanLyHoaDon_DTO> ketQua = new List<QuanLyHoaDon_DTO>();

            foreach (DataRow row in data.Rows)
            {
                QuanLyHoaDon_DTO hoadon = new QuanLyHoaDon_DTO();
                if (row["MaHD"] != DBNull.Value)
                    hoadon.MaHD = Convert.ToInt32(row["MaHD"]);
                if (row["MaKH"] != DBNull.Value)
                    hoadon.MaKH = Convert.ToInt32(row["MaKH"]);
                if (row["MaNV"] != DBNull.Value)
                    hoadon.MaNV = Convert.ToInt32(row["MaNV"]);
                if (row["NgayLapHD"] != DBNull.Value)
                    hoadon.NgayLapHD = Convert.ToDateTime(row["NgayLapHD"]);
                // Các trường khác nếu cần

                ketQua.Add(hoadon);
            }

            return ketQua;
        }


    }
}