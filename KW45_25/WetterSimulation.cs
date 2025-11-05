using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW45_25
{
    internal class WetterSimulation
    {
        static void Main(string[]args)
        {
            Wetter w = new Wetter();

            w.RunSimulation();
        }
    }



    class Wetter
    {

        public int days;

        public Random random = new Random();

        public Wetter()
        {
            Console.WriteLine("Wie viele Tage sollen simuliert werden?");
            days = int.Parse(Console.ReadLine());
        }


        public void RunSimulation()
        {
            // Array für die Temperaturen pro Tag
            int[] temperatur = new int[days];

            // mögliche Wetterbedingungen
            string[] möglicheBedingungen = { "Sonnig", "Bewölkt", "Regen", "Schneefall" };

            // Array für die zufällig gewählte Wetterbedingungen
            string[] wetterBedingungen = new string[days];


            // Schleife, das durch alle Tage durchgeht
            for (int i = 0; i < days; i++)
            {
                // Zufällige Temperatur zwischen -10 und 40 Grad
                temperatur[i] = random.Next(-10, 41);

                // Wetterbedingung zufällig auswählen
                // Ganz am Anfang wird an der 0. Stelle von der Liste wetterBedingungen eine zufällig gewählte möglicheBedingung gespeichert
                wetterBedingungen[i] = möglicheBedingungen[random.Next(möglicheBedingungen.Length)];
            }

            double durschnitt = DurschnittBerechnen(temperatur);

            // Ergebnisse ausgeben

            Console.WriteLine($"Wetterbericht für {days} Tage");
            Console.WriteLine($"Durchschnitttemperatur: {durschnitt:F2} Celcius");
            Console.WriteLine($"Höchste Temperatur: {temperatur.Max()}");
            Console.WriteLine($"Tiefste Temperatur: {temperatur.Min()}");
            Console.WriteLine($"Häufiste Wetterlage {FindeHäufigsteBedingung(wetterBedingungen)}");
        }


        private double DurschnittBerechnen(int[] temperaturen)
        {
            double summe = 0;

            for (int i = 0; i < temperaturen.Length; i++)
            {
                summe += temperaturen[i];
            }

            double durschnitt = summe / temperaturen.Length;
            return durschnitt;
        }

        private string FindeHäufigsteBedingung(string[] bedingungen)
        {
            int zähler = 0; // Zählt, wie oft die Bedingung vorkommt
            string häufigste = bedingungen[0]; // Startwert (erste Bedingung)

            // Äussesrste Schleife: prüft jedes Element einmal
            for (int i = 0; i < bedingungen.Length; i++)
            {
                int tempZähler = 0; // Zählt Vorkommen der aktuellen Bedingung


                for (int j = 0; j < bedingungen.Length; j++)
                {
                    if (bedingungen[j] == bedingungen[i])
                    {
                        tempZähler++;
                    }
                }

                if(tempZähler > zähler)
                {
                    zähler = tempZähler;
                    häufigste = bedingungen[i];
                }

            }

            return häufigste;
        }











    }
}
