using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW45_25
{
    // =============================================
    // ÜBUNG 2: Verdopplung einer Zahl (mit Rückgabe)
    // ---------------------------------------------
    // - Erstelle eine Methode "VerdoppleZahl", die eine Zahl entgegennimmt
    // - Verdopple den Wert und gib das Ergebnis zurück
    // - Speichere das Ergebnis in einer Variable in Main
    // - Zeige das Resultat mit Console.WriteLine an
    // =============================================



    internal class Übung2
    {
        static void Main(string[]args)
        {

            Verdopplung v = new Verdopplung();

            v.VerdoppleZahl();


        }
    }




    class Verdopplung
    {
        public int VerdoppleZahl()
        {
            int zahl = 5;
            int summe = zahl * 2;
            Console.WriteLine(summe);
            return summe;
        }
    }
}
