using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLessonTasks
{
    static class StringPausePrintClass
    {
        public static void Print(string str)
        {
            Console.WriteLine(str);
        }

        public static void Pause()
        {
            Console.ReadKey();
        }

        public static void PrintInCenter(string str)
        {
            int bufHeightM = Console.WindowHeight / 2;
            int bufWidthM = Console.WindowWidth / 2 - str.Length / 2;
            Console.SetCursorPosition(bufWidthM, bufHeightM);
            Console.Write(str);
        }

    }
}
