using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project
{
    internal class ReadLine
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name = ");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is = " + s);
            
            Console.Write("Enter your new name = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your name = " +a);

            Console.WriteLine(s + a);
            Console.ReadLine();
        }
    }
}
