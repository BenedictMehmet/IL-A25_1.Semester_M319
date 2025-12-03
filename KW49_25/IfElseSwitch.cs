using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW49_25
{
    internal class IfElseSwitch
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Wähle ein Tag zwischen 1 - 7 aus");
            string input = Console.ReadLine();

            int tag = int.Parse(input);
            string wochenTag;


            if(tag == 1)
            {
                Console.WriteLine("Montag");
            }

            else if (tag == 2)
            {
                Console.WriteLine("Dienstag");
            }

            else if (tag == 3)
            {
                Console.WriteLine("Mittwoch");
            }

            else if (tag == 4)
            {
                Console.WriteLine("Donnerstag");
            }

            else if (tag == 5)
            {
                Console.WriteLine("Freitag");
            }

            else if (tag == 6)
            {
                Console.WriteLine("Samstag");
            }

            else if (tag == 7)
            {
                Console.WriteLine("Sonntag");
            }

            else
            {
                Console.WriteLine("Ungültiger Tag");
            }

            Console.WriteLine($"Der Tag ist {tag}");



        }
    }
}
