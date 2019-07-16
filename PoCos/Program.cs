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
            Car snowCar = new Car("white");
            Car magicalCar = new Car("rainbow");
            Car hippyCar = new Car("tiedye");

            Console.WriteLine(snowCar.Color); //=> "white"
            Console.WriteLine(magicalCar.Color); //=> "rainbow"
            Console.WriteLine(hippyCar.Color); //=> "tiedye"          


                        /* Car car1 = new Car();
                        car1.make = "Mazda";
                        car1.model = "CX-5";
                        car1.numDoors = 4;
                        car1.vin = "ABCDEFGHIJKLM";

                        Car car2 = new Car();
                        car2.make = "BMW";
                        car2.model = "325";
                        car2.numDoors = 4;
                        car2.vin = "NOPQRSTUVWXYZ";

                        Console.WriteLine("Car1 is a {0} {1} with {2} doors", 
                            car1.make, car1.model, car1.numDoors 
                            );

                        Console.WriteLine("Car2 is a {0} {1} with {2} doors",
                            car2.make, car2.model, car2.numDoors
                            ); */

            /* Person joe = new Person();
            joe.firstName = "Joe";
            joe.lastName = "Smith";
            joe.age = 10;

            Person mary = new Person();
            mary.firstName = "Mary";
            mary.lastName = "Donalds";
            mary.age = 31;

            Console.WriteLine("{0} {1} is {2} years old.",
                joe.firstName, joe.lastName, joe.age
                );

            Console.WriteLine("{0} {1} is {2} years old.",
                mary.firstName, mary.lastName, mary.age
                ); */



            Console.ReadKey();

        }
        
    }

    /* public class driversLicense
    {
        public string licensee { get; set; }

        public driversLicense(string field)
        {
            licensee = field;
        }

        string firstName = new licensee("tivo");
        string lastName = "duentes";
        string gender = "alpha";
        string licenseNumber = "0000000001";
    } */

    public class Car
    {
        public string Color { get; set; }

        public Car(string initialColor)
        {
            Color = initialColor;
        }

        /* Car randomCar = new Car();
        randomCar.Color = "blue";
        Console.WriteLine(randomCar.Color); */

        /* public string make;
        public string model;
        public string vin;
        public int numDoors; */


    }

    /* public class Person
    {
        public String firstName;
        public String lastName;
        public int age;

    } */

    
}
