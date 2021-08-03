using System;
using System.Linq;
using System.Text;

namespace Lessons
{
    /* Check String Builder*/

    class Program
    {
        static void Main(string[] args)
        {

            // 1.
            string[,] arrFLM = new string[3, 3] {
            { "Eli", "Tzuri", "Menahomovich" },
            { "Igor", "Schwartz", "Iosifovich" },
            { "Anton", "brodsky", "Aleksndrovich" }};

            for (int i = 0; i < arrFLM.GetLength(0); i++)
            {
                Console.WriteLine(GetFullName(arrFLM[i, 0], arrFLM[i, 1], arrFLM[i, 2]));
            }

            Console.WriteLine("\n\n");


            // использывания функции кортеж
            var tuple = ("Eli", "Tzuri", "Menahoomovich");
            Console.WriteLine(tuple.Item1 + " " + tuple.Item2 + " " + tuple.Item3);

            tuple = ("Igor", "Schwartz", "Iosifovich");
            Console.WriteLine(tuple.Item1 + " " + tuple.Item2 + " " + tuple.Item3);

            tuple = ("Anton", "brodsky", "Aleksndrovich");
            Console.WriteLine(tuple.Item1 + " " + tuple.Item2 + " " + tuple.Item3);


            Console.WriteLine("\n\n");


            //2.
            string userInput = string.Empty;

            do
            {
                Console.WriteLine("please enter input of user");
                userInput = Console.ReadLine();
                if (GetSumOfNumbers(userInput) > -1)
                    Console.WriteLine("The sum of input numbers is: " + GetSumOfNumbers(userInput));
                else
                    Console.WriteLine("Wrong input!!! please try again.");
            } while (GetSumOfNumbers(userInput) == -1);



            Console.WriteLine("\n\n");


            //3.
            string month = string.Empty;
            int intMonth = 0;

            do
            {
                Console.WriteLine("Please enter the number of month between 1 and 12");
                month = Console.ReadLine();

                try
                {
                    intMonth = Convert.ToInt32(month);
                    Console.WriteLine("The season is: " + GetSeasonName(intMonth));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wrong input! Please try again");
                }
            } while (intMonth < 1 || intMonth > 12);


            Console.WriteLine("\n\n");


            //4. Fibonacci
            Console.WriteLine(Fibonacci(5));


            //5.
            String str1 = " Предложение один Теперь предложение два Предложение три";

            //" Предложение один. Теперь предложение два. Предложение три"

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(StrArrangement(str1));
        }





        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return firstName + " " + lastName + " " + patronymic;
        }

        private static int GetSumOfNumbers(string userInput)
        {
            try
            {
                var numbers = userInput.Split(' ').Select(Int32.Parse).ToList();
                return numbers.Sum();
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        private static Enum GetSeasonName(int month)
        {
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    return Season.Winter;
                case 3:
                case 4:
                case 5:
                    return Season.Spring;
                case 6:
                case 7:
                case 8:
                    return Season.Summer;
                // 9 10 11
                default:
                    return Season.Autumn;
            }
        }

        enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }

        private static int Fibonacci(int n)
        {
            // return 1 of negative number and zero            
            if (n <= 1)
                return 1;

            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        static String StrArrangement(String str1)
        {
            string[] arr = str1.Split(" ");
            StringBuilder strRes = new StringBuilder("");

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].ToLower() == "предложение")
                {
                    if (arr[i] != null)
                    {
                        strRes.Append(arr[i]);
                        strRes.Append(" " + arr[i + 1] + ". ");
                        i++;
                        continue;
                    }
                }
                else
                {
                    strRes.Append(arr[i] + " ");
                }
            }

            return strRes.ToString();
        }

    }
}
