using System;
using System.Collections.Generic;
using System.Text;
using ExampleLibrary;

namespace Lessons.Lesson_8
{
    class Main8
    {
        const int N = 3;
        const int M = 3;

        static void Main(string[] args)
        {
            int [,] arrSprial = new int[N, M];

            Console.WriteLine("Print before initialzing:");
            PrintSpiral(arrSprial);

            Console.WriteLine("Print after initializing:");
            InitializeSpiralArray(arrSprial);
        }

        private static void InitializeSpiralArray(int [,] arrSpiral)
        {
            int top = 0, bottom = M - 1;
            int left = 0, right = N - 1;

            int counter = 1;

            while (counter <= N * M)
            {
                if (left > right)
                    break;

                for (int i = left; i <= right; i++)
                {
                    arrSpiral[top, i] = counter++;
                }
                top++;

                if (top > bottom)
                    break;

                for (int i = top; i <= bottom; i++)
                {
                    arrSpiral[i, right] = counter++;
                }
                right--;

                if (left > right)
                    break;

                for (int i = right; i >= left; i--)
                {
                    arrSpiral[bottom, i] = counter++;
                }
                bottom--;


                if (top > bottom)
                    break;

                for (int i = bottom; i >= top; i--)
                {
                    arrSpiral[i, left] = counter++;
                }

                left++;
            }
   
            PrintSpiral(arrSpiral);
        }


        private static void PrintSpiral(int [,] arrSpiral)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(arrSpiral[i,j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
