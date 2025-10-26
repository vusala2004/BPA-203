

namespace _11.AbstractClassPolymorphismForEach.Models
{
     public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string PlateNumber { get; set; }
        public double FuelLevel { get; set; }


        protected Vehicle(string brand, string model, int year, string plateNumber)
        {
          this.Brand = brand;
          this.Model = model;
          this.Year = year;
          this.PlateNumber = plateNumber;
           this.FuelLevel = 100;

        }
        public abstract string GetVehicleInfo();

        public virtual void ShowBasicInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}, Plate: {PlateNumber}, Fuel: {FuelLevel}%");
        }
        









    }
    
}

