using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW43_25
{
    internal class Aufgabe1
    {
        static void Main(string[]args)
        {
            Random rdm = new Random();

            int spieler = 100;
            int gegner = 100;

            do
            {
                // Im do programmiere ich den Code

                // Zufällig bestimmen, wer angreift
                // 0 = Spieler greift an, 1 = Gegener greift an
                int angreifer = rdm.Next(2);

                // Zufälliger Schaden zwischen 10 und 20
                int schaden = rdm.Next(10, 21);


                // Wenn der Spieler angfreift, denn verliert der Gegner
                // Sonst verliert der Spieler
                if (angreifer == 0)
                {
                    gegner -= schaden; // summe = gegner (100) - schaden (15)
                }
                else
                {
                    spieler -= schaden;
                }
            }
             // Wenn while stimmt, dann führe do wieder aus
            while (spieler > 0 && gegner > 0); // Schleife läuft weiter, bis einer 0 Lebenspunkte hat

            if (spieler <= 0 && gegner <= 0)
            {
                Console.WriteLine("Unentschieden");
            }
            else if (spieler <= 0)
            {
                Console.WriteLine("Gegnere hat gewonnen");
            }
            else 
            {
                Console.WriteLine("Spieler hat gewonnen");
            }
        }
    }
}
