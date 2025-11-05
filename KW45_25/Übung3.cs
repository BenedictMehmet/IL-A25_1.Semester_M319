using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW45_25
{

    // =============================================
    // ÜBUNG 3: Grösste Zahl finden
    // ---------------------------------------------
    // - Erstelle eine Methode "FindeGroessteZahl"
    // - Die Methode soll drei Zahlen entgegennehmen
    // - Bestimme, welche Zahl am grössten ist
    // - Gib die grösste Zahl zurück
    // =============================================



    internal class Übung3
    {
        static void Main(string[]args)
        {

            GrössteZahl z = new GrössteZahl();

            z.GrössteZahlFinden(5, 12,60);


        }
    }






    class GrössteZahl
    {
        public void GrössteZahlFinden(int zahl1, int zahl2, int zahl3)
        {
            // Zuerst wird Zahl1 in grössteZahl gespeichert
            int grössteZahl = zahl1;


            // Wenn die Regel stimmt, wird grössteZahl überschrieben mit Zahl2
            if (zahl2 > grössteZahl)
            {
                grössteZahl = zahl2;
            }


            // Wenn diese Regel stimmt, wird grössteZahl überschrieben mit Zahl3
            if (zahl3 > grössteZahl)
            {
                grössteZahl = zahl3;
            }

            // Am Schluss gebe ich die GrössteZahl zurück
            Console.WriteLine($"Die grösste Zahl ist: {grössteZahl}");
        }
    }
}
