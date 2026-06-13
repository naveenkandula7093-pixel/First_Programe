using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b,c;

            Console.Write("Enter first number: ");
            if (!int.TryParse(Console.ReadLine(), out a))
                a = 0;

            Console.Write("Enter second number: ");
            if (!int.TryParse(Console.ReadLine(), out b))
                b = 0;
            c = a - b;
            Console.WriteLine("Sum is = " + c);
            Console.ReadLine();

            


        }
    }
}
