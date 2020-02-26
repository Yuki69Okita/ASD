using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerSimple
{
    /// <summary>
    /// Farm is a class which can contain up to 10 animals.
    /// It can be accessed and set with an Indexer for specific position between 0 and 9
    /// </summary>
    public class Farm
    {
        private string[] animals = new string[10];

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index <= animals.Length)
                {
                    return animals[index];
                }
                return $"Invalid index: {index}";
            }
            set
            {
                if (index >= 0 && index < animals.Length && !string.IsNullOrEmpty(value))
                {
                    animals[index] = value;
                }
                else
                {
                    Console.WriteLine($"Failed to set value '{value}' at index: {index}");
                }
            }
        }

        public int GetAnimalsCount()
        {
            return animals.Length;
        }
    }
}
