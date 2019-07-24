using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroes
{
    class Program
    {
        static List<Person> Humans = new List<Person>();
        static void Main(string[] args)
        {
            Humans.Add(new Person ("Jim Wock", "DogLover"));
            Humans.Add(new Person("Tuna Tinner", "Sanger"));
            Humans.Add(new SuperHeroe("SuperTroy", "Teeny Tro", "Vocal Aerobics"));
            Humans.Add(new Villain("Dirty Harvey", "Clim Westwood"));

            foreach (Person person in Humans)
            {
                person.PrintGreeting();
            }
            
            Console.ReadKey();

        }
    }




    public class Person
    {

        public string Name { get; set; }
        public string Nickname { get; set; }

        public Person(string name, string nickName)
        {
            Name = name;
            Nickname = nickName;
        }

        public override string ToString()
        {
            return Name;
        }
        
        public virtual void PrintGreeting()
        {
            Console.Write(Name + ":");
            Console.WriteLine(" Hi, my name is {0}, you can call me {1}", Name, Nickname);
        }

    }

    class SuperHeroe : Person
    {
        public string RealName { get; set; }
        public string SuperPower { get; set; }

        public SuperHeroe(string name, string realName, string superPower) : base(name, null)
        {
            RealName = realName;
            SuperPower = superPower;
        }

        public override void PrintGreeting()
        {
            Console.Write(Name + ":");
            Console.WriteLine(" I am {0}. when I am {1}, my super power" +
                " is {2}", RealName, Name, SuperPower);

        }
    }

    class Villain : Person
    {
        public String Nemesis;

        public Villain(string name, string nemesis) : base(name, null)
        {
            Nemesis = nemesis;
        }


        public override void PrintGreeting()
        {
            Console.Write(Name + ":");
            Console.WriteLine(" I am {0}! have you seen {1}?", Name, Nemesis);

        }

    }
    
    
    
    
}
