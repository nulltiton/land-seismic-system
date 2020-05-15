using System;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace LandSeismic.Validation
{
    /// <summary>
    /// Класс валидации
    /// </summary>
    class ValidationClass
    {
        /// <summary>
        /// Шифрование пароля
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Проверка на английские символы или числа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        static public Boolean IsEnglishSybolsOrNumeral(object sender, 
            KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'А' && e.KeyChar <= 'я')
                return true;
            else
                return false;
        }

        /// <summary>
        /// Проверка на числа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        static public Boolean IsNumeral(object sender, 
            KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) && e.KeyChar != 8)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Проверка на русские символы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        static public Boolean IsRussianSymbols(object sender, 
            KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != 8 && 
                e.KeyChar != 32 && e.KeyChar != '-')
                return true;
            else
                return false;
        }

        /// <summary>
        /// Проверка на русские символы или числа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        static public Boolean IsRussianSymbolsOrNumeral(object sender, 
            KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && e.KeyChar != 8 &&
                e.KeyChar != 32 && e.KeyChar != '.' && e.KeyChar != ',' &&
                !Char.IsNumber(e.KeyChar))
                return true;
            else
                return false;
        }
    }
}
