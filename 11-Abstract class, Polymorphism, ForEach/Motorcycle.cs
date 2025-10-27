using System;


namespace _11_Abstract_class__Polymorphism__ForEach
{
    class Motorcycle : Vehicle
    {
        public int EngineCapacity { get; set; }
        public bool HasSideCar { get; set; }
        public int MaxSpeed { get; set; }
        public string Type { get; set; }

        public Motorcycle (string brand, string model, int year, string plateNumber,int engineCapacity, bool hasSideCar, int maxSpeed, string type)
                          :base (brand,model,year,plateNumber)
        {
            this.EngineCapacity = engineCapacity;
            this.HasSideCar = hasSideCar;
            this.MaxSpeed = maxSpeed;
            this.Type = type;
        }

        public override string GetVehicleInfo()
        {
            return $"{Brand} {Model} ({Year}) - {Type} növü, {MaxSpeed} km/s, Sidecar: {HasSideCar}";

        }
        public void ShowMotorcycleInfo()
        {
            ShowBasicInfo();
            Console.WriteLine($"Müherrik: {EngineCapacity}cc, Növ: {Type}, Sidecar: {HasSideCar}, Max Speed: {MaxSpeed} km/s\n");
        }

        public double CalculateFuelCost(double distance)
        {
            return (distance / 100) * 4 * 1.50;
        }
    }
}
