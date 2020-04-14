using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace Hashing
{
    public class Md5
    {
        //
        // calcul du Md5 d'un fichier
        //
        public static string MD5HashFile(string Filename)
        {
            byte[] Result;
            string HashString;
            MD5 MD5 = new MD5CryptoServiceProvider();
            try
            {
                Stream MyStream = File.OpenRead(Filename);
                Result = MD5.ComputeHash(MyStream);
                StringBuilder output = new StringBuilder(2 + (Result.Length * 2));
                foreach (byte b in Result)
                {
                    output.Append(b.ToString("x2"));
                }
                HashString = output.ToString().ToUpper();
                MyStream.Close();

                return HashString;
            }
            catch (Exception e1)
            {
                return e1.Message;
            }
        }
    }
}
