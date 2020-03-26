using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace LandSeismic.Validation
{
    class Validation
    {
        static public string PasswordEncryption(string password)
        {
            byte[] Bytes = Encoding.Unicode.GetBytes(password);
            MD5CryptoServiceProvider EncryptedPassword = new MD5CryptoServiceProvider();
            byte[] byteHash = EncryptedPassword.ComputeHash(Bytes);
            string hash = string.Empty;
            foreach (byte Symbol in byteHash)
                hash += string.Format("{0:x2}", Symbol);
            return hash;
        }

        static public Boolean IsEnglishSybols(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'А' && e.KeyChar <= 'я')
                return true;
            else
                return false;
        }
    }
}
