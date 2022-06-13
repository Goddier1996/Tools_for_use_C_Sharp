using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.CollectionsLib;

namespace List_stack_array_q
{
    class List_fuctions
    {

        public static void addItemsList() //add items to list
        {

            Node<int> head = null;


            Console.WriteLine("enter number");

            for (int i = 0; i < 3; i++)
            {
                int x = int.Parse(Console.ReadLine());

                //input 123 output 321
                //head = ListEx.AddAboveHead<int>(head, x);

                // input 123 output 123
                //head = ListEx.AddBelowTail<int>(head, x);

                //ListEx.InsertAft(head, i);
            }

            Console.WriteLine();

            Node<int> tmp = head;

            ListEx.Print(tmp); //print items in list

        }

        public static void deleteItemList()
        {

            Node<int> head = null;


            Console.WriteLine("enter number");

            for (int i = 0; i < 3; i++)
            {
                int x = int.Parse(Console.ReadLine());

                head = ListEx.AddAboveHead<int>(head, x);
            }

            Console.WriteLine();
            Node<int> tmp = head;

            ListEx.Print(tmp); //print items in list


            //ListEx.DeleteAft(head);
            //ListEx.Delete1st(head);
           // ListEx.Delete(head, head); !!!!!!!!!!!!!!!!!!!!!!!!

            Console.WriteLine("\nafter delete items");

            ListEx.Print(tmp); //print items in list

        }//delete items in list

        public static void resFuction()
        {

            Node<int> head = null;


            Console.WriteLine("enter number");

            for (int i = 0; i < 3; i++)
            {
                int x = int.Parse(Console.ReadLine());

                head = ListEx.AddAboveHead<int>(head, x);
            }

            Console.WriteLine("\n====");

            //int z = ListEx.Sum(head);
            //Console.WriteLine("sum " + z);

            //int z = ListEx.Count(head);
            //Console.WriteLine("count " + z);

            //bool z = ListEx.IsSortedUp(head);
            //Console.WriteLine("List sort ? " + z );

            //Node<int> tmp = head;
            //ListEx.FetchLast(tmp);


            //here we sort list

            //Node<int> tmp = head;
            //ListEx.sort(tmp);
            //ListEx.Print(tmp);

        } //sum,cout,fetch,fetchLast list,sort

    }
}
