using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.CollectionsLib;

namespace List_stack_array_q
{
    class Two_List_function
    {


        public static void LeftAndRight() // הוספת מספר חדש לצד שמאל ברשימה 

        {
            BinTreeNode<int> right = new BinTreeNode<int>(2);  // ימין
            BinTreeNode<int> middle = new BinTreeNode<int>(5); // אמצע
            BinTreeNode<int> left = new BinTreeNode<int>(3);   // שמאל


            // פוינטרים ימין לשמאל
            left.SetLeft(null);
            left.SetRight(middle);
            middle.SetLeft(left);
            middle.SetRight(right);
            right.SetLeft(middle);
            right.SetRight(null);


            Console.WriteLine("show list Before change :");
            Two_ListEx.PrintLeftToRight(left);

            Console.WriteLine("\n\n\n\t\t\tshow new list after add new number :");
            //פונקציה מוסיפה מספר חדש לרשימה לצד שמאל
            Two_ListEx.AddFromLeft(left, 16);


            Console.WriteLine("\nshow print list: Left to Right");
            //הדפסת רשימה מ שמאל לימין
            Two_ListEx.PrintLeftToRight(left);


            Console.WriteLine("\n\nshow print list: Right to Left");
            //הדפסת רשימה מ ימין לשמאל
            Two_ListEx.PrintRightToLeft(right);

        }

        public static void CreateChains() // הוספה לרשימה 20 מספרים דרך לולאה
        {

            BinTreeNode<int> newNumber = new BinTreeNode<int>(0);

            BinTreeNode<int> Right = newNumber;//מצביעה עבור הדפסת מימין 


            for (int i = 0; i < 20; i++)//הכנסת לרשימה 20 מספרים
            {
                Two_ListEx.AddFromLeft(newNumber, i + 1);

                newNumber = newNumber.GetLeft(); //קידום
            }


            Console.WriteLine("show print list: Right to Left");
            Two_ListEx.PrintRightToLeft(Right); //הדפסת רשימה מימין לשמאל


            Console.WriteLine("\nshow print list: Left to Right");
            Two_ListEx.PrintLeftToRight(newNumber);//הדפסת רשימה משמאל לימין

        }

        public static void addNumberToCenter()// הוספת מספר לאמצע של הרשימה
        {

            BinTreeNode<int> newNumber = new BinTreeNode<int>(0);

            BinTreeNode<int> NumCenter = null;


            for (int i = 0; i < 5; i++)
            {
                Two_ListEx.AddFromLeft(newNumber, i + 1);

                if (i == 3)
                {
                    NumCenter = newNumber; // שמירת האמצע
                }

                newNumber = newNumber.GetLeft(); //קידום
            }

            Two_ListEx.AddFromCenter(NumCenter, 100); // קריאה לפונקציה שמכניסה מספר לאמצע השרשרת

            Two_ListEx.PrintLeftToRight(newNumber); // הדפסה של הפונקציה שמדפיסה  את השרשרת מצד שמאל לימין
        }


    }
}
