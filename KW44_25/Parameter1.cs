using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW44_25
{
    internal class Parameter1
    {
        static void Main(string[]args)
        {
            ForParameter f = new ForParameter();

            f.WriteSomething();

            Console.WriteLine();

            Console.WriteLine("Gib dein Name ein: ");
            string myName = Console.ReadLine();

            f.MyStringMethod(myName);

        }
    }



    class ForParameter
    {
        public void WriteSomething()
        {
            Console.WriteLine("I am writing something");
        }

        public void MyStringMethod(string myName)
        {
            Console.WriteLine("My Name is: " + myName);
        }
    }

}
