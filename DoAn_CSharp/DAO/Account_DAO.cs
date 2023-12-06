using DoAn_CSharp.Databsase;
using DoAn_CSharp.DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public Account_DTO GetAccountByUserName(string tenTaiKhoanNV)
        {

            DataTable data = DataProvider.Instance.ExecuteQuery(" SELECT * FROM nhanvien WHERE TenTaiKhoanNV =  '" + tenTaiKhoanNV + "'");
            foreach (DataRow item in data.Rows)
            {
                return new Account_DTO(item);
            }
            return null;
        }

                   
        public bool UpdateAccount(string hoTenNV , string tenTaiKhoanNV , string matKhauNV , string matKhauMoi) 
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @tenTaiKhoanNV  , @hoTenNV  , @matKhauNV , @matKhauMoi", new object[]{ hoTenNV, tenTaiKhoanNV , matKhauNV , matKhauMoi} );

            return result > 0;
        }

    }

}
