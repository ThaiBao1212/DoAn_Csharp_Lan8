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

        public Account_DTO(string maNV, string maCV, string hoTenNV, string tenTaiKhoanNV, int type, string matKhauNV = null)
        {
            this.MaNV = maNV;
            this.maCV = maCV;
            this.HoTenNV = hoTenNV;
            this.TenTaiKhoanNV = tenTaiKhoanNV;
            this.Type = type;
            this.matKhauNV= matKhauNV;

        }

        public Account_DTO(DataRow row)
        {

        }
        
        
        private string matKhauNV;
        public string MatKhauNV
        {
            get { return matKhauNV; }
            set { matKhauNV = value; }
        }



        private int type;
        public int Type
        {
            get { return type; }
            set { type = value; }
        }



        private string maCV;
        public string MaCV
        {
            get { return maCV; }
            set { maCV = value; }
        }

        private string maNV;

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value;}    

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
