using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FifthLessonTasks
{
    class Program
    {

        //Ионов Георгий

        static string message = "Дедуктивный метод решительно представляет собой бабувизм. " +
                                       "Сомнение рефлектирует естественный закон исключённого третьего.. " +
                                       "Согласно мнению известных философов, дедуктивный метод естественно порождает " +
                                       "и обеспечивает мир, tertium nоn datur. Интеллект естественно понимает под собой " +
                                       "интеллигибельный закон внешнего мира внезапный бактерионоситель";

        static void Main(string[] args)
        {

            //1) Создать программу, которая будет проверять корректность ввода логина. 
            //Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, 
            //при этом цифра не может быть первой:
            //a) без использования регулярных выражений;
            TaskFirstA();
            //б) **с использованием регулярных выражений.
            TaskFirstB();
            //Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
            //а) Вывести только те слова сообщения,  которые содержат не более n букв.
            TaskSecondA();
            //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            TaskSecondB();
            //в) Найти самое длинное слово сообщения.
            TaskSecondС();
            //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
            TaskSecondD();

        }

        static void TaskFirstA()
        {
            Console.WriteLine(CheckLogin("testLogin").ToString());
            Console.WriteLine(CheckLogin("-testLogin").ToString());
            Console.WriteLine(CheckLogin("1testLogin").ToString());
            Console.WriteLine(CheckLogin("test4Login").ToString());
            Console.ReadKey();
        }

        static bool CheckLogin(string login)
        {

            if(login.Length < 2 || login.Length > 10)
            {
                return false;
            }
            StringBuilder sb = new StringBuilder(login);
            var result = false;
            for (var i = 0; i < sb.Length; i++)
            {
                if (sb[i] >= 'a' && sb[i] <= 'z')
                    result = true;
                else if (sb[i] >= 'A' && sb[i] <= 'Z')
                    result = true;
                else if (sb[i] >= '0' && sb[i] <= '9')
                    result = true;
                if (!result) return result;
            }
            if(sb[0] >= '0' && sb[0] <= '9')
            {
                return false;
            }
            return true;
        }

        static bool CheckLoginRegex(string login)
        {
            Regex strReg = new Regex(@"^[a-zA-Z][a-zA-Z0-9]{1,9}");
            Match mtch = strReg.Match(login);
            if(login == mtch.Value)
            {
                return true;
            }
            return false;
        }

        static void TaskFirstB()
        {
            Console.WriteLine(CheckLoginRegex("testLogin").ToString());
            Console.WriteLine(CheckLoginRegex("-testLogin").ToString());
            Console.WriteLine(CheckLoginRegex("1testLogin").ToString());
            Console.WriteLine(CheckLoginRegex("test4Login").ToString());
            Console.ReadKey();
        }

        static void TaskSecondA()
        {
            Message nwMessage = new Message(message);
            Console.WriteLine("Слова в которых максимум 5 букв:");
            List<string> listOfWords = nwMessage.GetLesserThanMaxWords(5);
            foreach(string word in listOfWords)
            {
                Console.WriteLine(word+"; ");
            }
            Console.WriteLine("Слова в которых максимум 10 букв:");
            List<string> listOfWords2 = nwMessage.GetLesserThanMaxWords(10);
            foreach (string word in listOfWords2)
            {
                Console.WriteLine(word + "; ");
            }
            Console.ReadKey();
        }

        static void TaskSecondB()
        {
            Message nwMessage = new Message(message);
            Console.WriteLine("Удалённые слова оканчивающиеся на 'т':");
            List<string> listOfWords = nwMessage.RemoveWordsEndsOn('т');
            foreach (string word in listOfWords)
            {
                Console.WriteLine(word + "; ");
            }
            Console.WriteLine("Сообщение после удаления:\n" + nwMessage.ToString());
            Console.ReadKey();
        }

        static void TaskSecondС()
        {
            Message nwMessage = new Message(message);
            Console.WriteLine("Максимально длинное слово:\n" + nwMessage.GetLongestWord());
            Console.ReadKey();
        }

        static void TaskSecondD()
        {
            Message nwMessage = new Message(message);
            Console.WriteLine("Строка из самых длинных слов:\n" + nwMessage.GetStringWithLongestWords());
            Console.ReadKey();
        }

    }
}
