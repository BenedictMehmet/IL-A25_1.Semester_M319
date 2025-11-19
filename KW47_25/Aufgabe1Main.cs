using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW47_25
{
    internal class Aufgabe1Main
    {
        static void Main(string[]args)
        {
            Auto a1 = new Auto();

            Auto a2 = new Auto("BMW", "M3", 2020, 50.000);

            a2.ZeigeInfo();
        }
    }
}
