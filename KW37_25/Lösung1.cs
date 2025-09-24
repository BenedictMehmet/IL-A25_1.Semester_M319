using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW37_25
{

    // AUFGABE 1:
    // Erzeuge zwei Zufallszahlen zwischen 1 und 100.
    // Vergleiche die Zahlen:
    //    Wenn die erste grösser ist -> gib aus: "Die erste Zahl ist grösser."
    //    Wenn die zweite grösser ist -> gib aus: "Die zweite Zahl ist grösser."
    //    Wenn beide gleich sind -> gib aus: "Die Zahlen sind gleich."


    internal class Lösung1
    {
        static void Main(string[]args)
        {

            Random zufallZahl = new Random();

            int zahl1 = zufallZahl.Next(1, 101);
            int zahl2 = zufallZahl.Next(1, 101);


            if (zahl1 > zahl2)
            {
                Console.WriteLine("Die erste Zahl ist grösser.");
            }
            else if (zahl1 < zahl2)
            {
                Console.WriteLine("Die zweite Zahl ist grösser.");
            }
            else
            {
                Console.WriteLine("Die Zahlen sind gleich");
            }
        }
    }
}
