using System;


namespace _12_InterfaceAbstraction
{
    class Calculation : ICalculation
    {
        public double Calculate(double num1, double num2, string operation) 
        {
            double result = 0;
            switch (operation) 
            {
                case "+": result = num1 + num2; break;
                case "-": result = num1 - num2; break;
                case "*": result = num1 * num2; break;
                case "/":
                    if (num2 != 0) 
                        result = num2 / num1;
                    else
                        Console.WriteLine("0-a bölmek olmaz!");
                    break;
                default:
                    Console.WriteLine("Yanlıs emeliyyat!");
                    break;
            }

            return result;



        }
        
        
    }
}
