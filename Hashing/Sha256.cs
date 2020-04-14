using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace Hashing
{
    public class Sha256
    {
        //
        // Calcul SHA256
        //
        public static string SHA256HashFile(string Filename)
        {
            byte[] HashValue;
            string HashString = string.Empty;
            SHA256 MySHA256 = SHA256Managed.Create();
            try
            {
                Stream MyStream = File.OpenRead(Filename);
                HashValue = MySHA256.ComputeHash(MyStream);
                StringBuilder output = new StringBuilder(2 + (HashValue.Length * 2));
                foreach (byte b in HashValue)
                {
                    output.Append(b.ToString("x2"));
                }
                HashString = output.ToString().ToUpper();
                MyStream.Close();

                return HashString;
            }
            catch (Exception e3)
            {
                return e3.Message;
            }
        }

    }
}
