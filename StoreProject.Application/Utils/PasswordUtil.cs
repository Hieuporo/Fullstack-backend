using System.Text;
using System.Security.Cryptography;

namespace StoreProject.Application.Utils
{
    public static class PasswordUtil
    {
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new();
            MD5CryptoServiceProvider md5provider = new();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        public static bool Compare(string password, string userPassword)
        {
            string hash = MD5Hash(password);
            return hash.ToLower().Equals(userPassword.ToLower());
        }
    }
}
