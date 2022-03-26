using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    class Employee
    {
        public string Fulllname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


        public Employee(string fullname,string email, string username, string password)
        {
            Fulllname = fullname;
            Email = email;
            Username = username;
            Password = password;
        }
        public override string ToString()
        {
            return $"Fullname: {Fulllname}, Username: {Username}";
        }
    }
}
