using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Lessons.Lesson_6
{
    class TaskManager
    {
        static int tableWidth = 73;
        private Process[] localProcesses = null;

        public TaskManager()
        {
            // Load All Local Proccess
            localProcesses = Process.GetProcesses();
        }

        public void ShowAllProccessOfSystem()
        {
            Console.Clear();
            PrintLine();
            PrintRow("Proc. Name", "PID", "Session Name");
            PrintLine();

            foreach (var proc in localProcesses)
            {
                PrintRow(proc.ProcessName, proc.Id.ToString(), ((ServiceType)proc.SessionId).ToString());
                PrintLine();
            }
        }

        public bool KillProcessByIdOrName(string input)
        {
            bool isKilled = false;

            foreach (var proc in localProcesses)
            {
                if (proc.ProcessName.ToLower() == input || proc.Id.ToString() == input)
                {
                    proc.Kill();
                    isKilled = true;
                }
            }

            return isKilled;
        }


        // another method to kill proccess
        // /IM + ProcessName
        // /IM + ProcessID
        private static void KillProcess(string cmd)
        {
            Process.Start("taskkill.exe", cmd);
        }


        // draw table in the console
        static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }
        static void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }
        static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
        private enum ServiceType
        {
            Services = 0,
            Console = 1
        }
    }
}
