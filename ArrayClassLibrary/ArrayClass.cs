using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthLessonTasks.ArrayClassLibrary
{
    public class ArrayClass
    {
        int[] a;
        //  Создание массива и заполнение его одним значением el  
        public ArrayClass(int n, int el)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = el;
        }
        //  Создание массива и заполнение его случайными числами от min до max
        public ArrayClass(int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }
        // Создание массива и заполнение его числами в арифметической последовательности от from до to с шагом step
        public ArrayClass(double from, double to, int step)
        {
            int n = (int)Math.Floor((to - from) / step) + 1;
            a = new int[n];
            int arrElem = (int)from;
            int i = 0;
            while (arrElem <= to)
            {
                a[i] = arrElem;
                arrElem += step;
                i++;
            }
        }

        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }
        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }
        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + "; ";
            return s;
        }

        public int Sum { get { return a.Length; } }

        public int[] Inverse()
        {
            int[] result = new int[a.Length];
            int counter = 0;
            foreach (int elem in a)
            {
                int newElem = 0;
                if (elem != 0)
                {
                    newElem = -elem;
                }
                result[counter] = newElem;
                counter++;
            }
            return result;
        }

        public void Multi(int factor)
        {
            for (int i = 0; i < a.Length; i++)
                a[i] *= factor;
        }

        private int CountСoincidence(int searchingEl)
        {
            int counter = 0;
            for (int i = 0; i < a.Length; i++)
                if (a[i] == searchingEl) counter++;
            return counter;
        }

        public int MaxCount { get { return CountСoincidence(Max); } }

    }
}
