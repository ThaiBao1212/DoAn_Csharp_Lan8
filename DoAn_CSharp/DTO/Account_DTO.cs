using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_CSharp.DTO
{
    public class Account_DTO
    {

        public Account_DTO(string maNV, int maCV, string hoTenNV, string tenTaiKhoanNV, string matKhauNV = null)
        {
            this.MaNV = maNV;
            this.MaCV = maCV;
            this.HoTenNV = hoTenNV;
            this.TenTaiKhoanNV = tenTaiKhoanNV;

            this.MatKhauNV = matKhauNV;

        }

        public Account_DTO(DataRow row)
        {
            this.MaNV = row["MaNV"].ToString();
            this.MaCV = (int)row["MaCV"];
            this.HoTenNV = row["HoTenNV"].ToString();
            this.TenTaiKhoanNV = row["TenTaiKhoanNV"].ToString();

            this.MatKhauNV = row["MatKhauNV"].ToString();

        }


        private string matKhauNV;
        public string MatKhauNV
        {
            get { return matKhauNV; }
            set { matKhauNV = value; }
        }
        private string tenChucVu; // Đặt tên biến private

        public string TenChucVu // Tên thuộc tính
        {
            get { return tenChucVu; }
            set { tenChucVu = value; }
        }

        private int maCV;
        public int MaCV
        {
            get { return maCV; }
            set { maCV = value; }
        }

        private string maNV;

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }

        }

        private string tenTaiKhoanNV; // Đặt tên biến private

        public string TenTaiKhoanNV // Tên thuộc tính
        {
            get { return tenTaiKhoanNV; }
            set { tenTaiKhoanNV = value; }
        }

        private string hoTenNV;

        public string HoTenNV
        {
            get { return hoTenNV; }
            set { hoTenNV = value; }

        }



    }
}