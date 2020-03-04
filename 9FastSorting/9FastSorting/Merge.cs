using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9FastSorting
{
    public class Merge
    {
        #region Public Methods
        public void Sort(int[] arr)
        {
            MergeSort(arr, 0, arr.Length - 1);
        }
        #endregion

        #region Private Methods
        private void MergeSort(int[] arr, int startIndex, int endIndex)
        {
            int mid;
            if (endIndex > startIndex)
            {
                mid = (endIndex + startIndex) / 2;
                MergeSort(arr, startIndex, mid);
                MergeSort(arr, (mid+1), endIndex);
                MergeArrays(arr, startIndex, (mid + 1), endIndex);
            }
        }

        private void MergeArrays(int[] arr, int left, int mid, int right)
        {
            int[] temp = new int[arr.Length];
            int i, leftEnd, lengthOfInput, tmpPos;
            leftEnd = mid - 1;
            tmpPos = left;
            lengthOfInput = right - left + 1;

            //selecting smaller element form left sorted arr or
            // right sorted arr
            while ((left <= leftEnd) && (mid <= right))
            {
                if (arr[left] <= arr[mid])
                {
                    temp[tmpPos++] = arr[left++];
                }
                else
                {
                    temp[tmpPos++] = arr[mid++];
                }
            }

            //placing remaining elements in temp from left sorted array
            while (left <= leftEnd)
            {
                temp[tmpPos++] = arr[left++];
            }
            //placing remaining elements in temp from right sorted array

            while (mid <= right)
            {
                temp[tmpPos++] = arr[mid++];
            }

            //placing temp array to input
            for (i = 0; i < lengthOfInput; i++)
            {
                arr[right] = temp[right];
                right--;
            }
        }
        #endregion

        #region Merge Sort 2
        public int[] MergeSort2(int[] arr)
        {
            Func<int[], int[]> firstHalf = (array) =>
            {
                return array.Take((array.Length + 1) / 2).ToArray();
            };

            Func<int[], int[]> secondHalf = (array) =>
            {
                return array.Skip((array.Length + 1) / 2).ToArray(); //take last                
            };

            Func<int[], int[], int[]> mergeSortedArrays = (arr1, arr2) =>
            {
                int[] mergedArray = new int[arr1.Length + arr2.Length];

                int i1 = 0, i2 = 0, currentMin;

                while (i1 < arr1.Length || i2 < arr2.Length)
                {
                    if (i1 < arr1.Length && i2 < arr2.Length)
                    {
                        if (arr1[i1] < arr2[i2])
                        {
                            currentMin = arr1[i1];
                            i1++;
                        }
                        else
                        {
                            currentMin = arr2[i2];
                            i2++;
                        }
                    }
                    else if (i1 < arr1.Length)
                    {
                        currentMin = arr1[i1];
                        i1++;
                    }
                    else
                    {
                        currentMin = arr2[i2];
                        i2++;
                    }
                    mergedArray[i1 + i2 - 1] = currentMin;
                }
                return mergedArray;
            };

            int[] half1 = firstHalf(arr);
            int[] half2 = secondHalf(arr);

            if (half1.Length < 2)
                return mergeSortedArrays(half1, half2);
            else
                return mergeSortedArrays(MergeSort2(half1), MergeSort2(half2));
        }

        #endregion
    }
}
