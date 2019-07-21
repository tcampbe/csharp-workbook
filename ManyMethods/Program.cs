using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyMethods
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Troy is here.");
            // directly call static method with class name
            Program.hello();
            Program.addition();
            Program.catDog();
            Program.oddEvent();
            Program.inches();
            Program.echo();
            Program.killGrams();
            Program.date();
            Program.age();
            Program.guess();
        }

        public static void hello()//hello
        {
            //prints greeting asks name then prints bye NAME
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Bye " + name + "!");
            Console.WriteLine();
        }

        public static void addition()//addition
        {
            //asks for two numbers and prints the sum
            int Number1, Number2;
            Console.WriteLine("Please enter a number.");
            Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number.");
            Number2 = Convert.ToInt32(Console.ReadLine());
            int Result;
            Result = Number1 + Number2;
            Console.WriteLine("The sum of the two numbers is " + Result.ToString());
            Console.WriteLine();
        }

        public static void catDog()//catDog
        {
            //asks cats or dogs and replies bark or meow
            Console.WriteLine("Do you prefer cats or dogs?");
            string result = Console.ReadLine();
            if (result == "cats")

                Console.WriteLine(" 'Meow' ");

            else if (result == "dogs")

                Console.WriteLine(" 'WOOF!'  ");

            else

                Console.WriteLine("Incorrect response");

            Console.WriteLine();
        }

        public static void oddEvent()//oddEvent
        {
            //asks for number replies odd or even
            int i;
            Console.Write("Enter a Number : ");
            i = Convert.ToInt32(Console.ReadLine());
            if (i % 2 == 0)

                Console.Write("Entered Number is an Even Number");

            else

                Console.Write("Entered Number is an Odd Number");

            Console.WriteLine();
            Console.WriteLine();
        }

        public static void inches()//inches
        {
            //asks ht in feet replies ht in inches
            double inch;
            Console.Write("Input Value (Feet)  : ");
            double feet = Convert.ToDouble(Console.ReadLine());
            inch = feet * 12;

            Console.WriteLine("{0} Feet is {1} Inches", feet, inch);
            Console.WriteLine();
        }

        public static void echo()//echo
        {
            //asks for word replies word in CAPS then two lowercase
            Console.WriteLine("Please input a word.");
            string word = Console.ReadLine();
            string big = word.ToUpper();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(big);
            string low = word.ToLower();
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(" ");
            Console.WriteLine(low);
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(low);
            Console.WriteLine();
        }

        public static void killGrams()//killGrams
        {
            //asks for wt in lbs replies wt in kg
            double kg;
            Console.Write("Input a weight (lbs) : ");
            double lbs = Convert.ToDouble(Console.ReadLine());
            kg = lbs * 0.4536;
            Console.WriteLine("{0} lbs is {1} kg", lbs, kg);
            Console.WriteLine();
        }

        public static void date()//date
        {
            //prints out the current date
            Console.Write("The current date and time is : ");
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine();
        }

        public static void age()//age
        {
            //asks birthyear replies age (extra birthday if possible)
            Console.WriteLine("What year were you born? 4 digits please! example: 1969");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            int age = DateTime.Now.Year - birthYear;
            Console.WriteLine("You are " + age);
            Console.WriteLine();
        }

        public static void guess()//guess
        {
            //asks to guess a word replies correct! if csharp otherwise WRONG!
            Console.WriteLine("Guess the word I am thinking.");
            string result = Console.ReadLine();
            if (result == "csharp")

                Console.WriteLine(" 'WOW, Correct!!!' ");

            else

                Console.WriteLine(Environment.NewLine + "Wrong"
                    + Environment.NewLine
                    + Environment.NewLine + "WRONG!!"
                    + Environment.NewLine
                    + Environment.NewLine + "duh....");

            Console.ReadKey();

        }


    }
}
