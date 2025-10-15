using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW42_25
{
    internal class WhileLoop
    {
        static void Main(string[]args)
        {
            int counter = 0;

            while (counter <= 10)
            {
                Console.WriteLine(counter);
                counter++;
            }



            Console.WriteLine();


            bool isGood = true;

            while (isGood)
            {
                Console.WriteLine("Life is good");
                isGood = false;
            }


            Console.WriteLine();

            Console.WriteLine("Stehen bleiben oder gehen?");
            string choice = Console.ReadLine();

            while(choice == "gehen")
            {
                Console.WriteLine("Du willst gehen");
                Console.WriteLine("Willst du wirklich weitergehen?");
                choice = Console.ReadLine();
            }




        }
    }
}
