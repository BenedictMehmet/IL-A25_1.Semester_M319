using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW49_25
{
    /*
           Aufgabe: Einfaches Menü mit do/while

           1. Erstelle ein Programm, das ein Menü anzeigt:
                 1 = Text anzeigen
                 2 = Zufallszahl erzeugen
                 3 = Programm beenden

           2. Verwende eine do/while-Schleife, damit das Menü nach jeder Aktion
              erneut angezeigt wird, bis der Benutzer die Option "3" wählt.

           3. Der Benutzer soll eine Zahl eingeben, um eine Menüoption auszuwaehlen.

           4. Falls eine ungueltige Auswahl gemacht wird, soll eine Fehlermeldung erscheinen.

           Hinweis:
           - Achte darauf, dass die Eingabe als ganze Zahl eingelesen wird.
           */


    internal class DoWhileMenü
    {
        static void Main(string[]args)
        {
            string input;
            bool isZahl;
            int zahl;
            Random zufallsZahl = new Random();

            do
            {
                // Menü anzeigen
                Console.WriteLine($"1 = Text anzeigen / 2 = Zufallszahl erzeugen / 3 = Programm beenden");
                Console.WriteLine("Wähle ein Menüpunkt aus");
                input = Console.ReadLine();
                
                isZahl = int.TryParse(input, out zahl);

                if (!isZahl)
                {
                    Console.WriteLine("Ungültig Eingabe. Gib bitte eine Zahl ein von 1-3");
                }
                else if (zahl == 1)
                {
                    Console.WriteLine("Hier sollte ein Text angezeigt werden");
                }
                else if(zahl == 2)
                {
                    int randomNumber = zufallsZahl.Next(1, 11);
                    Console.WriteLine($"Deine generierte Zahl {randomNumber}");
                }
                else if(zahl == 3)
                {
                    Console.WriteLine("Programm wird beendet");
                }
                else
                {
                    Console.WriteLine("Ungültige Auswahl. Bitte 1,2 oder 3 eingeben");
                }


            }
            // Wenn ich die Zahl 3 eingebe, stimmt die while Regelung nicht mehr und somit wird das Programm beendet.
            // Wenn ich alles ausser 3 eingebe, dann stimmt die while Regelung und die do Schleife wird ausgeführt
            while (zahl != 3);




           
        }












    }
}
