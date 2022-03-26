using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    class Admin
    {
        private string username = "asd";
        private string password = "asd";
        public string Username/* = "Admin123";*/
        {
            get
            {
                return username;

            }
            set
            {
                username = value;
            }
        }
        public string Password /*= "Aa12345678";*/
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
    }
}
