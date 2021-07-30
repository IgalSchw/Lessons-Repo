using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Lesson_3
{
    class Program
    {
        const int N = 3;
        const int M = 3;


        /* 1 */
        static void Main(string[] args)
        {
            int[,] TwoDimArray = new int[N, M];

            Console.WriteLine($"Please enter values {N} X {M} array:");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    int val = 0;

                    try
                    {
                        val = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)

                    {
                        Console.WriteLine("Please try agian!");
                        j--;
                        continue;
                    }

                    TwoDimArray[i, j] = val;
                }
            }

            Console.WriteLine("Diagonal of the array:");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (i == j)
                    {
                        Console.Write(TwoDimArray[i, j]);
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }



        /* 2 */

        //static void Main(string[] args)
        //{
        //    string[,] arrContacts = new string[5, 2] {
        //        { "Igor","0526504354"},
        //        { "Anton","Anton@yahoo.com"},
        //        { "Ekaterina","Ek47Gmail.com"},
        //        { "Sam","Sam@one.co.il"},
        //        { "David","+972526987456"}};

        //    for (int i = 0; i < arrContacts.GetLength(0); i++)
        //    {
        //        Console.WriteLine("Name:" + arrContacts[i,0] + ", Email/Phone:" + arrContacts[i,1]);
        //    }
        //}






        /* 3 */

        //static void Main(string[] args)
        //{

        //    Console.WriteLine("Please enter some text: ");

        //    string inputStr = Console.ReadLine();

        //    Console.WriteLine("The reverse string of input: ");

        //    for (int i = inputStr.Length -1;i>=0; i--)
        //    {
        //        Console.Write(inputStr[i]);
        //    }

        //}




        /* 4 */

        //static void Main(string[] args)
        //{
        //    const int xBoard = 10;
        //    const int yBoard = 10;

        //    // hard coded
        //    char[,] arrBoard = new char[xBoard, yBoard] {
        //        { 'X', 'X' , 'X', 'X' ,  'X', 'X' ,  'X', 'X' ,  'X', 'X' },
        //        { 'X', 'X' , 'X', 'X' ,  'X', 'X' ,  'X', 'X' ,  'X', 'X' },
        //        { 'X', 'X' , 'X', 'X' ,  'X', 'X' ,  'X', 'X' ,  'X', 'X' },
        //        { 'X', 'X' , 'X', 'X' ,  'X', 'X' ,  'X', 'X' ,  'X', 'X' },
        //        { 'X', 'X' , 'X', 'X' ,  'X', 'X' ,  'X', 'X' ,  'X', 'X' },
        //        { 'X', 'X' , 'X', 'X' ,  'X', 'X' ,  'X', 'X' ,  'X', 'X' },
        //        { '0', 'X' , 'X', 'X' ,  'X', 'X' ,  'X', 'X' ,  'X', 'X' },
        //        { '0', 'X' , 'X', 'X' ,  'X', 'X' ,  'X', 'X' ,  'X', 'X' },
        //        { '0', 'X' , 'X', 'X' ,  'X', 'X' ,  'X', 'X' ,  'X', 'X' },
        //        { '0', 'X' , 'X', 'X' ,  'X', 'X' ,  'X', 'X' ,  'X', 'X' }
        //   };


        //    // Randomaly
        //    var chars = "X0";
        //    var random = new Random();

        //    for (int i = 0; i < xBoard ; i++)
        //    {
        //        for (int j = 0; j < yBoard; j++)
        //        {
        //            for (int k = 0; k < chars.Length; k++)
        //            {
        //                arrBoard[i,j] = chars[random.Next(chars.Length)];
        //            }              
        //        }
        //    }


        //    for (int i = 0; i < 10; i++)
        //    {
        //        for (int j = 0; j < 10; j++)
        //        {
        //            Console.Write(arrBoard[i, j] + "  ");
        //        }

        //        Console.WriteLine("\n");
        //    }




        //}


    }
}
