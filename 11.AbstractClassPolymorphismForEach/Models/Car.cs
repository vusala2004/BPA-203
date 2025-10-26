
namespace _11.AbstractClassPolymorphismForEach.Models
{
    public class Car : Vehicle
    {
        public int DoorsCount { get; set; }
        public int TrunkCapacity { get; set; }
        public bool IsAutomatic { get; set; }
        public  int MaxSpeed { get; set; }

        public Car(string brand, string model, int year, string platenumber,
           int doorscount, int trunkcapacity, bool isautomatic, int maxspeed)
    : base(brand, model, year, platenumber)
        {
            this.DoorsCount = doorscount;
            this.TrunkCapacity = trunkcapacity;
            this.IsAutomatic = isautomatic;
            this.MaxSpeed = maxspeed;
        }
        public void ShowCarInfo()
        {
            Console.WriteLine($"DoorsCount: {DoorsCount},TrunkCapacity: {TrunkCapacity},IsAutpmatic:{IsAutomatic},MaxSpeed:{MaxSpeed}");
        }
        
            public double CalculateFuelCost(double distance)
            {
            double cost = (distance / 100) * 8 * 1.50;
            return cost;
             }

        

        public override string GetVehicleInfo()
        {
            return $"Brand: {Brand}, Model: {Model}, Year: {Year}, PlateNumber: {PlateNumber}, Doors: {DoorsCount}, TrunkCapacity: {TrunkCapacity}, IsAutomatic: {IsAutomatic}, MaxSpeed: {MaxSpeed}";
        }
        }
    }


