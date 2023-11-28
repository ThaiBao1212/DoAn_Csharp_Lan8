﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DoAn_CSharp.Databsase;
using System.Data.SqlClient;
using System.Windows.Forms;
using DoAn_CSharp.DTO;
using System.Collections;

namespace DoAn_CSharp.DAO
{
    public class QuanLyNhanVien_DAO
    {
        private Database_TB provider = new Database_TB();


        public List<DTO.QuanLyNhanVien_DTO> GetNhanVien()
        {
            List<DTO.QuanLyNhanVien_DTO> listNhanVien = new List<DTO.QuanLyNhanVien_DTO>();
            string query = "SELECT nv.MaNV, nv.MaCV, cv.TenCV, nv.TenTaiKhoanNV, nv.MatKhauNV, nv.HoTenNV, nv.GioiTinhNV, nv.NgaySinh, nv.DiaChiNV, nv.EmailNV, nv.AnhNV, nv.SDTNV,nv.CMNDNV ,nv.TrangThaiNV FROM nhanvien nv INNER JOIN chucvu cv ON nv.MaCV = cv.MaCV";
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
                    SDTNV = row["SDTNV"].ToString(),
                    CMNDNV = row["CMNDNV"].ToString()

                };
               

                if (!string.IsNullOrEmpty(nhanVien.MaNV)) // Kiểm tra MaKH có giá trị không
                {
                    listNhanVien.Add(nhanVien);
                }
            }

