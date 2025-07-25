﻿using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject_ShowDesk.Scripts.Utilities.Helpers
{
    public static class DataHasher
    {
        public static async Task<string> HashPassword(string password)
        {
            return await Task.Run(() =>
            {
                using (var rng = new RNGCryptoServiceProvider())
                {
                    byte[] salt = new byte[16];
                    rng.GetBytes(salt);

                    var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100_000, HashAlgorithmName.SHA256);
                    byte[] hash = pbkdf2.GetBytes(32);

                    byte[] hashBytes = new byte[48];
                    Array.Copy(salt, 0, hashBytes, 0, 16);
                    Array.Copy(hash, 0, hashBytes, 16, 32);

                    return Convert.ToBase64String(hashBytes);
                }
            });
        }

        public static async Task<bool> VerifyPassword(string password, string storedHash)
        {
            return await Task.Run(() =>
            {
                byte[] hashBytes = Convert.FromBase64String(storedHash);
                byte[] salt = new byte[16];
                Array.Copy(hashBytes, 0, salt, 0, 16);

                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100_000, HashAlgorithmName.SHA256);
                byte[] hash = pbkdf2.GetBytes(32);

                for (int i = 0; i < 32; i++)
                {
                    if (hashBytes[i + 16] != hash[i])
                        return false;
                }

                return true;
            });
        }
    }
}
