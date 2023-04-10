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
        public const string ALLEMAIL = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})(\.[a-zA-Z]{2,5})?$";
        string[] mails = { "abc@yahoo.com", "abc-100@yahoo.com",
            "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net",
            " abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com",
            "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com",
            "abc()*@gmail.com", "abc..2002@gmail.com", "abc.@gmail.com", "bc@abc@gmail.com",
            "abc@%*.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };
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
        public void PasswordRule2(string pass2)
        {
            if (Regex.IsMatch(pass2, PASSWORD_RULE))
                Console.WriteLine("Password is Valid");
            else
                Console.WriteLine("Not Valid");
        }
        public void PasswordRule3(string pass3)
        {
            if (Regex.IsMatch(pass3, PASSWORD_RULE))
                Console.WriteLine("Password is Valid");
            else
                Console.WriteLine("Not Valid");
        }
        public void PasswordRule4(string pass4)
        {
            if (Regex.IsMatch(pass4, PASSWORD_RULE))
                Console.WriteLine("Password is Valid");
            else
                Console.WriteLine("Not Valid");
        }
        public void AllEmails()
        {
            for (int i = 0; i < mails.Length; i++)
            {
                if (Regex.IsMatch(mails[i], ALLEMAIL))
                    Console.WriteLine(mails[i] + " ----> Valid");
                else
                    Console.WriteLine(mails[i] + " -----> Invalid");
            }
        }
    }
}

