﻿using System;
namespace Lamda_UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose Option to Perform\n1.First Name\n2.Exit");
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
                        flag = false;
                        break;
                }
            }
           
            
        }
    }
}
