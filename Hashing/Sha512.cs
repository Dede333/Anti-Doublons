using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace Hashing
{
    public class Sha512
    {
        //
        // Calcul SHA512
        //
        public static string SHA512HashFile(string Filename)
        {
            byte[] HashValue;
            string HashString = string.Empty;
            SHA512 MySHA512 = SHA512Managed.Create();
            try
            {
                Stream MyStream = File.OpenRead(Filename);
                HashValue = MySHA512.ComputeHash(MyStream);
                StringBuilder output = new StringBuilder(2 + (HashValue.Length * 2));
                foreach (byte b in HashValue)
                {
                    output.Append(b.ToString("x2"));
                }
                HashString = output.ToString().ToUpper();
                MyStream.Close();

                return HashString;
            }
            catch (Exception e5)
            {
                return e5.Message;
            }
        }
    }
}
