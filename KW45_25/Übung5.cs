using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW45_25
{
    internal class Übung5
    {
        // =============================================
        // Übung 5: Preise im Laden
        // ---------------------------------------------
        // - Erstelle ein Array mit 5 Preisen (double)
        // - Berechne den Gesamtpreis aller Artikel
        // - Berechne den Durchschnittspreis
        // - Zeige alle Preise, Gesamtsumme und Durchschnitt an
        // =============================================

        static void Main(string[]args)
        {
            Artikel a = new Artikel();

            a.ZeigeArtikelPreise();
        }
    }


    class Artikel
    {
        public void ZeigeArtikelPreise()
        {
            double[] Preise = new double[] {3.50, 1.50, 5.50, 6, 8.20 };

            double summe = 0;

            // Alle Artikel durchgehen und zusammen addieren
            foreach(double p in Preise)
            {
                summe += p;
            }

            Console.WriteLine($"Gesamtpreis: {summe}");

            double durchschnitt = summe / Preise.Length;

            Console.WriteLine($"Durschnittpreis ist: {durchschnitt}");

            foreach(double p in Preise)
            {
                Console.WriteLine($"{p} CHF");
            }

        }
    }



}
