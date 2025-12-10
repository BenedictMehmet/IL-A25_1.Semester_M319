using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A25_1.Semester_M319.KW50_25.QuizApp
{
    internal class Question
    {
        public string QuestionText { get; set; }

        public string[] Answers { get; set; }

        public int CorrectAnswerIndex { get; set; }

        public int ChooseAnswerIndex { get; set; }

        public Question(string questionText, string[] answers, int correctAnswerIndex)
        {
            this.QuestionText = questionText;
            this.Answers = answers;
            this.CorrectAnswerIndex = correctAnswerIndex;
        }
    }
}
