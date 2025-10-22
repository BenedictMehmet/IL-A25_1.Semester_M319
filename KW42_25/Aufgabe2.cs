using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW42_25
{

    // =========================
    // Aufgabe 2: While-Loop
    // =========================
    // Schreibe ein Programm, das den Benutzer wiederholt nach einer Zahl fragt,
    // bis der Benutzer eine Zahl grösser als 100 eingibt.
    // Zähle, wie viele Versuche der Benutzer gebraucht hat, und gib diese Zahl aus.
    // Ich sollte eine Zahl eingeben und kein Zeichen. Bei einem Zeichen sollte ein Fehler aufzeigen.

    internal class Aufgabe2
    {
        static void Main(string[] args)
        {
            
            int Versuche = 0;
            int tipp = 0;
            string input;
            bool isZahl;

            while(tipp <= 100)
            {
                Console.WriteLine("Gib eine Zahl ein");
                input = Console.ReadLine();

                isZahl = int.TryParse(input, out tipp);

                if(isZahl)
                {
                    Versuche++;
                }
                else
                {
                    Console.WriteLine("Das ist keine gültige Zahl");
                }
            }
            Console.WriteLine($"Du hattest {Versuche} Versuch(e) gebraucht");
        }
    }
}
