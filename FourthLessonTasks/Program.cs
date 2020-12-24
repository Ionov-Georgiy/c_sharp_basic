using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FourthLessonTasks.ArrayClassLibrary;

namespace FourthLessonTasks
{
    class Program
    {
        static void Main(string[] args)
        {

            //1) Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно. Заполнить случайными числами.  Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.
            FirstTask();
            // 2) а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив определенного размера и заполняющий 
            //массив числами от начального значения с заданным шагом. Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, 
            //возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),  метод Multi, 
            //умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов.
            SecondTask();

        }

        static void FirstTask()
        {

            short[] arr = new short[20];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (short)rand.Next(-10000, 10000);
            }
            int counter = 0;
            string str = "";
            for(int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] % 3 == 0 && arr[i+1] % 3 != 0)
                {
                    str += arr[i] + " и " + arr[i+1] + "; ";
                    counter++;
                }
                else if(arr[i] % 3 != 0 && arr[i + 1] % 3 == 0)
                {
                    str += arr[i] + " и " + arr[i + 1] + "; ";
                    counter++;
                }
            }
            Console.WriteLine(str);
            Console.WriteLine("Итого: " + counter);
            Console.ReadKey();
        }

        static void SecondTask()
        {
            Random rand = new Random();
            double from = 1d;
            double to = rand.Next(1, 100);
            int step = rand.Next(1, 10);

            Console.WriteLine("От: "+from+" До: "+to+" Шаг: "+step+"; ");

            ArrayClass nwArCls = new ArrayClass(from, to, step);
            Console.WriteLine("Итог: \n" + nwArCls.ToString());
            Console.WriteLine("Количество элементов: " + nwArCls.Sum);
            int[] invertedArr = nwArCls.Inverse();
            string invertedArrInString = "";
            foreach(int i in invertedArr)
            {
                invertedArrInString += i + "; ";
            }
            Console.WriteLine("Инвертированный: \n" + invertedArrInString);
            Console.WriteLine("Старый не поменялся: \n" + nwArCls.ToString());
            int factor = rand.Next(1, 100);
            nwArCls.Multi(factor);
            Console.WriteLine("Множитель: " + factor);
            Console.WriteLine("Итог: \n" + nwArCls.ToString());
            Console.WriteLine("MaxCount: " + nwArCls.MaxCount);
            Console.ReadKey();

        }

    }
}
