using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLessonTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
            SumPosOddNumb();

            //4. Реализовать метод проверки логина и пароля. 
            //На вход метода подается логин и пароль. На выходе истина, 
            //если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
            //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
            //программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
            CheckAut();

            //6. *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
            //«Хорошим» называется число, которое делится на сумму своих цифр. 
            //Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
            CountGoodNumbers();

            //7. 
            //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
            Console.WriteLine("Введите число a:");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b:");
            int b = Int32.Parse(Console.ReadLine());
            aToBRec(a, b);
            //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
            Console.WriteLine("Сумма чисел от a до b:");
            Console.WriteLine(aToBSumRec(a, b));
            Console.ReadLine();

        }

        private static int aToBRec(int a, int b)
        {
            while (a < b)
            {
                Console.WriteLine(a);
                a++;
                a = aToBRec(a, b);
            }
            return a;
        }

        private static int aToBSumRec(int a, int b)
        {
            int sum = a;
            if (a < b)
            {
                sum += aToBSumRec(++a, b);
            }
            return sum;
        }

        private static void CountGoodNumbers()
        {
            DateTime startDate = DateTime.Now;
            long sum = 0;
            for(int i = 1; i <= 1000000000; i++)
            {
                int numbLength = i.ToString().Length;
                if(i % numbLength == 0)
                {
                    sum += i;
                }
            }
            DateTime endDate = DateTime.Now;
            int sec = endDate.Subtract(startDate).Seconds;
            Console.WriteLine("Сумма всех хороших чисел от 1 до 1 000 000 000:");
            Console.WriteLine(sum);
            Console.WriteLine("Время затраченное на подсчет:");
            Console.WriteLine($"{sec} секунд.");
            Console.ReadLine();
        }

        private static void SumPosOddNumb()
        {
            Console.WriteLine("Введите целое число:");
            string input = Console.ReadLine();
            int inputNumber;
            int sum = 0;

            while (input != "0")
            {
                if (Int32.TryParse(input, out inputNumber))
                {
                    if(inputNumber % 2 != 0)
                    {
                        sum += inputNumber;
                    }
                }
                else
                {
                    Console.WriteLine($"Введенное значение не получилось преобразовать в Int32 ({input})!");
                    Console.WriteLine("Введите целое число:");
                    input = Console.ReadLine();
                    continue;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Сумма введенных нечетных чисел:");
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        private static void CheckAut()
        {
            int counter = 0;
            do
            {
                counter++;
                Console.WriteLine("Введите логин:");
                string login = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                string pass = Console.ReadLine();
                if(Aut(login, pass))
                {
                    Console.WriteLine("Добро пожаловать!");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    Console.WriteLine("Ошибка авторизациивф!");
                    Console.ReadKey();
                }
            } while (counter < 3);
            Console.WriteLine("Ваша учетная запись была заблокирована!");
            Console.ReadKey();
        }

        private static bool Aut(string login, string pass)
        {
            if (login == "root" && pass == "GeekBrains") return true;
            return false;
        }

    }
}
