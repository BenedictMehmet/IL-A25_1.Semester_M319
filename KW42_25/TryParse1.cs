using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW42_25
{
    internal class TryParse1
    {
        static void Main(string[]args)
        {
            // Ich sollte eine Zahl eingeben und diese Zahl soll mit TryParse kontrolliert werden. Wenn ich ein 
            // Zeichen wie "A" eingebe, dann sollte ein Fehler vorkommen.

            //int zahl;
            string input;
            bool isZahl;

            Console.WriteLine("Gib eine Zahl ein");
            input = Console.ReadLine();

            isZahl = int.TryParse(input, out int zahl);

            if(isZahl)
            {
                Console.WriteLine("Du hast eine Zahl eingegeben");
            } else
            {
                Console.WriteLine("Du hast keine Zahl eingegeben");
            }


        }
    }
}
