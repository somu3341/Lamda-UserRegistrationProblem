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
        public void UserFirst(string name)
        {
            var first = name.Where(x => Regex.IsMatch(name, USER_NAME));
            string filteredName = string.Concat(first);
            {
                if (filteredName.Equals(name))
                {
                    Console.WriteLine("Valid");
                }
                else
                {
                    Console.WriteLine("InValid");
                }
            }                   
        }
        public void UserLast(string name)
        {
            var last = name.Where(x => Regex.IsMatch(name, USER_NAME));
            string filteredName = string.Concat(last);
            {
                if (filteredName.Equals(name))
                {
                    Console.WriteLine("Valid");
                }
                else
                {
                    Console.WriteLine("InValid");
                }
            }
        }
        public void Email(string email)
        {
            var mail = email.Where(x => Regex.IsMatch(email, EMAIL));
            string filteredName = string.Concat(mail);
            {
                if (filteredName.Equals(email))
                {
                    Console.WriteLine("Email ID is Valid");
                }
                else
                {
                    Console.WriteLine("InValid");
                }
            }
        }
    }
}
