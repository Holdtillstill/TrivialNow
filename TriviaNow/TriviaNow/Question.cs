//CIS 345 9:00 Bozhi Yin Project
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaNow
{
    [Serializable]
    public class Question
    {
        private string questionText;
        private string[] choices = new string[4];
        private string feedback;
        private int correctAnswer;

        public Question()
        {
            
        }

        public Question(string questionText, string[] choices, string feedback, int correctAnswer)
        {
            this.questionText = questionText;
            this.choices = choices;
            this.feedback = feedback;
            this.correctAnswer = correctAnswer;
        }

        public string QuestionText
        {
            get
            {
                return questionText;
            }

            set
            {
                questionText = value;
            }
        }

        public string[] Choices
        {
            get
            {
                return choices;
            }

            set
            {
                choices = value;
            }
        }

        public string Feedback
        {
            get
            {
                return feedback;
            }

            set
            {
                feedback = value;
            }
        }

        public int CorrectAnswer
        {
            get
            {
                return correctAnswer;
            }

            set
            {
                correctAnswer = value;
            }
        }
        public override string ToString()
        {
            return QuestionText;
        }
    }
}
