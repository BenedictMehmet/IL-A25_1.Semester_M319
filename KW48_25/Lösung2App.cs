using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW48_25
{
    internal class Lösung2App
    {
        static void Main(string[]args)
        {
            Lösung2 b1 = new Lösung2("Drache");

            // public Lösung2 (string autor, int seitenZahl)
            Lösung2 b2 = new Lösung2("Max", 300);

            b1.ZeigeInfo();
            b2.ZeigeInfo();
        }
    }
}
