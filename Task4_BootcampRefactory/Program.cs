using System;
using System.Collections.Generic;

namespace Task4_BootcampRefactory
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Masukkan kata yang kamu inginkan: ");
            string plainData = Console.ReadLine();
            Console.WriteLine("Raw data : {0}", plainData);

            string hashedDataMD5 = HashStringClass.md5(plainData);
            Console.WriteLine($"Hash.md5('{plainData}') // {hashedDataMD5}");

            string hashedDataSHA1 = HashStringClass.sha1(plainData);
            Console.WriteLine($"Hash.SHA1('{plainData}') // {hashedDataSHA1}");

            string hashedDataSHA256 = HashStringClass.sha256(plainData);
            Console.WriteLine($"Hash.SHA256('{plainData}') // {hashedDataSHA256}");

            string hashedDataSHA512 = HashStringClass.sha512(plainData);
            Console.WriteLine($"Hash.SHA512('{plainData}') // {hashedDataSHA512}");

            Console.WriteLine("Hash String is done.");
            Console.WriteLine("");

            Console.WriteLine("Please enter a password to use:");
            string passPhrase = Console.ReadLine();
            Console.WriteLine("Please enter a string to encrypt:");
            string plaintext = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Your encrypted string is:");
            string encryptedstring = CipherStringClass.EncryptString(plaintext, passPhrase);
            Console.WriteLine("This is a secret that you may not know, please input your password first");
            Console.WriteLine("");

            Console.WriteLine("Please enter a password to decrypted:");
            string passWord = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Your decrypted string is:");
            string decryptedstring = CipherStringClass.DecryptString(encryptedstring, passPhrase, passWord);
            Console.WriteLine(decryptedstring);

            Console.WriteLine("Cipher String is done.");
            Console.WriteLine("");

        }
    }
}
