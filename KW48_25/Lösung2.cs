using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW48_25
{

    // Aufgabe2:
    // 1. Erstelle eine Klasse "Buch"
    // 2. Füge 4 Properties hinzu, z.B. Titel, Autor, Seitenzahl, Verlag
    // 3. Erstelle mindestens zwei Konstruktoren:
    //    - Standardkonstruktor mit Default-Werten
    //    - Parametrisierter Konstruktor, um alle Properties zu setzen
    // 4. Erstelle Methoden, um die Buchinformationen auszugeben oder zu bearbeiten
    // 5. Im Main:
    //    - Erstelle mindestens zwei Objekte mit den verschiedenen Konstruktoren
    //    - Ändere Properties eines der Objekte
    //    - Gib alle Informationen in der Konsole aus

    internal class Lösung2
    {
        public string Titel { get; set; }
        public string Autor { get; set; }
        public int SeitenZahl { get; set; }
        public string Verlag { get; set; }


        public Lösung2(string titel)
        {
            this.Titel = titel;
            this.Autor = "No Name";
            this.SeitenZahl = 0;
            this.Verlag = "No Verlag";
        }

        public Lösung2(string titel, string autor, int seitenZahl, string verlag)
        {
            this.Titel = titel;
            this.Autor = autor;
            this.SeitenZahl = seitenZahl;
            this.Verlag = verlag;
        }

        // Wie sieht der Konstruktor aus, wenn nur der Autor bekannt ist.
        public Lösung2(string autor, int seitenZahl)
        {
            this.Titel = "Unbekannt";
            this.Autor = autor;
            this.SeitenZahl = seitenZahl;
            this.Verlag = "Unbekannt";
        }


        public void ZeigeInfo()
        {
            Console.WriteLine($"Titel: {this.Titel} / Autor: {this.Autor} / Seitenzahl: {this.SeitenZahl} / Verlag: {this.Verlag}");
        }
    }
}
