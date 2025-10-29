using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW43_25
{
    internal class Aufgabe3
    {
        // =============================================
        // Übung 3: Notendurchschnitt mit Array
        // - Benutzer gibt Noten für 5 Schüler ein
        // - Noten werden in einem Array gespeichert
        // - Berechne Durchschnitt
        // - Zeige alle Noten und Durchschnitt an
        // =============================================



        static void Main(string[]args)
        {
            double[] noten = new double[5];

            double summe = 0;

            Console.WriteLine("Gib 5 Noten ein: ");
            noten[0] = Convert.ToDouble(Console.ReadLine());
            noten[1] = Convert.ToDouble(Console.ReadLine());
            noten[2] = Convert.ToDouble(Console.ReadLine());
            noten[3] = Convert.ToDouble(Console.ReadLine());
            noten[4] = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < noten.Length; i++)
            {
                summe += noten[i];
            }

            double durchschnitt = summe / noten.Length;

            Console.WriteLine();

            foreach(double note in noten)
            {
                Console.WriteLine(note);
            }

            Console.WriteLine("Durschnitt: " + durchschnitt);


        }
    }
}
