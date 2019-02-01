
using System;
using TextToAESEncryptor;

namespace EncryptorTester
{
    class Program
    {
        static void Main(string[] args)
        {
            //EncryptMenu();
            //DecryptMenu();
            EncryptAndDecryptMenu();
            Console.ReadKey();
        }

        public static void EncryptAndDecryptMenu()
        {
            Console.WriteLine("Write text: ");
            string text = Console.ReadLine();
            Console.WriteLine("Write encrypt password: ");
            string password = Console.ReadLine();
            string encryptedText = TextAESEncryptor.TextEncrypt(text, password);
            Console.WriteLine(encryptedText);
            string decryptedText = TextAESEncryptor.TextDecrypt(encryptedText, password);
            Console.WriteLine("Text Written: " + decryptedText); ;
        }

        public static void EncryptMenu()
        {
            Console.WriteLine("Write text: ");
            string text = Console.ReadLine();
            Console.WriteLine("Write encrypt password: ");
            string password = Console.ReadLine();
            string encryptedText = TextAESEncryptor.TextEncrypt(text, password);
            Console.WriteLine(encryptedText);
        }

        public static void DecryptMenu()
        {
            Console.WriteLine("Write text: ");
            string encryptedText = Console.ReadLine();
            Console.WriteLine("Write encrypt password: ");
            string password = Console.ReadLine();
            string decryptedText = TextAESEncryptor.TextDecrypt(encryptedText, password);
            Console.WriteLine("Text Written: " + decryptedText); ;
        }

    }
}
