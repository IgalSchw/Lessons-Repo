using Lessons.Lesson_5;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {

            // write into startup.txt file 
            WriteInLog("Start  " + DateTime.Now.ToString());
            // 1.
            string UserInput = string.Empty;

            Console.Write("Please enter some text: ");
            UserInput = Console.ReadLine();
            WriteInTxtFile(UserInput);
            Console.WriteLine("The data is Saved into txt file!");


            //3.
            UserInput = string.Empty;
            int num = 0;


            do
            {
                Console.WriteLine("Please enter integer number between 0-255 and -1 for exit");
                UserInput = Console.ReadLine();

                try
                {
                    num = Convert.ToInt32(UserInput);

                    if (num > 255 || num < 0)
                        throw new Exception();
                    else
                    {
                        CreateAppendInBinaryFile(num);
                    }
                }
                catch (Exception ex)
                {
                    if (num != -1)
                        Console.WriteLine("Wrong input! please try again");
                }
            }
            while (num != -1);

            Console.WriteLine("The data is Saved into Binary file!");
            Console.WriteLine(Environment.NewLine);

            //4.
            Employee[] EmployeeArray = new Employee[5]    {new Employee("Ivanov Ivan", "Engineer", "ivivan@mailbox.com", "892312312", 80000, new DateTime(1989, 9,30)),
                                                           new Employee("Arkadi rad", "Support", "arkadi@mailbox.com", "892312312", 50000, new DateTime(1992, 9,30)),
                                                           new Employee("Daria shultz", "Programmer", "daria@mailbox.com", "892312312", 120000, new DateTime(1996, 9,30)),
                                                           new Employee("Meni evdokimov", "Product Manager", "meni@mailbox.com", "892312312", 90000, new DateTime(1964, 9,30)),
                                                           new Employee("Arthur Pirashkov", "Consultant", "arthur@mailbox.com", "892312312", 30000, new DateTime(1988, 9,30)) };


            foreach (var employee in EmployeeArray)
            {
                // older than 40
                if (employee.CalcualteAge(employee.BirthDate) > 40)
                {
                    // print details
                    employee.GetDetails();
                }
            }

            WriteInLog("End  " + DateTime.Now.ToString());



            // delete files
            //DeleteTxtFile();
            //DeleteStartupFile();
        }

        private static void WriteInTxtFile(string UserInput)
        {
            // write in text file if not exist create one
            File.WriteAllText(FileNames.txtFile, UserInput);
        }

        private static void WriteInLog(string now)
        {
            File.AppendAllText(FileNames.startUpFile,now + "\n"); // instead \n can write Enviroment.NewLine
        }

        private static void CreateAppendInBinaryFile(int num)
        {
           BinaryWriter binWriter = null;

            if (!File.Exists(FileNames.BinaryFile))
                binWriter = new BinaryWriter(new FileStream(FileNames.BinaryFile, FileMode.OpenOrCreate));
            else
                binWriter = new BinaryWriter(new FileStream(FileNames.BinaryFile, FileMode.Append));


           binWriter.Write(num);

           binWriter.Close();
        }
        
        
        private static void DeleteTxtFile()
        {
            File.Delete(FileNames.txtFile);
        }
        
        private static void DeleteStartupFile()
        {
            File.Delete(FileNames.startUpFile);
        }
    }
}
