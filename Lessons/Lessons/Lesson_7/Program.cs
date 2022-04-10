using Lessons.Lesson_7;
using System;
using System.IO;
using System.Linq;


namespace Lessons
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // set encoding to console writeline ecoding.utf8
    //        Console.OutputEncoding = System.Text.Encoding.UTF8;
    //        Cross.InitField();            
    //        Cross.PrintField();

    //        do
    //        {
    //            Cross.playerMove();
    //            Console.WriteLine("Ваш ход на поле");
    //            Cross.PrintField();
    //            if (Cross.CheckWin(Cross.PLAYER_DOT))
    //            {
    //                Console.WriteLine("Вы выиграли");
    //                break;
    //            }
    //            else if (Cross.IsFieldFull()) break;
                
    //            Cross.AiMove();
    //            Console.WriteLine("Ход Компа на поле");
    //            Cross.PrintField();
    //            if (Cross.CheckWin(Cross.AI_DOT))
    //            {
    //                Console.WriteLine("Выиграли Комп");
    //                break;
    //            }
    //            else if (Cross.IsFieldFull()) break;
    //        } while (true);
    //        Console.WriteLine("!Конец игры!");
    //    }
    //}
}
