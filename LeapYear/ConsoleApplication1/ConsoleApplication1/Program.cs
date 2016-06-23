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

            Console.WriteLine("Welcome Leap Year Programm");
                int year;
            year = int.Parse(Console.ReadLine());


            if ((year % 4 == 0 && year %100 != 0) ||(year % 400== 0))
            {
                Console.WriteLine("Yesss, This is Leap Year");
                
            }
            else
            {
                Console.WriteLine("Noooo, This is Not Leap Yearrrr");
            }




            Console.ReadKey();
        }
    }
}
