using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project
{
    internal class Percentage
    {
        static void Main(string[] args)
        {
            float p; int a;
            Console.WriteLine("Enter a value");
            a = Convert.ToInt32(Console.ReadLine());
            p = ((float)a / 600) * 100;
            Console.Write(p);
            Console.ReadLine();


        }
    }
}
