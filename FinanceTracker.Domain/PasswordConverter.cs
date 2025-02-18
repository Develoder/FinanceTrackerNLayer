using System.Security.Cryptography;
using System.Text;

namespace FinanceTracker.Domain
{
    internal class PasswordConverter
    {
        /// <summary>
        /// Возвращает зашиврованный хэш (используется для записи пароля)
        /// </summary>
        internal static string GetHashPassword(string input)
        {
            char[] chars = input.ToCharArray();
            byte[] buffer = Encoding.UTF8.GetBytes(chars);
            byte[] hash = MD5.Create().ComputeHash(buffer);
            string[] hashString = hash.Select(x => x.ToString("x2")).ToArray();
            return string.Join("", hashString);
        }
    }
}
