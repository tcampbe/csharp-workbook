using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot Troys = new CarLot();
            Troys.Name = "TMoney's Slammin' Rides";
            Troys.Autos = new List<Vehicle>();
            Truck troys = new Truck();
            Troys.Autos.Add(troys);
            troys.License = "IMNO UG";
            troys.Make = "Chervoling";
            troys.Model = "C550";
            troys.Price = "999.99";
            troys.BedSize = "Scary Long";
            Car sedan = new Car();
            Troys.Autos.Add(sedan);
            sedan.License = "UR P00R";
            sedan.Make = "Cadolact";
            sedan.Model = "La Desparado";
            sedan.Price = "55k";
            sedan.Doors = "4";
            sedan.Type = "Sedan";


            Troys.PrintLot();





            Console.WriteLine();
            Console.ReadKey();


            

        }
    }

    public class CarLot
    {
        public string Name { get; set; }

        public List<Vehicle> Autos { get; set; }



        public void PrintLot()
        {
            Console.WriteLine(Name);
            foreach (Vehicle auto in Autos)
            {
                auto.PrintDetails();
            }
        }
    }


    public abstract class Vehicle
    {
        public string License { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Price { get; set; }

        public abstract void PrintDetails();

    }

    class Truck : Vehicle
    {
        public string BedSize { get; set; }

        public override void PrintDetails()
        {
            Console.WriteLine();
            Console.WriteLine("{0} {1} Truck with {2} bed; Plate#: {3};" +
                " ${4}", Make, Model, BedSize, License, Price );
            Console.WriteLine();
        }

    }

    class Car : Vehicle
    {
        public string Type { get; set; }
        public string Doors { get; set; }

        public override void PrintDetails()
        {
            Console.WriteLine();
            Console.WriteLine("{0} {1}, {2} door {3}; Plate#: {4};" +
                " ${5}", Make, Model, Doors, Type, License, Price);
            Console.WriteLine();
        }


    }
}
