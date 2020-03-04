using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7SimpleSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] array = new int[n];
            RandArray(array, 2 * n, false);
            Console.WriteLine("Original Array: ");
            PrintArray(array);

            Stopwatch sw = new Stopwatch();

            Console.WriteLine("Bubble Sort: ");
            int[] arrayCopy = (int[])array.Clone();
            sw.Start();
            BubbleSort(arrayCopy);
            sw.Stop();
            //Console.WriteLine("Time to execute: " + sw.Elapsed);
            PrintArray(arrayCopy);

            int[] arrayCopy2 = (int[])array.Clone();
            Console.WriteLine("Selection Sort: ");
            sw.Reset();
            sw.Start();
            SelectionSort(arrayCopy2);
            sw.Stop();
            //Console.WriteLine("Time to execute: " + sw.Elapsed);
            PrintArray(arrayCopy2);

            int[] arrayCopy3 = (int[])array.Clone();
            Console.WriteLine("Insertion Sort: ");
            sw.Reset();
            sw.Start();
            InsertionSort(arrayCopy3);
            sw.Stop();
            //Console.WriteLine("Time to execute: " + sw.Elapsed);
            /PrintArray(arrayCopy3);


            int[] arrayCopy4 = (int[])array.Clone();
            Console.WriteLine("My Simple Sort: ");
            sw.Reset();
            sw.Start();
            MySimpleSort(arrayCopy4);
            sw.Stop();
            //Console.WriteLine("Time to execute: " + sw.Elapsed);
            PrintArray(arrayCopy3);
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
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
            T temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        // Buble sort which orders from smallest to biggest
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        SwapValues<int>(arr, j, j - 1);
                    }
                }
                // PrintArray(arr);
            }
        }

        // Buble sort which orders from biggest to smallest
        static void BubbleSort2(int[] arr)
        {
            int n = arr.Length;
            for (int k = 0; k < n - 1; k++)
            {
                // (n-k-1) is for ignoring comparisons of elements which have already been compared in earlier iterations
                for (int i = 0; i < n - k - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        SwapValues<int>(arr, i, i + 1);
                    }
                }
                // PrintArray(arr);
            }
        }

        // Buble sort which orders from biggest to smallest
        static void BubbleSort3(int[] arr)
        {
            int n = arr.Length;
            for (int i = n - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        SwapValues<int>(arr, j, j + 1);
                    }
                }
                PrintArray(arr);
            }
        }

        public static void SelectionSort(int[] arr)
        {
            int i, j, min, minPos;
            int n = arr.Length;
            for (i = 0; i < n - 1; i++)
            {
                min = arr[i]; minPos = i;
                for (j = i + 1; j < n; j++)
                {
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        minPos = j;
                    }
                }
                SwapValues<int>(arr, i, minPos);
                //PrintArray(arr);
            }
        }

        public static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int x = arr[i], j = i;
                while (j > 0 && arr[j - 1] > x)
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = x;
                //Console.WriteLine("a[{0}]={1}",j, arr[j]);
                //PrintArray(arr);
            }
        }

        // за всеки елемент от масива 0..N-1 правил следното:
        // проверяваме го със всички елементи след него
        // и ако имаме елемент който който е по-малък, разменяме им местата
        static void MySimpleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        SwapValues<int>(arr, i, j);
                    }
                }
                //PrintArray(arr);
            }
        }
    }
}
