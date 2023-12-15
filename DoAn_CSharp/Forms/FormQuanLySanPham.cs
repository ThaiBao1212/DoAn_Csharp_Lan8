using DoAn_CSharp.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;



namespace DoAn_CSharp.Forms
{



    public partial class FormQuanLySanPham : Form
    {
        private DAO.QuanLyDanhMuc_DAO ql_danhmuc_DAO = new DAO.QuanLyDanhMuc_DAO();
        private DTO.QuanLyDanhMuc_DTO ql_danhmuc_DTO = new DTO.QuanLyDanhMuc_DTO();
        private DAO.QuanLyNhaCungCap_DAO ql_cungcap_DAO = new DAO.QuanLyNhaCungCap_DAO();

        private DAO.QuanLySanPham_DAO ql_sanpham_DAO = new DAO.QuanLySanPham_DAO();
        private DTO.QuanLySanPham_DTO ql_sanpham_DTO = new DTO.QuanLySanPham_DTO();

        public FormQuanLySanPham()
        {
            InitializeComponent();
            LoadDanhMucToComboBox();
            LoadNhaCungCapToComboBox();
            HienThiSanPham();

            dtgvDanhSachSanPham.CellClick += DtgvDanhSachSanPham_CellClick;


            dtgvDanhSachSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvDanhSachSanPham.ReadOnly = true;

        }

        private void DtgvDanhSachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is not a header cell
            if (e.RowIndex >= 0)
            {
                // Access the data only if it's not a header cell
                DataGridViewRow selectedRow = dtgvDanhSachSanPham.Rows[e.RowIndex];
                txtTenSP.Text = selectedRow.Cells["TenSP"].Value?.ToString();
                cbTenNCC.SelectedValue = selectedRow.Cells["MaNCC"].Value;
                cbTenDM.SelectedValue = selectedRow.Cells["MaDM"].Value;
                txtMieuTa.Text = selectedRow.Cells["MieuTaSP"].Value?.ToString();
                txtDonGia.Text = selectedRow.Cells["DonGia"].Value?.ToString();
            }
        }


