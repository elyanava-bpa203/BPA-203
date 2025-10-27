using System;


namespace _11_Abstract_class__Polymorphism__ForEach
{
    class Car : Vehicle
    {
        public int DoorsCount { get; set; }
        public int TrunkCapacity { get; set; }
        public bool IsAutomatic { get; set; }
        public int MaxSpeed { get; set; }

        public Car(string brand, string model, int year, string plateNumber, int doorsCount, int trunkCapacity, bool isAutomatic, int maxSpeed)
                     : base(brand,model,year,plateNumber)
        {
            this.DoorsCount = doorsCount;
            this.TrunkCapacity = trunkCapacity;
            this.IsAutomatic = isAutomatic;
            this.MaxSpeed = maxSpeed;
        
        }

        public override string GetVehicleInfo()
        {
            return $"{Brand} {Model} ({Year}) - {MaxSpeed} km/s, Qapı: {DoorsCount}, Baqaj: {TrunkCapacity}L";
        }

        public void ShowCarInfo()
        {
            ShowBasicInfo();
            Console.WriteLine($"Qapı sayı: {DoorsCount}, Baqaj: {TrunkCapacity}L, Avtomat: {IsAutomatic}, Max Speed: {MaxSpeed} km/s\n");
        }

        public double CalculateFuelCost(double distance)
        {
            double cost = (distance / 100) * 8 * 1.50;
            return cost;
        }





    }
}
