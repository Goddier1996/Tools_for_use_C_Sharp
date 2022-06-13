using System;
using System.Collections.Generic;
using System.Text;

namespace List_stack_array_q
{
    class Two_ArrayEx
    {

        public static void print(int[,] array1)
        {

            Console.WriteLine("-------------------------");

            for(int i = 0; i < array1.GetLength(0); i++)
            {
                Console.WriteLine("\nclass number --> " + i + 1);

                for(int x = 0; x < array1.GetLength(1); x++)
                {
                    Console.WriteLine(array1[i, x] + "\n");
                }
            }

        }

        public static void sum(int[,] array1)
        {

            int sum = 0;
            int count_class = array1.GetLength(0);
            int count_studet = array1.GetLength(1);

            int[] average = new int[count_class];


            for (int i = 0; i < array1.GetLength(0); i++)
            {

                for(int x = 0; x < array1.GetLength(1); x++)
                {
                    sum += array1[i, x];
                }

                average[i] = sum / count_studet;
            }

            Console.WriteLine("-------------------");
            ArrayEx.print(average);

        }


    }
}
