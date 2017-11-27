//CIS 345 9:00 Bozhi Yin Project
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaNow
{
    class QuestionEventArgs : EventArgs
    {
        private Question question;
        private int counter = 0;

        public QuestionEventArgs(Question question)
        {
            this.Question = question;
        }

        public Question Question
        {
            get
            {
                return question;
            }

            set
            {
                question = value;
            }
        }
    }
}
