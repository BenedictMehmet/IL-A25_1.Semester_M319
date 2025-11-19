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

            
            Console.WriteLine($"Durschnittstemperatur ist: {durschnitt}");
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



            string[] möglicheBedingungen = { "Sonnig", "Bewölk", "Regen", "Schnee" };
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


/*
Die erste for-Schleife beginnt mit dem ersten Element in bedingungen.Length.
Sie nimmt die erste Option in der Liste als Ausgangspunkt.

Dann startet die zweite for-Schleife und durchsucht von Index 0 aus jedes Wort in der Liste.
Immer wenn ein Wort dem aktuellen Element entspricht (demjenigen an Index i,
also dem Startwert), wird tempCount erhöht.

Nach dieser Überprüfung kommt die letzte if-Abfrage zum Zug.
Wenn tempCount grösser ist als count, dann wird dieser Wert count zugewiesen
und die aktuelle Wetterbedingung wird häufigste zugeteilt.
Das Element conditions[i] wird aus der oben erwähnten Schleife entnommen,
da es genau diese Wetterbedingung aus der Liste ausliest.

Nun folgt die zweite Runde. Das heisst, der nächste Index, also 1, wird gewählt.
Zunächst ändert sich nichts.
Dann läuft die nächste for-Schleife.
Angenommen count ist 3 und der neue tempCount ist kleiner als 3,
dann wird die letzte if-Abfrage nicht ausgeführt.

Die erste for-Schleife beginnt mit dem ersten Element in conditions.Length.
Sie nimmt die erste Option in der Liste als Ausgangspunkt.

Dann startet die zweite for-Schleife und durchsucht von Index 0 aus jedes Wort in der Liste.
Immer wenn ein Wort dem aktuellen Element entspricht (demjenigen an Index i,
also dem Startwert), wird tempCount erhöht.

Nach dieser Überprüfung kommt die letzte if-Abfrage zum Zug.
Wenn tempCount grösser ist als count, dann wird dieser Wert count zugewiesen
und die aktuelle Wetterbedingung wird mostCommon zugeteilt.
Das Element conditions[i] wird aus der oben erwähnten Schleife entnommen,
da es genau diese Wetterbedingung aus der Liste ausliest.

Nun folgt die zweite Runde. Das heisst, der nächste Index, also 1, wird gewählt.
Zunächst ändert sich nichts.
Dann läuft die nächste for-Schleife.
Angenommen count ist 3 und der neue tempCount ist kleiner als 3,
dann wird die letzte if-Abfrage nicht ausgeführt.
*/
