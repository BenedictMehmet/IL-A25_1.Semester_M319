using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW45_25
{
    // =============================================
    // Übung 6: Regenmengen
    // ---------------------------------------------
    // - Erstelle ein Array mit 7 Werten für die Regenmenge (mm)
    // - Benutzer gibt jeden Wert ein
    // - Berechne die gesamte Regenmenge der Woche
    // - Finde den Tag mit dem meisten Regen
    // - Zeige alle Werte, Gesamtsumme und Maximum an
    // =============================================

    internal class Übung6
    {
        static void Main(string[]args)
        {
            RegenMengen rm = new RegenMengen();

            rm.AnalysiereRegen();
        }
    }


    class RegenMengen
    {
        public void AnalysiereRegen()
        {
            double[] regenMenge = new double[7];

            // 0. 20
            // 1. 
            // 2.
            // 3.
            // 4.
            // ...

            double summe = 0;
            double maximum = 0;
            int TagMax = 0;
          
            // i ist am Anfang bei 0
            // 0 ist kleiner als 7 (regenMenge.Length)
            for (int i = 0; i < regenMenge.Length; i++)
            {
                Console.WriteLine("Regenmenge für Tag " + (i + 1) + " mm: ");
                // Ganz am Anfang bei der Stelle 0 tippe ich mit Console.ReadLine eine Zahl ein.
                regenMenge[i] = Convert.ToDouble(Console.ReadLine());

                summe += regenMenge[i];

                if (regenMenge[i] > maximum)
                {
                    maximum = regenMenge[i];

                }
            }

            Console.WriteLine($"Gesamte Regenmenge: {summe}");
            Console.WriteLine($"Die höchste Regenmenge: {maximum}");


        }
    }
}
