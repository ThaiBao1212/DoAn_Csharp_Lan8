using DoAn_CSharp.Databsase;
using DoAn_CSharp.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_CSharp.DAO
{
    public class QuanLyNhapHang_DAO
    {
        private Database_TB provider = new Database_TB();

        public List<QuanLyNhapHang_DTO> GetPhieuNhap()
        {
            List<QuanLyNhapHang_DTO> list_PN = new List<QuanLyNhapHang_DTO>();

            string query = "SELECT * FROM phieunhap";
            DataTable data = provider.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                QuanLyNhapHang_DTO phieuNhap = new QuanLyNhapHang_DTO()
                {
                    MaPhieuNhap = Convert.ToInt32(row["MaPhieuNhap"]),
                    MaNV = Convert.ToInt32(row["MaNV"]),
                    NgayLapPhieu = Convert.ToDateTime(row["NgayLapPhieu"]),
                    TrangThaiPN = row["TrangThaiPN"].ToString()
                };

                // Kiểm tra MaPhieuNhap có giá trị không
                if (phieuNhap.MaPhieuNhap > 0)
                {
                    list_PN.Add(phieuNhap);
                }
            }
            return list_PN;
        }
        public DataTable LayDanhSachChiTietPhieuNhap(QuanLyNhapHang_DTO ql_NhapHang_DTO)
        {
            // Sử dụng thẳng giá trị MaPhieuNhap trong câu lệnh SQL
            string query = $"SELECT ctpn.MaCTPN, ctpn.MaPhieuNhap, ctpn.MaSP, sp.TenSP, ctpn.SoLuongNhap " +
               $"FROM chitietphieunhap ctpn " +
               $"JOIN sanpham sp ON ctpn.MaSP = sp.MaSP " +
               $"WHERE ctpn.MaPhieuNhap = {ql_NhapHang_DTO.MaPhieuNhap}";

            DataTable data = provider.ExecuteQuery(query);
            return data;
        }



        public List<QuanLyNhapHang_DTO> TimKiemPhieuNhapTatCa(string tuKhoa = "")
        {
            string query = $"SELECT * FROM phieunhap WHERE " +
                           $"MaPhieuNhap LIKE '%{tuKhoa}%' OR " +
                           $"MaNV LIKE '%{tuKhoa}%' OR " +
                           $"NgayLapPhieu LIKE '%{tuKhoa}%' OR " +
                           $"TrangThaiPN LIKE N'%{tuKhoa}%'";

            DataTable data = provider.ExecuteQuery(query);

            List<QuanLyNhapHang_DTO> ketQua = new List<QuanLyNhapHang_DTO>();
            foreach (DataRow row in data.Rows)
            {
                QuanLyNhapHang_DTO phieuNhap = new QuanLyNhapHang_DTO();
                if (row["MaPhieuNhap"] != DBNull.Value)
                    phieuNhap.MaPhieuNhap = Convert.ToInt32(row["MaPhieuNhap"]);
                if (row["MaNV"] != DBNull.Value)
                    phieuNhap.MaNV = Convert.ToInt32(row["MaNV"]);
                if (row["NgayLapPhieu"] != DBNull.Value)
                    phieuNhap.NgayLapPhieu = Convert.ToDateTime(row["NgayLapPhieu"]);
                if (row["TrangThaiPN"] != DBNull.Value)
                    phieuNhap.TrangThaiPN = row["TrangThaiPN"].ToString();
                // Các trường khác nếu cần

                ketQua.Add(phieuNhap);
            }

            return ketQua;
        }

        public List<QuanLyNhapHang_DTO> TimKiemPhieuNhapTheoMaNhanVien(string tuKhoa = "")
        {
            string query = $"SELECT * FROM phieunhap WHERE MaNV LIKE N'%{tuKhoa}%'";

            DataTable data = provider.ExecuteQuery(query);

            List<QuanLyNhapHang_DTO> ketQua = new List<QuanLyNhapHang_DTO>();
            foreach (DataRow row in data.Rows)
            {
                QuanLyNhapHang_DTO phieuNhap = new QuanLyNhapHang_DTO();
                if (row["MaPhieuNhap"] != DBNull.Value)
                    phieuNhap.MaPhieuNhap = Convert.ToInt32(row["MaPhieuNhap"]);
                if (row["MaNV"] != DBNull.Value)
                    phieuNhap.MaNV = Convert.ToInt32(row["MaNV"]);
                if (row["NgayLapPhieu"] != DBNull.Value)
                    phieuNhap.NgayLapPhieu = Convert.ToDateTime(row["NgayLapPhieu"]);
                if (row["TrangThaiPN"] != DBNull.Value)
                    phieuNhap.TrangThaiPN = row["TrangThaiPN"].ToString();
                // Các trường khác nếu cần

                ketQua.Add(phieuNhap);
            }

            return ketQua;
        }

        public List<QuanLyNhapHang_DTO> TimKiemPhieuNhapTheoNgayLapPhieu(DateTime tuNgay, DateTime denNgay)
        {
            // Xây dựng câu truy vấn với điều kiện WHERE theo khoảng thời gian
            string query = $"SELECT * FROM phieunhap WHERE NgayLapPhieu BETWEEN '{tuNgay}' AND '{denNgay}'";

            // Thực hiện truy vấn
            DataTable data = provider.ExecuteQuery(query);

            // Khởi tạo danh sách kết quả
            List<QuanLyNhapHang_DTO> ketQua = new List<QuanLyNhapHang_DTO>();

            // Duyệt qua từng dòng dữ liệu và thêm vào danh sách
            foreach (DataRow row in data.Rows)
            {
                QuanLyNhapHang_DTO phieuNhap = new QuanLyNhapHang_DTO();

                // Kiểm tra và lấy giá trị từ cột, tránh lỗi DBNull
                if (row["MaPhieuNhap"] != DBNull.Value)
                    phieuNhap.MaPhieuNhap = Convert.ToInt32(row["MaPhieuNhap"]);
                if (row["MaNV"] != DBNull.Value)
                    phieuNhap.MaNV = Convert.ToInt32(row["MaNV"]);
                if (row["NgayLapPhieu"] != DBNull.Value)
                    phieuNhap.NgayLapPhieu = Convert.ToDateTime(row["NgayLapPhieu"]);
                if (row["TrangThaiPN"] != DBNull.Value)
                    phieuNhap.TrangThaiPN = row["TrangThaiPN"].ToString();
                // Các trường khác nếu cần

                // Thêm đối tượng vào danh sách
                ketQua.Add(phieuNhap);
            }

            // Trả về danh sách kết quả
            return ketQua;
        }




    }
}
    