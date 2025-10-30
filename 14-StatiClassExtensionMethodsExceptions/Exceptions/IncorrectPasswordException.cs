using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_StatiClassExtensionMethodsExceptions.Exceptions
{
    public class IncorrectPasswordException : SystemException
    {
        private static object attemptsLeft;

        public int AttemptsLeft { get; set; }
        public IncorrectPasswordException(int attempsLeft): base($"Password yalnisdir.Qalan cehdlerin sayi: {attemptsLeft}") 
        {
            AttemptsLeft = attempsLeft;
        
        }
    }
}
