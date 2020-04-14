using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace Hashing
{
    public class Sha1
    {
        //
        // calcul du SHA1 d'un fichier
        //
        public static string SHA1HashFile(string Filename)
        {
            byte[] Result;
            string HashString = string.Empty;
            SHA1 SHA1 = new SHA1CryptoServiceProvider();
            try
            {
                Stream MyStream = File.OpenRead(Filename);
                Result = SHA1.ComputeHash(MyStream);
                StringBuilder output = new StringBuilder(2 + (Result.Length * 2));
                foreach (byte b in Result)
                {
                    output.Append(b.ToString("x2"));
                }
                HashString = output.ToString().ToUpper();
                MyStream.Close();

                return HashString;

            }
            catch (Exception e2)
            {
                return e2.Message;
            }
        }
    }
}
