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
                Console.WriteLine("Rock, Paper, Scissors! \r\n Enter P to " +
                                    "Play or E to exit.");
                string play = Console.ReadLine().ToLower();

            while (play == "p")
            {
                printGame();

                Console.WriteLine("Rock, Paper, Scissors! \r\n Enter P to " +
                    "Play or E to exit.");
                play = Console.ReadLine().ToLower();
            }
        }

        public static void printGame()
        {

            Console.WriteLine("To Play rock, paper, scissors, ");
            Console.WriteLine("Enter ");
            Console.WriteLine("1 for Rock");
            Console.WriteLine("2 for Paper");
            Console.WriteLine("3 for Scissors");
            Console.WriteLine();
            int hand = 1;
            while (hand == 1 || hand == 2 || hand == 3) { 
                try
                {
                    hand = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Enter ");
                    Console.WriteLine("1 for Rock");
                    Console.WriteLine("2 for Paper");
                    Console.WriteLine("3 for Scissors");
                    Console.WriteLine();
                }
            }
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
        }

        public static void compareHands(int hand, int randomNumber)
        {

            if (hand == randomNumber) 
            {
                Console.WriteLine("You both picked {0}, Tie!!!!", hand);
            }
            else if (hand == (randomNumber + 1) || hand == (randomNumber - 2))
            {
                Console.WriteLine("The computer picked {0}, You win!!!!", randomNumber);
            }
            else if (hand == (randomNumber - 1) || hand == (randomNumber + 2)) 
            {
                Console.WriteLine("The computer picked {0}, sorry, you lose.", randomNumber);
            }
            else
            {
                Console.WriteLine("Error. No Winners!");
            }
             


            /*switch (hand)
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
            } */
        }
    }
}
