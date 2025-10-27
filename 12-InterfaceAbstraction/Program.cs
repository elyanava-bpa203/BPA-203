namespace _12_InterfaceAbstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci ededi daxil edin:");
            double num1= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Əməliyyatı daxil edin (+, -, *, /): ");
            string operation= Console.ReadLine();

            Console.WriteLine("Ikinci ededi daxil edin:");
            double num2= Convert.ToDouble(Console.ReadLine());

            Calculation calculation = new Calculation();
            double result = calculation.Calculate(num1, num2, operation);
            Console.WriteLine($"Nəticə: {result}");
        }
    }
}
