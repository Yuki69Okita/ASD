using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9FastSorting
{
    public class Search
    {
        public static bool LinearSearch(int[] array, int key)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool BinarySearchNonRec(int[] array, int key)
        {
            int left = 0;
            int right = array.Length - 1;
            while (left <= right)
            {
                int medium = (left + right) / 2;
                if (array[medium] == key)
                { return true; }

                if (key > array[medium])
                {
                    left = medium + 1;
                }
                else //key < [medium]
                {
                    right = medium - 1;
                }
            }//while
            return false;
        }

        public static bool BinarySearchRec(int[] array, int left, int right, int key)
        {
            if (left > right)
            { return false; }
            else
            {
                int mid = (left + right) / 2;
                if (array[mid] == key)
                { return true; }
                else if (key < array[mid])
                {
                    return BinarySearchRec(array,left,mid-1,key);
                }
                else
                {
                    return BinarySearchRec(array,mid+1,right,key);
                }
            }
        }
    }
}
