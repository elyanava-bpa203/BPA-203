namespace _11_Abstract_class__Polymorphism__ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mercedes" ,"E200" ,2023, 4 , 500L, true,220);
            Car car2 = new Car("BMW", "320i", 2022, 4, 480L, true, 235);
            Car car3 = new Car("Toyoto" , "Camry", 2021, 4, 524L, true, 210);

            Motorcycle moto1 = new Motorcycle("Yamaha R1", 2031, 998, "Sport", false, 299);
            Motorcycle moto2 = new Motorcycle("Harley-Davidson", 2022, 1868, "Cruicer", true, 180);

            Truck truck1 = new Truck("MAN", "TGX", 2020,  18, 3, 12, 120);
            Truck truck2 = new Truck("Volvo", "FH16", 2021,  25, 4, 18, 110);


            Vehicle[] vehicles = { car1, car2, car3, moto1, moto2, truck1, truck2 };
            Console.WriteLine("AVTOMOBILLER");
            foreach (var vehicle in vehicles) 
            {
                if (vehicle is Car car) 
                {
                    car.ShowCarInfo();
                    Console.WriteLine($"500 km ucun yanacaq xerci: {car.CalculateFuelCost(500): } AZN\n");
                
                }
            
            }


            Console.WriteLine("MOTOSIKLERLER");
            foreach (var vehicle in vehicles) 
            {

                if (vehicle is Motorcycle) 
                {
                    moto.ShowMotorcycleInfo();
                    Console.WriteLine($"300 km ucun yanacaq xerci: {moto.CalculateFuelCost(300): } AZN\n");
                
                }
            
            }



            Console.WriteLine("YUK MASINLARI");
            foreach (var vehicle in Truck) 
            {
                if (vehicle is Truck) 
                {
                    truck.ShowTruckInfo();
                    Console.WriteLine($"800 km ucun yanacaq xerci: {truck.CalculateFuelCost(800): } AZN\n");
                
                }
            
            }
             

           

        }
    }
}
