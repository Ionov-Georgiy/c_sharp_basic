using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex1a(); //1a) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
            Ex1b(); //1b) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
            Ex2();  //2) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран
            Ex3();  //3) Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
        }

        public static void Ex1a()
        {
            Console.WriteLine("Задание 1 (a)");
            Console.WriteLine("Демонстрация метода вычитания в структуре сложных чисел.");

            StructComplex complex1;
            Console.WriteLine("Введите действительную часть первого комплексного числа");
            while (!Double.TryParse(Console.ReadLine(), out complex1.re))
            {
                Console.WriteLine("Вы ввели неверное число, повторите ввод!");
            }
            Console.WriteLine("Введите мнимую часть первого комплексного числа");
            while (!Double.TryParse(Console.ReadLine(), out complex1.im))
            {
                Console.WriteLine("Вы ввели неверное число, повторите ввод!");
            }

            StructComplex complex2;
            Console.WriteLine("Введите действительную часть второго (вычитаемого) комплексного числа");
            while (!Double.TryParse(Console.ReadLine(), out complex2.re))
            {
                Console.WriteLine("Вы ввели неверное число, повторите ввод!");
            }
            Console.WriteLine("Введите мнимую часть второго (вычитаемого) комплексного числа");
            while (!Double.TryParse(Console.ReadLine(), out complex2.im))
            {
                Console.WriteLine("Вы ввели неверное число, повторите ввод!");
            }

            StructComplex complex3 = complex1.Minus(complex2);
            Console.WriteLine("Результат:");
            Console.WriteLine($"{complex1.ToString()} - {complex2.ToString()} = {complex3.ToString()}");
        }

        public static void Ex1b()
        {
            Console.WriteLine("Задание 1 (b)");
            Console.WriteLine("Демонстрация методов вычитания и умножения в классе сложных чисел.");

            double inputRe;
            double inputIm;

            Console.WriteLine("Введите действительную часть первого комплексного числа");
            while (!Double.TryParse(Console.ReadLine(), out inputRe))
            {
                Console.WriteLine("Вы ввели неверное число, повторите ввод!");
            }
            Console.WriteLine("Введите мнимую часть первого комплексного числа");
            while (!Double.TryParse(Console.ReadLine(), out inputIm))
            {
                Console.WriteLine("Вы ввели неверное число, повторите ввод!");
            }
            ClassComplex complex1 = new ClassComplex(inputRe, inputIm);

            Console.WriteLine("Введите действительную часть второго (вычитаемого) комплексного числа");
            while (!Double.TryParse(Console.ReadLine(), out inputRe))
            {
                Console.WriteLine("Вы ввели неверное число, повторите ввод!");
            }
            Console.WriteLine("Введите мнимую часть второго (вычитаемого) комплексного числа");
            while (!Double.TryParse(Console.ReadLine(), out inputIm))
            {
                Console.WriteLine("Вы ввели неверное число, повторите ввод!");
            }
            ClassComplex complex2 = new ClassComplex(inputRe, inputIm);

            ClassComplex complex3 = complex1.Minus(complex2);
            Console.WriteLine("Результат:");
            Console.WriteLine($"{complex1.ToString()} - {complex2.ToString()} = {complex3.ToString()}");

            ClassComplex complex4 = complex1.Multiply(complex2);
            Console.WriteLine("Результат:");
            Console.WriteLine($"{complex1.ToString()} - {complex2.ToString()} = {complex4.ToString()}");
        }

        public static void Ex2()
        {

            Console.WriteLine("Введите целое число:");
            string input = Console.ReadLine();
            int inputNumber;
            int sum = 0;

            while (input != "0")
            {
                if (Int32.TryParse(input, out inputNumber))
                {
                    if (inputNumber % 2 != 0)
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

        public static void Ex3()
        {
            Console.WriteLine("Задание 3");
            Console.WriteLine("Демонстрация методов класса дробных чисел.");

            Console.WriteLine("Дробное1 = 3|4");
            Console.WriteLine("Дробное2 = 8|9");
            Fractions fract1 = new Fractions(3, 4);
            Fractions fract2 = new Fractions(8, 9);

            Fractions plusResult = fract1.Plus(fract2);
            Console.WriteLine($"3|4 + 8|9 = {plusResult.ToString()}");

            Fractions minusResult = fract1.Minus(fract2);
            Console.WriteLine($"3|4 - 8|9 = {minusResult.ToString()}");

            Fractions multiplyResult = fract1.Multiply(fract2);
            Console.WriteLine($"3|4 * 8|9 = {multiplyResult.ToString()}");

            Fractions devideResult = fract1.Divide(fract2);
            Console.WriteLine($"3|4 / 8|9 = {devideResult.ToString()}");
        }
        struct StructComplex
        {
            public double im;
            public double re;
            
            public string ToString()
            {
                return re + "+" + im + "i";
            }

            public StructComplex Minus(StructComplex x)
            {
                StructComplex y;
                y.im = im - x.im;
                y.re = re - x.re;
                return y;
            }

        }

    }

}
