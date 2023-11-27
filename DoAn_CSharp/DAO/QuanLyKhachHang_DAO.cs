using DoAn_CSharp.Databsase;
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

            foreach(DataRow row in data.Rows)
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
