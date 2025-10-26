

using System.Security.Cryptography.X509Certificates;

namespace _11.AbstractClassPolymorphismForEach.Models
{
    public class Truck : Vehicle
    {
        public double CargoCapacity { get; set; }
        public int AxleCount { get; set; }
        public double CurrentLoad { get; set; }
        public int MaxSpeed { get; set; }
        public Truck(string brand, string model, int year, string platenumber, double cargocapacity, int axlecount, double currentload, int maxspeed)
            : base(brand, model, year, platenumber)

        {
            this.CargoCapacity = cargocapacity;
            this.AxleCount = axlecount;
            this.CurrentLoad = currentload;
            this.MaxSpeed = maxspeed;

        }
        public double  CalculateFuelCost(double distance2)
        {
           
          
            double cost = (distance2 / 100) * (25 + CurrentLoad *2) * 1.80;

            return cost;
        }

        public void ShowTruckInfo()
        {
            Console.WriteLine($"CargoCapacity: {CargoCapacity}, AxleCount: {AxleCount}, CurrentLoad: {CurrentLoad}, MaxSpeed: {MaxSpeed}");
        }
        public void LoadCargo(double weight)
        {
            if (CurrentLoad + weight > CargoCapacity)// currentload+weight -umumi yuk
            {
                Console.WriteLine($" {weight}Yük elave edile bilmedi!");
            }
            else
            {
                CurrentLoad += weight;
                Console.WriteLine($"{weight}ton yük elave olundu");
            }




        }

        public override string GetVehicleInfo()
        {
            return $"Brand: {Brand}, Model: {Model}, Year: {Year}, PlateNumber: {PlateNumber}, CargoCapacity: {CargoCapacity}, AxleCount: {AxleCount}, CurrentLoad: {CurrentLoad}, MaxSpeed: {MaxSpeed}";
        }
    }
    }

