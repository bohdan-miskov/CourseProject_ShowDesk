using System;
using System.Security.Cryptography;
using System.Text;

namespace CourseProject_ShowDesk.Scripts.Utilities.Helpers
{
    public class MasterCypherAES
    {
        private readonly byte[] key;

        public MasterCypherAES(string masterPassword)
        {
            using (SHA256 sha = SHA256.Create())
            {
                key = sha.ComputeHash(Encoding.UTF8.GetBytes(masterPassword));
            }
        }

        public string Encrypt(string plainText)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.GenerateIV();

                ICryptoTransform encryptor = aes.CreateEncryptor();
                using (encryptor)
                {
                    byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
                    byte[] cipherBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);

                    byte[] result = new byte[aes.IV.Length + cipherBytes.Length];
                    Buffer.BlockCopy(aes.IV, 0, result, 0, aes.IV.Length);
                    Buffer.BlockCopy(cipherBytes, 0, result, aes.IV.Length, cipherBytes.Length);

                    return Convert.ToBase64String(result);
                }
            }
        }


        public string Decrypt(string cipherText)
        {
            byte[] fullCipher = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;

                byte[] iv = new byte[16];
                byte[] cipherBytes = new byte[fullCipher.Length - iv.Length];
                Buffer.BlockCopy(fullCipher, 0, iv, 0, iv.Length);
                Buffer.BlockCopy(fullCipher, iv.Length, cipherBytes, 0, cipherBytes.Length);

                aes.IV = iv;

                ICryptoTransform decryptor = aes.CreateDecryptor();
                using (decryptor)
                {
                    byte[] plainBytes = decryptor.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
                    return Encoding.UTF8.GetString(plainBytes);
                }
            }
        }

    }
}
