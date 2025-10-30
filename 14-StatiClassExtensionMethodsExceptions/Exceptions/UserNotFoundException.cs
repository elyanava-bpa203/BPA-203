using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_StatiClassExtensionMethodsExceptions.Exceptions
{
    public class UserNotFoundException : System.Exception
    {
        public UserNotFoundException() : base("Bele bir istifadeci yoxdur") { }
        public UserNotFoundException(string username) : base($"Istifadeci {username} tapilmadi.") { }
        
    }
}
