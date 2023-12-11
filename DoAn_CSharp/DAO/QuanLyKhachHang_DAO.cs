using DoAn_CSharp.Database;
using DoAn_CSharp.DTO;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using DoAn_CSharp.DAO;
using System.Windows.Navigation;


namespace DoAn_CSharp.DAO
{
    public class QuanLyKhachHang_DAO
    {
        private Database_TB provider = new Database_TB();


        public List<QuanLyKhachHang_DTO> GetKhachHang()
        {
            List<QuanLyKhachHang_DTO> list_KH = new List<QuanLyKhachHang_DTO>();

            string query = "SELECT * From khachhang";
            DataTable data = provider.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                QuanLyKhachHang_DTO khachhang = new QuanLyKhachHang_DTO()
                {
                    //MaKH = Convert.ToInt32(row["MaNCC"]);
                    MaKH = row["MaKH"].ToString(),
                    HoTenKH = row["HoTenKH"].ToString(),
                    DiaChiKH = row["DiaChiKH"].ToString(),
                    SDTKH = row["SDTKH"].ToString(),
                    CMNDKH = row["CMNDKH"].ToString(),
                    GioiTinhKH = row["GioiTinhKH"].ToString(),
                    TrangThaiKH = row["TrangThaiKH"].ToString()
                };

                if (!string.IsNullOrEmpty(khachhang.MaKH)) // Kiểm tra MaKH có giá trị không
                {
                    list_KH.Add(khachhang);
                }

            }
            return list_KH;
        }


        public bool DeleteKhachHang(string maKH)
        {
            try
            {
                // Thực hiện câu truy vấn xóa nhân viên từ cơ sở dữ liệu
                string query = $"DELETE FROM khachhang WHERE MaKH = '{maKH}'";

                // Gọi phương thức ExecuteNonQuery từ đối tượng Database để thực hiện câu truy vấn
                provider.ExecuteNonQuery(query);

                return true;
            }
            catch (Exception ex)
            {
                // Xử lý exception nếu có
                Console.WriteLine("Error deleting employee: " + ex.Message);
                return false;
            }
        }




        public bool ThemKhachHang(QuanLyKhachHang_DTO khachHang)
        {
            try
            {
                // Thực hiện câu truy vấn thêm khách hàng vào cơ sở dữ liệu
                string query = $"INSERT INTO khachhang (HoTenKH, DiaChiKH, SDTKH, CMNDKH, GioiTinhKH, TrangThaiKH) " +
                               $"VALUES (N'{khachHang.HoTenKH}', N'{khachHang.DiaChiKH}', N'{khachHang.SDTKH}', " +
                               $"N'{khachHang.CMNDKH}', N'{khachHang.GioiTinhKH}', N'{khachHang.TrangThaiKH}')";

                // Gọi phương thức ExecuteNonQuery từ đối tượng Database để thực hiện câu truy vấn
                provider.ExecuteNonQuery(query);

                return true;
            }
            catch (Exception ex)
            {
                // Xử lý exception nếu có
                Console.WriteLine("Error adding customer: " + ex.Message);
                return false;
            }
        }
        public bool UpdateKhachHang(string maKH, string hoTenKH, string diaChiKH, string sdtKH, string cmndKH,
                             string gioiTinhKH, string trangThaiKH)
        {
            try
            {
                // Thực hiện câu truy vấn cập nhật thông tin khách hàng trong cơ sở dữ liệu
                string query = $"UPDATE khachhang SET HoTenKH = N'{hoTenKH}', DiaChiKH = N'{diaChiKH}', " +
                               $"SDTKH = N'{sdtKH}', CMNDKH = N'{cmndKH}', " +
                               $"GioiTinhKH = N'{gioiTinhKH}', TrangThaiKH = N'{trangThaiKH}' " +
                               $"WHERE MaKH = '{maKH}'";

                // Gọi phương thức ExecuteNonQuery từ đối tượng Database để thực hiện câu truy vấn
                provider.ExecuteNonQuery(query);

                return true;
            }
            catch (Exception ex)
            {
                // Xử lý exception nếu có
                Console.WriteLine("Error updating customer: " + ex.Message);
                return false;
            }
        }


