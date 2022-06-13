using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.CollectionsLib;

namespace List_stack_array_q
{
    class QueueEx
    {

        public static int Count(Queue<int> q)
        {
            Queue<int> t = new Queue<int>();
            int count = 0;
            while (!q.IsEmpty())
            {
                t.Insert(q.Remove());
                count++;
            }

            while (!t.IsEmpty())
            {
                q.Insert(t.Remove());
            }

            return count;
        }

        public static int Sum(Queue<int> q)
        {
            Queue<int> t = new Queue<int>();
            int sum = 0;
            int x;
            while (!q.IsEmpty())
            {
                x = q.Remove();
                t.Insert(x);
                sum = sum + x;
            }

            while (!t.IsEmpty())
            {
                q.Insert(t.Remove());
            }
            return sum;
        }

        public static int Fetch(Queue<int> q, int k)
        {
            int tVal;
            Queue<int> t = new Queue<int>();
            while ((!q.IsEmpty()) && (k > 0)) //Go over s - k places.
            {
                t.Insert(q.Remove()); //Temporary save elements in t
                k--;                  //Count Location      
            }
            //Assuming there was no error in the request --> k<=Count(s) 
            //i.e --> the while terminated because of k - not because of Isempty.
            tVal = q.Remove();
            t.Insert(tVal);            //Temporary save elements in t

            while (!t.IsEmpty())       //Recover s
            {
                q.Insert(t.Remove());
            }
            return tVal;
        }

        public static int FetchLast(Queue<int> q)
        {
            int x = 0;            //if q is empty --> returns 0
            Queue<int> t = new Queue<int>();

            while (!q.IsEmpty())  //Go over q - till end
            {
                x = q.Remove();
                //if (!q.IsEmpty()){t.Insert(x);} --> This is a method to avoid keeping the last element
                t.Insert(x);      //Temporary save elements in t
            }
            //when while ends x=last

            while (!t.IsEmpty()) //Recover s
            {
                q.Insert(t.Remove());
            }
            return x;
        }

        public static void Reverse(Queue<int> q)
        {
            Stack<int> t = new Stack<int>();

            while (!q.IsEmpty())     //Go over q - till end
            {
                t.Push(q.Remove());  //Get into Stack - to Reverse 
            }

            while (!t.IsEmpty())    //Recover s
            {
                q.Insert(t.Pop());
            }
        }

        public static void print(Queue<int> s)
        {

            int x;

            Console.WriteLine();

            while (!s.IsEmpty())
            {
                x = s.Remove();
                Console.WriteLine(x);
            }

        }

        public static Queue<int> sort(Queue<int> q)
        {

            Queue<int> temp = new Queue<int>();

            while (!q.IsEmpty())
            {
                int x = findMax(q);
                temp.Insert(x);
            }

            return temp;
        }

        public static int findMax(Queue<int> q)
        {

            bool extracted = false;
            int max = q.Head();
            Queue<int> qt = new Queue<int>();

            while (!q.IsEmpty())
            {
                int t = q.Remove();

                if (t > max)
                {
                    max = t;
                }

                qt.Insert(t); 
            }



            while (!qt.IsEmpty())
            {
                int t = qt.Remove();

                if (t == max && !extracted) 
                {
                    extracted = true;
                }

                else
                {
                    q.Insert(t);
                }
            }


            return max;

        }

    }
}
