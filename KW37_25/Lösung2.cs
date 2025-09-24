using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW37_25
{
    // AUFGABE 2:
    // Deklariere zwei Variablen "punkteSpieler" und "punkteComputer" in int.
    // Addiere jeweils einen Wert (z.B. 5 oder 10 Punkte) dazu.
    // Prüfe danach:
    //    Wenn punkteSpieler >= 50 -> gib aus: "Spieler hat gewonnen!"
    //    Wenn punkteComputer >= 50 -> gib aus: "Computer hat gewonnen!"
    //    Sonst -> gib aus: "Noch keiner hat gewonnen."


    internal class Lösung2
    {
        static void Main(string[] args)
        {

            int punkteSpieler = 40;
            int punkteComputer = 45;


            punkteSpieler += 10;
            punkteComputer += 5;


            Console.WriteLine($"Spielerpunkte {punkteSpieler}");
            Console.WriteLine($"Spielerpunkte {punkteComputer}");


            if (punkteSpieler >= 50)
            {
                Console.WriteLine("Spieler hat gewonnen");
            }
            else if (punkteComputer >= 50)
            {
                Console.WriteLine("Computer hat gewonnen");
            }
            else
            {
                Console.WriteLine("Niemand hat gewonnen");
            }




        }
    }
}
