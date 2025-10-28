
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrderSystem
{
    internal class DrinkOrder
    {
        public int OrderNumber { get; set; }
        public  string CustomerName { get; set; }
        public DrinkType Drink { get; set; }
        public DrinkSize Size { get; set; }
        public OrderStatus Status { get; set; }
        public decimal Price { get; set; }
        public DrinkOrder(int orderNumber,string  customerName, DrinkType drink, DrinkSize size )
        {
            OrderNumber = orderNumber;
            CustomerName = customerName;
            Drink = drink;
            Size = size;
            
            Status=OrderStatus.New;
            
        }
        public enum OrderStatus
        {
            New,
            Processing,
            Completed

        }
        public void CalculatePrice()
        {
            
        }
        public decimal CalculatePrice(string drink, string size)
        {
            decimal price = 0;

            switch (drink.ToLower())
            {
                case "coffee":
                    switch (size.ToLower())
                    {
                        case "small": price = 3m; break;
                        case "medium": price = 4m; break;
                        case "large": price = 5m; break;
                    }
                    break;

                case "tea":
                    switch (size.ToLower())
                    {
                        case "small": price = 2m; break;
                        case "medium": price = 3m; break;
                        case "large": price = 4m; break;
                    }
                    break;

                case "juice":
                    switch (size.ToLower())
                    {
                        case "small": price = 4m; break;
                        case "medium": price = 5m; break;
                        case "large": price = 6m; break;
                    }
                    break;

                case "water":
                    switch (size.ToLower())
                    {
                        case "small": price = 1m; break;
                        case "medium": price = 1.5m; break;
                        case "large": price = 2m; break;
                    }
                    break;

                default:
                    Console.WriteLine("Belə içki yoxdur!");
                    break;
            }

            return price;
        }
        public void UpdateStatus(OrderStatus newStatus)
        {
            Status = newStatus;
            Console.WriteLine("Sifariş :{OrderNumber} ,statusu: {newStatus}");
        }
        public void DisplayOrder()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Sifariş nömrəsi: {OrderNumber}");
            Console.WriteLine($"Müştəri: {CustomerName}");
            Console.WriteLine($"İçki: {Drink}");
            Console.WriteLine($"Ölçü: {Size}");
            Console.WriteLine($"Qiymət: {Price} AZN");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine("----------------------------\n");
        }

       
    }
}
