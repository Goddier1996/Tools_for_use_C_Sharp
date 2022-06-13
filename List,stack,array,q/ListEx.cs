using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.CollectionsLib;


namespace List_stack_array_q
{
    class ListEx
    {

        public static Node<T> AddAboveHead<T>(Node<T> head, T data)
        {
            Node<T> tmp = new Node<T>(data, head);
            return tmp;
        }

        public static void InsertAft<T>(Node<T> ptr, T data)
        {
            Node<T> elmnt = new Node<T>(data);
            elmnt.SetNext(ptr.GetNext());
            ptr.SetNext(elmnt);
        }

        public static Node<T> DeleteAft<T>(Node<T> ptr)
        {
            Node<T> t = ptr.GetNext();            //Save the ptr to the "item to be deleted"
            ptr.SetNext(ptr.GetNext().GetNext());  //The Actual Delete
            t.SetNext(null);                       //Erase links to the list in the deleted item
            return ptr.GetNext();                  //return the ptr to the next item
        }

        public static Node<T> Delete<T>(Node<T> h, Node<T> ptr)
        {
            Node<T> s = h;
            while (s.GetNext() != ptr) { s = s.GetNext(); }  //Find the BEFORE ptr
            return DeleteAft<T>(s);                          //use the previous Method
        }

        public static Node<T> Delete1st<T>(Node<T> head)
        {
            Node<T> t = head;
            head = head.GetNext();
            t.SetNext(null);
            return head;
        }

        public static void Print<T>(Node<T> h)
        {
            Node<T> s = h;
            while (s != null) { Console.WriteLine(s.GetInfo()); s = s.GetNext(); }
        }

        public static int Count<T>(Node<T> h)
        {
            int count = 0;
            Node<T> s = h;

            while (s != null) { count++; s = s.GetNext(); }
            return count;
        }

        public static int Sum(Node<int> h)
        {
            int sum = 0;
            Node<int> s = h;

            while (s != null) { sum = sum + s.GetInfo(); s = s.GetNext(); }
            return sum;
        }

        public static Node<T> Fetch<T>(Node<T> h, int k)
        {
            Node<T> s = h;

            while ((s != null) && (k > 0)) { k--; s = s.GetNext(); }
            return s;
        }

        public static Node<T> FetchLast<T>(Node<T> h)
        {
            Node<T> s = h;
            if (s != null)  //--> Count(h) > 0 --> Search for last. 
                            //Otherwise --> empty list --> return null
            {
                while (s.GetNext() != null)
                {
                    s = s.GetNext();
                }
            }
            return s;
        }

        public static Node<T> AddBelowTail<T>(Node<T> h, T data)
        {
            Node<T> s = FetchLast<T>(h);
            Node<T> t = new Node<T>(data, null); //the new item will be last --> points to null

            //non empty list --> new item added at bottom. same head:
            if (s != null) { s.SetNext(t); return h; }
            else { return t; }                    //Empty list --> t is head   
        }

        public static bool IsSortedUp(Node<int> h)
        {
            bool sorted = true;
            int a = h.GetInfo();               //Assumes at least 1 element in list
            int b = 0;
            Node<int> s = h;
            s = s.GetNext();

            while (sorted && (s != null))       //Go over list - till violation
            {
                b = s.GetInfo();               //Get next b
                if (a > b) { sorted = false; } //compares a pair of consequtives a <--> b
                a = b;                         //b - becomes the new - a
                s = s.GetNext();
            }
            return sorted;
        }

        public static void sort(Node<int> head)
        {

            Node<int> curr = head;
            bool sorted = false;

            while (!sorted)
            {
                sorted = true;
                curr = head;

                while (curr.GetNext() != null)
                {
                    if (curr.GetNext().GetInfo() > curr.GetInfo())
                    {
                        swap(curr, curr.GetNext());
                        sorted = false;
                    }

                    curr = curr.GetNext();
                }
            }
        }
        public static void swap(Node<int> a, Node<int> b)
        {

            int temp = a.GetInfo();
            a.SetInfo(b.GetInfo());
            b.SetInfo(temp);
        }
 

    }
}
