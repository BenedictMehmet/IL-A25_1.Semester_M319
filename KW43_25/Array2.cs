using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW43_25
{
    internal class Array2
    {
        static void Main(string[]args)
        {
            int[,] array2DDecleration = new int[3, 3];
            
            //    0   1   2
            // 0 [0] [0] [0]
            // 1 [0] [0] [5]
            // 2 [0] [9] [0]

            array2DDecleration[1, 2] = 5;
            array2DDecleration[2, 1] = 9;

            Console.WriteLine(array2DDecleration[1,2]);
            Console.WriteLine(array2DDecleration[2,1]);

            Console.WriteLine();


            // Jede Klammer ist eine Zeile
            // Innerhalb einer Zeile sind zwei Spalten
            int[,] Beispiel2 = { {1,2}, { 3,4}, { 5,6} };

            //    0   1   
            // 0 [1] [2]
            // 1 [3] [4]
            // 2 [5] [6]


            Console.WriteLine();

            string[] days = { "Monday", "Tuesday" , "Wendnesday", "Tuesday", "Friday" };

            foreach(string day in days)
            {
                Console.WriteLine(day);
            }
        }
    }
}
