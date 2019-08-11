﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Checkers
{
    public enum Color { White, Black }

    class Program
    {
        public static void Main(String[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Game Game = new Game();
            Game.Start();
            Console.WriteLine();
            Console.ReadKey();
        }
    }

    public struct Position
    {
        public int Row { get; private set; }
        public int Col { get; private set; }
        public Position(int row, int col)
        {
            Row = row;
            Col = col;
        }
    }

    public class Checker
    {
        public string Symbol { get; private set; }
        public Position Position { get; set; }
        public Color Team { get; private set; }

        public Checker(Color team, int row, int col)
        {
            Team = team;
            if (team == Color.Black)
            {
                Symbol = char.ConvertFromUtf32(int.Parse("25CB", System.Globalization.NumberStyles.HexNumber));
                // Team = team;
            }
            else
            {
                Symbol = char.ConvertFromUtf32(int.Parse("25CF", System.Globalization.NumberStyles.HexNumber));
                // Team = team;
            }
            Position = new Position(row, col);
        }
    }

    public class Board
    {
        public List<Checker> Checkers { get; private set; }

        public Board()
        {
            Checkers = new List<Checker>();
            for (int r = 0; r < 3; r++)
            {
                for (int i = 0; i < 8; i += 2)
                {
                    Checker c = new Checker(Color.White, r, (r + 1) % 2 + i);
                    Checkers.Add(c);
                }
                for (int i = 0; i < 8; i += 2)
                {
                    Checker c = new Checker(Color.Black, (r + 5), r % 2 + i);
                    Checkers.Add(c);
                }
            }
        }

        public Checker GetChecker(Position pos)
        {
            Checker found = null;
            foreach (Checker c in Checkers)
            {
                if (pos.Equals(c.Position))
                {
                    found = c;
                    break;
                }
            }
            return found;
        }

        public void RemoveChecker(Checker checker)
        {
            if (checker != null)
            {
                Checkers.Remove(checker);
            }
        }

        public void MoveChecker(Checker checker, Position dest)
        {
            Checkers.Remove(checker);
            checker.Position = dest;
            Checkers.Add(checker);
        }
    }

    public class Game
    {
        private Board board;
        private Color Turn = Color.Black;

        public Game()
        {
            board = new Board();
        }

        public bool CheckForWin()
        {
            return (board.Checkers.All(x => x.Team == Color.White) ||
                board.Checkers.All(x => x.Team == Color.Black));
            
            /* foreach(var x in Checkers) 
             * {
             *      if(x.Team == Color.White || x.Team == Color.Black)
             *          {
             *              return true;   
             *          }
             * } */
        }

        
        public void Start()
        {
            while (!CheckForWin())
            {
                Console.Clear();
                DrawBoard();
                Console.WriteLine($"Enter {Turn} Move in the following" +
                    $" format.");
                Console.WriteLine("Start Column, Start Row, Destination" +
                    " Column, Destination Row");
                string Move = Console.ReadLine();

                string[] coord = Move.Split(',');

                Checker checker = new Checker(Turn, Int32.Parse(coord[1]), Int32.Parse(coord[0]));
                Position src = new Position(Int32.Parse(coord[1]), Int32.Parse(coord[0]));
                Position dest = new Position(Int32.Parse(coord[3]), Int32.Parse(coord[2]));
                if (IsLegalMove(checker, src, dest))
                {
                    board.MoveChecker(checker, dest);
                    var result = Turn == Color.Black ? Turn = Color.White : Turn = Color.Black;
                }

                Console.ReadLine();

                // ProcessInput();
            }
            Console.ReadLine();
        }
        
        public bool IsLegalMove(Checker checker, Position src, Position dest)
        {
            if (checker == null)
            {
                return false;
            }
            if (checker.Team != Turn)
            {
            return false;
            }

            int r = dest.Row;
            int c = dest.Col;
            // if (you suck)


            return true;
        }

        public void DrawBoard()
        {
            string[][] grid = new string[8][];
            for (int r = 0; r < 8; r++)
            {
                grid[r] = new string[8];
                for (int c = 0; c < 8; c++)
                {
                    grid[r][c] = " ";
                }
            }
            foreach (Checker c in board.Checkers)
            {
                grid[c.Position.Row][c.Position.Col] = c.Symbol;
            }

            Console.WriteLine("  0 1 2 3 4 5 6 7");
            for (int r = 0; r < 8; r++)
            {
                Console.Write(r);
                for (int c = 0; c < 8; c++)
                {
                    Console.Write(" {0}", grid[r][c]);
                }
                Console.WriteLine();
            }
        }

    }
}
