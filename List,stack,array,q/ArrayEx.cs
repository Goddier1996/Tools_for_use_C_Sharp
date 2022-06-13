using System;
using System.Collections.Generic;
using System.Text;

namespace List_stack_array_q
{
    class ArrayEx
    {

        public static void SelectionSort(int[] nums)
        {
            int n = nums.Length;
            for (int bottom = 0; bottom < n - 1; bottom++)
            {
                for (int i = bottom + 1; i < n; i++)
                {
                    if (nums[i] < nums[bottom])
                    {
                        int temp = nums[bottom];
                        nums[bottom] = nums[i];
                        nums[i] = temp;
                    }
                }
            }
        }

        public static int BinarySearch( int[] nums, int x)
        {
            int low = 0, mid, item;
            int high = nums.Length - 1;
            while (low <= high) // There is still a range to search
            {
                mid = (low + high) / 2; // Position of middle item
                item = nums[mid];
                if (x == item) // Found it! Return the index
                    return mid;
                else if (x < item) // x is in lower half of range
                    high = mid - 1; // move top marker down
                else // x is in upper half of range
                    low = mid + 1; // move bottom marker up
            }
            return -1; // No range left to search,
                       // x is not there
        }//index value in array

        public static void bubble_sort(int[] arr)
        {

            int i, j, temp;
            bool sorted = false;

            for (i = 1; i <= arr.Length - 1 && !sorted; i++)
            {
                sorted = true;

                for (j = 0; j < arr.Length - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        sorted = false;
                    }
                }
            }

        }

        public static void print(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            
        }

    }
}
