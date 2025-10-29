using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW43_25
{
    internal class Aufgabe2
    {
        // =============================================
        // Übung 2: Array-Summen-Berechnung
        // - Erstelle ein Array mit 5 Zahlen
        // - Berechne die Summe aller Zahlen
        // - Finde die grösste Zahl im Array
        // - Zeige alle Zahlen, Summe und Maximum an
        // =============================================

        static void Main(string[]args)
        {
            //               0   1  2   3  4   5
            int[] zahlen = { 22, 6, 7, 10, 20, 30 };

            int summe = 0;

            int grössteZahl = zahlen[0];

            // Zählt die Indexes in einer Liste
            Console.WriteLine(zahlen.Length);

            // Schleife, der durch alle Zahlen durchgeht
            // Zahlen.lenght  = 6
            // i = 0. Es startet bei 22
            // Weil i kleiner als 6 ist, wird summe + 22 gerechnet und in summe gespeichert
            for (int i = 0; i < zahlen.Length; i++ )
            {
                summe += zahlen[i];
           
            // Dank for Loop geht zahlen[i] in der Liste durch und gibt mir die grösste Zahl
            if (zahlen[i] > grössteZahl)
                {
                grössteZahl = zahlen[i];
                }
            }


            Console.WriteLine($"Summe aller Zahlen: {summe}");
            Console.WriteLine($"Die grösste Zahl ist: {grössteZahl}");
        }
    }
}
