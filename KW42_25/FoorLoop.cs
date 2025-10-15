using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW42_25
{
    internal class FoorLoop
    {
        static void Main(string[]args)
        {

            /*
             * 1. Zuerst ein Datentyp deklarieren. int i = 0;
             * 2. Regel festlegen. Bis wohin soll die Schleife durchlaufen?
             * 3. Wie oft soll die Schleife durchlaufen
             * 4. In der Konsole anzeigen
             */


            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("I is: " + i);
            }

            Console.WriteLine();

            for(int i = 10; i >= 0; i--)
            {
                Console.WriteLine("I is: " + i);
            }



        }
    }
}
