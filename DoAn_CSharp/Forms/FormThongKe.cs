using DoAn_CSharp.DTO;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;

using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DoAn_CSharp.Forms
{
    public partial class FormThongKe : Form
    {
        QuanLyNhanVien_DTO staffSelected = new QuanLyNhanVien_DTO();
        int revenueValue = 0;
        QuanLyKhachHang_DTO customerSelected = new QuanLyKhachHang_DTO();
        public string connString = "Data Source=LAPTOP-PDE9TC1I\\SQLEXPRESS;Initial Catalog=QuanLyBanGiay2;Integrated Security=true";

        List<string> months = new List<string> {
            "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6",
            "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12"
        };

        List<decimal> revenueList = new List<decimal> {

        };


        Dictionary<string, int> bestSeller = new Dictionary<string, int>();

        public FormThongKe()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void handleLoad()
        {
            string sqlQueryProduct = "SELECT COUNT(*) FROM sanpham";
            string sqlQueryStaff = "SELECT COUNT(*) FROM nhanvien";
            string sqlQueryCustomer = "SELECT COUNT(*) FROM khachhang";
            string sqlQueryBill = "SELECT COUNT(*) FROM hoadon";

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sqlQueryProduct, connection))
                {
                    // Execute the query and retrieve the result
                    int count = (int)command.ExecuteScalar();
                    productCount.Text =  count.ToString();
                    // Display the result

                }
                using (SqlCommand command = new SqlCommand(sqlQueryStaff, connection))
                {
                    // Execute the query and retrieve the result
                    int count = (int)command.ExecuteScalar();
                    staffCount.Text = count.ToString();
                    // Display the result
                }
                using (SqlCommand command = new SqlCommand(sqlQueryCustomer, connection))
                {
                    // Execute the query and retrieve the result
                    int count = (int)command.ExecuteScalar();
                    customerCount.Text = count.ToString();
                    // Display the result
                }
                using (SqlCommand command = new SqlCommand(sqlQueryBill, connection))
                {
                    // Execute the query and retrieve the result
                    int count = (int)command.ExecuteScalar();
                    billCount.Text = "Số lượng: " + count.ToString();
                    // Display the result
                }

                handleRevenue();
                handleMonthRevenue();
            }

        }

        private void handleMonthRevenue()
        {

            for (int i = 1; i <= 12; i++)
            {
                string sqlRevenue = "SELECT SUM(chitiethd.ThanhTien) AS TotalRevenue FROM chitiethd JOIN hoadon ON chitiethd.MaHD = hoadon.MaHD WHERE MONTH(hoadon.NgayLapHD) = " + i;
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sqlRevenue, connection))
                    {
                        object result = command.ExecuteScalar();
                   
                        if (result != null && result != DBNull.Value)
                        {
                            
                            int sum = Convert.ToInt32(result);
                            // Hiển thị tổng trong một điều khiển WinForms

                            revenueList.Add(sum);
                        }
                        else
                        {
                            revenueList.Add(0);
                        }
                    }
                }
            }
            chart_Load();
        }


        private void chart_Load()
        {
            chartControl.Series.Clear();
            chartControl.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea();
            chartControl.ChartAreas.Add(chartArea);

            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            series.Name = "Doanh số bán hàng";
            chartControl.Series.Add(series);

            for (int i = 0; i < months.Count; i++)
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.AxisLabel = months[i];
                dataPoint.YValues = new double[] { (double)revenueList[i] };
                series.Points.Add(dataPoint);
            }

            chartArea.AxisX.Interval = 1;
            chartArea.AxisY.Title = "Doanh thu";

            chartControl.Refresh();
        }


        private void createDataBestSeller()
        {
            var bestSellerQuery = "SELECT CTHD.MaSP, SP.TenSP, SUM(CTHD.SoLuongSP) AS TongSoLuong FROM chitiethd CTHD JOIN sanpham SP ON CTHD.MaSP = SP.MaSP \n" + "GROUP BY CTHD.MaSP, SP.TenSP";
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(bestSellerQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                      
                            string tenSP = reader.GetString(1);
                            int soLuong = reader.GetInt32(2);

                            // Thêm sản phẩm vào danh sách đã bán
                            bestSeller.Add(tenSP, soLuong);
                        }
                    }
                }
            }
        }

        private void pie_chart_load()
        {
            pieChartControl.Series.Clear();
            pieChartControl.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea();
            pieChartControl.ChartAreas.Add(chartArea);

            Series series = new Series();
            series.ChartType = SeriesChartType.Pie;
            series.Name = "Doanh số bán hàng";
            pieChartControl.Series.Add(series);


            createDataBestSeller();
          /*  bestSeller.Add("Sản phẩm A", 50);
            bestSeller.Add("Sản phẩm B", 30);
            bestSeller.Add("Sản phẩm C", 20);*/

            foreach (var product in bestSeller)
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.AxisLabel = product.Value.ToString();
                dataPoint.LegendText = product.Key;
                dataPoint.YValues = new double[] { (double)product.Value };
                series.Points.Add(dataPoint);
            }

    
            chartArea.AxisX.Interval = 1;
            chartArea.AxisY.Title = "Doanh thu";

            pieChartControl.Refresh();
        }

        public void handleRevenue()
        {
            string sqlRevenue = "SELECT SUM(ThanhTien) FROM chitiethd";
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sqlRevenue, connection))
                {
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int sum = Convert.ToInt32(result);
                        // Hiển thị tổng trong một điều khiển WinForms
                        revenue.Text = sum.ToString();
                    }
                }
            }
        }


        
        public void staff_data_Load()
        {

            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    // Mở kết nối
                    connection.Open();

                    // Xây dựng câu truy vấn SQL để lấy dữ liệu từ bảng
                    string query = "SELECT * FROM nhanvien";

                    // Tạo đối tượng SqlDataAdapter và DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    // Đổ dữ liệu từ cơ sở dữ liệu vào DataTable
                    adapter.Fill(dataTable);

                    // Gán DataTable làm nguồn dữ liệu cho DataGridView
                    staffList.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi kết nối và lấy dữ liệu từ cơ sở dữ liệu: " + ex.Message);
                }
            }
        }

        public void orderByStaff_load()
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {

                // Mở kết nối
                connection.Open();
                string query = "SELECT * FROM hoadon WHERE MaNV=" + staffSelected.MaNV;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    // Tạo đối tượng SqlDataAdapter và DataTable

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    // Đổ dữ liệu từ cơ sở dữ liệu vào DataTable
                    adapter.Fill(dataTable);

                    // Gán DataTable làm nguồn dữ liệu cho DataGridView
                    OrderByStaff.DataSource = dataTable;

                }
                
            }
        }

        public void orderByCustomer_load()
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {

                // Mở kết nối
                connection.Open();
                string query = "SELECT * FROM hoadon WHERE MaKH=" + customerSelected.MaKH;
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    // Tạo đối tượng SqlDataAdapter và DataTable

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    // Đổ dữ liệu từ cơ sở dữ liệu vào DataTable
                    adapter.Fill(dataTable);

                    // Gán DataTable làm nguồn dữ liệu cho DataGridView
                    orderByCustomer.DataSource = dataTable;

                }

            }
        }

        private void staffList_SelectionChanged(object sender, EventArgs e)
        {
            if (staffList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = staffList.SelectedRows[0];
                staffSelected.MaNV = selectedRow.Cells["MaNV"].Value.ToString();
                orderByStaff_load();
                /* NCC_selected.TenNCC = (string)selectedRow.Cells["TenNCC"].Value;
                 NCC_selected.DiaChiNCC = (string)selectedRow.Cells["DiaChiNCC"].Value;
                 NCC_selected.SDTNCC = (string)selectedRow.Cells["SDTNCC"].Value;
                 NCC_selected.Email = (string)selectedRow.Cells["Email"].Value;
                 NCC_selected.TrangThaiNCC = (string)selectedRow.Cells["TrangThaiNCC"].Value;
                 detailForm_load();

                 ql_NhaCungCap_DTO.MaNCC = NCC_selected.MaNCC; // Thêm dòng này để đảm bảo ql_NhaCungCap_DTO.MaNCC có giá trị

                 HienThiSanPhamTrongNhaCungCap();*/
            }
        }

        private void customerList_SelectionChanged(object sender, EventArgs e)
        {
            if (customerList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = customerList.SelectedRows[0];
                customerSelected.MaKH = selectedRow.Cells["MaKH"].Value.ToString();
                orderByCustomer_load();
                /* NCC_selected.TenNCC = (string)selectedRow.Cells["TenNCC"].Value;
                 NCC_selected.DiaChiNCC = (string)selectedRow.Cells["DiaChiNCC"].Value;
                 NCC_selected.SDTNCC = (string)selectedRow.Cells["SDTNCC"].Value;
                 NCC_selected.Email = (string)selectedRow.Cells["Email"].Value;
                 NCC_selected.TrangThaiNCC = (string)selectedRow.Cells["TrangThaiNCC"].Value;
                 detailForm_load();

                 ql_NhaCungCap_DTO.MaNCC = NCC_selected.MaNCC; // Thêm dòng này để đảm bảo ql_NhaCungCap_DTO.MaNCC có giá trị

                 HienThiSanPhamTrongNhaCungCap();*/
            }
        }

        private void customer_data_Load()
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    // Mở kết nối
                    connection.Open();

                    // Xây dựng câu truy vấn SQL để lấy dữ liệu từ bảng
                    string query = "SELECT * FROM khachhang";

                    // Tạo đối tượng SqlDataAdapter và DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    // Đổ dữ liệu từ cơ sở dữ liệu vào DataTable
                    adapter.Fill(dataTable);

                    // Gán DataTable làm nguồn dữ liệu cho DataGridView
                    customerList.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi kết nối và lấy dữ liệu từ cơ sở dữ liệu: " + ex.Message);
                }
            }
        }


        private void FormThongKe_Load(object sender, EventArgs e)
        {
            staffList.SelectionChanged += staffList_SelectionChanged;
            staffList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            staffList.ReadOnly = true;

            customerList.SelectionChanged += customerList_SelectionChanged;
            customerList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customerList.ReadOnly = true;

            OrderByStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrderByStaff.ReadOnly = true;


            handleLoad();
            chart_Load();
            pie_chart_load();
            staff_data_Load();
            customer_data_Load();
        }

        private void dtgvDanhSachNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void OrderByStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void revenue_Click(object sender, EventArgs e)
        {

        }

        private void chartControl_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
