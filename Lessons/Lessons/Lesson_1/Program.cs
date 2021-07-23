using System;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {

            string UserName = string.Empty;
            string dtToday = DateTime.Now.ToShortDateString();

            Console.WriteLine("Please enter your user name:");
            UserName = Console.ReadLine();
            
            Console.WriteLine("Hello, {0} , today is {1}", UserName, dtToday);


            Console.ReadKey();
        }
    }
}
