using System;
using System.Collections.Generic;
using System.Data;
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
        public const string PASSWORD_RULE = "^[A-Za-z]{4,}[!+@+#+$+%+^+&+*+(+)+_+++~+.+,]{1,}[0-9]{3,}$";
        public const string ALLEMAIL = "^[a-z]{1,}([-.+]{1}){0,1}([0-9]{1,}){0,1}[@]{1}[a-z0-9]{1,}[.][a-zA-Z]{2,3}([.]{1}[a-z]{2,3}){0,1}$";
        string[] mail = { "abc@yahoo.com", "abc-100@yahoo.com",
            "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net",
            " abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com",
            "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com",
            "abc()*@gmail.com", "abc..2002@gmail.com", "abc.@gmail.com", "bc@abc@gmail.com",
            "abc@%*.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };
        public void UserFirst(string name)
        {
            var first = name.Where(x => Regex.IsMatch(name, USER_NAME));
            string filteredName = string.Concat(first);
            {
                if (filteredName.Equals(name))
                {
                    Console.WriteLine("First Name is Valid");
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
                    Console.WriteLine("Last Name is Valid");
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
                    Console.WriteLine("Email is Valid");
                }
                else
                {
                    Console.WriteLine("InValid");
                }
            }
        }
        public void PhoneNumber(string number)
        {
            var num = number.Where(x => Regex.IsMatch(number, PHONE_NUMBER));
            string filteredName = string.Concat(num);
            {
                if (filteredName.Equals(number))
                {
                    Console.WriteLine("Phone Number is Valid");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
        }
        public void PasswordRule1(string pass1)
        {
            var rule1 = pass1.Where(x => Regex.IsMatch(pass1, PASSWORD_RULE));
            string filteredName = string.Concat(rule1);
            {
                if (filteredName.Equals(pass1))
                {
                    Console.WriteLine("Password Rule-1 is Valid");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
        }
        public void PasswordRule2(string pass2)
        {
            var rule2 = pass2.Where(x => Regex.IsMatch(pass2, PASSWORD_RULE));
            string filteredName = string.Concat(rule2);
            {
                if (filteredName.Equals(pass2))
                {
                    Console.WriteLine("Password Rule-2 is Valid");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
        }
        public void PasswordRule3(string pass3)
        {
            var rule3 = pass3.Where(x => Regex.IsMatch(pass3, PASSWORD_RULE));
            string filteredName = string.Concat(rule3);
            {
                if (filteredName.Equals(pass3))
                {
                    Console.WriteLine("Password Rule-3 is Valid");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
        }
        public void PasswordRule4(string pass4)
        {
            var rule4 = pass4.Where(x => x.Equals(Regex.IsMatch(pass4, PASSWORD_RULE)));
            string filteredName = string.Concat(rule4);
            {
                if (filteredName.Equals(pass4))
                {
                    Console.WriteLine("Password Rule-4 is Valid");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
        }
        public void AllEmail()
        {
            for (int i=0; i<mail.Length; i++)
            {
                var all = mail[i].Where(x => Regex.IsMatch(mail[i], ALLEMAIL));
                string filteredName = string.Concat(all);
                {
                    if (filteredName.Equals(mail[i]))
                    {
                        Console.WriteLine(mail[i] + "-----> Is Valid");
                    }
                    else
                    {
                        Console.WriteLine(mail[i]+"-------> Not Valid");
                    }
                }
            }
        }
    }
}

