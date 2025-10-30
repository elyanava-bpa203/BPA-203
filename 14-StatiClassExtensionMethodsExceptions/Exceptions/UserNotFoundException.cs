using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_StatiClassExtensionMethodsExceptions.Exceptions
{
    public class UserNotFoundException : System.Exception
    {

        private static object username;
        public UserNotFoundException() : base("Bele bir istifadeci yoxdur") { }
        public UserNotFoundException(string message) : base($"Istifadeci {username} tapilmadi.") { }
        
    }
}
