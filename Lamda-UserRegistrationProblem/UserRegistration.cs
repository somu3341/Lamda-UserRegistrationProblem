using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lamda_UserRegistrationProblem
{
    public class UserRegistration
    {
        public const string USER_NAME = "^[A-Z]{1}[a-z]{2,}";
        public const string EMAIL = "^[A-Za-z]{3,}[.]{0,}[a-zA-Z]{3,}[@]{1}[a-z]{2,}[.]{1}[a-z]{2,}[.]{1}[a-z]{2,}$";
        public const string PHONE_NUMBER = "[0-9]{2,}\\s[6-9]{1}[0-9]{9}$";
        public const string PASSWORD_RULE = "^[A-Za-z0-9]{8,}";
        public void UserFirst(string name)
        {
            if (Regex.IsMatch(name, USER_NAME))
                Console.WriteLine("First Name Valid");
            else
                Console.WriteLine("Not Valid");
        }
        public void UserLast(string lastname)
        {
            if (Regex.IsMatch(lastname, USER_NAME))
                Console.WriteLine("Last Name Valid");
            else
                Console.WriteLine("Not Valid");
        }
        public void Email(string email)
        {
            if (Regex.IsMatch(email, EMAIL))
                Console.WriteLine("Email is Valid");
            else
                Console.WriteLine("Not Valid");
        }
        public void PhoneNumber(string number)
        {
            if (Regex.IsMatch(number, PHONE_NUMBER))
                Console.WriteLine("Mobile Number is Valid");
            else
                Console.WriteLine("Not Valid");
        }
        public void PasswordRule1(string pass1)
        {

            if (Regex.IsMatch(pass1, PASSWORD_RULE))
                Console.WriteLine("Password is Valid");
            else
                Console.WriteLine("Not Valid");
        }
    }
}
