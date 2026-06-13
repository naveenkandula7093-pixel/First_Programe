using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace First_Programe
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            //Step_1:-IdentifyandDeclarethevariables
            int Length,Breadth,Area,Perimeter;
            //Step_2:-Accept therequireddatafromtheuser
            Console.Write("EntertheLength=");
            Console.Write("EntertheBreadth=");
            Length = Convert.ToInt32(Console.ReadLine());
            Breadth = Convert.ToInt32(Console.ReadLine());
            //Step_3:-Performtherequiredcalculation
            Area = Length * Breadth;
            Perimeter = 2 * (Length + Breadth);
            //Step_4:-Print therequireddatatotheuser
            Console.WriteLine("Areais=" + Area);
            Console.WriteLine("Perimeteris=" + Perimeter);
            Console.ReadLine();
        }

    }

}

