using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp12.Enum;

namespace ConsoleApp12
{
    class Member
    {
        public string Fulllname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        Departments Department;
        public static int Count = 1;
        public static int Count1 = 1;
        public static int Count2 = 1;
        public string No;
        public Member(string fullname, string email, string username, string password/*,Departments departments*/)
        {
            Fulllname = fullname;
            Email = email;
            Username = username;
            Password = password;
        }
        public Member(Departments department)
        {
            switch (department)
            {
                case Departments.Bank:
                    No = $"B{Count}";
                    Count++;
                    break;
                case Departments.Natoriat:
                    No = $"N{Count1}";
                    Count1++;
                    break;
                case Departments.Passport:
                    No = $"P{Count2}";
                    Count2++;
                    break;
                default:
                    break;
            }
            Department = department;
        }
        public override string ToString()
        {
            return $"Fullname: {Fulllname}, Username: {Username}";
        }
    }
}
