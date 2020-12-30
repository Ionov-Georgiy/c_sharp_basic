using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace FirstTask
{
    class Program
    {
        static string Main(string[] args)
        {
            StringWriter cnslText = new StringWriter();
            Console.SetOut(cnslText);
            Type dtType = typeof(DateTime);
            foreach(PropertyInfo pi in dtType.GetProperties())
            {
                Console.WriteLine(pi.Name);
            }
            string cnsTxt = cnslText.ToString();
            return cnsTxt;
        }
    }
}
