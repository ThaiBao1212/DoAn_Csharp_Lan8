using DoAn_CSharp.Databsase;
using DoAn_CSharp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DoAn_CSharp.DAO
{
    internal class QuanLyDanhMuc_DAO
    {
        private Databsase.Database db;
        public QuanLyDanhMuc_DAO()
        {
            db = new Databsase.Database();

        }

        Database_TB provider = new Database_TB();
        public DataTable LayDanhSachDanhMuc()
        {
            try
            {
                string strSQL = "SELECT * FROM danhmuc WHERE TrangThaiDM =N'Mở'";
                DataTable dt = db.Execute(strSQL);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return null;
            }
        }
        public DataTable LayDanhSachSanPhamDanhMuc(QuanLyDanhMuc_DTO ql_danhmuc_DTO)
        {
            /* string strSQL = $"Select * from sanpham where MaDM=N'{ql_danhmuc_DTO.maDanhMuc}'";*/
            string strSQL = "SELECT sp.MaSP, ncc.MaNCC, ncc.TenNCC, dm.TenDM, sp.TenSP, s.TenSize, sps.SoLuongSP, sp.DonGia, sp.TrangThaiSP " +
                           "FROM sanpham sp " +
                           "JOIN nhacungcap ncc ON sp.MaNCC = ncc.MaNCC " +
                           "JOIN danhmuc dm ON sp.MaDM = dm.MaDanhMuc " +
                           "JOIN SanPhamSize sps ON sp.MaSP = sps.MaSP " +
                           "JOIN Sizes s ON sps.MaSize = s.MaSize " +
                           $"WHERE sp.MaDM = '{ql_danhmuc_DTO.maDanhMuc}'";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public DataTable LayDanhSachSanPhamTrongDanhMuc(QuanLyDanhMuc_DTO ql_danhmuc_DTO)
        {
            string query = "SELECT sp.MaSP, ncc.MaNCC, ncc.TenNCC, dm.TenDM, sp.TenSP, s.TenSize, sps.SoLuongSP, sp.DonGia, sp.TrangThaiSP " +
                           "FROM sanpham sp " +
                           "JOIN nhacungcap ncc ON sp.MaNCC = ncc.MaNCC " +
                           "JOIN danhmuc dm ON sp.MaDM = dm.MaDanhMuc " +
                           "JOIN SanPhamSize sps ON sp.MaSP = sps.MaSP " +
                           "JOIN Sizes s ON sps.MaSize = s.MaSize " +
                           $"WHERE sp.MaDM = '{ql_danhmuc_DTO.maDanhMuc}'";

            DataTable data = provider.ExecuteQuery(query);
            return data;
        }



        public void ThemDanhMuc(QuanLyDanhMuc_DTO ql_danhmuc_DTO)
        {
            try
            {
                string strSQL = $"INSERT INTO danhmuc(TenDM) VALUES (N'{ql_danhmuc_DTO.tenDM}')";
                db.ExecuteNonQuery(strSQL);

                MessageBox.Show("Thêm Danh Mục Thành Công");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Thêm Thất Bại: {ex.Message}");
            }
        }

        public void CapNhap(QuanLyDanhMuc_DTO ql_danhmuc_DTO)
        {

            try
            {

                string strSQL = $"UPDATE danhmuc SET TenDM = N'{ql_danhmuc_DTO.tenDM}'WHERE MaDanhMuc ={ql_danhmuc_DTO.maDanhMuc}";
                db.ExecuteNonQuery(strSQL);

                MessageBox.Show("Cập Nhật Danh Mục Thành Công");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cập Nhật Thất Bại: {ex.Message}");
            }
        }
        public bool DanhMucDaTonTai(string tenDanhMucMoi)
        {
            try
            {
                string strSQL = $"SELECT COUNT(*) FROM danhmuc WHERE TenDM = N'{tenDanhMucMoi}'";
                int count = Convert.ToInt32(db.ExecuteScalar(strSQL));

                if (count > 0)
                {
                    MessageBox.Show("Tên danh mục đã tồn tại ");
                    return true; // Trả về true nếu tên danh mục đã tồn tại
                }
                else
                {
                    return false; // Trả về false nếu tên danh mục không tồn tại
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false; // Trả về false nếu có lỗi xảy ra
            }
        }
        public void XoaDanhMuc(QuanLyDanhMuc_DTO ql_danhmuc_DTO)
        {
            try
            {
                // Kiểm tra xem danh mục có tồn tại không
                if (DanhMucTonTai(ql_danhmuc_DTO.maDanhMuc))
                {
                    string strSQL = $"UPDATE danhmuc SET TrangThaiDM = N'Khóa' WHERE MaDanhMuc = {ql_danhmuc_DTO.maDanhMuc}";
                    db.ExecuteNonQuery(strSQL);

                    MessageBox.Show("Xóa Danh Mục Thành Công");
                }
                else
                {
                    MessageBox.Show("Danh Mục không tồn tại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xóa Thất Bại: {ex.Message}");
            }
        }

        private bool DanhMucTonTai(int maDanhMuc)
        {
            try
            {
                string strSQL = $"SELECT COUNT(*) FROM danhmuc WHERE MaDanhMuc = {maDanhMuc} AND TrangThaiDM = N'Mở'";
                int count = Convert.ToInt32(db.ExecuteScalar(strSQL));

                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
        }


        public List<QuanLyDanhMuc_DTO> TimKiemDanhMucTatCa(string tuKhoa)
        {
            // Thực hiện câu truy vấn tìm kiếm theo tất cả các trường trong bảng khachhang
            string strSQL = $"SELECT * FROM danhmuc WHERE MaDanhMuc LIKE N'%{tuKhoa}%' OR TenDM LIKE N'%{tuKhoa}%' OR TrangThaiDM LIKE N'%{tuKhoa}%'";
            DataTable dt = db.Execute(strSQL);

            List<QuanLyDanhMuc_DTO> ketQua = new List<QuanLyDanhMuc_DTO>();
            foreach (DataRow row in dt.Rows)
            {
                QuanLyDanhMuc_DTO danhmuc = new QuanLyDanhMuc_DTO()
                {
                    maDanhMuc = Convert.ToInt32(row["MaDanhMuc"]),
                    tenDM = row["TenDM"].ToString(),
                    trangThaiDM = row["TrangThaiDM"].ToString()



                };
                ketQua.Add(danhmuc);
            }

            return ketQua;
        }
        public List<QuanLyDanhMuc_DTO> TimKiemDanhMucTheoMaDM(string tuKhoa)
        {
            // Thực hiện câu truy vấn tìm kiếm theo tất cả các trường trong bảng khachhang
            string strSQL = $"SELECT * FROM danhmuc WHERE MaDanhMuc LIKE N'%{tuKhoa}%'";
            DataTable dt = db.Execute(strSQL);

            List<QuanLyDanhMuc_DTO> ketQua = new List<QuanLyDanhMuc_DTO>();
            foreach (DataRow row in dt.Rows)
            {
                QuanLyDanhMuc_DTO danhmuc = new QuanLyDanhMuc_DTO()
                {
                    maDanhMuc = Convert.ToInt32(row["MaDanhMuc"]),
                    tenDM = row["TenDM"].ToString(),
                    trangThaiDM = row["TrangThaiDM"].ToString()



                };
                ketQua.Add(danhmuc);
            }

            return ketQua;
        }

        public List<QuanLyDanhMuc_DTO> TimKiemDanhMucTheoTenDM(string tuKhoa)
        {
            // Thực hiện câu truy vấn tìm kiếm theo tất cả các trường trong bảng khachhang
            string strSQL = $"SELECT * FROM danhmuc WHERE TenDM LIKE N'%{tuKhoa}%' ";
            DataTable dt = db.Execute(strSQL);

            List<QuanLyDanhMuc_DTO> ketQua = new List<QuanLyDanhMuc_DTO>();
            foreach (DataRow row in dt.Rows)
            {
                QuanLyDanhMuc_DTO danhmuc = new QuanLyDanhMuc_DTO()
                {
                    maDanhMuc = Convert.ToInt32(row["MaDanhMuc"]),
                    tenDM = row["TenDM"].ToString(),
                    trangThaiDM = row["TrangThaiDM"].ToString()



                };
                ketQua.Add(danhmuc);
            }

            return ketQua;
        }


    }
}