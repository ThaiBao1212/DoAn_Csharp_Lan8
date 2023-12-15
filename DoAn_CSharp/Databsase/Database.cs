using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_CSharp.Databsase
{
    internal class Database
    {
        SqlConnection sqlConn;

        public Database()
        {
            /*string strCnn = "Server=LAPTOP-PEQVO1V4\\ALINSBTC;Database=QLthuvien;uid=sa;pwd=123";*/
            // string strCnn = "Server=LAPTOP-PEQVO1V4\\ALINSBTC;Database=QuanLyBanGiay;uid=sa;pwd=123";
            /*string strCnn = "Data Source=DESKTOP-7R66M1N\\THAIBAOSERVER;Initial Catalog=QuanLyBanGiay;Integrated Security=True";*/
           /* string strCnn = "Data Source=DESKTOP-7R66M1N\\THAIBAOSERVER;Initial Catalog=QuanLyBanGiay1;Integrated Security=True";*/
            string strCnn = "Data Source=LAPTOP-PDE9TC1I\\SQLEXPRESS; Initial Catalog=QuanLyBanGiay2; Integrated Security=True";

            sqlConn = new SqlConnection(strCnn);
        }

        public SqlConnection GetConnection()
        {
            return sqlConn;
        }

        public DataTable Execute(string sqlStr)
        {
            SqlDataAdapter da = new SqlDataAdapter(sqlStr, sqlConn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        public DataTable Execute(string sqlStr, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(sqlStr, sqlConn))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                // Log the exception details
                Console.WriteLine($"Error executing SQL query: {ex.Message}");
                throw; // Re-throw the exception to propagate it
            }
        }

        public object ExecuteScalar(string strSQL, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(strSQL, sqlConn))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    sqlConn.Open();
                    object result = command.ExecuteScalar();
                    return result;
                }
            }
            catch (Exception ex)
            {
                // Log the exception details
                Console.WriteLine($"Error executing SQL query: {ex.Message}");
                throw; // Re-throw the exception to propagate it
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
            }
        }


        public object ExecuteScalar(string strSQL)
        {
            SqlCommand sqlcmd = new SqlCommand(strSQL, sqlConn);
            sqlConn.Open();
            object result = sqlcmd.ExecuteScalar();
            sqlConn.Close();
            return result;
        }

        public void ExecuteNonQuery(string strSQL)
        {
            SqlCommand sqlcmd = new SqlCommand(strSQL, sqlConn);
            sqlConn.Open();
            sqlcmd.ExecuteNonQuery();
            sqlConn.Close();
        }

        public void ExecuteNonQuery(string strSQL, SqlParameter[] parameters)
        {
            SqlCommand sqlcmd = new SqlCommand(strSQL, sqlConn);
            sqlcmd.Parameters.AddRange(parameters);
            sqlConn.Open();
            sqlcmd.ExecuteNonQuery();
            sqlConn.Close();
        }
    }
}
