using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_StatiClassExtensionMethodsExceptions.Exceptions
{
    public class InvalidPasswordException: System.Exception
    {
        public InvalidPasswordException() : base("Password bos ola bilmez ve min 6 simvol olmalidir.") { }

        public InvalidPasswordException(string message) : base(message) { }
        
        
    }
}
