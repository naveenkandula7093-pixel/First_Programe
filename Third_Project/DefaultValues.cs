using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project
{
    internal class DefaultValues
    {
        static void Main(string[] args)
        {
            int i = default(int); // 0

            Console.Write(i);

            float f = default(float);// 0
            Console.Write(f +"\n");

            
            decimal d = default(decimal);// 0
            Console.Write(d);
            
            bool b = default(bool);// false
            Console.Write(b +"\n");
            
            char c = default(char);// ''
            Console.Write(c + "\n");

            // C# 7.1 onwards
            int i2 = default; // renamed to avoid CS0128
            Console.Write(i2 + "\n");

            float f2 = default;
            Console.Write(f2 + "\n");

            decimal d2 = default;
            Console.Write(d2 + "\n");

            bool b2 = default;
            Console.Write(b2 + "\n");

            char c2 = default;
            Console.Write(c2 + "\n");

            Console.ReadLine();


        }
    }
}
