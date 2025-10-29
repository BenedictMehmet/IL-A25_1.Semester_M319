using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW44_25
{
    internal class Methods2
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Gib die erste Zahl ein");
            int zahl1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Gib die zweite Zahl ein");
            int zahl2 = int.Parse(Console.ReadLine());

            Function2 f = new Function2();

            int result = f.AddTwoValues(zahl1, zahl2);

            Console.WriteLine(result);

            f.SubtractTwoValues(zahl1, zahl2);


            // Ich kann void Methoden nicht weiterverwenden und darum geht die Codierung unten nicht auf
            // int result1 = f.AddTwoValues2(zahl1, zahl2);
            f.AddTwoValues2(zahl1, zahl2);

        }
    }




    class Function2
    {
        public int AddTwoValues(int z1, int z2)
        {
            int myResult = z1 + z2;
            Console.WriteLine($"{z1} + {z2} = {myResult}");
            return myResult;
        }

        public int SubtractTwoValues(int z1, int z2)
        {
            int myResult = z1 - z2;
            Console.WriteLine($"{z1} - {z2} = {myResult}");
            return myResult;
        }

        public void AddTwoValues2(int z1, int z2)
        {
            int myResult = z1 + z2;
            Console.WriteLine($"{z1} + {z2} = {myResult}");
        }
    }



}
