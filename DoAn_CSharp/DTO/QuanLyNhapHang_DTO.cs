using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_CSharp.DTO
{
    public class QuanLyNhapHang_DTO
    {
        public int MaPhieuNhap { get; set; }
        public int MaNV { get; set; }
        public DateTime NgayLapPhieu { get; set; }
        public string TrangThaiPN { get; set; }
        
        public int MaCTPN { get; set; }
        public int MaSP { get; set; }

        public string TenSP { get; set; }
        public int SoLuongNhap { get; set; }    


    }
}
