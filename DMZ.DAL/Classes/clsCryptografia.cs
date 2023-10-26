using System;
using System.Security.Cryptography;
using System.Text;

namespace DMZ.DAL.Classes
{
    public static class ClsCryptografia
    {
        // Fields
        private static string myKey = "DFD@$/*9068fSiusdWSIKJKSAhgdf\x00a8%&*&1231";
        private static TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
        private static MD5CryptoServiceProvider hashmd5 = new   MD5CryptoServiceProvider();

        // Methods
        private static string Cifra(string texto)
        {
            des.Key = hashmd5.ComputeHash(Encoding.ASCII.GetBytes(myKey));
            des.Mode = CipherMode.ECB;
            byte[] bytes = Encoding.ASCII.GetBytes(texto);
            return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(bytes, 0, bytes.Length));
        }

        public static string Crypto(string texto, bool op) =>
            !op ? DeCifra(texto) : Cifra(texto);

        private static string DeCifra(string texto)
        {
            des.Key = hashmd5.ComputeHash(Encoding.ASCII.GetBytes(myKey));
            des.Mode = CipherMode.ECB;
            ICryptoTransform transform = des.CreateDecryptor();
            byte[] inputBuffer = Convert.FromBase64String(texto);
            return Encoding.ASCII.GetString(transform.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length));
        }
    }



}
