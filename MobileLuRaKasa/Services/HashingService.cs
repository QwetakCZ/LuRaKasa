using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace MobileLuRaKasa.Services
{
    public static class HashingService
    {
        public static string PasswordTo256Hash(string rawData)
        {
            // Vytvoření SHA256 objektu
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Výpočet hash hodnoty zadaného textu (hesla)
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Převod bajtového pole na string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
