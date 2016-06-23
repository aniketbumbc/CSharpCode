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

            Console.WriteLine("Which Number is bigeer");

            int a;
            int b;

            a = int.Parse(Console.ReadLine());
            b= int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Number is A is bigger");

            }
            else
            {
                Console.WriteLine("Number is B is bigger");

            }






            Console.ReadKey();


        }
    }
}
