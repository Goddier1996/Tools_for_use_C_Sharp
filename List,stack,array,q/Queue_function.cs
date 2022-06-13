using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.CollectionsLib;

namespace List_stack_array_q
{
    class Queue_function
    {

        public static void return_res_int()
        {

            Queue<int> tmp = new Queue<int>();

            Console.WriteLine("enter numbers");

            for(int i = 0; i < 3; i++)
            {
                int x = int.Parse(Console.ReadLine());

                tmp.Insert(x);
            }


            //int count = QueueEx.Count(tmp);
            //Console.WriteLine("\ncount --> " + count);

            //int sum = QueueEx.Sum(tmp);
            //Console.WriteLine("\nsum --> " + sum);



            //search item him place (5,9,7 : input 0 - output = 5)

            //int fetch = QueueEx.Fetch(tmp, 0);
            //Console.WriteLine("\nfetch -- > " + fetch);



            //search last item in Queue

            //int fetch_last = QueueEx.FetchLast(tmp);
            //Console.WriteLine("\nfetch last --> " + fetch_last);
        }//sum,count,fetch,fetch last

        public static void return_res() //revers,print,sort
        {

            Queue<int> tmp = new Queue<int>();

            Console.WriteLine("enter numbers");

            for (int i = 0; i < 3; i++)
            {
                int x = int.Parse(Console.ReadLine());

                tmp.Insert(x);
            }


            //we revres stack input 1,2,3 output 3,2,1

            //QueueEx.Reverse(tmp);
            //QueueEx.print(tmp);



            //here we sort Queue

            //Queue<int> tmp1 = QueueEx.sort(tmp);
            //QueueEx.print(tmp1);

        }

    }
}
