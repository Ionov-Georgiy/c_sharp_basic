using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthLessonTasks
{
    //Ионов Георгий

    class Program
    {
        static void Main(string[] args)
        {
            //1) Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
            //Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
            FirstTask();
            //4) **Считайте файл различными способами.Смотрите “Пример записи файла различными способами”. 
            //Создайте методы, которые возвращают массив byte (FileStream, BufferedStream), строку для StreamReader и массив int для BinaryReader.
            //FourthTask();

        }

        public static void FirstTask()
        {
            // Создаем новый делегат и передаем ссылку на него в метод Table
            Console.WriteLine("Таблица функции MyFunc:");
            // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
            Table(new Fun(MyFunc), -2, 2);
            Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
            // Упрощение(c C# 2.0).Делегат создается автоматически.            
            Table(MyFunc, -2, 2);
            Console.WriteLine("Таблица функции Sin:");
            Table(ASinX, 5, -2, 2);      // Можно передавать уже созданные методы
            Console.WriteLine("Таблица функции x^2:");
            // Упрощение(с C# 2.0). Использование анонимного метода
            Table(AXSqRoot, 5, 0, 3);
            Console.WriteLine("Таблица функции x^2 лямбда выражением:");
            // Использование лямбда выражения
            Table((double a, double x) => a * Math.Sqrt(x), 5, 0, 3);
            Console.ReadKey();

        }

        // Описываем делегат. В делегате описывается сигнатура методов, на
        // которые он сможет ссылаться в дальнейшем (хранить в себе)
        public delegate double Fun(double x);
        public delegate double Function(double a, double x);

        // Создаем метод, который принимает делегат
        // На практике этот метод сможет принимать любой метод
        // с такой же сигнатурой, как у делегата
        public static void Table(Fun F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        public static void Table(Function F, double a, double x, double b)
        {
            Console.WriteLine("------- A ------- X ------- Y -------");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", a, x, F(a, x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        // Создаем метод для передачи его в качестве параметра в Table
        public static double MyFunc(double x)
        {
            return x * x * x;
        }

        public static double AXSqRoot(double a, double x)
        {
            return a * Math.Sqrt(x);
        }

        public static double ASinX(double a, double x)
        {
            return a * Math.Sin(x);
        }

        //public static void FourthTask()
        //{
        //    string name = "example.txt";
        //    string txt = "Привет немногопоточность!";
        //    //StreamReader
        //    CreateFile(name, txt);
        //    Console.WriteLine("StreamReader: ");
        //    Console.WriteLine(ReadFileStreamReader());
        //    //BinaryReader
        //    int[] BinaryReaderArr = ReadFileBinaryReader(name, txt + " BinaryReader!");
        //    Console.WriteLine("BinaryReader: ");
        //    //Console.WriteLine(Encoding.Default.GetString(BinaryReaderArr.)
        //    Console.WriteLine(Encoding.Default.GetString(BinaryReaderArr.)
        //}

        public static void CreateFile(string name, string text)
        {
            // запись в файл
            using (FileStream fstream = new FileStream(name, FileMode.Create))
            {
                // преобразуем строку в байты
                byte[] array = Encoding.Default.GetBytes(text);
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
            }
        }

        public static string ReadFileStreamReader()
        {
            string result = "";
            using (StreamReader strRdrd = new StreamReader("example.txt"))
            {
                result = strRdrd.ReadToEnd();
            }
            return result;
        }

        public static int[] ReadFileBinaryReader(string name, string txt)
        {
            int[] result;
            // запись в файл
            using (FileStream fstream = new FileStream(name, FileMode.Create))
            {
                // преобразуем строку в байты
                byte[] array = Encoding.Default.GetBytes(txt);
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
                using (BinaryReader bnrReader = new BinaryReader(fstream))
                {
                    result = new int[bnrReader.BaseStream.Length];
                    int i = 0;
                    while (bnrReader.BaseStream.CanRead)
                    {
                        result[i] = bnrReader.ReadInt32();
                        i++;
                    }
                }
            }

            return result;
        }

        public static byte[] ReadFileFileStream(string name, string text)
        {
            byte[] btArr;
            using (FileStream flStream = new FileStream("example.txt", FileMode.OpenOrCreate))
            {
                btArr = new byte[flStream.Length];
                flStream.Read(btArr, 0, btArr.Length);
            }
            return btArr;
        }

    }
}