        public List<QuanLyKhachHang_DTO> TimKiemKhachHangTatCa(string tuKhoa)
        {
            // Thực hiện câu truy vấn tìm kiếm theo tất cả các trường trong bảng khachhang
            string query = $"SELECT * FROM khachhang WHERE HoTenKH LIKE N'%{tuKhoa}%' OR MaKH LIKE N'%{tuKhoa}%' OR SDTKH LIKE N'%{tuKhoa}%' OR TrangThaiKH LIKE N'%{tuKhoa}%' OR CMNDKH LIKE N'%{tuKhoa}%'  OR GioiTinhKH LIKE N'%{tuKhoa}%' ";
            DataTable data = provider.ExecuteQuery(query);

            List<QuanLyKhachHang_DTO> ketQua = new List<QuanLyKhachHang_DTO>();
            foreach (DataRow row in data.Rows)
            {
                QuanLyKhachHang_DTO khachHang = new QuanLyKhachHang_DTO()
                {
                    MaKH = row["MaKH"].ToString(),
                    HoTenKH = row["HoTenKH"].ToString(),
                    DiaChiKH = row["DiaChiKH"].ToString(),
                    SDTKH = row["SDTKH"].ToString(),
                    CMNDKH = row["CMNDKH"].ToString(),
                    GioiTinhKH = row["GioiTinhKH"].ToString(),
                    TrangThaiKH = row["TrangThaiKH"].ToString()
                };
                ketQua.Add(khachHang);
            }

            return ketQua;
        }


        public List<QuanLyKhachHang_DTO> TimKiemKhachHangTheoHoTen(string hoTenKH)
        {
            // Thực hiện câu truy vấn tìm kiếm theo họ tên trong bảng khachhang
            string query = $"SELECT * FROM khachhang WHERE HoTenKH LIKE N'%{hoTenKH}%'";
            DataTable data = provider.ExecuteQuery(query);

            List<QuanLyKhachHang_DTO> ketQua = new List<QuanLyKhachHang_DTO>();
            foreach (DataRow row in data.Rows)
            {
                QuanLyKhachHang_DTO khachHang = new QuanLyKhachHang_DTO()
                {
                    MaKH = row["MaKH"].ToString(),
                    HoTenKH = row["HoTenKH"].ToString(),
                    DiaChiKH = row["DiaChiKH"].ToString(),
                    SDTKH = row["SDTKH"].ToString(),
                    CMNDKH = row["CMNDKH"].ToString(),
                    GioiTinhKH = row["GioiTinhKH"].ToString(),
                    TrangThaiKH = row["TrangThaiKH"].ToString()
                };
                ketQua.Add(khachHang);
            }

            return ketQua;
        }

        public List<QuanLyKhachHang_DTO> TimKiemKhachHangTheoMaKH(string makH)
        {
            // Thực hiện câu truy vấn tìm kiếm theo họ tên trong bảng khachhang
            string query = $"SELECT * FROM khachhang WHERE MaKH LIKE N'%{makH}%'";
            DataTable data = provider.ExecuteQuery(query);

            List<QuanLyKhachHang_DTO> ketQua = new List<QuanLyKhachHang_DTO>();
            foreach (DataRow row in data.Rows)
            {
                QuanLyKhachHang_DTO khachHang = new QuanLyKhachHang_DTO()
                {
                    MaKH = row["MaKH"].ToString(),
                    HoTenKH = row["HoTenKH"].ToString(),
                    DiaChiKH = row["DiaChiKH"].ToString(),
                    SDTKH = row["SDTKH"].ToString(),
                    CMNDKH = row["CMNDKH"].ToString(),
                    GioiTinhKH = row["GioiTinhKH"].ToString(),
                    TrangThaiKH = row["TrangThaiKH"].ToString()
                };
                ketQua.Add(khachHang);
            }

            return ketQua;
        }

