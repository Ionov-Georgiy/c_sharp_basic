using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using str = FirstLessonTasks.StringPausePrintClass;

namespace FirstLessonTasks
{
    class Program
    {
        //Ионов Георгий

        static void Main(string[] args)
        {
            //1) Анкета
            CountIndex();
            //2) Индекс массы тела
            Bmi();
            //3) Расстояния между точками
            double x1 = 3;
            double y1 = 5;
            double x2 = 15;
            double y2 = 21;
            Console.WriteLine(string.Format("Расстояние между точками a({0}, {1}) и b({2}, {3}) равно {4:F}.", x1, y1, x2, y2, DistanceBtwPoints(x1, y1, x2, y2)));
            Console.ReadKey();
            //5) ФИО, город в центре экрана
            PrintNameInCenter();

        }

        static void PrintNameInCenter()
        {
            str.PrintInCenter("Ионов Георгий город Алматы");
            str.Pause();
        }

        static double DistanceBtwPoints(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void Bmi()
        {
            Console.WriteLine("Введите ваш вес в кг:");
            double mass = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ваш рост в м:");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(string.Format("Индекс Вашей массы равен {0}.", Convert.ToInt32(mass / (height * height))));
            Console.ReadKey();
        }

        static void CountIndex()
        {
            Console.WriteLine("Введите ваше имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию:");
            string secondName = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст:");
            string age = Console.ReadLine();
            Console.WriteLine("Вы: " + name + " " + secondName + " Вам: " + age + " лет.");
            Console.WriteLine(string.Format("Вы: {0} {1} Вам: {2} лет.", name, secondName, age));
            Console.WriteLine($"Вы: {name} {secondName} Вам: {age} лет.");
            Console.ReadKey();
        }
    }
}
