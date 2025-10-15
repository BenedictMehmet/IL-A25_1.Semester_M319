using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW42_25
{
    internal class DoWhile2
    {
        static void Main(string[]args)
        {
            int geheimZahl = 7;

            int tipp;

            do
            {
                Console.WriteLine("Rate eine Zahl zwischen 1 - 10");
                tipp = int.Parse(Console.ReadLine());

                if(tipp < geheimZahl)
                {
                    Console.WriteLine("Zahl zu klein");
                }
                else if(tipp > geheimZahl)
                {
                    Console.WriteLine("Zahl zu gross");
                }
            }

            while (tipp != geheimZahl);

            Console.WriteLine("Richtig geraten");

        }
            
    }
}
