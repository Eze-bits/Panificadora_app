using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Seguridad
{
    public class Encriptacion
    {

        public string Encriptar(string encrip)
        {

          
            UnicodeEncoding Ue = new UnicodeEncoding();
   
            byte[] arraybytes = Ue.GetBytes(encrip);
          
            MD5CryptoServiceProvider Md5 = new MD5CryptoServiceProvider();
        
            byte[] arrayhash = Md5.ComputeHash(arraybytes);
           
            return Convert.ToBase64String(arrayhash);

        }

    }
}
