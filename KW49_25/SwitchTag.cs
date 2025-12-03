using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW49_25
{
    internal class SwitchTag
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Bitte gib einen Tag zwischen 1 bis 7 ein");
            string input = Console.ReadLine();
            int tag = int.Parse(input);

            string wochenTag;

            switch (tag)
            {
                case 1:
                    wochenTag = "Montag";
                    break;

                case 2:
                    wochenTag = "Dienstag";
                    break;

                case 3:
                    wochenTag = "Mittwoch";
                    break;

                case 4:
                    wochenTag = "Donnerstag";
                    break;

                case 5:
                    wochenTag = "Freitag";
                    break;

                case 6:
                    wochenTag = "Samstag";
                    break;

                case 7:
                    wochenTag = "Sonntag";
                    break;

                default:
                    wochenTag = "Ungültiger Tag. Bitte Zahl zwischen 1 bis 7 eingeben";
                    break;
            }
            Console.WriteLine("Ergebnis" + wochenTag);
        }
    }
}
