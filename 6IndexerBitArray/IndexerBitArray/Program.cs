using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerBitArray
{
    /// <summary>
    /// A program showing how we might use a struct/class with indexer to help us using an array with 0s and 1s
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BitArray32 arr = new BitArray32();
                arr[0] = 1;
                arr[5] = 1;
                arr[5] = 0;
                arr[25] = 1;
                arr[31] = 1;
                //arr[32] = 3;
                //arr[7] = 3;
                for (int i = 0; i <= 31; i++)
                {
                    Console.WriteLine("arr[{0}]={1}",i, arr[i]);
                }
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
