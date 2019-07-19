using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoCos
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver joe = new Driver();
            joe.FirstName = "Joe";
            joe.LastName = "Smith";
            joe.LicenseNumber = 10;
            joe.Gender = "Male";

            Driver mary = new Driver();
            mary.FirstName = "Mary";
            mary.LastName = "Donalds";
            mary.LicenseNumber = 31;
            mary.Gender = "Female";

            Console.WriteLine("{0} license number {1}, {2}.",
                joe.Gender, joe.LicenseNumber, joe.FullName()
                );
            Console.WriteLine();

            Console.WriteLine("{0} license number {1}, {2}.",
                mary.Gender, mary.LicenseNumber, mary.FullName()
                );
            Console.WriteLine();

            Book saga = new Book();
            saga.Title = " 'The Story' ";
            saga.Authors = new string[] { "Rit Righter", "Ink Blotter" };
            saga.Pages = 321;
            saga.SKU = "RH321TS1";
            saga.Publisher = "Random House";
            saga.Price = 99.99m;

            Console.WriteLine( "From {0}: {1} by {2}: {3} Pages: " +
                "Price ${4}: SKU {5}", saga.Publisher, saga.Title, 
                saga.Authors[1], saga.Pages, saga.Price, saga.SKU 
                );
            Console.WriteLine();


            Plane snowPlane = new Plane("white");
            snowPlane.Manufacturer = "AirSled";
            snowPlane.Model = "Tejas";
            snowPlane.Variant = "Lone Star";
            snowPlane.Capacity = 13;
            snowPlane.Engines = "Single";


        Console.WriteLine( " A {0}, {1} engine powered, {2} {3} {4} " +
            "with room for {5}", snowPlane.Color, snowPlane.Engines, 
            snowPlane.Manufacturer, snowPlane.Model, snowPlane.Variant, 
            snowPlane.Capacity );
            Console.WriteLine();

            Console.ReadKey();
        }
        
    }

    public class Driver
    {
        public String FirstName;
        public String LastName;
        public int LicenseNumber;
        public String Gender;


        public string FullName()
        {
            string space = " ";
            string FullName = String.Concat(FirstName, space, LastName);
            return FullName;

        }

    }

    public class Book
    {
        public String Title;
        public String[] Authors;
        public int Pages;
        public String SKU;
        public String Publisher;
        public Decimal Price;

    }

    public class Plane
    {
        public String Manufacturer;
        public String Model;
        public String Variant;
        public int Capacity;
        public String Engines;

        public string Color { get; set; }

        public Plane(string initialColor)
        {
            Color = initialColor;
        }

    }


    
}
