using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW45_25
{
    internal class Übung1
    {
        static void Main(string[]args)
        {
            Begrüssen b = new Begrüssen();


            b.BegrüsseDich();


            BegrüsseMich();

        }


        static void BegrüsseMich()
        {
            Console.WriteLine("Hallo, wie geht es ihm?");
        }


    }






    class Begrüssen
    {

        public void BegrüsseDich()
        {
            Console.WriteLine("Hallo, wie geht es dir?");
        }
    }



}
