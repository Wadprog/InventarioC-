using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilidades
{
    class Exceptions
    {
        public static void OnlyLetters(KeyPressEventArgs key) {
            try
            {
                if (Char.IsLetter(key.KeyChar) || Char.IsControl(key.KeyChar) || Char.IsSeparator(key.KeyChar))
                    key.Handled = false;
                else
                    key.Handled = true;
            }
            catch (Exception e) {
                Console.WriteLine("Error in verifying is key is letter" + e.Message);
            }
        }
        public static void OnlyNumbers(KeyPressEventArgs key)
        {
            try
            {
                if (Char.IsNumber(key.KeyChar) || Char.IsControl(key.KeyChar) || Char.IsSeparator(key.KeyChar))
                    key.Handled = false;
                else
                    key.Handled = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in verifying is key is letter" + e.Message);
            }
        }
        public static bool MailValidation(string email)
        {
            try {
                if (!String.IsNullOrEmpty(email.Trim()))
                {
                    new MailAddress(email);
                    return true;
                }
                else
                    return false; 

            } catch (Exception e) {
                Console.WriteLine("Error reviewing email " + e.Message);
                return false;
            }
        }
    }
}
