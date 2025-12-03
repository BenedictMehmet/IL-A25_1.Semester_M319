using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW36_25
{
    internal class KonvertierungsTypen
    {
        static void Main(string[]args)
        {
            // string -> int
            string input = "40";
            // 1. Möglichkeit
            int number = int.Parse(input);
            // 2. Möglichkeit
            int number1 = Convert.ToInt32(input);

            Console.WriteLine(number + " / " + number1);


            // int -> string
            int zahl = 99;
            string zahltoString = zahl.ToString();
            Console.WriteLine(zahltoString);



            // double -> int
            double Preis = 9.75;
            int gerundet = (int)Preis;
            Console.WriteLine(gerundet);


            // bool -> string
            bool isLearning = true;
            string boolText = isLearning.ToString();
            Console.WriteLine(boolText);


            // string -> bool
            string textBool = "true";
            bool parsedBool = bool.Parse(textBool);
            Console.WriteLine(parsedBool);


            // string -> char
            string buchstabe = "A";
            char c = char.Parse(buchstabe);
            Console.WriteLine(c);


            /* Aufgabe: string zu double
         * 
         * 1. Erstelle eine string Variable mit einer Zahl (z. B. "12.34").
         * 2. Wandle den string in ein double um.
         * 3. Gib den Wert auf der Konsole aus.
         */


            string input1 = "12.34";
            // 1. Möglichkeit
            double stringToDouble = Convert.ToDouble(input1);
            // 2. Möglichkeit
            double stringToDouble1 = double.Parse(input1);

            Console.WriteLine(stringToDouble + " " + stringToDouble1);

        }
    }
}
