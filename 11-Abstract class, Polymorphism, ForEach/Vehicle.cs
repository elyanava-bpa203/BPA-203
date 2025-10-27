using System;


namespace _11_Abstract_class__Polymorphism__ForEach
{
    public abstract class Vehicle 
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string PlateNumber { get; set; }
        public double FuelLevel { get; set; }

        public Vehicle(string brand, string model, int year, string plateNumber, double fuelLevel) 
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.PlateNumber = plateNumber;
            this.FuelLevel = 100;
        
        }

        public abstract string GetVehicleInfo();
        public virtual string ShowVehicleInfo() { $"Marka: {Brand}, Model: {Model}, İl: {Year}, Nömrə: {PlateNumber}"}

    
    }
}
