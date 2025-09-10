using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW37_25
{
    internal class VergleichsOperatoren
    {
        static void Main(string[]args)
        {
            new AlterPrüfen().AltersTest();
            new Temperatur().TemperaturTest();
            new NotenVergleich().NotenTest();
            new ZahlenVergleich().ZahlenTest();
            new VergleichsBeispiele().Test();
        }
    }



    class AlterPrüfen
    {
        public void AltersTest()
        {
            int alter = 18;


            // >= bedeutet grösser oder gleich 18
            if(alter >= 18)
            {
                Console.WriteLine("Du bist volljährig");
            }
            else
            {
                Console.WriteLine("Du bist noch nicht volljährig");
            }
        }
    }




    class Temperatur
    {
        public void TemperaturTest()
        {
            int temperatur = 25;

            // Grösser als 30
            if(temperatur > 30)
            {
                Console.WriteLine("Es ist sehr heiss");
            }
            // Grösser oder gleich 20
            else if (temperatur >= 20)
            {
                Console.WriteLine("Es ist sehr angenehm");
            }
            // Wenn 19 oder unter 19
            else
            {
                Console.WriteLine("Es ist sehr kühl");
            }
        }
    }




    class NotenVergleich
    {
        public void NotenTest()
        {
            int note = 5;

            if (note >= 5)
            {
                Console.WriteLine("Bestanden");
            }
            else
            {
                Console.WriteLine("Nicht bestanden");
            }
        }
    }


    class ZahlenVergleich
    {
        public void ZahlenTest()
        {
            int a = 10;
            int b = 15;

            if (a > b)
            {
                Console.WriteLine("A ist Grösser als B");
            }
            else if (a < b)
            {
                Console.WriteLine("A ist Kleiner als B");
            }
            else
            {
                Console.WriteLine("A und B sind gleich");
            }
        }
    }



    class Monate
    {
        public void MonateTest()
        {
            int Monat = 5;
            string Name;


            // == ist ein Vergleichsoperator und keine Zuweisung
            // = ist eine Zuweisung
            if(Monat == 1) 
            {
                Name = "Januar";
                Monat = 1;
            }
            else if (Monat == 2)
            {
                Name = "Februar";
            }
            else if (Monat == 3)
            {
                Name = "März";
            }
            else
            {
                Name = "Unbekannt";
            }
        }
    }


    class VergleichsBeispiele
    {

        public void Test()
        {
            int zahl1 = 1;
            int zahl2 = 1;

            if(zahl1 != zahl2)
            {
                Console.WriteLine("Die Zahlen sind ungleich");
            }
            else
            {
                Console.WriteLine("Die Zahlen sind gleich");
            }
        }
    }





}
