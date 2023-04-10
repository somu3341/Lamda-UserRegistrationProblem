using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lamda_UserRegistrationProblem
{
    public class UserRegistration
    {
        public const string USER_NAME = "^[A-Z]{1}[a-z]{2,}";
        public const string EMAIL = "^[A-Za-z]{3,}[.]{0,}[a-zA-Z]{3,}[@]{1}[a-z]{2,}[.]{1}[a-z]{2,}[.]{1}[a-z]{2,}$";
        public const string PHONE_NUMBER = "[0-9]{2,}\\s[6-9]{1}[0-9]{9}$";
        public const string PASSWORD_RULE = "^[A-Za-z]{4,}[!+@+#+$+%+^+&+*+(+)+_+++~+.+,]{1,}[0-9]{3,}$";       
        public static string ValidationFirstName_Lamda(string input) => Regex.IsMatch(input, USER_NAME) ? "Name is Valid" : "Name is Invalid";
        public static string ValidationLastName_Lamda(string input) => Regex.IsMatch(input, USER_NAME) ? "Name is Valid" : "Name is Invalid";
        public static string ValidationPhoneNUmner_Lamda(string input) => Regex.IsMatch(input, PHONE_NUMBER) ? "Name is Valid" : "Name is Invalid";
        public static string ValidationEmail_Lamda(string input) => Regex.IsMatch(input, EMAIL) ? "Name is Valid" : "Name is Invalid";
        public static string ValidationPassword_Lamda(string input) => Regex.IsMatch(input, PASSWORD_RULE) ? "Name is Valid" : "Name is Invalid";

    }
}

