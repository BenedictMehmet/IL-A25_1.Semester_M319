using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW37_25
{
    internal class ZufallsZahl
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int randomNumber = random.Next(1, 11);

            Console.WriteLine("Gib eine Zahl von 1-10 an");
            string input = Console.ReadLine();

            int number = Convert.ToInt32(input);

            if (number == randomNumber)
            {
                Console.WriteLine("Du hast die Zahl richtig erraten");
            }
            else
            {
                Console.WriteLine($"Du hast es falsch erraten. Die richtige Zahl ist: {randomNumber}");
            }



        }
    }
}
