using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW47_25
{
    internal class Aufgabe1
    {
        // Aufgabe:
        // 1. Erstelle eine Klasse deiner Wahl (z.B. Auto, Tier, Buch)
        // 2. Füge der Klasse 4 Properties hinzu (z.B. Name, Alter, Farbe, Preis)
        // 3. Erstelle mindestens zwei Konstruktoren:
        //    - Einen Standardkonstruktor, der Default-Werte setzt
        //    - Einen parametrisierten Konstruktor, der Werte beim Erstellen übernimmt
        // 4. Erstelle Methoden, um die Daten der Klasse auszugeben oder zu bearbeiten // Nicht so viel Zeit verwenden
        // 5. Im Main:
        //    - Erstelle mindestens zwei Objekte der Klasse
        //    - Nutze die Konstruktoren zum Erstellen der Objekte
        //    - Rufe die Properties auf, um Werte zu setzen oder auszulesen
        //    - Zeige die Informationen der Objekte in der Konsole an

    }


    class Auto
    {
        public string Marke { get; set; }
        public string Model { get; set; }
        public int Baujahr { get; set; }
        public double Preis { get; set; }

        public Auto()
        {
            this.Marke = "Default Marke";
            this.Model = "Default Model";
            this.Baujahr = 0;
            this.Preis = 0;
        }

        public Auto(string marke, string model, int baujahr, double preis)
        {
            this.Marke = marke;
            this.Model = model;
            this.Baujahr = baujahr;
            this.Preis = preis;
        }

        public void ZeigeInfo()
        {
            Console.WriteLine($"Marke: {this.Marke} / Model: {this.Model} / Baujahr: {this.Baujahr} / Preis: {this.Preis}");
        }
    }
}
