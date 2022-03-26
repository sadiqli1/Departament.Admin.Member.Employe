using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp12.Enum;
using ConsoleApp12.Interface;

namespace ConsoleApp12.Services
{
    class DepartmentServices: IDepartmentServices
    {
        List<Employee> employees = new List<Employee>();
        List<Member> members = new List<Member>();
        public void CreateEmployee(string fullname, string email, string username, string password)
        {
            Employee employee = new Employee(fullname, email, username, password);
            employees.Add(employee);
            Console.WriteLine("Created Employee");
        }
        public void ShowallEmployee()
        {
            if (employees.Count!=0)
            {
                foreach (var employee in employees)
                {
                    Console.WriteLine(employee);
                }
            }
            else
            {
                Console.WriteLine("There are no employees");
            }
        }
        public void ShowAllMembers()
        {
            if (members.Count!=0)
            {
                foreach (var member in members)
                {
                    Console.WriteLine(member);
                }
            }
            else
            {
                Console.WriteLine("There are no member");
            }
        }
        public void RegisterMember(string fullname, string email, string username, string password)
        {
            Member member = new Member(fullname, email, username, password);
            members.Add(member);
        }
        public bool FindMember(string username, string password)
        {
            bool result = false;
            foreach (var item in members)
            {
                if (item.Username == username && item.Password == password)
                {
                    result = true;
                    break;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }
        public bool FindEnployee(string username, string password)
        {
            bool result = false;
            foreach (var item in employees)
            {
                if (item.Username == username && item.Password == password)
                {
                    result = true;
                    break;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }
        public string LoginMember(Departments departments)
        {
            Member member = new Member(departments);
            members.Add(member);
            return member.No;
        }
    }
}
