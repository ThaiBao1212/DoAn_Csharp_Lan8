using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_CSharp.Database
{
    internal class Database
    {
        internal SqlConnection sqlConn;

        public Database()
        {
            /*string strCnn = "Server=LAPTOP-PEQVO1V4\\ALINSBTC;Database=QLthuvien;uid=sa;pwd=123";*/
            string strCnn = "Server=LAPTOP-PEQVO1V4\\ALINSBTC;Database=QuanLyBanGiay4;uid=sa;pwd=123";

            sqlConn = new SqlConnection(strCnn);
        }
        public SqlConnection GetConnection()
        {
            return sqlConn;
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


        public int ExecuteNonQuery(string strSQL)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand(strSQL, sqlConn);
                sqlConn.Open();
                int rowsAffected = sqlcmd.ExecuteNonQuery();
                return rowsAffected; // Return the number of rows affected
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

        // Overloaded ExecuteNonQuery method with parameters
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
