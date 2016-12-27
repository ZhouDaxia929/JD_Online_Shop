using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace JD_Online_Shop_Bll {
    class MD5 {
        //MD5
        static public string MD5_Hash (string str_md5_in) {
            /*
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            string t2 = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(str_md5_in)), 4, 8);
            t2 = t2.Replace("-", "").ToLower();
            return t2;
            */
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            return BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(str_md5_in)), 4, 8).Replace("-", "").ToLower();
        }

    }
}
