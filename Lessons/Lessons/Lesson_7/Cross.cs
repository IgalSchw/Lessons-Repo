using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Lesson_7
{
    public class Cross
    {
        //const int SIZE_X = 3;
        //const int SIZE_Y = 3;

        //const int SIZE_X = 4;
        //const int SIZE_Y = 4;

        const int SIZE_X = 4;
        const int SIZE_Y = 4;

        static char[,] field = new char[SIZE_Y, SIZE_X];

        public const char PLAYER_DOT = 'X';
        public const char AI_DOT = 'O';
        public const char EMPTY_DOT = '.';

        static Random random = new Random();

        public static void InitField()
        {
            for (int i = 0; i < SIZE_Y; i++)
            {
                for (int j = 0; j < SIZE_X; j++)
                {
                    field[i, j] = EMPTY_DOT;
                }
            }
        }

        public static void PrintField()
        {
            Console.Clear();
            Console.WriteLine("-------");
            for (int i = 0; i < SIZE_Y; i++)
            {
                Console.Write("|");
                for (int j = 0; j < SIZE_X; j++)
                {
                    Console.Write(field[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------");
        }

        public static void SetSym(int y, int x, char sym)
        {
            field[y, x] = sym;
        }

        public static bool IsCellValid(int y, int x)
        {
            if (x < 0 || y < 0 || x > SIZE_X - 1 || y > SIZE_Y - 1)
            {
                return false;
            }

            return field[y, x] == EMPTY_DOT;
        }

        public static bool IsFieldFull()
        {
            for (int i = 0; i < SIZE_Y; i++)
            {
                for (int j = 0; j < SIZE_X; j++)
                {
                    if (field[i, j] == EMPTY_DOT)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static void playerMove()
        {
            int x, y;
            do
            {
                Console.WriteLine("Координат по строке ");
                Console.WriteLine("Введите координаты вашего хода в диапозоне от 1 до " + SIZE_Y);
                x = Int32.Parse(Console.ReadLine()) - 1;
                Console.WriteLine("Координат по столбцу ");
                Console.WriteLine("Введите координаты вашего хода в диапозоне от 1 до " + SIZE_X);
                y = Int32.Parse(Console.ReadLine()) - 1;
            } while (!IsCellValid(y, x));
            SetSym(y, x, PLAYER_DOT);
        }

        private static bool CheckVertical(int y, char sym)
        {
            int countToWin = 0;

            for (int i = 0; i < SIZE_X; i++)
            {
                for (int j = y; j < y + 1; j++)
                {
                    if (field[i, j] == sym)
                    {
                        countToWin++;
                    }
                }
            }
            if (countToWin == SIZE_X || countToWin == SIZE_Y)
                return true;
            else if ((SIZE_X > 3 && SIZE_Y > 3) && (countToWin == SIZE_X - 1 || countToWin == SIZE_Y - 1)) //  *4X4 and greater
                return true;
            else
                return false;
        }

        private static bool checkHorizontal(int x, char sym)
        {
            int countToWin = 0;

            for (int i = x; i < x + 1; i++)
            {
                for (int j = 0; j < SIZE_Y; j++)
                {
                    if (field[i, j] == sym)
                    {
                        countToWin++;
                    }
                }
            }
            if (countToWin == SIZE_X || countToWin == SIZE_Y)
                return true;
            else if ((SIZE_X > 3 && SIZE_Y > 3) && (countToWin == SIZE_X - 1 || countToWin == SIZE_Y - 1)) //  *4X4 and greater
                return true;
            else
                return false;
        }

        public static bool CheckWin(char sym)
        {
            int countToWin = 0;
            int countSecondDiagonal = 0;
           
            for (int i = 0; i < SIZE_X; i++)
            {
                for (int j = 0; j < SIZE_Y; j++)
                {
                    if (CheckVertical(j, sym) == true)
                        return true;

                    // Check diagonal (0,0)...
                    if (i == j)
                    {
                        if (field[i, j] == sym)
                            countToWin++;
                    }
                    // Check second diagonal
                    if (j == SIZE_Y - i - 1)
                    {
                        if (field[i, j] == sym)
                            countSecondDiagonal++;
                    }
                }

                if (checkHorizontal(i, sym) == true)
                    return true;
            }

            if (countToWin == SIZE_X || countToWin == SIZE_Y)
                return true;
            else if ((SIZE_X > 3 && SIZE_Y > 3) && ((countSecondDiagonal == SIZE_X - 1 || countSecondDiagonal == SIZE_Y - 1) || countToWin == SIZE_X - 1 || countToWin == SIZE_Y -1)) //  *4X4 and greater
                return true;

            return false;

            #region hard coded
            /*
            if (field[0, 0] == sym && field[0, 1] == sym && field[0, 2] == sym)
            {
                return true;
            }
            if (field[1, 0] == sym && field[1, 1] == sym && field[1, 2] == sym)
            {
                return true;
            }
            if (field[2, 0] == sym && field[2, 1] == sym && field[2, 2] == sym)
            {
                return true;
            }

            if (field[0, 0] == sym && field[1, 0] == sym && field[2, 0] == sym)
            {
                return true;
            }
            if (field[0, 1] == sym && field[1, 1] == sym && field[2, 1] == sym)
            {
                return true;
            }
            if (field[0, 2] == sym && field[1, 2] == sym && field[2, 2] == sym)
            {
                return true;
            }

            if (field[0, 0] == sym && field[1, 1] == sym && field[2, 2] == sym)
            {
                return true;
            }
            if (field[2, 0] == sym && field[1, 1] == sym && field[0, 2] == sym)
            {
                return true;
            }
            return false;
            */
            #endregion
        }

        public static void AiMove()
        {
            int x, y;
            do
            {
                x = random.Next(0, SIZE_X);
                y = random.Next(0, SIZE_Y);
            } while (!IsCellValid(y, x));
            
            SetSym(y, x, AI_DOT);
        }     
    }
}
