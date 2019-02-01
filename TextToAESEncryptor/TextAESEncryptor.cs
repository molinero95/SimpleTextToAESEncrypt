using System;
using System.IO;
using System.Text;

namespace TextToAESEncryptor
{
    public static class TextAESEncryptor
    {
        public static string TextEncrypt(string text, string encryptPassword)
        {
            byte[] textAsByteArray = Encoding.UTF8.GetBytes(text.Trim());
            byte[] textEncryptedByteArray;
            using (MemoryStream plainTextMemoryStream = new MemoryStream(textAsByteArray))
            {
                using(MemoryStream encryptedTextMemoryStream = new MemoryStream())
                {
                    SharpAESCrypt.SharpAESCrypt.Encrypt(encryptPassword, plainTextMemoryStream, encryptedTextMemoryStream);
                    textEncryptedByteArray = encryptedTextMemoryStream.ToArray();
                }
            }
            return Convert.ToBase64String(textEncryptedByteArray);
        }

        public static string TextDecrypt(string encryptedText, string encryptPassword)
        {
            byte[] textAsByteArray = Convert.FromBase64String(encryptedText);
            byte[] textEncryptedByteArray;
            using (MemoryStream plainTextMemoryStream = new MemoryStream(textAsByteArray))
            {
                using (MemoryStream encryptedTextMemoryStream = new MemoryStream())
                {
                    SharpAESCrypt.SharpAESCrypt.Decrypt(encryptPassword, plainTextMemoryStream, encryptedTextMemoryStream);
                    textEncryptedByteArray = encryptedTextMemoryStream.ToArray();
                }
            }
            return System.Text.Encoding.UTF8.GetString(textEncryptedByteArray);
        }
    }
}
