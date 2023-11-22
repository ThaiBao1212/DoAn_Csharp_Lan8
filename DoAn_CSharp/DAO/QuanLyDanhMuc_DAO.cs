﻿using DoAn_CSharp.Databsase;
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
        private Database db;
        public QuanLyDanhMuc_DAO()
        {
            db = new Database();

        }
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



    }
}
