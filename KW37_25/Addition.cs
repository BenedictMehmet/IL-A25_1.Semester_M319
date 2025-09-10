using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW37_25
{
    internal class Addition
    {
        static void Main(string[]args)
        {
            int zahl1 = 0;
            int zahl2 = 0;

            //Ich sollte nach zwei Zahlen gefragt werden und diese Zwei Zahlen sollten addiert werden.

            Console.WriteLine("Gib die erste Zahl ein");
            string input1 = Console.ReadLine();
            zahl1 = Convert.ToInt32(input1);

            Console.WriteLine("Gib die zweite Zahl ein");
            string input2 = Console.ReadLine();
            zahl2 = Convert.ToInt32(input2);

            int summe = zahl1 * zahl2;

            Console.WriteLine($"{zahl1} + {zahl2} = {summe}");
        }
    }
}
