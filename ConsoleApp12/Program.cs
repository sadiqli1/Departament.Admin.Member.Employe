using System;
using ConsoleApp12.Services;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuServices menu = new MenuServices();
            bool result = false;
            int num;
            do
            {
                Console.WriteLine("1.Admin");
                Console.WriteLine("2.Member");
                Console.WriteLine("3.Employee");
                Console.WriteLine("0.Exit");
                string numstr = Console.ReadLine();
                result = int.TryParse(numstr, out num);
                switch (num)
                {
                    case 1:
                        menu.AdminMethodMenu();
                        break;
                    case 2:
                        menu.MemberMethodMenu();
                        break;
                    case 3:
                        menu.EmployeeMenu();
                        break;
                    default:
                        break;
                }
            } while (num!=0 || result==false);
            
        }
    }
}
