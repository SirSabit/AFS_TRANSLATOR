using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AFS_TRANSLATOR.CORE
{
    public static class HelperFunctions
    {
        public static string HashString(string passwordHash)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(passwordHash))
                sb.Append(b.ToString("X3"));
            return sb.ToString();
        }

        public static byte[] GetHash(string passwordHash)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
            {
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(passwordHash));
            }
        }
    }
}
