using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CheckpointOneHanoi
{
    class Program
    {
        public static void Main(string[] args)
        {
            // uae stacks to push and pop numbers 1-4 from stack a to stack b and c 
            // uae peak ?? to compare the pop to the top in new stack
            Stack<int> a = new Stack<int>();
            a.Push(4);
            a.Push(3);
            a.Push(2);
            a.Push(1);
            Stack<int> b = new Stack<int>();
            Stack<int> c = new Stack<int>();


            int play = 1;
            while (play == 1)
            {
                Console.Write("A  ");
                PrintStack(a);
                Console.WriteLine();
                Console.WriteLine();

                Console.Write("B  ");
                PrintStack(b);
                Console.WriteLine();
                Console.WriteLine();

                Console.Write("C  ");
                PrintStack(c);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Pick a letter to move from.");
                string from = Console.ReadLine().ToLower();
                Console.WriteLine();
                Console.WriteLine("Pick a letter to move to.");
                string to = Console.ReadLine().ToLower();

                Console.WriteLine();
                Console.WriteLine();

                if (from == "a")
                {
                    if (to == "b")
                    {
                        b.Push(a.Pop());
                    }
                    else if (to == "c")
                    {
                        c.Push(a.Pop());
                    }
                    else
                    {
                        Console.WriteLine("Pick a letter to move to.");
                    }
                }
                else if (from == "b")
                {
                    if (to == "a")
                    {
                        a.Push(b.Pop());
                    }
                    else if (to == "c")
                    {
                        c.Push(b.Pop());
                    }
                    else
                    {
                        Console.WriteLine("Pick a letter to move to.");
                    }
                }
                else if (from == "c")
                {
                    if (to == "a")
                    {
                        a.Push(c.Pop());
                    }
                    else if (to == "b")
                    {
                        b.Push(c.Pop());
                    }
                    else
                    {
                        Console.WriteLine("Pick a letter to move to.");
                    }
                }
                else
                {
                    Console.WriteLine("Pick a letter to move from.");
                }
                Console.Clear();
            }
            Console.WriteLine("");

            Console.ReadKey();
        }

        public static void PrintStack(Stack<int> a)
        {
            if (a.Count == 0)
                return;
            else
            {
                int x = a.Peek();
                a.Pop();
                PrintStack(a);
                Console.Write(x + " ");
                a.Push(x);
            }
        }
    }
}
