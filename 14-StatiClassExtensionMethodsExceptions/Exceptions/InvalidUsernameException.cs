using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_StatiClassExtensionMethodsExceptions.Exceptions
{
    public class InvalidUsernameException : System.Exception 
    {
        public InvalidUsernameException() : base("Username bos ola bilmez ve min 3 element olmalidir.") { }
        public InvalidUsernameException(string message) : base(message) { }
      
    }
}
