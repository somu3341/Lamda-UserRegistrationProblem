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
    }
}
