using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW42_25
{
    internal class AverageCalculator
    {
        static void Main(string[]args)
        {
            int currentScore;
            int sum = 0;
            int counter = 0;
            do
            {
                Console.WriteLine("Enter your students score. Enter -1 to finish");
                currentScore = int.Parse(Console.ReadLine());

                if(currentScore != -1)
                {
                    sum = sum + currentScore;
                    counter++;
                }
            } while (currentScore != -1);

            int average = sum / counter;
            Console.WriteLine(sum);
            Console.WriteLine(counter);
            Console.WriteLine("Averag is: " + average);
        }
    }
}
