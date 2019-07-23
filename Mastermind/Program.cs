using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    class Program
    {
        

        public static void Main(string[] args)
        {
            Random generatora = new Random();
           int colora = generatora.Next(1, 4);

            int guessa = 4;
            string picka = "a";
            int clue1 = 3;
            int guessb = 4;
            string pickb = "a";
            int clue2 = 3;

            Console.WriteLine("");

            int colorb = generatora.Next(1, 4);

            printGame();

            while (clue2 != 2)
            {
                Console.WriteLine("Enter your first pick.");
                picka = Convert.ToString(Console.ReadLine());
                picka = picka.ToLower();

                if (picka == "red")
                {
                    guessa = 1;

                }
                else if (picka == "yellow")
                {
                    guessa = 2;

                }
                else if (picka == "blue")
                {
                    guessa = 3;
                }
                else
                {
                    guessa = 4;
                }
                Console.WriteLine();

                Console.WriteLine("Enter your second pick.");
                pickb = Convert.ToString(Console.ReadLine());
                pickb = pickb.ToLower();

                if (pickb == "red")
                    guessb = 1;
                else if (pickb == "yellow")
                    guessb = 2;
                else if (pickb == "blue")
                    guessb = 3;
                else
                    guessb = 4;

                Console.WriteLine();

                if ((guessa == colora && guessb == colorb))
                {
                    Console.WriteLine("WIN!!");
                    clue2 = 2;
                }
                else if ((guessa == colora || guessb == colorb))
                    clue2 = 1;
                else
                    clue2 = 0;

                Console.WriteLine();

                if ((guessa == colorb && guessb == colorb))
                    clue1 = 2;
                else if ((guessa == colorb || guessb == colora))
                    clue1 = 1;
                else
                    clue1 = 0;
                    
                Console.WriteLine("Clue " + clue1 + " : " + clue2);
            }

            Console.WriteLine(picka + " = " + guessa);
            Console.WriteLine("coolr b = " + colora);
            Console.WriteLine(pickb + " = " + guessb);
            Console.WriteLine("coolr b = " + colorb);

            Console.ReadKey();

        }

        public static void printGame()
        {
            Console.WriteLine("MASTERMIND!!!!");
            Console.WriteLine();
            Console.WriteLine("I have 3 colors in my mind.");
            Console.WriteLine();
            Console.WriteLine("Red, Yellow, and Blue!");
            Console.WriteLine();
            Console.WriteLine("Can you gues which two I have chosen???");
            Console.WriteLine();
        }

        
    }
}
