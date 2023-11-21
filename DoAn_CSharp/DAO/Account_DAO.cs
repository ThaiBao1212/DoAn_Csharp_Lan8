using DoAn_CSharp.Databsase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_CSharp.DAO
{
    internal class Account_DAO
    {
        private static Account_DAO instance;

        public static Account_DAO Instance
        {
            get { if (instance == null) instance = new Account_DAO(); return instance; }
            set { instance = value; }
        }

        private Account_DAO() { }



        public bool Login(string userName, string passWord)
        {
            string query = "USP_Login @username , @password";

            DataTable result = DataProvider.Instance.ExecuteQuery(query , new object[] {userName , passWord} );
            return result.Rows.Count > 0;
        }










    }


}
