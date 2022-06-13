using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.CollectionsLib;

namespace List_stack_array_q
{
    class Stack_function
    {

        public static void return_res_int() //sum,count,fetch,fetch last
        {

            Stack<int> tmp = new Stack<int>();

            Console.WriteLine("enter numbers");

            for(int i = 0; i < 3; i++)
            {
                int x = int.Parse(Console.ReadLine());

                tmp.Push(x);
            }

            //int sum = StackEx.Sum(tmp);
            //Console.WriteLine("\nsum --> " + sum);

            //int count = StackEx.Count(tmp);
            //Console.WriteLine("\ncount --> " + count);


            //search item him place (5,9,7 : input 0 - output = 7)

            //int fetch = StackEx.Fetch(tmp, 0);                 
            //Console.WriteLine("\n fetch --> " + fetch);
             


            //search last item in stack

            //int fetch_last = StackEx.FetchLast(tmp);
            //Console.WriteLine("\nfetch last --> " + fetch_last);


        
        }

        public static void return_bool_res()
        {

            Stack<int> tmp = new Stack<int>();

            Console.WriteLine("enter numbers");

            for (int i = 0; i < 3; i++)
            {
                int x = int.Parse(Console.ReadLine());

                tmp.Push(x);
            }

            //check if stack was sort

            //bool is_sort = StackEx.IsSortedUp(tmp);
            //Console.WriteLine("\n is sort ? --> " + is_sort);



            //check if in stack was this value

            //bool value_in = StackEx.IsValueIn(tmp, 3);
            //Console.WriteLine("\nvalue in ? " + value_in);



            //check if two stacks was same

            //Stack<int> tmp2 = new Stack<int>();

            //Console.WriteLine("\nenter numbers for stack 2");

            //for (int i = 0; i < 3; i++)
            //{
            //    int x = int.Parse(Console.ReadLine());

            //    tmp2.Push(x);
            //}

            //bool same_stacks = StackEx.S1EqS2(tmp,tmp2);
            //Console.WriteLine("\nstacks same ? " + same_stacks);
        }//is value in,stack same,was sort stack

        public static void return_res()//reverse stack,print,add new number to stack,sort
        {

            Stack<int> tmp = new Stack<int>();

            Console.WriteLine("enter numbers");

            for (int i = 0; i < 3; i++)
            {
                int x = int.Parse(Console.ReadLine());

                tmp.Push(x);
            }


            //we revres stack input 1,2,3 output 3,2,1

            //Stack<int> tmp1 = StackEx.Reverse(tmp);
            //StackEx.print(tmp1);



            //add new number to stack

            //StackEx.InsertNumToSorted(tmp, 3);
            //StackEx.print(tmp);



            //here we sord stack

            //StackEx.sortStack(tmp);
            //StackEx.print(tmp);

        }

    }
}
