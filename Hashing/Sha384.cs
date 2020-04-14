using System;
using System.Collections.Generic;

using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace Hashing
{
    public class Sha384
    {
        //
        // Calcul SHA384
        //
        public static string SHA384HashFile(string Filename)
        {
            byte[] HashValue;
            string HashString = string.Empty;
            SHA384 MySHA384 = SHA384Managed.Create();
            try
            {
                Stream MyStream = File.OpenRead(Filename);
                HashValue = MySHA384.ComputeHash(MyStream);
                StringBuilder output = new StringBuilder(2 + (HashValue.Length * 2));
                foreach (byte b in HashValue)
                {
                    output.Append(b.ToString("x2"));
                }
                HashString = output.ToString().ToUpper();
                MyStream.Close();

                return HashString;
            }
            catch (Exception e4)
            {
                return e4.Message;
            }
        }

    }
}
