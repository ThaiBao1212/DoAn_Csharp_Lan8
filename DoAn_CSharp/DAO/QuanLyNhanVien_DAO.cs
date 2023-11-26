using System;
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
                listNhanVien.Add(nhanVien);
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


        // Kiểm tra tên tài khoản đã tồn tại 
        public bool IsTenTaiKhoanExists(string tenTaiKhoan)
        {
            string query = $"SELECT COUNT(*) FROM nhanvien WHERE TenTaiKhoanNV = '{tenTaiKhoan}'";
            int count = Convert.ToInt32(provider.ExecuteScalar(query));

            return count > 0;
        }




    }// Trong lớp DAO (QuanLyNhanVien_DAO)
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

