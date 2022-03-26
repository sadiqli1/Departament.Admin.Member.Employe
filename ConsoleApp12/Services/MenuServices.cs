using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp12.Enum;
using ConsoleApp12.Interface;
using ConsoleApp12.Check;

namespace ConsoleApp12.Services
{
    class MenuServices
    {
        DepartmentServices departmentServices = new DepartmentServices();
        Check_ check = new Check_();
        public void AdminMethodMenu()
        {
            Admin admin = new Admin();
            string username;
            string password;
            do
            {
                Console.WriteLine("Please chosse username.");
                username = Console.ReadLine();
                Console.WriteLine("Please chosse password.");
                password = Console.ReadLine();
                if (admin.Username == username && admin.Password == password)
                {
                    int num;
                    string numstr;
                    bool result = false;
                    do
                    {
                        Console.WriteLine("1.CreateEmployee");
                        Console.WriteLine("2.ShowAllEmployes");
                        Console.WriteLine("3.ShowAllMembers");
                        Console.WriteLine("0.Exit");
                        numstr = Console.ReadLine();
                        result = int.TryParse(numstr, out num);
                        switch (num)
                        {
                            case 1:
                                CreateEmployeeMenu();
                                break;
                            case 2:
                                ShowallEmployeeMenu();
                                break;
                            case 3:
                                departmentServices.ShowAllMembers();
                                break;
                            default:
                                break;
                        }
                    } while (result==false || num!= 0);
                }
            } while (admin.Username != username || admin.Password != password);
        }
        public void CreateEmployeeMenu()
        {
            string fullname;
            string email;
            string username;
            string password;
            do
            {
                Console.WriteLine("Please chosse Fullname.");
                fullname = Console.ReadLine();
            } while (check.CheckFullname(fullname) == false);
            do
            {
                Console.WriteLine("Please chosse Email.");
                email = Console.ReadLine();
            } while (check.CheckEmail(email) == false);
            do
            {
                Console.WriteLine("Please chosse username.");
                username = Console.ReadLine();
            } while (check.CheckUsername(username) == false);
            do
            {
                Console.WriteLine("Please chosse password.");
                password = Console.ReadLine();
            } while (check.CheckPassword(password) == false);
            departmentServices.CreateEmployee(fullname, email, username, password);
        }
        public void ShowallEmployeeMenu()
        {
            departmentServices.ShowallEmployee();
        }
        public void MemberMethodMenu()
        {
            bool result = false;
            int num;
            do
            {
                Console.WriteLine("1.Register");
                Console.WriteLine("2.Login");
                Console.WriteLine("0.Exit");
                string numstr = Console.ReadLine();
                result = int.TryParse(numstr, out num);
                switch (num)
                {
                    case 1:
                        RegisterMemberMenu();
                        break;
                    case 2:
                        LoginMemberMenu();
                        break;
                    default:
                        break;
                }
            } while (num!= 0 || result==false);
        }
        public void RegisterMemberMenu()
        {
            string fullname;
            string email;
            string username;
            string password;
            do
            {
                Console.WriteLine("Please chosse Fullname.");
                fullname = Console.ReadLine();
            } while (check.CheckFullname(fullname) == false);
            do
            {
                Console.WriteLine("Please chosse Email.");
                email = Console.ReadLine();
            } while (check.CheckEmail(email) == false);
            do
            {
                Console.WriteLine("Please chosse Username.");
                username = Console.ReadLine();
            } while (check.CheckUsername(username));
            do
            {
                Console.WriteLine("Please chosse Password.");
                password = Console.ReadLine();
            } while (check.CheckPassword(password) == false);
            departmentServices.RegisterMember(fullname, email, username, password);
        }
        public void LoginMemberMenu()
        {
            Console.WriteLine("Please chosse Username.");
            string username = Console.ReadLine();
            Console.WriteLine("Please chosse Password.");
            string password = Console.ReadLine();
            bool result = departmentServices.FindMember(username, password);
            if (result)
            {
                int departmentnum;
                string departmentstr;
                bool resaultnum;
                bool result1;
                do
                {
                    Console.WriteLine("Please chosse Department");
                    foreach (Departments d in System.Enum.GetValues(typeof(Departments)))
                    {
                        Console.WriteLine($"{(int)d}. {d}");
                    }
                    departmentstr = Console.ReadLine();
                    result1 = int.TryParse(departmentstr, out departmentnum);
                    resaultnum = departmentstr == "1" || departmentstr == "2" || departmentstr == "3";
                } while (resaultnum == false || result1 == false);
                switch (departmentnum)
                {
                    case (int)Departments.Bank:
                        string No = departmentServices.LoginMember(Departments.Bank);
                        Console.WriteLine($"You queue \n {No}");
                        break;
                    case (int)Departments.Natoriat:
                        No = departmentServices.LoginMember(Departments.Natoriat);
                        Console.WriteLine($"You queue \n {No}");
                        break;
                        case (int)Departments.Passport:
                        No = departmentServices.LoginMember(Departments.Passport);
                        Console.WriteLine($"You queue \n {No}");
                        break;
                    default:
                        break;
                }

            }
            else
            {
                Console.WriteLine("Not exist");
            }
        }
        public void EmployeeMenu()
        {
            string username;
            string password;
            do
            {
                Console.WriteLine("Please chosse Username.");
                username = Console.ReadLine();
                Console.WriteLine("Please chosse Password.");
                password = Console.ReadLine();
            } while (departmentServices.FindEnployee(username,password)==false);
            if (departmentServices.FindEnployee(username,password))
            {
                Console.WriteLine("Entered");
            }
        }
    }
}
