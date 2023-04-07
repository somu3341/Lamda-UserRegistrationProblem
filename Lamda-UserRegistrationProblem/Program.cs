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
                Console.WriteLine("Choose Option to Perform\n1.First Name\n2.Last Name\n3.Email ID\n4.Phone NUmber\n5.Exit");
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
                        flag = false;
                        break;
                }
            }           
        }
    }
}
