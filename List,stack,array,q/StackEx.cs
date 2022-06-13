using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.CollectionsLib;

namespace List_stack_array_q
{
    class StackEx
    {

        public static int Count(Stack<int> s)
        {
            int count = 0;
            Stack<int> t = new Stack<int>();
            while (!s.IsEmpty()) //Go over s
            {
                t.Push(s.Pop()); //Temporary save elements in t
                count++;
            }

            while (!t.IsEmpty()) //Recover s
            {
                s.Push(t.Pop());
            }
            return count;
        }

        public static int Sum(Stack<int> s)
        {
            int sum = 0;
            int x;
            Stack<int> t = new Stack<int>();
            while (!s.IsEmpty()) //Go over s
            {
                x = s.Pop();
                t.Push(x); //Temporary save elements in t
                sum = sum + x;
            }

            while (!t.IsEmpty()) //Recover s
            {
                s.Push(t.Pop());
            }
            return sum;
        }

        public static int Fetch(Stack<int> s, int k)
        {
            int tVal;
            Stack<int> t = new Stack<int>();
            while ((!s.IsEmpty()) && (k > 0)) //Go over s - k places.
            {
                t.Push(s.Pop());          //Temporary save elements in t
                k--;                      //Count Location      
            }
            //Assuming there was no error in the request --> k <= Count(s) 
            //i.e --> the while terminated because of k - not because of Isempty.
            tVal = s.Pop();
            t.Push(tVal);                  //Temporary save elements in t

            while (!t.IsEmpty())           //Recover s
            {
                s.Push(t.Pop());
            }
            return tVal;
        }

        public static int FetchLast(Stack<int> s)
        {
            int x = 0;            //if s is empty --> returns 0
            Stack<int> t = new Stack<int>();

            while (!s.IsEmpty()) //Go over s - till end
            {
                x = s.Pop();
                t.Push(x);      //Temporary save elements in t
            }
            //when while ends x=last

            while (!t.IsEmpty()) //Recover s
            {
                s.Push(t.Pop());
            }
            return x;
        }

        public static Stack<int> Reverse(Stack<int> s)
        {
            Stack<int> t = new Stack<int>();  //S --> Q: Reverse
            while (!s.IsEmpty())              //Go over s - till end
            {
                t.Push(s.Pop());            //Temporary save elements in t
            }

            while (!t.IsEmpty())              //Q --> S: Keep the Reversal
            {
                s.Push(t.Pop());
            }

            return s;

        }

        public static bool IsSortedUp(Stack<int> s)
        {
            bool sorted = true;
            Stack<int> t = new Stack<int>();
            int a = s.Pop();                   //Assumes at least 1 element in stack
            t.Push(a);                         //Temp save element in t - for recovery
            int b = 0;
            while (sorted && (!s.IsEmpty()))   //Go over s - till violation
            {
                b = s.Pop();                   //Get next b
                t.Push(b);                     //Temp save element in t - for recovery
                if (a > b) { sorted = false; } //compares a pair of consequtives a <--> b
                a = b;                         //b - becomes the new - a
            }

            while (!t.IsEmpty())               //Recover s;
            {
                s.Push(t.Pop());
            }

            return sorted;
        }

        public static void InsertNumToSorted(Stack<int> s, int num) //Assumes Ascending order
        {
            Stack<int> t = new Stack<int>();
            bool found = false;
            int x;

            while (!found && (!s.IsEmpty()))   //Go over s - Search Location
            {
                x = s.Pop();                   //Get next b
                if (num > x) { t.Push(x); }      //not yet - continue search
                else { t.Push(num); t.Push(x); found = true; }
            }

            if (!found) { t.Push(num); }       //exited the while && !found --> num is last

            while (!t.IsEmpty())               //Recover s;
            {
                s.Push(t.Pop());
            }
        }

        public static bool IsValueIn(Stack<int> s, int num)
        {
            Stack<int> t = new Stack<int>();
            bool found = false;
            int x;

            while (!found && (!s.IsEmpty()))   //Go over s - Search Location
            {
                x = s.Pop();                   //Get next item from Stack
                if (num == x) { found = true; }//found 
                t.Push(x);
            }


            while (!t.IsEmpty())               //Recover s;
            {
                s.Push(t.Pop());
            }

            return found;
        }

        public static bool S1EqS2(Stack<int> s1, Stack<int> s2)
        {
            Stack<int> t1 = new Stack<int>();
            Stack<int> t2 = new Stack<int>();
            bool equal = true;
            int x1, x2;

            while (equal && (!s1.IsEmpty()) && (!s2.IsEmpty()))   //Go over s1 and s2
            {
                x1 = s1.Pop();                 //Get next item from s1
                x2 = s2.Pop();                 //Get next item from s2
                if (x1 != x2) { equal = false; } //failure found 
                t1.Push(x1);
                t2.Push(x2);
            }

            if (equal && (!(s1.IsEmpty() && s2.IsEmpty()))) //if equal but only 1 stack has been scanned till end --> not equal
            { equal = false; }

            //seperate recover needed --> only if unequal Count
            //could use explicit Count knowledge --> to improve efficiency

            while (!t1.IsEmpty())               //Recover s1;
            {
                s1.Push(t1.Pop());
            }

            while (!t2.IsEmpty())               //Recover s2;
            {
                s2.Push(t2.Pop());
            }

            return equal;
        }//check if 2 stacks was same

        public static void print(Stack<int> s)
        {

            Stack<int> t = new Stack<int>();
            int x;

            Console.WriteLine();

            while (!s.IsEmpty())
            {
                x = s.Pop();
                Console.WriteLine(x);

                t.Push(x);
            }

            while (!t.IsEmpty())
            {
                x = t.Pop();

                s.Push(x);
            }

        }

        public static void sortStack(Stack<int> stack)
        {

            Stack<int> temp = new Stack<int>();

            while (!stack.IsEmpty())
            {
                int t = stack.Pop();

                while (!temp.IsEmpty() && t < temp.Top()) 
                {
                    stack.Push(temp.Pop());
                }

                temp.Push(t);
            }


            while (!temp.IsEmpty())
            {
                stack.Push(temp.Pop());
            }

        }

    }
}
