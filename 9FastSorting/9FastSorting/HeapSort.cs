using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9FastSorting
{
    public class HeapSort
    {

        public static void Sort(int[] array)
        {
            int n = array.Length;
            for(int i = n/2; i>=0; i--)
            {
                Sift(array, i, n-1);
            }
            int last = n - 1;
            while (last > 0)
            {
                SwapValues<int>(array,0,last);
                last--;
                Sift(array,0,last);
            }
        }
        private static void Sift(int[] array, int vertex, int right)
        {
            int i = vertex;
            int j = 2 * vertex + 1;
            if (j < right && array[j] < array[j + 1])
            {
                j++;
            }
            int x = array[i];
            while (j<= right && array[j]>x)
            {
                array[i] = array[j];
                i = j;
                j = 2 * i + 1;
                if (j < right && array[j] < array[j + 1])
                {
                    j++;
                }
            }
            array[i] = x;
        }


        static void SwapValues<T>(T[] arr, int i, int j)
        {
            if (arr.Length <= i || arr.Length <= j) return;
            T temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