        private void HienThiSanPham()
        {

            DataTable dt = ql_sanpham_DAO.LayDanhSachSanPham();
            dtgvDanhSachSanPham.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dtgvDanhSachSanPham.Rows.Add(row.ItemArray);
            }
        }

        private void LoadDanhMucToComboBox()
        {
            DataTable dt = ql_danhmuc_DAO.LayDanhSachDanhMuc();
            cbTenDM.DisplayMember = "TenDM"; // Display the category name
            cbTenDM.ValueMember = "MaDanhMuc"; // Use the correct column name for the ID
            cbTenDM.DataSource = dt;
        }

        private void LoadNhaCungCapToComboBox()
        {
            DataTable dt = ql_cungcap_DAO.LayDanhSachNhaCungCap();
            cbTenNCC.DisplayMember = "TenNCC"; // Display the supplier name
            cbTenNCC.ValueMember = "MaNCC"; // Use the correct column name for the ID
            cbTenNCC.DataSource = dt;
        }



        private string imagePath; // Declare a class-level variable to store the image path

        private void browseButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All files (*.*)|*.*";
                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // Store the selected image path
                    imagePath = openFileDialog.FileName;

                    iPBAnh.Image = Image.FromFile(imagePath);

                    iPBAnh.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur while loading the image
                MessageBox.Show("Error loading image: " + ex.ToString());
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if an image is selected
                if (string.IsNullOrEmpty(imagePath))
                {
                    MessageBox.Show("Please select an image.");
                    return;
                }

                // Get values from the form controls
                int maNCC = Convert.ToInt32(cbTenNCC.SelectedValue);
                int maDM = Convert.ToInt32(cbTenDM.SelectedValue);
                string tenSP = txtTenSP.Text;
                string mieuTaSP = txtMieuTa.Text;
                decimal donGia = Convert.ToDecimal(txtDonGia.Text);

                // Use Path.Combine to create the full path to the Resources folder

                string resourcesPath = Path.Combine(Application.StartupPath, "Image");

                // Create a new folder if it doesn't exist
                if (!Directory.Exists(resourcesPath))
                {
                    Directory.CreateDirectory(resourcesPath);
                }

                // Get the file name from the original path
                string fileName = Path.GetFileName(imagePath);


                // Combine the Resources folder path with the file name

                string destinationPath = Path.Combine(resourcesPath, fileName);

                // Copy the selected image to the Resources folder
                File.Copy(imagePath, destinationPath, true);

                // Set the image path to the destination path
                string anhSP = fileName;

                QuanLySanPham_DTO sanPham = new QuanLySanPham_DTO
                {
                    MaNCC = maNCC,
                    MaDM = maDM,
                    TenSP = tenSP,
                    MieuTaSP = mieuTaSP,
                    DonGia = donGia,
                    AnhSP = anhSP,
                };

                // Call the method to add the product
                ql_sanpham_DAO.ThemSanPham(sanPham);

                MessageBox.Show("Sản phẩm đã được thêm thành công.");

                // You can add additional logic here if needed

                HienThiSanPham();
                ClearFormControls();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng cho trường số.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearFormControls()
        {
            // Clear all form controls
            cbTenNCC.SelectedIndex = -1;
            cbTenDM.SelectedIndex = -1;
            txtTenSP.Clear();
            txtMieuTa.Clear();
            txtDonGia.Clear();
            imagePath = null;
            iPBAnh.Image = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgvDanhSachSanPham.SelectedRows.Count == 1)
            {
                try
                {
                    // Get the selected product's information from the DataGridView
                    DataGridViewRow selectedRow = dtgvDanhSachSanPham.SelectedRows[0];
                    int maSP = Convert.ToInt32(selectedRow.Cells["MaSP"].Value);
                    string tenSP = txtTenSP.Text;
                    int maNCC = Convert.ToInt32(cbTenNCC.SelectedValue);
                    int maDM = Convert.ToInt32(cbTenDM.SelectedValue);
                    string mieuTaSP = txtMieuTa.Text;
                    decimal donGia = Convert.ToDecimal(txtDonGia.Text);

                    // Check if an image is selected
                    if (string.IsNullOrEmpty(imagePath))
                    {
                        // If imagePath is null or empty, it means the user didn't select a new image,
                        // so we keep the existing image path.
                        string existingImagePath = selectedRow.Cells["AnhSP"].Value?.ToString();
                        if (!string.IsNullOrEmpty(existingImagePath))
                        {
                            // If there is an existing image path, use it
                            imagePath = Path.Combine(Application.StartupPath, "Image", existingImagePath);
                        }
                        else
                        {
                            // Handle the case where there is no existing image path
                            MessageBox.Show("Please select an image.");
                            return;
                        }
                    }
                    else
                    {
                        // If a new image is selected, update the image in the specified folder
                        string resourcesPath = Path.Combine(Application.StartupPath, "Image");
                        string fileName = Path.GetFileName(imagePath);
                        string destinationPath = Path.Combine(resourcesPath, fileName);
                        File.Copy(imagePath, destinationPath, true);
                    }

                    // Set the image path to the destination path
                    string anhSP = Path.GetFileName(imagePath);

                    // Update the information in the DTO object
                    ql_sanpham_DTO.MaSP = maSP;
                    ql_sanpham_DTO.TenSP = tenSP;
                    ql_sanpham_DTO.MaNCC = maNCC;
                    ql_sanpham_DTO.MaDM = maDM;
                    ql_sanpham_DTO.MieuTaSP = mieuTaSP;
                    ql_sanpham_DTO.DonGia = donGia;
                    ql_sanpham_DTO.AnhSP = anhSP;

                    // Update the information in the database using your data access layer
                    ql_sanpham_DAO.CapNhatSanPham(ql_sanpham_DTO);

                    // Refresh the DataGridView to reflect the changes
                    HienThiSanPham();
                    ClearFormControls();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chỉ chọn một sản phẩm để sửa.", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvDanhSachSanPham.SelectedRows.Count == 1)
            {
                try
                {
                    // Get the selected product's information from the DataGridView
                    DataGridViewRow selectedRow = dtgvDanhSachSanPham.SelectedRows[0];
                    int maSP = Convert.ToInt32(selectedRow.Cells["MaSP"].Value);

                    // Call the method to delete the product
                    ql_sanpham_DAO.XoaSanPham(maSP);

                    MessageBox.Show("Sản phẩm đã được xóa thành công.");

                    // Refresh the DataGridView to reflect the changes
                    HienThiSanPham();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chỉ chọn một sản phẩm để xóa.", "Thông báo");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            HienThiSanPham();
            ClearFormControls();
        }
    }
}