        public List<QuanLyKhachHang_DTO> TimKiemKhachHangTheoDiaChiKH(string tuKhoa)
        {
            // Thực hiện câu truy vấn tìm kiếm theo họ tên trong bảng khachhang
            string query = $"SELECT * FROM khachhang WHERE DiaChiKH LIKE N'%{tuKhoa}%'";
            DataTable data = provider.ExecuteQuery(query);

            List<QuanLyKhachHang_DTO> ketQua = new List<QuanLyKhachHang_DTO>();
            foreach (DataRow row in data.Rows)
            {
                QuanLyKhachHang_DTO khachHang = new QuanLyKhachHang_DTO()
                {
                    MaKH = row["MaKH"].ToString(),
                    HoTenKH = row["HoTenKH"].ToString(),
                    DiaChiKH = row["DiaChiKH"].ToString(),
                    SDTKH = row["SDTKH"].ToString(),
                    CMNDKH = row["CMNDKH"].ToString(),
                    GioiTinhKH = row["GioiTinhKH"].ToString(),
                    TrangThaiKH = row["TrangThaiKH"].ToString()
                };
                ketQua.Add(khachHang);
            }

            return ketQua;
        }
        public List<QuanLyKhachHang_DTO> TimKiemKhachHangTheoTrangThaiKH(string tuKhoa)
        {
            // Thực hiện câu truy vấn tìm kiếm theo họ tên trong bảng khachhang
            string query = $"SELECT * FROM khachhang WHERE TrangThaiKH LIKE N'%{tuKhoa}%'";
            DataTable data = provider.ExecuteQuery(query);

            List<QuanLyKhachHang_DTO> ketQua = new List<QuanLyKhachHang_DTO>();
            foreach (DataRow row in data.Rows)
            {
                QuanLyKhachHang_DTO khachHang = new QuanLyKhachHang_DTO()
                {
                    MaKH = row["MaKH"].ToString(),
                    HoTenKH = row["HoTenKH"].ToString(),
                    DiaChiKH = row["DiaChiKH"].ToString(),
                    SDTKH = row["SDTKH"].ToString(),
                    CMNDKH = row["CMNDKH"].ToString(),
                    GioiTinhKH = row["GioiTinhKH"].ToString(),
                    TrangThaiKH = row["TrangThaiKH"].ToString()
                };
                ketQua.Add(khachHang);
            }

            return ketQua;
        }
        public List<QuanLyKhachHang_DTO> TimKiemKhachHangTheoGioiTinhKH(string tuKhoa)
        {
            // Thực hiện câu truy vấn tìm kiếm theo họ tên trong bảng khachhang
            string query = $"SELECT * FROM khachhang WHERE GioiTinhKH LIKE N'%{tuKhoa}%'";
            DataTable data = provider.ExecuteQuery(query);

            List<QuanLyKhachHang_DTO> ketQua = new List<QuanLyKhachHang_DTO>();
            foreach (DataRow row in data.Rows)
            {
                QuanLyKhachHang_DTO khachHang = new QuanLyKhachHang_DTO()
                {
                    MaKH = row["MaKH"].ToString(),
                    HoTenKH = row["HoTenKH"].ToString(),
                    DiaChiKH = row["DiaChiKH"].ToString(),
                    SDTKH = row["SDTKH"].ToString(),
                    CMNDKH = row["CMNDKH"].ToString(),
                    GioiTinhKH = row["GioiTinhKH"].ToString(),
                    TrangThaiKH = row["TrangThaiKH"].ToString()
                };
                ketQua.Add(khachHang);
            }

            return ketQua;
        }
        public List<QuanLyKhachHang_DTO> TimKiemKhachHangTheoSDTKH(string tuKhoa)
        {
            // Thực hiện câu truy vấn tìm kiếm theo họ tên trong bảng khachhang
            string query = $"SELECT * FROM khachhang WHERE SDTKH LIKE N'%{tuKhoa}%'";
            DataTable data = provider.ExecuteQuery(query);

            List<QuanLyKhachHang_DTO> ketQua = new List<QuanLyKhachHang_DTO>();
            foreach (DataRow row in data.Rows)
            {
                QuanLyKhachHang_DTO khachHang = new QuanLyKhachHang_DTO()
                {
                    MaKH = row["MaKH"].ToString(),
                    HoTenKH = row["HoTenKH"].ToString(),
                    DiaChiKH = row["DiaChiKH"].ToString(),
                    SDTKH = row["SDTKH"].ToString(),
                    CMNDKH = row["CMNDKH"].ToString(),
                    GioiTinhKH = row["GioiTinhKH"].ToString(),
                    TrangThaiKH = row["TrangThaiKH"].ToString()
                };
                ketQua.Add(khachHang);
            }

            return ketQua;
        }
        public List<QuanLyKhachHang_DTO> TimKiemKhachHangTheoCMNDKH(string tuKhoa)
        {
            // Thực hiện câu truy vấn tìm kiếm theo họ tên trong bảng khachhang
            string query = $"SELECT * FROM khachhang WHERE CMNDKH LIKE N'%{tuKhoa}%'";
            DataTable data = provider.ExecuteQuery(query);

            List<QuanLyKhachHang_DTO> ketQua = new List<QuanLyKhachHang_DTO>();
            foreach (DataRow row in data.Rows)
            {
                QuanLyKhachHang_DTO khachHang = new QuanLyKhachHang_DTO()
                {
                    MaKH = row["MaKH"].ToString(),
                    HoTenKH = row["HoTenKH"].ToString(),
                    DiaChiKH = row["DiaChiKH"].ToString(),
                    SDTKH = row["SDTKH"].ToString(),
                    CMNDKH = row["CMNDKH"].ToString(),
                    GioiTinhKH = row["GioiTinhKH"].ToString(),
                    TrangThaiKH = row["TrangThaiKH"].ToString()
                };
                ketQua.Add(khachHang);
            }

            return ketQua;
        }

