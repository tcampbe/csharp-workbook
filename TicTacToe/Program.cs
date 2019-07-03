using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        public static void Main(string[] args)
        {
            static string[,] board = new String[9];
        }

        /*  static string[,] board: this variable represents your 3x3 tic tac toe board

            static String currentPlayer: this variable represents your current player (X or O)
        */


        /*  static void placeMark() : this method should print out the current players 
                                      turns (X or O), ask the user for their row and 
                                      column inputs, and update the board.

            static bool isHorizonalWin(): this method should check if the current player
                                          has won horizontally

            static bool isVerticalWin(): this method should check if the current player 
                                         has won vertically

            static bool isDiagonalWin(): this method should check if the current player 
                                         has won diagonally

            static bool hasWon(): this method should check if the current player has won

            static bool isTie(): this methods checks if the game is over and is a tie
        */
        //    static void printBoard(): this method should print the board to the console.
        static void printBoard()
        {
            Console.WriteLine("/---|---|---\\");
            Console.WriteLine("| " + board[0] + " | " + board[1] + " | " + board[2] + " |");
            Console.WriteLine("|-----------|");
            Console.WriteLine("| " + board[3] + " | " + board[4] + " | " + board[5] + " |");
            Console.WriteLine("|-----------|");
            Console.WriteLine("| " + board[6] + " | " + board[7] + " | " + board[8] + " |");
            Console.WriteLine("/---|---|---\\");
        }

    }
}
