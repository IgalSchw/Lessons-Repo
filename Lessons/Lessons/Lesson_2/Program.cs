using System;

namespace Lessons
{
    
    class Program
    {
        static void Main(string[] args)
        {
            string strMainInput = string.Empty;
            float avgTemp = 0; // global scope variable

            do
            {

                Console.WriteLine("\nWelcome to the program");
                Console.WriteLine("----------------------\n");
                Console.WriteLine("+ Average temperature - Press 1");
                Console.WriteLine("+ Get current Month - Press 2"); // include question 5 only after entered average temperature
                Console.WriteLine("+ Check the Number - Press 3");
                Console.WriteLine("+ Draw Invoice - Press 4");
                Console.WriteLine("+ Working hours - press 6");

                Console.WriteLine("\n");
                Console.WriteLine("Press Q to exit from the program");
                Console.Write("Your choose:");

                strMainInput = Console.ReadLine();

                bool flag = false;


                switch (strMainInput)
                {
                    case "1":

                        #region question 1

                        string strMaxTemp = string.Empty;
                        string strMinTemp = string.Empty;
                        float maxTemp = 0, minTemp = 0;

                        do
                        {
                            Console.WriteLine("Please enter the max temperature of the day:");
                            strMaxTemp = Console.ReadLine();

                            try
                            {
                                maxTemp = float.Parse(strMaxTemp);
                                flag = false;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Wrong input! Please re-enter the value of temperature");
                                flag = true;
                            }
                        } while (flag);


                        do
                        {
                            Console.WriteLine("Please enter the min temperature of the day:");
                            strMinTemp = Console.ReadLine();

                            try
                            {
                                minTemp = float.Parse(strMinTemp);
                                flag = false;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Wrong input! Please re-enter the value of temperature");
                                flag = true;
                            }
                        } while (flag);

                        avgTemp = (minTemp + maxTemp) / 2;

                        Console.WriteLine("The average temeperature of the day is: " + avgTemp);


                        #endregion
                        Console.WriteLine("*******************************************************");
                        break;

                    case "2": // (include quesion 5 - only after entered the average temperature)

                        #region question 2
                        int inptUserMonth = 0;
                        string strUserInptMonth = string.Empty;

                        do
                        {
                            Console.WriteLine("Please enter the number of current month");
                            strUserInptMonth = Console.ReadLine();

                            try
                            {
                                inptUserMonth = Convert.ToInt32(strUserInptMonth);

                                if (inptUserMonth > 12 || inptUserMonth < 0)
                                    throw new Exception();

                                flag = false;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Wrong input! please re-enter the value of current month");
                                flag = true;
                            }
                        } while (flag);


                        Console.WriteLine("Current month is: " + (Months)inptUserMonth);

                        // Winter months (December, January, February)
                        if (inptUserMonth == 12 || inptUserMonth == 1 || inptUserMonth == 2)
                        {
                            // check temperature
                            if (avgTemp > 0)
                            {
                                Console.WriteLine("It's a rainy winter!");
                                avgTemp = 0; // reset
                            }
                        }

                        #endregion
                        Console.WriteLine("*******************************************************");
                        break;

                    case "3":

                        #region question 3

                        int inptEvenNum = 0;
                        string strInptEvenNum = string.Empty;

                        do
                        {
                            Console.WriteLine("Please enter number to check if it Even number");
                            strInptEvenNum = Console.ReadLine();

                            try
                            {
                                inptEvenNum = Convert.ToInt32(strInptEvenNum);

                                flag = false;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Wrong input! please re-enter the number");
                                flag = true;
                            }
                        } while (flag);


                        if (inptEvenNum % 2 == 0)
                            Console.WriteLine("Yes, {0} is the even number", inptEvenNum);
                        else
                            Console.WriteLine("No! isn't even number");

                        #endregion
                        Console.WriteLine("*******************************************************");
                        break;


                    case "4":
                        #region question 4

                        // very simple solution
                        string currentDate = DateTime.Now.ToShortDateString();
                        string currentTime = DateTime.Now.ToShortTimeString();

                        string BuisName = string.Empty;
                        string BuisTaxNo = string.Empty;
                        string BuisAddress = string.Empty;
                        string BuisTel = string.Empty;

                        string CardPayment = string.Empty; // decimal
                        string CashPayment = string.Empty; // decimal

                        try
                        {
                            Console.WriteLine("Please enter buisness Name: ");
                            BuisName = Console.ReadLine();

                            Console.WriteLine("Please enter buisness tax number: ");
                            BuisTaxNo = Console.ReadLine();

                            Console.WriteLine("Please enter buisness Address: ");
                            BuisAddress = Console.ReadLine();

                            Console.WriteLine("Please enter buisness Tel: ");
                            BuisTel = Console.ReadLine();

                            Console.WriteLine("Please enter sum of card Payment: ");
                            CardPayment = Console.ReadLine();

                            Console.WriteLine("Please enter sum of cash Payment: ");
                            CashPayment = Console.ReadLine();


                            Console.WriteLine("\n\n\n");
                            Console.WriteLine("-----------------------------------------------");
                            Console.WriteLine("-------------" + BuisName + "-------------");
                            Console.WriteLine("-------------" + BuisTaxNo + "-------------");
                            Console.WriteLine("-------------" + BuisAddress + "-------------");
                            Console.WriteLine("-------------" + BuisTel + "-------------");
                            Console.WriteLine("Invoice date and time: " + currentDate + " " + currentTime + "--------");

                            Console.WriteLine("-------------Invoice No.1234-------------------");
                            Console.WriteLine("To: An occasional customer --------------------");
                            Console.WriteLine("Cash: " + CashPayment);
                            Console.WriteLine("Card: " + CardPayment);
                            Console.WriteLine("#####");
                            Console.WriteLine("Total: " + (Convert.ToDecimal(CardPayment) + Convert.ToDecimal(CashPayment)));
                            Console.WriteLine("-----------------------------------------------");
                            Console.WriteLine("\n\n\n");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Wrong input try again!!!!!");
                        }

                        #endregion
                        Console.WriteLine("*******************************************************");
                        break;


                    case "6":
                        #region question 6
                        DaysOfWeek office1 = (DaysOfWeek)0b0111100;
                        DaysOfWeek office2 = (DaysOfWeek)0b1111111;
                        Console.WriteLine($"Working hours of office 1: {office1}");
                        Console.WriteLine($"Working hours of office 2: {office2}");

                        #endregion
                        Console.WriteLine("*******************************************************");
                        break;

                        break;
                                        
                    case "q":
                        // exit from program
                        break;

                    default:

                        Console.WriteLine("***Wrong user input, please try again***");
                        break;
                }

            } while (strMainInput.ToLower() != "q");
        }
    }

    [Flags]
    enum DaysOfWeek
    {
        Sunday = 0b0000001,
        Monday = 0b0000010,
        Tuesday = 0b0000100,
        Wednesday = 0b0001000,
        Thursday = 0b0010000,
        Friday = 0b0100000,
        Saturday = 0b1000000
    }

    enum Months
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12
    }
}
