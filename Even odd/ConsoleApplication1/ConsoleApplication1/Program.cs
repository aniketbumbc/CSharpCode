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


            Console.WriteLine("Welcome to Even and Odd ");

            int a;
            a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.Write("This is even number");
            }
            else
            {
                Console.Write("This is odd number");
            }

       Console.ReadKey();         

        }
    }
}
