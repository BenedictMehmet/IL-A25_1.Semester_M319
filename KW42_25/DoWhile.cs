using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW42_25
{
    internal class DoWhile
    {
        static void Main(string[]args)
        {
            int number;

            do
            {
                Console.WriteLine("Enter a number");
                number = int.Parse(Console.ReadLine());
            }
            while (number < 0);

            Console.WriteLine("Finally");


        }
    }
}
