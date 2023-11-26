using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace DoAn_CSharp.Databsase
{
    public class DataProvider1
    {
        private string connectionSTR = "Data Source=DESKTOP-7R66M1N\\THAIBAOSERVER;Initial Catalog = QuanLyBanGiay; Integrated Security = True";
        public string GetConnectionString()
        {
            return connectionSTR;
        }

        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(data);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý exception ở đây, ví dụ in thông báo lỗi ra console
                Console.WriteLine("Error in ExecuteQuery: " + ex.Message);
            }

            return data;
        }

        public int ExecuteNonQuery(string query, List<SqlParameter> parameters)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddRange(parameters.ToArray());
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý exception ở đây, ví dụ in thông báo lỗi ra console
                Console.WriteLine("Error in ExecuteNonQuery: " + ex.Message);
            }

            return rowsAffected;
        }


    }
}
