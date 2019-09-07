using System;
using System.Security.Cryptography;
using System.Text;

namespace CryptoChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
            Byte[] hashedBytes;
            UTF8Encoding encoder = new UTF8Encoding();

            hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes("steve4505" + "sdemaine"));

            string retVal = string.Empty;

            foreach (byte b in hashedBytes)
            {
                retVal += b;
            }

            var result = retVal;

        }
    }
}
