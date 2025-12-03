using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW49_25
{


    /*
     Aufgabe: Gueltige Eingabe pruefen

     1. Erstelle ein Programm, das den Benutzer nach einer Zahl zwischen 1 und 10 fragt.

     2. Verwende eine do/while-Schleife, damit das Programm so lange fragt,
        bis der Benutzer eine Zahl im gültigen Bereich eingibt.

         Verwende hierfür die Try.Parse Methode

     3. Falls die eingegebene Zahl zu tief oder zu hoch ist,
        soll das Programm eine entsprechende Fehlermeldung ausgeben.

     4. Erst wenn der Wert gültig ist, soll eine Erfolgsmeldung erscheinen.

     Hinweis:
     - Achte darauf, dass die Eingabe als ganze Zahl eingelesen wird.
     */
    internal class GültigeEingabeDoWhile
    {
        static void Main(string[] args)
        {
            string input;
            bool isZahl;
            int zahl;

            do
            {
                Console.WriteLine("Bitte gib eine Zahl zwischen 1 - 10 an");
                input = Console.ReadLine();

                isZahl = int.TryParse(input, out zahl);

                if (!isZahl)
                {
                    Console.WriteLine("Ungültig. Bitte gib eine Zahl ein");
                }
                else if (zahl < 1)
                {
                    Console.WriteLine("Die Zahl ist zu klein. Bitte eine Zahl zwischen 1-10 eingeben");
                    isZahl = false;
                }
                else if (zahl > 10)
                {
                    Console.WriteLine("Die Zahl ist zu gross. Bitte eine Zahl zwischen 1-10 eingeben");
                    isZahl = false;
                }

            } while (!isZahl);

            Console.WriteLine($"Super, die Zahl {zahl} ist gültig");


        }

    }
}
