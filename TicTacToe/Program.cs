using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Program
    {
        public static string[] board = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public static string winner;
        public static void Main(string[] args)
        {
            // public static string currentPlayer;
            string currentPlayer = "x";
            printBoard();
            placeMark(currentPlayer);
            Console.ReadKey();
        }

        public static void printBoard()
        {
            Console.WriteLine("TicTacToe");
            Console.WriteLine("");
            Console.WriteLine("Player 1 is X");
            Console.WriteLine("");
            Console.WriteLine("Player 2 is o");
            Console.WriteLine("");
            Console.WriteLine("/ --- | --- | --- \\");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", board[1], board[2], board[3]);
            Console.WriteLine("|-----------------|");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", board[4], board[5], board[6]);
            Console.WriteLine("|-----------------|");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", board[7], board[8], board[9]);
            Console.WriteLine("/ --- | --- | --- \\");

            Console.WriteLine();
        }

        public static void placeMark(string currentPlayer)
        {
            for(int i = 0; i < 9; i++)
            {
                Console.WriteLine("Player " + currentPlayer + " pick a Square");
                int choice = Convert.ToInt32(Console.ReadLine());
                string x = currentPlayer;
                board[choice] = x;
                Console.Clear();
                printBoard();
                horizontalWin();
                verticalWin();
                diagonalWin();
                if (currentPlayer == winner)
                {
                    break;
                }
                else
                {
                    if (currentPlayer == "x")
                        {
                            currentPlayer = "o";
                        }
                    else
                        {
                            currentPlayer = "x";
                        }
                }

                Console.WriteLine();
            }
            isTie();
            Console.WriteLine();
            Console.WriteLine("Game Over");
            Console.WriteLine();

            Console.WriteLine();
        }

        public static void horizontalWin()
        {
            if ((board[1] == board[2] && board[2] == board[3]))
            {
                winner = board[1];
                Console.WriteLine(board[1] + " WINS!!!");
            }
            else if ((board[4] == board[5] && board[5] == board[6]))
            {
                winner = board[4];
                Console.WriteLine(board[4] + " WINS!!!");
            }
            else if ((board[7] == board[8] && board[8] == board[9]))
            {
                winner = board[7];
                Console.WriteLine(board[7] + " WINS!!!");
            }
            else
            {
                return;
            }
        }

        public static void verticalWin()
        {
            if ((board[1] == board[4] && board[4] == board[7]))
            {
                winner = board[1];
                Console.WriteLine(board[1] + " WINS!!!");
            }
            else if ((board[2] == board[5] && board[5] == board[8]))
            {
                winner = board[2];
                Console.WriteLine(board[2] + " WINS!!!");
            }
            else if ((board[3] == board[6] && board[6] == board[9]))
            {
                winner = board[3];
                Console.WriteLine(board[3] + " WINS!!!");
            }
            else
            {
                return;
            }
        }

        public static void diagonalWin()
        {
            if ((board[1] == board[5] && board[5] == board[9]))
            {
                winner = board[1];
                Console.WriteLine(board[1] + " WINS!!!");
            }
            else if ((board[3] == board[5] && board[5] == board[7]))
            {
                winner = board[3];
                Console.WriteLine(board[3] + " WINS!!!");
            }
            else
            {
                return;
            }
        }

        public static void isTie()
        {
            if ((winner != "x" && winner != "o")) 
                {
                    Console.WriteLine("TIE GAME !!!");
                }
            else
            {
                return;
            }
        }

    }
}
