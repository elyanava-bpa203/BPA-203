using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_AccessModifiresEncupsulationNamespace
{
    internal class Get
    {

        private int age;
        public int  Age
        {
            get 
            {
                return age;
            
            }
            set 
            {
                if (value < 18)
                {
                    Console.WriteLine("You are not an adult yet.");
                    return;
                
                }
                age = value;
            
            }
        
        }
    }
}
