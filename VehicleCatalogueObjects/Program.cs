/*
truck Man red 200
truck Mercedes blue 300
car Ford green 120
car Ferrari red 550
car Lamborghini orange 570
End
Ferrari
Ford
Man
Close the Catalogue
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogueObjects
{
    class Vehicles
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
        public Vehicles(string type, string model, string color, int horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }
        public override string ToString()
        {
            if (Type == "car")
            {
                Type = "Car";
            }
            else
            {
                Type = "Truck";
            }
            return $"Type: {Type}\n" +
                $"Model: {Model}\n" +
                $"Color: {Color}\n" +
                $"Horsepower: {HorsePower}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicles> list = new List<Vehicles>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] values = input.Split(" ");
                Vehicles vehicles = new Vehicles(values[0], values[1], values[2], int.Parse(values[3]));
                list.Add(vehicles);
            }
            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Model == input)
                    {
                        Console.WriteLine(list[i].ToString());
                    }
                }
            }
            var cars = list.Where(x => x.Type == "Car" || x.Type == "car").ToList();
            var trucks = list.Where(x => x.Type == "Truck" || x.Type == "truck").ToList();
            double avarageC = 0;
            double avarageT = 0;
            foreach (var car in cars)
            {
                avarageC += car.HorsePower;
            }
            foreach (var truck in trucks)
            {
                avarageT += truck.HorsePower;
            }
            double avarageCar = avarageC / cars.Count();
            double avarageTruck = avarageT / trucks.Count();
            if (avarageCar > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {avarageCar:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }
            if (avarageTruck > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {avarageTruck:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }

        }
    }
}
