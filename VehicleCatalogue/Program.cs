/*
Car/Subaru/Impreza/152
Car/Peugeot/307/109
end
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace VehicleCatalogue
{
    internal class Program
    {

        class Catalog
        {
            public string Type { get; set; }
            public string Brand { get; set; }
            public string Model { get; set; }
            public double HorsePower { get; set; }
            public double Weight { get; set; }
        }

        static void Main(string[] args)
        {
            List<Catalog> list = new List<Catalog>();
            int countCars = 0;
            int countTruck = 0;
            while (true)
            {
                string[] input = Console.ReadLine().Split('/');
                if (input[0] == "end")
                {
                    var ordered=list.OrderBy(x => x.Brand).ToList();
                   if(countCars>0) Console.WriteLine("Cars:");
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (ordered[i].Type == "Car")
                        {
                            Console.WriteLine($"{ordered[i].Brand}: {ordered[i].Model} - {ordered[i].HorsePower}hp");
                        }
                    }
                   if(countTruck>0) Console.WriteLine("Trucks:");
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (ordered[i].Type == "Truck")
                        {
                            Console.WriteLine($"{ordered[i].Brand}: {ordered[i].Model} - {ordered[i].Weight}kg");
                        }
                    }
                    break;
                }
                if (input[0] == "Car")
                {
                    Catalog car = new Catalog();
                    car.Type = "Car";
                    car.Brand = input[1];
                    car.Model = input[2];
                    car.HorsePower = double.Parse(input[3]);
                    list.Add(car);
                    countCars++;
                }
                else
                {
                    Catalog truck = new Catalog();
                    truck.Type = "Truck";
                    truck.Brand = input[1];
                    truck.Model = input[2];
                    truck.Weight = double.Parse(input[3]);
                    list.Add(truck);
                    countTruck++;
                }
            }

        }
    }
}

