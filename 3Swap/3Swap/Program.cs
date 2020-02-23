using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 100;
            int num2 = 200;
            Console.WriteLine("num1: " + num1);
            Console.WriteLine("num2: " + num2);

            Swap<int>(ref num1, ref num2);

            Console.WriteLine("num1: " + num1);
            Console.WriteLine("num2: " + num2);
            Console.WriteLine();
            
            string str1 = "Peter";
            string str2 = "Lili";
            Console.WriteLine("str1: " + str1);
            Console.WriteLine("str2: " + str2);

            Swap<string>(ref str1, ref str2);

            Console.WriteLine("str1: " + str1);
            Console.WriteLine("str2: " + str2);
            Console.WriteLine();

            Node<string> node1 = new Node<string>("Maria", null);
            Node<string> node2 = new Node<string>("Lili", node1);

            // can not swap reference types like value types
            Console.WriteLine("node1: " + node1);
            Console.WriteLine("node2: " + node2);
            Swap<Node<string>>(ref node1, ref node2);
            Console.WriteLine("node1: " + node1);
            Console.WriteLine("node2: " + node2);
        }


        static void Swap<T>(ref T val1, ref T val2)
        {
            T temp;
            temp = val1;
            val1 = val2;
            val2 = temp;
        }
    }
}