        // Kiểm tra tên khách hàng đã tồn tại hay chưa 

        public bool IsTenKhachHangExists(string tenKhachHang)
        {
            string query = $"SELECT COUNT(*) FROM khachhang WHERE HoTenKH = N'{tenKhachHang}'";
            int count = Convert.ToInt32(provider.ExecuteScalar(query));

            return count > 0;
        }
        public bool IsTenKhachHangExists(string tenKhachHang, string maKH)
        {
            try
            {
                // Thực hiện câu truy vấn kiểm tra tên tài khoản tồn tại trong cơ sở dữ liệu
                string query = $"SELECT COUNT(*) FROM khachhang WHERE HoTenKH = N'{tenKhachHang}' AND MaKH <> N'{maKH}'";
                int count = Convert.ToInt32(provider.ExecuteScalar(query));

                // Trả về true nếu tên tài khoản tồn tại, ngược lại trả về false
                return count > 0;
            }
            catch (Exception ex)
            {
                // Xử lý exception nếu có
                Console.WriteLine("Error checking customer existence: " + ex.Message);
                return false;
            }
        }





        /*public bool UpdateKhachHang(string maKH, string hoTenKH, string diaChiKH, string sdtKH, string cmndKH,
                            string gioiTinhKH, string trangThaiKH)
        {
            try
            {
                // Thực hiện câu truy vấn cập nhật thông tin nhân viên trong cơ sở dữ liệu
                string query = $"UPDATE khachhang SET MaKH = N'{maKH}', HoTenKH = N'{hoTenKH}', " +
                               $"DiaChiKH = N'{diaChiKH}', SDTKH = N'{sdtKH}', " +
                               $"CMNDKH = N'{cmndKH}', GioiTinhKH = N'{gioiTinhKH}', TrangThaiKH = N'{trangThaiKH}' " +
                               $"WHERE MaKH = '{maKH}'";

                // Gọi phương thức ExecuteNonQuery từ đối tượng Database để thực hiện câu truy vấn
                provider.ExecuteNonQuery(query);

                return true;
            }
            catch (Exception ex)
            {
                // Xử lý exception nếu có
                Console.WriteLine("Error updating customer : " + ex.Message);
                return false;
            }
        }*/











    }
}