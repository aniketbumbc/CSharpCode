using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2016,6, 23);

            Console.WriteLine("New Date Format");
            Console.WriteLine("First Format is" + date);

            Console.WriteLine(date.ToString("yyyy-mm-dd"));
            Console.WriteLine(date.ToString("mm-yyyy-dd"));
            Console.WriteLine(date.ToString("yyyy-dd-mm"));
            Console.WriteLine(date.ToString("yyyy-m-d"));





            Console.ReadKey();

        }
    }
}
