using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW47_25
{
    internal class CustomerApp
    {
        static void Main(string[]args)
        {
            // Objektinstanz von der Klasse customer erstellen
            Customer f = new Customer();

            Console.WriteLine($"{f.Name1}, {f.Number1}, {f.Adress1}");


            Customer a = new Customer("Max");
            Console.WriteLine($"{a.Name1}, {a.Number1}, {a.Adress1}");


            Customer b = new Customer("Bob", "Talstrasse", 847484);
            Console.WriteLine($"{b.Name1}, {b.Number1}, {b.Adress1}");


            Customer z = new Customer(83453);





        }
    }
}
