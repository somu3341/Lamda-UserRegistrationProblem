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
            var last = name.Where(x => x.Equals(Regex.IsMatch(name, USER_NAME)));
            string filteredName = string.Concat(last);
            {
                if (filteredName.Equals(name))
                {
                    Console.WriteLine("Last Name is Valid");
                }
                else
                {
                    Console.WriteLine("InValid");
                }
            }
        }
    }
}
