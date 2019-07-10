using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradebook
{
    class Program
    {
        public static void Main(string[] args)
        {
            string student = "0";
            Dictionary<string, int[]> gpa = new Dictionary<string, int[]>();

            Console.WriteLine("Enter a student name or enter 'quit'. ");
            student = Convert.ToString(Console.ReadLine());

            while (student != "quit")
            {
                
                Console.WriteLine("Enter the students grades seperated by a space.");
                string temp = (Console.ReadLine());
                // string[] grades = grade.Split(' ');
                char[] devider = new char[] { ' ' };
                string[] grade = temp.Split(devider);
                int[] grades = Array.ConvertAll(grade, s => int.Parse(s));
                gpa.Add(student, grades);

                Console.WriteLine("Enter a student name or enter 'quit'. ");
                student = Convert.ToString(Console.ReadLine());
            }

            int sum = 0;
            foreach (KeyValuePair<string, int[]> record in gpa)
            {
                sum = 0;
                int av = 0;
                foreach (int number in record.Value)
                {
                    sum += number;
                    int divisor = record.Value.GetLength(0);
                    av = sum/divisor;
                }
                Console.WriteLine("Student: " + record.Key +
                    ", GPA: " + av + ", Highest Grade: " + record.Value.Max() + 
                    ", Lowest Grade " + record.Value.Min());
                
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
