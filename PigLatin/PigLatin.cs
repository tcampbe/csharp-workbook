using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word, Now! ");
            string english = Console.ReadLine();
            char[] vowel = { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };
            int firstvow = english.IndexOfAny(vowel);
            int length = english.Length;
            string last = english.Substring(english.Length - 1, 1);
            int lastlet = last.IndexOfAny(vowel);

            string pigone;
            string pigtwo;

            if (firstvow == -1)
            {
                pigone = "";
                pigtwo = english;
            }
            else
            {
                pigone = english.Substring(firstvow, length - firstvow);
                pigtwo = english.Substring(0, firstvow);
            }

            Console.WriteLine("");
            Console.WriteLine("in pig latin is");
            Console.WriteLine("");
            if (firstvow < 1 && lastlet > -1)
            {
                Console.WriteLine(english + "yay");
            }
            else if (firstvow < 1 && lastlet < 0)
            {
                Console.WriteLine(english + "ay");
            }
            else if (firstvow < 0)
            {
                Console.WriteLine(english + "ay");
            }
            else
            {
                Console.WriteLine(pigone + pigtwo + "ay");
            }

            Console.WriteLine();
        }
    }
}