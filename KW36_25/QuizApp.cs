using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW36_25
{
    internal class QuizApp
    {
        static void Main(string[] args)
        {

            string question1 = "Was ist die Hauptstadt von Schweiz?";
            string answer1 = "Bern";


            string question2 = "Was ist 2+2?";
            string answer2 = "4";


            string question3 = "Wie viele Einwohner hat Luzern";
            string answer3 = "3 Millione";


            int score = 0;

            Console.WriteLine(question1);
            string input1 = Console.ReadLine();

            if (answer1 == input1)
            {
                Console.WriteLine("Korrekt");
                score++; // 0 + 1 = 1
            }
            else
            {
                Console.WriteLine($"Falsch, die richtige Antwort ist {answer1}");
            }


            Console.WriteLine(question2);
            string input2 = Console.ReadLine();

            if (answer2 == input2)
            {
                Console.WriteLine("Korrekt");
                score++;
            }
            else
            {
                Console.WriteLine($"Falsch, die richtige Antwort ist {answer2}");
            }


            Console.WriteLine(question3);
            string input3 = Console.ReadLine();

            if (answer3 == input3)
            {
                Console.WriteLine("Korrekt");
                score++;
            }
            else
            {
                Console.WriteLine($"Falsch, die richtige Antwort ist {answer3}");
            }


            Console.WriteLine($"Quizz beendet. Deine Punktet sind { score}");
            if (score == 3)
            {
                Console.WriteLine("Sehr gut");
            }
            else if ( score > 0)
            {
                Console.WriteLine("Du bist gut");
            }
            else
            {
                Console.WriteLine("Versuche es bitte erneut");
            }












        }
    }
}
