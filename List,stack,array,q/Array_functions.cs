using System;
using System.Collections.Generic;
using System.Text;

namespace List_stack_array_q
{
    class Array_functions
    {

        public static void return_res() //search index,sort,print
        {

            //int[] array = { 1, 2, 3, 23 }; //size of array is 4

            //OR

            int size = 3;
            int[] array = new int[size];

            Console.WriteLine("enter number");

            for(int i = 0; i < array.Length; i++)
            {
                int x = int.Parse(Console.ReadLine());
                array[i] = x;
            }

            Console.WriteLine();


            //here we sort array

            //ArrayEx.bubble_sort(array);
            //ArrayEx.SelectionSort(array);

            //ArrayEx.print(array);



            //serach binary index array value

            //int z = ArrayEx.BinarySearch(array, 1);
            //Console.WriteLine("\n" + z);
            
        }

    }
}
