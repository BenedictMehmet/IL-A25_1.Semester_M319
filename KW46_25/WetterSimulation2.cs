using IL_A25_1.Semester_M319.KW37_25;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW46_25
{
    internal class WetterSimulation2
    {
        static void Main(string[]args)
        {

        }
    }




    class Wetter1
    {
        //Datentyp deklarien, dass die Anzahl Tage angezeigt werden kann.
        public int days;

        // Zufallszahlgenerator codieren. Ich brauche die Bibliothek dazu
        public Random r = new Random();

        public Wetter1()
        {
            Console.WriteLine("Wie viele Tage sollen simuliert werden?");
            days = int.Parse(Console.ReadLine());
        }

        // Hauptmethode für die Simulation
        public void RunSimulation()
        {
            // Array für tägliche Temperaturen.
            int[] temperatur = new int[days];

            // Mögliche Wetterbedingungen
            string[] möglicheBedingungen = {"Sonnig", "Bewölk", "Regen", "Schnee" };

            // Array für die zufällig gewählten Wetterbedingungen der einzelnen Tage
            string[] wetterBedingungen = new string[days];


            // Schleife, die für jeden Tag eine Temperatur und eine mögliche Wetterbedingung zufällig generiert
            for (int i = 0; i < days; i++)
            {
                // zufällige Temperatur zwischen -10 und 40 grad
                temperatur[i] = r.Next(-10, 41);

                // Zufällige Auswahl einer Wetterbedingung aus der Liste der möglichen Wetterbedingungen
                wetterBedingungen[i] = möglicheBedingungen[r.Next(möglicheBedingungen.Length)];
            }


            double durschnitt = DurchschnittBerrechnen(temperatur);


            Console.WriteLine($"{FindeHäufigsteBedingung(wetterBedingungen)}");
        }

        private double DurchschnittBerrechnen(int[] berechnen)
        {
            double sum = 0;

            // Alle Temperature aufsummieren
            for(int i = 0; i < berechnen.Length; i++)
            {
                sum += berechnen[i];
            }

            // Durschnitt berechnen (Summe / Anzahl Werte)
            double durschnitt = sum / berechnen.Length;
            return durschnitt;
        }
        

        // Recherchiert diese Methode zu Hause. Zeile für Zeile. Was kann es sein und warum?

        private string FindeHäufigsteBedingung(string[] bedingungen)
        {
            int zähler = 0;
            string häufigste = bedingungen[0]; // Erste Wetterbedingung im Array


            // Äussere Schleife: prüft jede Bedingung
            for (int i = 0; i < bedingungen.Length; i++)
            {
                int tempZähler = 0;

                // Innere Schleife: vergleicht die aktuelle Bedingungen mit allen anderen
                for (int j = 0; j < bedingungen.Length; j++)
                {
                    if (bedingungen[j] == bedingungen[i])
                    {
                        tempZähler++;
                    }
                }

                if (tempZähler > zähler)
                {
                    zähler = tempZähler;
                    häufigste = bedingungen[i];
                }
            }

            return häufigste;
        }


    }
}
