using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_StatiClassExtensionMethodsExceptions.Exceptions
{
    public class AccountLockedException: System.Exception
    {
        public AccountLockedException() : base("Hesabiniz artiq bloklanib.") { }
       
    }
}
