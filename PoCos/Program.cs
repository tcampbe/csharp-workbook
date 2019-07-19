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

            Console.WriteLine("{0} license number {1}, {2}.",
                mary.Gender, mary.LicenseNumber, mary.FullName()
                );

            Book saga = new Book();
            saga.Title = "The Story";
            saga.Authors = new string[] { "a", "b" };
            saga.Pages = 321;
            saga.SKU = "RH321TS1";
            saga.Publisher = "Random House";
            saga.Price = 99.99m;

            Console.WriteLine( "From {0}: {1} by {2}: {3} Pages: " +
                "Price ${4}: SKU {5}", saga.Publisher, saga.Title, 
                saga.Authors[0], saga.Pages, saga.Price, saga.SKU 
                );


            Plane snowPlane = new Plane("white");


            Console.WriteLine(snowPlane.Color); //=> "white"




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
