using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW50_25.QuizApp
{
    internal class Program
    {

        //public Question(string questionText, string[] answers, int correctAnswerIndex)
        //{
        //    this.QuestionText = questionText;
        //    this.Answers = answers;
        //    this.CorrectAnswerIndex = correctAnswerIndex;
        //}

        static void Main(string[]args)
        {
            //(string questionText, string[] answers, int correctAnswerIndex)
            Question[] questions = new Question[]
            {
                new Question("Wie viele Tage hat ein Jahr?", new string[] {"200", "300", "400", "365"}, 3),
                new Question("Was ergibt 2+2?", new string[] {"1", "3", "4", "10"}, 2),
                new Question("Was ist die Hauptstadt der Schweiz", new string[] {"Luzern", "Bern", "Zürich", "Basel"}, 1)
            };


            Quiz myQuiz = new Quiz(questions);

            myQuiz.StartQuiz();
              
        }
    }
}
