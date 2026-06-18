using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project
{
    internal class SubjectWisemarks
    {
        static void Main(string[] args)
        {
            Double telugu, hindi, english,maths, scient, social; 
            
            Double TotalPercentage,AVG;

            Console.WriteLine("Enter telugu Marks");
            telugu = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter hindi Marks");
            hindi = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter english Marks");
            english = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter  maths Marks");
            maths = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter scient Marks");
            scient = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter social Marks");
            social = Convert.ToDouble(Console.ReadLine());

            TotalPercentage = ((telugu + hindi + english + maths + scient + social) / 600) * 100;

            Console.WriteLine(TotalPercentage);

            AVG = (telugu + hindi + english + maths + scient + social) / 6;

            Console.WriteLine(AVG);
            Console.ReadLine();


        }
    }
}
