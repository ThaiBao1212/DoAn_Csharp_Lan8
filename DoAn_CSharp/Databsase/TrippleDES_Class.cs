using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace DoAn_CSharp.Database
{
    public class TripleDES_Class
    {
        private byte[] key;
        private byte[] iv;

        public TripleDES_Class()
        {
            // Đặt khóa key bằng 24 ký tự bất kỳ
            key = Encoding.UTF8.GetBytes("123*45#hgk&^$#!df*7^3)g-");

            // Khởi tạo initialization Vector (IV) bằng ký tự bất kỳ
            iv = Encoding.UTF8.GetBytes("456%Q&$#");
        }

        public TripleDES_Class(string _key, string _iv)
        {
            key = Encoding.UTF8.GetBytes(_key);
            iv = Encoding.UTF8.GetBytes(_iv);
        }

        public string MaHoa(string strToEncrypt)
        {
            using (TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider())
            {
                DES.Key = key;
                DES.IV = iv;

                byte[] input = Encoding.UTF8.GetBytes(strToEncrypt);
                using (MemoryStream output = new MemoryStream())
                {
                    using (CryptoStream objCryptoStream = new CryptoStream(output, DES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        objCryptoStream.Write(input, 0, input.Length);
                        objCryptoStream.FlushFinalBlock();
                    }
                    return Convert.ToBase64String(output.ToArray());
                }
            }
        }

        public string GiaiMa(string strToDecrypt)
        {
            using (TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider())
            {
                DES.Key = key;
                DES.IV = iv;

                byte[] input = Convert.FromBase64String(strToDecrypt);
                using (MemoryStream output = new MemoryStream())
                {
                    using (CryptoStream objCryptoStream = new CryptoStream(output, DES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        objCryptoStream.Write(input, 0, input.Length);
                        objCryptoStream.FlushFinalBlock();
                    }
                    return Encoding.UTF8.GetString(output.ToArray());
                }
            }
        }
    }
}
