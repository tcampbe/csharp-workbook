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
        {   //                                      First Car lot with 3 cars
            CarLot Troys = new CarLot();
            Troys.Name = "TMoney's Slammin' Rides";
            Troys.Autos = new List<Vehicle>();

            Truck troys = new Truck();
            Troys.AddCar(troys);
            troys.License = "IMNO UG";
            troys.Make = "Chervoling";
            troys.Model = "C550";
            troys.Price = "999.99";
            troys.BedSize = "Scary Long";

            Car sedan = new Car();
            Troys.AddCar(sedan);
            sedan.License = "UR P00R";
            sedan.Make = "Cadolact";
            sedan.Model = "La Desparado";
            sedan.Price = "55k";
            sedan.Doors = "4";
            sedan.Type = "Sedan";

            Car muscle = new Car();
            Troys.AddCar(muscle);
            muscle.License = "FSTR BSTR";
            muscle.Make = "Evade";
            muscle.Model = "Attacker";
            muscle.Price = "43945.27";
            muscle.Doors = "2";
            muscle.Type = "Sportscar";

            Troys.PrintLot(); 

            //                                      Second Car lot with 4 cars
            CarLot Mama = new CarLot();
            Mama.Name = "Mrs. Friskey's Shagin' Wagons";
            Mama.Autos = new List<Vehicle>();

            Truck mamas = new Truck();
            Mama.AddCar(mamas);
            mamas.License = "LVR TRKR";
            mamas.Make = "Frog";
            mamas.Model = "River Raider";
            mamas.Price = "1999.99";
            mamas.BedSize = "Double";

            Car alamo = new Car();
            Mama.AddCar(alamo);
            alamo.License = "BIG FMLY";
            alamo.Make = "VMB";
            alamo.Model = "2210";
            alamo.Price = "15k";
            alamo.Doors = "4";
            alamo.Type = "Station Wagon";

            Car creep = new Car();
            Mama.AddCar(creep);
            creep.License = "N0 1 RKN";
            creep.Make = "Yuido";
            creep.Model = "Sleeper 8";
            creep.Price = "28951.27";
            creep.Doors = "5";
            creep.Type = "Van";

            Car prom = new Car();
            Mama.AddCar(prom);
            prom.License = "1 NITE 4U";
            prom.Make = "Ocelot";
            prom.Model = "Party Hauler";
            prom.Price = "534.28/Month";
            prom.Doors = "8";
            prom.Type = "Limo";

            Mama.PrintLot();

            Console.WriteLine();
            Console.ReadKey();
        }
    }

    public class CarLot
    {
        public string Name { get; set; }

        public List<Vehicle> Autos { get; set; }

        public void AddCar(Vehicle vehicle)
        {
            Autos.Add(vehicle);
        }

        public void PrintLot()
        { // prints the lot name number of cars and details from truck or car class
            Console.WriteLine(Name);
            Console.WriteLine(Autos.Count + " Vehicles on the Lot!");
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
        // method with no body, because it can't be instantiated
    }

    class Truck : Vehicle
    {
        public string BedSize { get; set; }

        public override void PrintDetails()
        { // overide abtract method specific to truck, prints relevant fields
            Console.WriteLine();
            Console.WriteLine("{0} {1}, Truck with {2} bed; Plate #: {3};" +
                " ${4}", Make, Model, BedSize, License, Price );
            Console.WriteLine();
        }

    }

    class Car : Vehicle
    {
        public string Type { get; set; }
        public string Doors { get; set; }

        public override void PrintDetails()
        { // overide abtract method specific to car, prints relevant fields
            Console.WriteLine();
            Console.WriteLine("{0} {1}, {2} with {3} doors; Plate #: {4};" +
                " ${5}", Make, Model, Type, Doors, License, Price);
            Console.WriteLine();
        }

    }
}
