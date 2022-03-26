using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12.Check
{
    class Check_
    {
        //public static bool CheckPassword(string password)
        //{

        //}
        public bool CheckFullname(string fullname)
        {
            if (fullname.Length>=3 && char.IsUpper(fullname[0]))
            {
                return true;
            }
            return false;
        }
        public bool CheckEmail(string email)
        {
            bool haslower = false;
            bool has_at = false;
            bool hasdigit = false;
            bool result = false;
            if (email.Length>10)
            {
                result = true;
                for (int i = 0; i < email.Length; i++)
                {
                    if (char.IsLower(email[i]))
                    {
                        haslower = true;
                    }
                    else if (char.IsDigit(email[i]))
                    {
                        hasdigit = true;
                    }
                    else if (email[i] == '@')
                    {
                        has_at = true;
                    }
                }
            }
            else
            {
                result = false;
            }
            result = haslower && has_at && hasdigit;
            return result;
        }
        public bool CheckUsername(string username)
        {
            if (username.Length>5)
            {
                return true;
            }
            return false;
        }
        public bool CheckPassword(string password)
        {
            bool haslower = false;
            bool hasupper = false;
            bool hasdigit = false;
            bool result = false;
            if (password.Length>=8)
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if (char.IsUpper(password[i]))
                    {
                        hasupper = true;
                    }
                    else if (char.IsLower(password[i]))
                    {
                        haslower = true;
                    }
                    else if (char.IsDigit(password[i]))
                    {
                        hasdigit = true;
                    }
                }
            }
            else
            {
                result=false;
            }
            result = hasupper && haslower && hasdigit;
            return result;
        }
    }
}
