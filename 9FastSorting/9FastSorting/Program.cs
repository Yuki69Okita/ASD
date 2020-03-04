using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9FastSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = 100;
            int[] array = new int[len];
            RandArray(array, 2 * len, false);
            int[] arrayCopy2 = (int[])array.Clone();
            int[] arrayCopy3 = (int[])array.Clone();
            int[] arrayCopy4 = (int[])array.Clone();

            Console.WriteLine("Quick sort: ");
            PrintArray(array);
            QuickSort(array, 0, array.Length - 1);
            PrintArray(array);

            Console.WriteLine();
            Console.WriteLine("Merge sort: ");
            PrintArray(arrayCopy2);
            new Merge().Sort(arrayCopy2);
            //arrayCopy2 = new Merge().MergeSort2(arrayCopy2);
            PrintArray(arrayCopy2);

            Console.WriteLine();
            Console.WriteLine("Heap sort: ");
            PrintArray(arrayCopy3);
            HeapSort.Sort(arrayCopy3);
            PrintArray(arrayCopy3);

            Console.WriteLine();
            Console.WriteLine("Radix sort: ");
            PrintArray(arrayCopy4);
            RadixSort(arrayCopy4);
            PrintArray(arrayCopy4);
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "{0}", i < arr.Length - 1 ? " " : "");
            }
            Console.WriteLine();
        }

        static void RandArray(int[] arr, int maxVal, bool allowNegative)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, maxVal + 1);
                if (allowNegative)
                {
                    //a=a*(-1)=> -a
                    //a=a*( 1)=>  a
                    arr[i] = arr[i] * (1 - 2 * rand.Next(0, 2));
                }
            }
        }

        static void SwapValues<T>(T[] arr, int i, int j)
        {
            if (arr.Length <= i || arr.Length <= j) return;
            T temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static void QuickSort(int[] array, int left, int right)
        {
            int i = left;
            int j = right;
            int x = array[(left + right) / 2];//pivot
            do
            {
                while (array[i] < x) i++;
                while (array[j] > x) j--;
                if (i <= j)
                {
                    SwapValues<int>(array,i,j);
                    i++; j--;
                }
            }
            while (i<=j);
            if (left < j) QuickSort(array,left,j);
            if (i < right) QuickSort(array, i, right);
        }

        static void RadixSort(int[] array)
        {
            int i;
            int j;
            int[] temp = new int[array.Length];
            for (int shift = 31; shift > -1; --shift)
            {
                j = 0;
                for (i=0; i < array.Length; ++i)
                {
                    bool move = (array[i]<<shift) >= 0;
                    if (shift == 0 ? !move : move)
                    {
                        array[i - j] = array[i];
                    }
                    else
                    {
                        temp[j++] = array[i];
                    }
                }
                Array.Copy(temp,0,array,array.Length-j,j);//time lagging!
            }
        }

    }
}
