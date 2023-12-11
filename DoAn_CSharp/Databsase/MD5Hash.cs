using System;
using System.Security.Cryptography;
using System.Text;

public class MD5Hash
{
    public static string CalculateMD5Hash(string input)
    {
        // Chuyển đổi input string thành mảng byte và tính toán mã MD5
        using (MD5 md5 = MD5.Create())
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Chuyển đổi mảng byte thành định dạng hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }

            return sb.ToString();
        }
    }
}
