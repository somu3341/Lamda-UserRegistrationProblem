using System;
namespace Lamda_UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose Option to Perform\n1.First Name\n2.Last Name\n3.Email ID\n4.Phone NUmber\n5.Password(Rule-1)\n6.Password(Rule-2)\n7.Password(Rule-3)\n8.Exit");
                int option=Convert.ToInt32(Console.ReadLine());
                UserRegistration user = new UserRegistration();
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter First Name");
                        string name = Console.ReadLine();
                        user.UserFirst(name);
                        break;
                    case 2:
                        Console.WriteLine("Enter Last Name");
                        string second = Console.ReadLine();
                        user.UserFirst(second);
                        break;
                    case 3:
                        Console.WriteLine("Enetr Email Id");
                        string email= Console.ReadLine();
                        user.Email(email);
                        break;
                        case 4:
                        Console.WriteLine("Enter Phone Number");
                        string phone= Console.ReadLine();
                        user.PhoneNumber(phone);
                        break; 
                        case 5:
                        Console.WriteLine("Enter Password Rule1(Min-8char)");
                        string rule= Console.ReadLine();
                        user.PasswordRule1(rule);
                        break;
                        case 6:
                        Console.WriteLine("Enter Password Rule2(1-Uppercase)(Min-8char)");
                        string rule2 = Console.ReadLine();
                        user.PasswordRule2(rule2);
                        break;
                        case 7:
                        Console.WriteLine("Enter Password Rule3(1-Numeric)(Min-8char)");
                        string rule3 = Console.ReadLine();
                        user.PasswordRule2(rule3);
                        break;
                    case 8:
                        flag = false;
                        break;
                }
            }           
        }
    }
}
