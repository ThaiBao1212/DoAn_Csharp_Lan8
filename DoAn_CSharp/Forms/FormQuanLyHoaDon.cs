using DoAn_CSharp.DAO;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_CSharp.Forms
{
    public partial class FormQuanLyHoaDon : Form
    {
 
        private DAO.QuanLyHoaDon_DAO ql_hoadon_DAO = new DAO.QuanLyHoaDon_DAO();
        private DTO.QuanLyHoaDon_DTO ql_hoadon_DTO = new DTO.QuanLyHoaDon_DTO();
        private DTO.QuanLyChiTietHoaDon_DTO quanLyChiTietHoaDon_DTO = new DTO.QuanLyChiTietHoaDon_DTO();
        private DAO.QuanLyChiTietHoaDon_DAO quanLyChiTietHoaDon_DAO = new DAO.QuanLyChiTietHoaDon_DAO();
        public FormQuanLyHoaDon()
        {
            InitializeComponent();
            HienThiHoaDon();
            dtgvDanhSachHoaDon.SelectionChanged += dtgvDanhSachHoaDon_SelectionChanged;


        }

        private void FormQuanLyHoaDon_Load(object sender, EventArgs e)
        {

            this.reportViewerHoaDon.RefreshReport();
        }
        private void HienThiHoaDon()
        {
            DataTable dt = ql_hoadon_DAO.LayDanhSachHoaDon();
            dtgvDanhSachHoaDon.Rows.Clear();
            foreach (DataRow row in dt.Rows) {
                dtgvDanhSachHoaDon.Rows.Add(row.ItemArray);
            }

        }
        private void dtgvDanhSachHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvDanhSachHoaDon.SelectedRows.Count > 0)
            {
                int maHD = Convert.ToInt32(dtgvDanhSachHoaDon.SelectedRows[0].Cells["MaHD"].Value);
                quanLyChiTietHoaDon_DTO.MaHD = maHD;
                HienThiChiTietHD();
            }
        }
      
        private void HienThiChiTietHD()
        {
            // Xóa tất cả dữ liệu hiện tại trong dtgvChiTietHD
            dtgvChiTietHD.Rows.Clear();

            // Lấy danh sách chi tiết hóa đơn theo mã hóa đơn
            DataTable dt = quanLyChiTietHoaDon_DAO.LayDanhSachChiTietDH(quanLyChiTietHoaDon_DTO);

            // Thêm dữ liệu vào dtgvChiTietHD
            foreach (DataRow row in dt.Rows)
            {
                dtgvChiTietHD.Rows.Add(row.ItemArray);
            }
        }
        private void ExportHoaDonToPdf()
        {
            // Tạo đối tượng SaveFileDialog để chọn vị trí lưu file
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            saveDialog.Title = "Chọn vị trí lưu hóa đơn";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                // Chọn định dạng xuất file (PDF)
                Microsoft.Reporting.WinForms.Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string extension;

                byte[] byteViewer = reportViewerHoaDon.LocalReport.Render(
                    "PDF", null, out mimeType, out encoding, out extension,
                    out streamids, out warnings);

                // Lưu file PDF
                using (FileStream fs = new FileStream(saveDialog.FileName, FileMode.Create))
                {
                    fs.Write(byteViewer, 0, byteViewer.Length);
                    fs.Close();
                }

                MessageBox.Show("Hóa đơn đã được lưu thành công!", "Thông báo");
            }
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            // Gọi hàm xuất hóa đơn và chọn định dạng file (PDF, Excel, Word, Image, ...)
            ExportHoaDonToPdf();
        }
    }
}
