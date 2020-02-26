using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerSimple
{
    class Program
    {
        /// <summary>
        /// A sample program for Indexer.
        /// If we have to make a Farm with exactly 10 animals, than it might be easier to use indexer.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Farm myFarm = new Farm() { [1] = "Cat", [3] = "Bird", [5]= "Dog" };
            myFarm[2] = "Rabbit";
            myFarm[7] = "turtle";
            myFarm[100] = "pinguin";
            myFarm[5] = "pinguin";

            for (int i = 0; i < myFarm.GetAnimalsCount(); i++)
            {
                Console.WriteLine("Animals[{0}]={1}",i, myFarm[i] ?? "empty");
            }
            Console.WriteLine();

            Console.WriteLine(myFarm[200]);
            Console.WriteLine();
        }
    }
}
