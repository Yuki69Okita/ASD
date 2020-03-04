using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Collections
{
    /// <summary>
    /// Sample program to create a custom class based on CollectionBase
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            MyCollection<string> names = new MyCollection<string>();
            names.Add("Ivan");
            names.Add("Peter");
            names.Add("Maria");
            names.Add("Georgi");

            // follow the DRY principle and use PrintList(names);
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Contains Georgi:{0}", names.Contains("Georgi"));
            Console.WriteLine();

            names.Insert(3, "Lili");
            PrintList(names);

            Console.WriteLine("Number of names: " + names.Count());

            names.Remove("Ivan");
            Console.WriteLine("Number of names after remove Ivan: " + names.Count());

            names.Clear();
            Console.WriteLine("Number of names after Clear(): " + names.Count());
        }

        private static void PrintList(MyCollection<string> names)
        {
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
