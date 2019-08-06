using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            // hastables are key value pairs

            Hashtable TroySecrets = new Hashtable();

            TroySecrets.Add("ht", "6 Even");
            TroySecrets.Add("wt", "470");
            TroySecrets.Add("==", "1/4 ton");
            // cant have same key but values can repeat
            TroySecrets.Add("lbs", "470");

            // change a value
            TroySecrets["wt"] = "qaurter ton of fluffy fun";

            // use .ContainsKey to check for exsisting keys (if !loop)

            // foreach loop retrieves pairs

            // .Values to use values alone

            // .Keys to use keys alone

            // .Remove to delete a pair

            // .Clear removes all pairs

            


            // A hash code is a value (numeric) used to identify an object during 
            // equality testing. It also serves as an index for an object in a collection.

            // a hashcode is a unique identifier and a hashtable guarantees 
            // no duplicates because it will not accept duplicate keys 

            // Basically, hash codes exist to make hashtables possible.
            // Two equal objects are guaranteed to have equal hashcodes.
            // Two unequal objects are not guaranteed to have unequal hashcodes
            // (that's called a collision).

            Console.WriteLine("lbs is   " + "lbs".GetHashCode());
            Console.WriteLine("wt  is   " + "wt".GetHashCode());
            Console.WriteLine("ht  is   " + "ht".GetHashCode());
            Console.WriteLine("==  is   " + "==".GetHashCode());
            Console.WriteLine();

            ICollection keys = TroySecrets.Keys;

            foreach (DictionaryEntry de in TroySecrets)
            {
                Console.WriteLine(de.Key + "  " + de.Value);
                Console.WriteLine();
            }


            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
