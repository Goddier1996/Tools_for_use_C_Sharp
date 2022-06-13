using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.CollectionsLib;

namespace List_stack_array_q
{
    class Two_ListEx
    {

        // פעולה שמחזירה את המצביע החדש לקצה השמאלי של השרשרת 
        public static BinTreeNode<int> AddFromLeft(BinTreeNode<int> left, int element)
        {

            BinTreeNode<int> newNode = new BinTreeNode<int>(element);

            left.SetLeft(newNode);
            newNode.SetRight(left);

            return newNode;
        }

        // פעולה שמכניסה איבר לאמצע השרשרת
        public static void AddFromCenter(BinTreeNode<int> centerNum, int element)
        {

            BinTreeNode<int> newNode = new BinTreeNode<int>(element);
            BinTreeNode<int> temp = centerNum.GetRight();

            centerNum.SetRight(newNode);
            newNode.SetRight(temp);
            temp.SetLeft(newNode);
            newNode.SetLeft(centerNum);
        }

        // פעולה שמדפיסה את השרשרת מצד שמאל לצד ימין
        public static void PrintLeftToRight(BinTreeNode<int> left)
        {
            Console.Write(left.GetLeft() + "  ");

            while (left != null)
            {
                Console.Write(left.GetInfo() + "  ");
                left = left.GetRight();
            }


            //if (left != null) //רקורסיה
            //{
            //    Console.Write(left.GetInfo() + "  ");
            //    PrintLeftToRight(left.GetRight());
            //}
        }

        // פעולה שמדפיסה את השרשרת מצד ימין לצד שמאל
        public static void PrintRightToLeft(BinTreeNode<int> Right)
        {
            Console.Write(Right.GetRight() + "  ");

            while (Right != null)
            {
                Console.Write(Right.GetInfo() + "  ");
                Right = Right.GetLeft();
            }

            //if (Right != null) //רקורסיה
            //{
            //    Console.Write(Right.GetInfo() + "  ");
            //    PrintRightToLeft(Right.GetLeft());
            //}
        }


    }
}
