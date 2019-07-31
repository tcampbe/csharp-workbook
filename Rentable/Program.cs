using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRentable> Rentals = new List<IRentable>();

            Rentals.Add(new Car(200, "2 Seat Sportscar"));
            Rentals.Add(new Car(300, "7 Passenger Minivan"));
            Rentals.Add(new Car(400, "4 Door with Boat Hitch"));
            Rentals.Add(new House(750, "Lake Side with Dock"));
            Rentals.Add(new House(1000, "Marina Special, Sleeps 12"));
            Rentals.Add(new Boat(18, "Ski Boat with Equipment Included"));
            Rentals.Add(new Boat(10, "Fishing Special with Troller"));


            Console.WriteLine("Today's Available Rentals!");
            Console.WriteLine();
            foreach (IRentable rent in Rentals)
            {
                rent.GetDescription();
                rent.GetDailyRate();
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }

    public interface IRentable
    {
        void GetDailyRate();

        void GetDescription();
    }

    public class Boat : IRentable 
    {
        public int Hourly { get; set; }
        public string Description { get; set; }

        public Boat(int hourly, string description)
        {
            Hourly = hourly;
            Description = description;
        }

        public void GetDailyRate()
        {
            int Daily = Hourly * 24;
            Console.WriteLine(" Only ${0}/hour or ${1}/day", Hourly, Daily);
        }

        public void GetDescription()
        {
            Console.Write("Boat: {0}. ", Description);
        }


    }

    public class House : IRentable 
    {

        public int Weekly { get; set; }
        public string Description { get; set; }

        public House(int weekly, string description)
        {
            Weekly = weekly;
            Description = description;
        }

        public void GetDailyRate()
        {
            int Daily = Weekly / 7;
            Console.WriteLine(" Weekly rental: ${0}, only ${1}/day!", Weekly, Daily);

        }

        public void GetDescription()
        {
            Console.Write("House: {0}. ", Description);
        }

        

    }

    public class Car : IRentable 
    {

        public int Daily { get; set; }
        public string Description { get; set; }

        public Car(int daily, string description)
        {
            Daily = daily;
            Description = description;
        }

        public void GetDailyRate()
        {
            Console.WriteLine(" Daily rate: ${0}", Daily);
        }

        public void GetDescription()
        {
            Console.Write("Car: {0}. ",  Description);
        }
    }
}
