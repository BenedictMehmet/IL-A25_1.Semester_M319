using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW44_25
{
    internal class Methoden1
    {
        static void Main(string[]args)
        {

            function f = new function();

            f.MyFirstMethod();

            int ergebnis = f.Add(5, 12);
            Console.WriteLine("Ergebnis der Addition: " + ergebnis);


        }
    }


    class function
    {
        // Zuerst Modifizierungstyp bestimmen: public, private 
        // Was für ein Datentyp es sein soll: int, string oder kein Datentyp void. Void bedeutet dass es keine Rückgabe gibt
        // Methode bennenen
        // Parameter bestimmen aber nur wenn nötig
        // Methode programmieren, also code schreiben
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        // Void passiert nur einmal und gibt nichts zurück
        public void MyFirstMethod()
        {
            Console.WriteLine("Rufe meine erste Methode auf");
        }

    }
}
