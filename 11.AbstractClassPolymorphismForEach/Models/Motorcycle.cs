

namespace _11.AbstractClassPolymorphismForEach.Models
{
    public class Motorcycle : Vehicle
    {
        public int EngineCapacity { get; set; }
        public bool HasSidecar { get; set; }
        public int MaxSpeed { get; set; }
        public string Type { get; set; }
        public Motorcycle( string brand, string model, int year, string platenumber, int enginecapacity, bool hassidecar, int maxspeed, string type)
            : base(brand, model, year, platenumber)
        {
            this.EngineCapacity = enginecapacity;
            this.HasSidecar = hassidecar;
            this.MaxSpeed = maxspeed;
            this.Type = type;
        }
        public double  CalculateFuelCost(double distance1)
        {
            double cost = (distance1 / 100) * 4 * 1.50;
            return cost;

        }
        public void ShowMotorcycleInfo()
        {
            Console.WriteLine($"EngineCapacity: {EngineCapacity}, HasSidecar: {HasSidecar}, MaxSpeed: {MaxSpeed}, Type: {Type}");
        }

       
        
          public override string GetVehicleInfo()
        {
            return $"Brand: {Brand}, Model: {Model}, Year: {Year}, Plate: {PlateNumber}, Fuel: {FuelLevel}%";
        }

    }
}

