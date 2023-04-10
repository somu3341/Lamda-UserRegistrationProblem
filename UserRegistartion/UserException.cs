using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistartion
{
    public class UserException : Exception
    {
        public enum ExceptionType
        {
            INVALID
        }
        private ExceptionType exceptionType;

        public UserException(ExceptionType type, string message) : base(message)
        {
            this.exceptionType = type;
        }
    }
}

