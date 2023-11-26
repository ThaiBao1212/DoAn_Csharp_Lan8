using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_CSharp.DAO
{
    public class KiemTra_DAO
    {
        //Kiểm tra Email
        public static bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return mailAddress.Address == email;
            }
            catch
            {
                return false;
            }
        }
        // Kiểm tra Mật khẩu :
        public static bool IsStrongPassword(string password)
        {
            return password.Length >= 6 && password.Any(char.IsUpper) && password.Any(char.IsDigit) && password.Any(c => !char.IsLetterOrDigit(c));
        }

        //Kiểm tra Số điện thoại

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            return phoneNumber.All(char.IsDigit) && phoneNumber.Length == 10;
        }

        //Kiểm tra Số CCCD

        public static bool IsValidCCCD(string cccd)
        {
            return cccd.All(char.IsDigit);
        }

        // Kiểm tra Tên Tài khoản
        public static bool IsAllLetters(string input)
        {
            return input.All(char.IsLetter);
        }

        //
        public static bool IsValidUsername(string input)
        {
            foreach (char c in input)
            {
                if (char.IsLetter(c) && !char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }

            // Kiểm tra xem có chứa chữ số hay không
            if (input.Any(char.IsDigit))
            {
                return false;
            }

            // Kiểm tra xem có được nhập liền không dấu hay không
            if (input.Any(char.IsWhiteSpace))
            {
                return false;
            }

            // Nếu không có vấn đề gì, trả về true
            return true;
        }

        // Kiểm tra họ tên 
        public static bool IsValidName(string name)
        {
            return name.All(c => char.IsLetter(c) || char.IsWhiteSpace(c) || char.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.NonSpacingMark);
        }

    }
}
