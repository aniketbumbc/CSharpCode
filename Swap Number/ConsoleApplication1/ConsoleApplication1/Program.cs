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
            Console.WriteLine("Swap Number Programm");

            int a;
            int b;
            int temp;
                a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("The Number a is " + a);
            Console.WriteLine ("The Number b is " + b);

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("after swapping Number ");

            Console.WriteLine("The Number a is " + a);
            Console.WriteLine("The Number b is " + b);


            Console.ReadKey();
        }
    }
}
