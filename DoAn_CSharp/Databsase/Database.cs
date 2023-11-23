using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_CSharp.Databsase
{
    public class Database : IDisposable
    {
        private SqlConnection sqlConn;

        public Database()
        {
            // Thay đổi chuỗi kết nối tới cơ sở dữ liệu của bạn
            string connectionString = "Data Source=DESKTOP-7R66M1N\\THAIBAOSERVER;Initial Catalog=QuanLyBanGiay;Integrated Security=True";
            sqlConn = new SqlConnection(connectionString);
        }

        public DataTable ExecuteQuery(string sqlStr)
        {
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(sqlStr, sqlConn))
                {
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                // Xử lý exception nếu có
                Console.WriteLine("Error executing query: " + ex.Message);
                return null;
            }
        }

        public object ExecuteScalar(string strSQL)
        {
            try
            {
                using (SqlCommand sqlcmd = new SqlCommand(strSQL, sqlConn))
                {
                    sqlConn.Open();
                    object result = sqlcmd.ExecuteScalar();
                    return result;
                }
            }
            catch (Exception ex)
            {
                // Xử lý exception nếu có
                Console.WriteLine("Error executing scalar query: " + ex.Message);
                return null;
            }
            finally
            {
                sqlConn.Close();
            }
        }

        public void ExecuteNonQuery(string strSQL)
        {
            try
            {
                using (SqlCommand sqlcmd = new SqlCommand(strSQL, sqlConn))
                {
                    sqlConn.Open();
                    sqlcmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Xử lý exception nếu có
                Console.WriteLine("Error executing non-query: " + ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
        }

        public void Dispose()
        {
            // Đảm bảo rằng kết nối được đóng khi đối tượng bị hủy
            if (sqlConn != null && sqlConn.State == ConnectionState.Open)
            {
                sqlConn.Close();
                sqlConn.Dispose();
            }
        }
    }
}
