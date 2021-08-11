using Lessons.Lesson_6;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;


namespace Lessons
{
    class Program
    {        
        static void Main(string[] args)
        {            
            string userInput = string.Empty;

            do
            {
                TaskManager taskManager = new TaskManager();
                taskManager.ShowAllProccessOfSystem();

                Console.WriteLine("Please enter the Name or ID of proccess to kill or -1 to Exit");
                userInput = Console.ReadLine();

                // exit from the program
                if (userInput.Trim() == "-1")
                {
                    continue;
                }
                else
                {
                    if (taskManager.KillProcessByIdOrName(userInput.ToLower()) == false)
                    {
                        Console.WriteLine("Process Not found please try again, please enter any key to continue");
                        Console.ReadKey();
                    }
                }

            } while (userInput != "-1");


            ////Wrong size
            string[,] strArr = new string[5, 4] { {"1","2","3","4"},
                                                  {"1","2","3","4"},
                                                  {"1","2","3","4"},
                                                  {"1","2","3","4"},
                                                  {"1","2","3","4"}};



            //// wrong Data
            //string[,] strArr = new string[4, 4] { {"1","2","3","4"},
            //                                      {"1","2","3","4"},
            //                                      {"1","2","3","4"},
            //                                      {"1","2","3","s"}};

            try
            {
                Console.WriteLine("The sum of array: " + CheckArray(strArr));
            }
            catch (MyArraySizeException ex)
            {
                Console.WriteLine(ex.msg);
            }
            catch (MyArrayDataException ex)
            {
                Console.WriteLine("Wrong value in cell[" + ex.i + "," + ex.j+ "]");
            }
        }

      

        
        // Exceptions
        private static int CheckArray(string[,] strArray)
        {
            // X
            int x = strArray.GetLength(0);
            // Y
            int y = strArray.GetLength(1);

            int sum = 0;
          
             if (x > 4 || y > 4)
               throw new MyArraySizeException("Wrong size of array must be 4X4");
           
             for (int i = 0; i < x; i++)
             {
                 for (int j = 0; j < y; j++)
                 {
                    try
                    {
                        sum += Int32.Parse(strArray[i, j]);
                    }
                    catch (Exception ex)
                    {
                        throw new MyArrayDataException(i, j);
                    }
                 }
             }

            return sum;
        }
    }
 }
