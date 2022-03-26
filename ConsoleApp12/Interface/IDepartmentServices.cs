using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12.Interface
{
    interface IDepartmentServices
    {
        public void CreateEmployee(string fullname, string email, string username, string password);
        public void ShowallEmployee();
        public void ShowAllMembers();
        
    }
}
    