            return listNhanVien;
        }

        public List<string> GetMaChucVu()
        {
            List<string> listMaChucVu = new List<string>();
            string query = "SELECT MaCV FROM chucvu";
            DataTable data = provider.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                listMaChucVu.Add(row["MaCV"].ToString());
            }

            return listMaChucVu;
        }

        public string GetTenChucVu(string maChucVu)
        {
            string query = $"SELECT TenCV FROM chucvu WHERE MaCV = '{maChucVu}'";
            DataTable data = provider.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                return data.Rows[0]["TenCV"].ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        public bool AddNhanVien(string maCV, string tenTaiKhoanNV, string matKhauNV, string hoTenNV,
                             string gioiTinhNV, DateTime ngaySinhNV, string diaChiNV,
                             string emailNV, string sdtNV, string cmndNV,string anhNV)
        {
            try
            {
                // Thực hiện câu truy vấn thêm nhân viên vào cơ sở dữ liệu
                string query = $"INSERT INTO nhanvien (MaCV, TenTaiKhoanNV, MatKhauNV, HoTenNV, GioiTinhNV, NgaySinh, DiaChiNV, EmailNV, SDTNV, CMNDNV,AnhNV) " +
                               $"VALUES (N'{maCV}', N'{tenTaiKhoanNV}', N'{matKhauNV}', N'{hoTenNV}', N'{gioiTinhNV}', N'{ngaySinhNV.ToString("yyyy-MM-dd")}', " +
                               $"N'{diaChiNV}', N'{emailNV}', N'{sdtNV}', N'{cmndNV}',N'{anhNV}')";

                // Gọi phương thức ExecuteNonQuery từ đối tượng Database để thực hiện câu truy vấn
                provider.ExecuteNonQuery(query);

                return true;
            }
            catch (Exception ex)
            {
                // Xử lý exception nếu có
                Console.WriteLine("Error adding employee: " + ex.Message);
                return false;
            }
        }


        public bool UpdateNhanVien(string maNV, string maCV, string tenTaiKhoanNV, string matKhauNV, string hoTenNV,
                            string gioiTinhNV, DateTime ngaySinhNV, string diaChiNV,
                            string emailNV, string sdtNV, string cmndNV, string anhNV)
        {
            try
            {
                // Thực hiện câu truy vấn cập nhật thông tin nhân viên trong cơ sở dữ liệu
                string query = $"UPDATE nhanvien SET MaCV = N'{maCV}', TenTaiKhoanNV = N'{tenTaiKhoanNV}', " +
                               $"MatKhauNV = N'{matKhauNV}', HoTenNV = N'{hoTenNV}', " +
                               $"GioiTinhNV = N'{gioiTinhNV}', NgaySinh = N'{ngaySinhNV.ToString("yyyy-MM-dd")}', " +
                               $"DiaChiNV = N'{diaChiNV}', EmailNV = N'{emailNV}', " +
                               $"SDTNV = N'{sdtNV}', CMNDNV = N'{cmndNV}', AnhNV = N'{anhNV}' " +
                               $"WHERE MaNV = '{maNV}'";

                // Gọi phương thức ExecuteNonQuery từ đối tượng Database để thực hiện câu truy vấn
                provider.ExecuteNonQuery(query);

                return true;
            }
            catch (Exception ex)
            {
                // Xử lý exception nếu có
                Console.WriteLine("Error updating employee: " + ex.Message);
                return false;
            }
        }

        public bool DeleteNhanVien(string maNV)
        {
            try
            {
                // Thực hiện câu truy vấn xóa nhân viên từ cơ sở dữ liệu
                string query = $"DELETE FROM nhanvien WHERE MaNV = '{maNV}'";

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

        public List<QuanLyNhanVien_DTO> TimKiemNhanVien(string cotTimKiem, string tuKhoa)
        {
            try
            {
                // Sử dụng thủ tục SQL để thực hiện tìm kiếm
                string query = $"SELECT nhanvien.*, chucvu.TenCV FROM nhanvien INNER JOIN chucvu ON nhanvien.MaCV = chucvu.MaCV WHERE {cotTimKiem} LIKE N'%{tuKhoa}%'";

                DataTable data = provider.ExecuteQuery(query);

                // Chuyển đổi dữ liệu từ DataTable sang danh sách đối tượng QuanLyNhanVien_DTO
                List<QuanLyNhanVien_DTO> ketQuaTimKiem = new List<QuanLyNhanVien_DTO>();

                foreach (DataRow row in data.Rows)
                {
                    QuanLyNhanVien_DTO nhanVien = new QuanLyNhanVien_DTO();
                    nhanVien.MaNV = row["MaNV"].ToString();
                    nhanVien.MaCV = row["MaCV"].ToString();
                    nhanVien.TenTaiKhoanNV = row["TenTaiKhoanNV"].ToString();
                    nhanVien.MatKhauNV = row["MatKhauNV"].ToString();
                    nhanVien.HoTenNV = row["HoTenNV"].ToString();
                    nhanVien.GioiTinhNV = row["GioiTinhNV"].ToString();
                    nhanVien.NgaySinh = Convert.ToDateTime(row["NgaySinh"]); // Thêm dòng này để lấy thông tin ngày sinh
                    nhanVien.DiaChiNV = row["DiaChiNV"].ToString();
                    nhanVien.EmailNV = row["EmailNV"].ToString();
                    nhanVien.SDTNV = row["SDTNV"].ToString();
                    nhanVien.CMNDNV = row["CMNDNV"].ToString();
                    nhanVien.AnhNV = row["AnhNV"].ToString();
                    nhanVien.TenCV = row["TenCV"].ToString();

                    ketQuaTimKiem.Add(nhanVien);
                }

                return ketQuaTimKiem;
            }
            catch (Exception ex)
            {
                // Xử lý exception nếu có
                Console.WriteLine("Error searching employees: " + ex.Message);
                return null;
            }
        }

        /*        public List<QuanLyNhanVien_DTO> TimKiemNhanVienTatCa(string tuKhoa)
                {
                    // Thực hiện câu truy vấn tìm kiếm theo tất cả các trường trong bảng khachhang
                    string query = $"SELECT * Form nhanvien WHERE " +
                        $"MaNV LIKE N'%{tuKhoa}%' OR MaCV LIKE N'%{tuKhoa}%' " +
                        $"OR TenTaiKhoanNV LIKE N'%{tuKhoa}%' OR HoTenNV LIKE N'%{tuKhoa}%'  OR GioiTinhNV LIKE N'%{tuKhoa}%' OR DiaChiNV LIKE N'%{tuKhoa}%' OR EmailNV LIKE N'%{tuKhoa}%' " +
                        $"OR SDTNV LIKE N'%{tuKhoa}%' OR CMNDNV LIKE N'%{tuKhoa}%'";


                    DataTable data = provider.ExecuteQuery(query);

                    List<QuanLyNhanVien_DTO> ketQua = new List<QuanLyNhanVien_DTO>();
                    foreach (DataRow row in data.Rows)
                    {
                        QuanLyNhanVien_DTO nhanvien = new QuanLyNhanVien_DTO()
                        {
                            MaNV = row["MaNV"].ToString(),
                            MaCV = row["MaCV"].ToString(),

                            TenTaiKhoanNV = row["TenTaiKhoanNV"].ToString(),
                            HoTenNV = row["HoTenNV"].ToString(),
                            MatKhauNV = row["MatKhauNV"].ToString(),
                            GioiTinhNV = row["GioiTinhNV"].ToString(),
                            NgaySinh = Convert.ToDateTime(row["NgaySinh"]),
                            DiaChiNV = row["DiaChiNV"].ToString(),
                            EmailNV = row["EmailNV"].ToString(),
                            SDTNV = row["SDTNV"].ToString(),
                            CMNDNV = row["CMNDNV"].ToString(),
                            AnhNV = row["AnhNV"].ToString()


                    };
                            ketQua.Add(nhanvien);
                    }

                    return ketQua;
                }*/






        // Kiểm tra tên tài khoản đã tồn tại 
        public bool IsTenTaiKhoanExists(string tenTaiKhoan)
        {
            string query = $"SELECT COUNT(*) FROM nhanvien WHERE TenTaiKhoanNV = '{tenTaiKhoan}'";
            int count = Convert.ToInt32(provider.ExecuteScalar(query));

            return count > 0;
        }

        public bool IsTenTaiKhoanExists(string tenTaiKhoan, string maNV)
        {
            try
            {
                // Thực hiện câu truy vấn kiểm tra tên tài khoản tồn tại trong cơ sở dữ liệu
                string query = $"SELECT COUNT(*) FROM nhanvien WHERE TenTaiKhoanNV = N'{tenTaiKhoan}' AND MaNV <> N'{maNV}'";
                int count = Convert.ToInt32(provider.ExecuteScalar(query));

                // Trả về true nếu tên tài khoản tồn tại, ngược lại trả về false
                return count > 0;
            }
            catch (Exception ex)
            {
                // Xử lý exception nếu có
                Console.WriteLine("Error checking username existence: " + ex.Message);
                return false;
            }
        }







    }
}

// hàm lấy tên chuc vu 2 
/*       public string GetTenChucVu(string maChucVu)
       {
           string query = "SELECT TenCV FROM chucvu WHERE MaCV = @MaCV";

           using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-7R66M1N\\THAIBAOSERVER;Initial Catalog = QuanLyBanGiay; Integrated Security = True"))
           {
               connection.Open();

               using (SqlCommand command = new SqlCommand(query, connection))
               {
                   command.Parameters.AddWithValue("@MaCV", maChucVu);

                   using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                   {
                       DataTable data = new DataTable();
                       adapter.Fill(data);

                       if (data.Rows.Count > 0)
                       {
                           return data.Rows[0]["TenCV"].ToString();
                       }
                   }
               }
           }

           return string.Empty;
       }*/
// hàm lấy cbGioiTinh

/*        public List<string> GetGioiTinh()
        {
            List<string> listGioiTinh = new List<string>();
            string query = "SELECT GioiTinhNV  FROM nhanvien";
            DataTable data = provider.ExecuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                listGioiTinh.Add(row["GioiTinhNV"].ToString());
            }
            return listGioiTinh;
        }*/

