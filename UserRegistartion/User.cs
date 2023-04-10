using System.Text.RegularExpressions;

namespace UserRegistartion
{
    public class User
    {
        string message;
        public User (string message)
        {
            this.message = message;
        }
        public static string USER_NAME = "^[A-Z]{1}[a-z]{2,}";
        public static string EMAIL = "^[A-Za-z]{3,}[.]{0,}[a-zA-Z]{3,}[@]{1}[a-z]{2,}[.]{1}[a-z]{2,}[.]{1}[a-z]{2,}$";
        public static string MOBILE = "^[0-9]{2}\\s[6-9]{1}[0-9]{9}$";
        public static string PASSWORD = "^[A-Za-z]{4,}[!+@+#+$+%+^+&+*+(+)+_+++~+.+,]{1,}[0-9]{3,}$";
        public string UserFirst()
        {
            try
            {
                if (Regex.IsMatch(message, USER_NAME))
                    return "Valid";
                return "InValid";
            }
            catch(UserException)
            {
                throw new UserException(UserException.ExceptionType.INVALID, "Message is InValid");
            }            
        }
        public string UserLast()
        {
            try
            {
                if (Regex.IsMatch(message, USER_NAME))
                    return "Valid";
                return "InValid";
            }
            catch (UserException)
            {
                throw new UserException(UserException.ExceptionType.INVALID, "Message is InValid");
            }
        }
        public string Email()
        {
            try
            {
                if (Regex.IsMatch(message, EMAIL))
                    return "Valid";
                return "InValid";
            }
            catch (UserException)
            {
                throw new UserException(UserException.ExceptionType.INVALID, "Message is InValid");
            }
        }
        public string Mobile()
        {
            try
            {
                if (Regex.IsMatch(message, MOBILE))
                    return "Valid";
                return "InValid";
            }
            catch (UserException)
            {
                throw new UserException(UserException.ExceptionType.INVALID, "Message is InValid");
            }
        }
        public string Password()
        {
            try
            {
                if (Regex.IsMatch(message, PASSWORD))
                    return "Valid";
                return "InValid";
            }
            catch (UserException)
            {
                throw new UserException(UserException.ExceptionType.INVALID, "Message is InValid");
            }
        }       
    }
}