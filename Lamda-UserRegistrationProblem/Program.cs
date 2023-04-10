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
                Console.WriteLine("Choose Option to Perform\n1.First Name\n2.Last Name\n3.Email ID\n4.Phone NUmber\n5.Password\n6.Exit");
                int option=Convert.ToInt32(Console.ReadLine());             
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter First Name");
                        string name = Console.ReadLine();
                        string first=UserRegistration.ValidationFirstName_Lamda(name);
                        Console.WriteLine(first);
                        break;
                    case 2:
                        Console.WriteLine("Enter Last Name");
                        string last = Console.ReadLine();
                        string lastname=UserRegistration.ValidationLastName_Lamda(last);
                        Console.WriteLine(lastname);
                        break;
                    case 3:
                        Console.WriteLine("Enetr Email Id");
                        string email= Console.ReadLine();
                        string emailId=UserRegistration.ValidationEmail_Lamda(email);
                        Console.WriteLine(emailId);
                        break;
                   case 4:
                        Console.WriteLine("Enter Phone Number");
                        string phone= Console.ReadLine();
                        string number = UserRegistration.ValidationPhoneNUmner_Lamda(phone);
                        Console.WriteLine(number);
                        break;                     
                   case 5:
                        Console.WriteLine("Enter Password (Min-8char)");
                        string password = Console.ReadLine();
                        string pass = UserRegistration.ValidationPassword_Lamda(password);
                        Console.WriteLine(pass);                     
                        break;           
                    case 6:
                        flag = false;
                        break;
                }
            }           
        }
    }
}
