namespace _10_AccessModifiresEncupsulationNamespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Get get = new Get();
            get.Age = 20;
            Console.WriteLine("Age: " + get.Age);   
        }
    }
}
