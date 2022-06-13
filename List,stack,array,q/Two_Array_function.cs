using System;
using System.Collections.Generic;
using System.Text;

namespace List_stack_array_q
{
    class Two_Array_function
    {

        public static void return_res()
        {

            const int NUM_CLASSES = 2;
            const int STUDENTS_IN_CLASS = 3;

            int[,] grades = new int[NUM_CLASSES, STUDENTS_IN_CLASS];


            Console.WriteLine($"Please enter grades for students in {NUM_CLASSES} classes:");


            for(int i=0; i < NUM_CLASSES; i++)
            {
                Console.WriteLine($"Please enter grades for {STUDENTS_IN_CLASS}students in class #{i + 1}:");
                 
                for(int x = 0; x < STUDENTS_IN_CLASS; x++)
                {
                    grades[i, x] = int.Parse(Console.ReadLine());
                }
            }

            //Two_ArrayEx.print(grades);

            //Two_ArrayEx.sum(grades);

        }

        public static void ex_project()
        {

            string[,] show = new string[3, 5] { //סעיף 1
                {"name: Coachella","| Artist: Beyonce","| Price: 450","| Ticket: Regular ticket","| Genre: contemporay R&B" },
                {"name: Coachella","| Artist: Beyonce","| Price: 850","| Ticket: vip ticket","| Genre: contemporay R&B" }
               ,{"name: Coachella","| Artist: Beyonce","| Price: 1250","| Ticket: gold ticket ","pop" }};

            int[] sumTicket = new int[0];//סעיף 2

            bool exitCase = false;//עם הערך גדול מהתפריט
            bool Exit = false;//עם לוחצים על 6 שיצא מהתפריט

            do
            {
                Console.WriteLine("\n1.\tshow all live concerts\n2.\tshow all live concerts for a genre\n3.\tAdd a new concert\n4.\tBuy concert\n5.\tGet total sales\n6.\tExit");
                Console.WriteLine("please enter your choise :");
                int choise = int.Parse(Console.ReadLine());

                switch (choise)
                {
                    case 1: Console.Clear(); ShowTicket(show); break;//מציג את ההופעות

                    case 2: //בחירת סוג מוסיקה
                        Console.Clear(); Console.WriteLine("please enter Genre");
                        string Gener = Console.ReadLine(); Genre(show, Gener);
                        break;

                    case 3://הוספת מופעה
                        Console.Clear();
                        Console.WriteLine("concert name: ");
                        string nameConcert = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Artist name: ");
                        string nameArtist = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Price: ");
                        string Price = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Ticket type: ");
                        string TicketType = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Genre type: ");
                        string GenreType = Console.ReadLine();
                        Console.WriteLine();

                        Addconcert(show, nameConcert, nameArtist, Price, TicketType, GenreType);//הפעלת פונקציה

                        break;

                    case 4: Console.Clear(); BuyConcertTicket(show); break;//קניית כרטיס ולאחר מכן מחיקה

                    case 5: break;

                    case 6://יציאה מהתפריט


                        break;

                    default:
                        Console.WriteLine("invalid input,try Agin");
                        break;
                }

            } while (exitCase != true);


            ///////////////////////////////////////////////////        פונקציות      ///////////////////////////////////////////////////////////

            static void ShowTicket(string[,] show)//מציג את ההופעות
            {
                Console.WriteLine("\t\t\t\t\t\tCencert");
                Console.WriteLine();

                for (int i = 0; i < show.GetLength(0); i++)
                {
                    Console.WriteLine($"cencert {i + 1} :");

                    for (int x = 0; x < show.GetLength(1); x++)
                    {
                        Console.Write($"{show[i, x]}");
                    }
                    Console.WriteLine();
                }
            }

            static void Genre(string[,] show, string Gener)//סוג מוסיקה
            {
                int index = -1;

                for (int i = 0; i < show.GetLength(0); i++)
                {
                    for (int x = 0; x < show.GetLength(1); x++)
                    {
                        if (show[i, 4] == Gener)//עם מערך במילה 4 שווה שסוג מוסיקה תציג
                        {
                            Console.WriteLine("we have this Gener :)");

                            for (x = 0; x < show.GetLength(1); x++)
                            {
                                Console.Write($"{show[i, x]}");
                            }
                            index = x;
                            break;
                        }
                    }
                }
                Console.WriteLine();

                if (index == -1)//עם לא קיים במערך תציג את ההודעה הזאת
                {
                    Console.WriteLine("we don't have this Gener!");
                }
            }

            static void Addconcert(string[,] show, string nameConcert, string nameArtist, string praice, string TicketType, string GenreType)//הוספת הופעה חדשה
            {
                int index = -1;

                for (int i = 0; i < show.GetLength(0); i++)
                {
                    for (int z = 0; z < show.GetLength(1); z++)
                    {

                        if (i < 10)
                        {
                            show[i, 0] += nameConcert;
                            show[i, 1] += nameArtist;
                            show[i, 2] += praice;
                            show[i, 3] += TicketType;
                            show[i, 4] += GenreType;

                            index = z;
                            break;
                        }

                    }
                }

                if (index == -1)//עם לא קיים במערך תציג את ההודעה הזאת
                {
                    Console.WriteLine("we don't have more place!");
                }
            }

            static void BuyConcertTicket(string[,] show)//בחירת הופעה ומחיקה אותו הופעה
            {
                int index = -1;

                Console.WriteLine("\t\t\t\t\t\tCencert");
                Console.WriteLine();

                for (int i = 0; i < show.GetLength(0); i++)//להציג את רשימה של כרטיסים
                {
                    Console.WriteLine($"cencert {i + 1} :");

                    for (int x = 0; x < show.GetLength(1); x++)
                    {
                        Console.Write($"{show[i, x]}");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\nPlease enter number concert: ");//קליטה מהשמתמש כרטיס למחיקה
                int numConcert = int.Parse(Console.ReadLine());


                for (int i = 0; i <= show.GetLength(0); i++)
                {
                    for (int x = 0; x < show.GetLength(1); x++)
                    {
                        if (numConcert == i)
                        {
                            Array.Clear(show, x, 5);//מחיקה
                            Console.WriteLine("Concert ticket successfully sold!");
                            index = i;
                            break;
                        }
                    }
                }

                if (index == -1)
                {
                    Console.WriteLine("Not a valid concert number!");
                }
            }


        }

      

    }
}
