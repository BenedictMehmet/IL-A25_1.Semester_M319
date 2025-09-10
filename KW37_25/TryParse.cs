using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW37_25
{
    internal class TryParse
    {
        static void Main(string[]args)
        {
            // Ich brauche einen string, bool und int Datentypen

            string input;
            bool isZahl;
            int zahl;


            Console.WriteLine("Gib eine Nummer ein");
            input = Console.ReadLine();

            // mit int.TryParse wird es konvertiert. Das was ich eingebe in die Konsole ist in input gespeichert.
            // Das input soll in Zahl umgewandelt werden, darum out zahl
            // Die eingegebene Zahl soll überprüft werden mit einem Bool (Wahr oder Falsch)
            isZahl = int.TryParse(input, out zahl);

            if(isZahl)
            {
                Console.WriteLine("Du hast eine Zahl eingegeben");
            }
            else
            {
                Console.WriteLine("Du hast keine Zahl eingegeben");
            }

        }
    }
}
