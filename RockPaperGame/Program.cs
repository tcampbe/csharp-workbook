using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperGame
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("To Play rock, paper, scissors, ");
            Console.WriteLine("Enter ");
            Console.WriteLine("1 for Rock");
            Console.WriteLine("2 for Paper");
            Console.WriteLine("3 for Scissors");
            Console.WriteLine();
            int hand;
            hand = Convert.ToInt32(Console.ReadLine());
            Random generator = new Random();
            // creates a number 1, 2 or 3
            int randomNumber = generator.Next(1, 4);

            compareHands(hand, randomNumber);
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("You Picked = " + hand);
            Console.WriteLine();
            Console.WriteLine("Computer Picked = " + randomNumber);



            Console.ReadKey();
        }
        public static void compareHands(int hand, int randomNumber)
        {
            switch (hand)
            {
                case 1:
                    switch (randomNumber)
                    {
                        case 1:
                            Console.WriteLine("The computer chose Rock, it's a tie!");
                            break;

                        case 2:
                            Console.WriteLine("The computer chose paper. Paper covers rock. Computer win!!");
                            break;

                        case 3:
                            Console.WriteLine("You are a winner! Your rock smashes the computers scissors!!!");
                            break;

                        default:
                            Console.WriteLine("Error. No Winners!");
                            break;
                    };
                    break;
                case 2:
                    switch (randomNumber)
                    {
                        case 1:
                            Console.WriteLine("You are a winner! Your paper covers the computers rock!!");
                            break;

                        case 2:
                            Console.WriteLine("The computer chose paper, it's a tie!");
                            break;

                        case 3:
                            Console.WriteLine("The computer chose scissors. Scissors cut paper. Computer wins!!");
                            break;

                        default:
                            Console.WriteLine("Error. No Winners!");
                            break;
                    }
                    break;
                case 3:
                    switch (randomNumber)
                    {
                        case 1:
                            Console.WriteLine("The computer chose rock. Rock smashes scissors. Computer wins!!");
                            break;

                        case 2:
                            Console.WriteLine("You are a winner! Your scissors cuts the computers paper!!!");
                            break;

                        case 3:
                            Console.WriteLine("The computer chose scissors, it's a tie!");
                            break;

                        default:
                            Console.WriteLine("Error. No Winners!");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Error. No Winners!");
                    break;
            }
        }
    }
}
