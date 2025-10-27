using System;
using System.Reflection;


namespace _11_Abstract_class__Polymorphism__ForEach
{
    class Truck : Vehicle
    {
        public double CargoCapacity { get; set; }
        public int AxleCount { get; set; }
        public double CurrentLoad { get; set; }
        public int MaxSpeed { get; set; }

        public Truck(string brand, string model, int year, string plateNumber, double cargoCapacity, int axleCount, double currentLoad, int maxSpeed)
                    : base(brand, model, year, plateNumber) 
        {
            this.CargoCapacity = cargoCapacity;
            this.AxleCount = axleCount;
            this.CurrentLoad = currentLoad;
            this.MaxSpeed = maxSpeed;
        
        }
        public override string GetVehicleInfo()
        {
            return $"{Brand} {Model} ({Year}) - {CurrentLoad}/{CargoCapacity} ton, {AxleCount} ox";
        }

        public void ShowTruckInfo()
        {
            ShowBasicInfo();
            Console.WriteLine($"Yük: {CurrentLoad}/{CargoCapacity} ton, Ox: {AxleCount}, Max Speed: {MaxSpeed} km/s\n");
        }

        public void LoadCargo(double weight)
        {
            if (CurrentLoad + weight <= CargoCapacity)
            {
                CurrentLoad += weight;
                Console.WriteLine($"{weight} ton əlavə edildi. Yeni yük: {CurrentLoad} ton\n");
            }
            else
            {
                Console.WriteLine(" Yük tutumu aşılır!");
            }
        }

        public double CalculateFuelCost(double distance)
        {
            double cost = (distance / 100) * (25 + CurrentLoad * 2) * 1.80;
            return cost;
        }
    }
}
