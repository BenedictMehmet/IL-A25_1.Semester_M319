using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW43_25
{
    internal class Array
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 1;
            int num3 = 2;
            int num4 = 3;
            int num5 = 4;
            int num6 = 5;

            // Speicher 10 Zahlen in die Liste "nummer"
            int[] nummer = new int[10];
            /*
                0.
                1.
                2. 20
                3.
                4.
            */

            nummer[2] = 20;
            nummer[0] = 55;
            nummer[1] = 44;
            nummer[3] = 80;

            // Geht nicht, da ausserhalb des Bereichs (Es sind nur 10 Positionen verfügbar)
            //nummer[12] = 19;

            Console.WriteLine(nummer[3]);


            // Eine andere Möglichkeit ein Array zu erstellen. Es startet bei Position 0. Die 1 ist bei Position 0 gesetzt.

            int[] myArray = new int[] {1, 2, 3, 4, 5, 6 };
            Console.WriteLine(myArray[3]);

            Console.WriteLine();

            // Zuerst Datentyp bestimmen. Dann eine Bezeichnung einfügen. Später codieren, wo du das holen willst (in welchem Array?)
            // Die Bezeichnung in der Konsole mit console.WriteLine ausgeben!
            foreach (int allesAusgeben in myArray)
            {
                Console.WriteLine("Zahl: " + allesAusgeben);
            }

        } 
    }
}
