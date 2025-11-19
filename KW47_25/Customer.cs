using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW47_25
{
    internal class Customer
    {
        //string Name;
        //string Adress;
        //int number;


        //Property ermöglicht einen kontrollierten Zugriff: Ich kann Regeln festlegen.
        // Es wird automatisch ein privates Feld im Hintergrund erstellt
        // Ich kann nur get verwenden und somit wird es nie gesetzt oder verwendet.
        public string Name1 { get; set; }
        public string Adress1 { get; set; }
        public int Number1 { get; set; }

        // Bei Konstruktoren zuerst public und dann Klassenname
        // Standardkonstruktor
        public Customer()
        {
            this.Name1 = "Default Name";
            this.Adress1 = "No Adres";
            this.Number1 = 0;
        }

        // Zweiter Konstruktor. Wird verwendet, wenn alle Infos bekannt sind.
        public Customer(string name, string adres, int number)
        {
            this.Name1 = name;
            this.Adress1 = adres;
            this.Number1 = number;
        }

        // 3. Konstruktor, wenn nur Name bekannt sind.
        public Customer(string name)
        {
            this.Name1 = name;
        }

        public Customer(int number)
        {
            this.Number1 = number;
        }

        public Customer(string adress, int number)
        {
            this.Adress1 = adress;
        }



    }
}
