using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFivePrototypes
{
    static class PasswordValidator
    {
        static public bool ValidPassword(string password)
        {
            if (password.Length < 6 || password.Length > 13) return false;

            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber))
            {

                foreach (char character in password)
                {
                    if(character == 'T' || character == '&')
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }

            return true;
        }
    }
}
