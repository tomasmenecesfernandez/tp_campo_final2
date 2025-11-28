using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Servicios
{
    public class encryptacion
    {


        private static readonly string key = "kjfsdhjklfdshjkf";
        private static readonly string iv = "jdkshfhjkfhsdajk";

        public static string Hash(string contenido)
        {
            var md5 = new MD5CryptoServiceProvider();
            var aux = md5.ComputeHash(Encoding.ASCII.GetBytes(contenido));
            return (new ASCIIEncoding()).GetString(aux);
        }
        public static string encriptar(string texto)
        {
            Aes aes = Aes.Create();
            aes.Key = Encoding.UTF8.GetBytes(key);
            aes.IV = Encoding.UTF8.GetBytes(iv);
            ICryptoTransform encryptor = aes.CreateEncryptor();
            MemoryStream ms_escryp = new MemoryStream();
            CryptoStream cs_escryp = new CryptoStream(ms_escryp, encryptor, CryptoStreamMode.Write);
            StreamWriter sw_escryp = new StreamWriter(cs_escryp);
            sw_escryp.Write(texto);
            sw_escryp.Close();
            cs_escryp.Close();
            ms_escryp.Close();
            return Convert.ToBase64String(ms_escryp.ToArray());
        }

        public static string desencryptar(string cipherText)
        {
            Aes aes = Aes.Create();
            aes.Key = Encoding.UTF8.GetBytes(key);
            aes.IV = Encoding.UTF8.GetBytes(iv);
            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
            byte[] bytes_cifrados = Convert.FromBase64String(cipherText);

            MemoryStream ms_escryp = new MemoryStream(bytes_cifrados);
            CryptoStream cs_escryp = new CryptoStream(ms_escryp, decryptor, CryptoStreamMode.Read);
            StreamReader sr_encryp = new StreamReader(cs_escryp);

            string plaintext = sr_encryp.ReadToEnd();
            sr_encryp.Close();
            cs_escryp.Close();
            ms_escryp.Close();

            return plaintext;
        }

    }
}
