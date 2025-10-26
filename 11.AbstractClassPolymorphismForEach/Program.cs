using _11.AbstractClassPolymorphismForEach.Models;
using System.Text.Json;

namespace _11.AbstractClassPolymorphismForEach
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[]
            {
                new Car("Mercedes", "E200", 2023, "90-AA-111", 4, 500, true, 210),
                new Car("BMW", "320i", 2022, "90-YY-112", 4, 480, true, 219),
                new Car("Toyota", "Camry", 2021, "90-BB-113",  4, 524, true, 210),
            };

            Motorcycle[] motorcycles = new Motorcycle[] 
            {
            new Motorcycle  ("Yamaha", "R1", 2023, "99-YY-001",  998, false, 299, "Sport"),
            new Motorcycle("Harley", "Davidson", 2022, "99-VV-098",  1868, true, 180, "Cruiser"), 
            };


            Truck[] trucks = new Truck[]
            {
             new Truck  ("MAN", "TGX", 2020, "90-VK-120", 18, 3, 12, 120),
            new Truck("Volvo", " FH16", 2021, "99-AA-321",  25, 4, 18, 110),
            };
            Vehicle[] vehicles =new Vehicle [ cars.Length+motorcycles.Length+ trucks.Length];
            
                int index = 0;
                
            

            double distance = 500;
            foreach (var car in cars)
            {
                vehicles[index++] = car;
                car.ShowCarInfo();
                Console.WriteLine($"500 km üçün yanacaq xerci");
                car.CalculateFuelCost(distance);
            }
            double distance1 = 300;
            foreach (var motorcyle in motorcycles)
            {
                vehicles[index++] = motorcyle;
                motorcyle.ShowMotorcycleInfo();
                Console.WriteLine($"300 km üçün yanacaq xerci");
                  motorcyle.CalculateFuelCost( distance1);
            }
            double distance2 = 800;
            foreach (var truck in trucks)
            {
                vehicles[index++] = truck;
                truck.ShowTruckInfo();
                Console.WriteLine($"800 km üçün yanacaq xerci:");
                 truck.CalculateFuelCost(distance2);
            }
            trucks[0].LoadCargo(5); // 5 ton əlavə
            Console.WriteLine($"Yeni yük ile Truck1 melumatları:");
            trucks[0].ShowTruckInfo();
            Console.WriteLine($"Yeni yanacaq xərci (800 km):");
            Console.WriteLine("umumi neqliyyat sayi:"+vehicles.Length);


            
    }
}
        
        
    


}
