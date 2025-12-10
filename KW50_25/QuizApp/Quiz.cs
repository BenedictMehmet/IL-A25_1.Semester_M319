using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW50_25.QuizApp
{
    internal class Quiz
    {
        private Question[] _questions;

        private int _score;

        public Quiz(Question[] questions)
        {
            this._questions = questions;
            _score = 0;
        }

        
        private void DisplayOneQuestion(Question questions)
        {
            Console.WriteLine(questions.QuestionText);

            for (int i = 0; i < questions.Answers.Length; i++)
            {
                Console.Write(i + 1);
                Console.WriteLine($". {questions.Answers[i]}");
            }
            // Die Methode GiveAnswer ist im Property ChooseAnswerIndex gespeichert
            questions.ChooseAnswerIndex = GiveAnswer(questions);
            ControlAnswer(questions);
        }

        private int GiveAnswer(Question q)
        {
            string input;
            int myNumber;
            bool isZahl;

            Console.WriteLine($"Gib eine Antwort zwischen 1 und {q.Answers.Length} ein.");
            input = Console.ReadLine();
            isZahl = int.TryParse(input, out myNumber);

            while (!isZahl || myNumber < 1 || myNumber > q.Answers.Length)
            {
                Console.WriteLine($"Ungültige Eingabe. Gib eine Zahl zwischen 1 und {q.Answers.Length} ein.");
                input = Console.ReadLine();
                isZahl = int.TryParse(input, out myNumber);
            }
            return myNumber -1;
        }

        private void ControlAnswer(Question q)
        {
            if(q.ChooseAnswerIndex == q.CorrectAnswerIndex)
            {
                Console.WriteLine("Korrekt");
                _score++;
            }
            else
            {
                Console.WriteLine($"Falsch. Die richtige Antwort ist {q.Answers[q.CorrectAnswerIndex]}");
            }

        }

        private void Result(Question[] q)
        {
            Console.WriteLine($"Du hast {_score} Punkt(e) von {q.Length} Fragen");
        }



        public void StartQuiz()
        {
            Console.WriteLine("Willommen zum Quiz");
            int questionNumber = 1;
            Console.WriteLine();

            foreach(Question alleFragen in _questions)
            {
                Console.Write($"Frage {questionNumber++}: ");
                DisplayOneQuestion(alleFragen);
                Console.WriteLine();
            }

            Result(_questions);
        }
    }
}
