using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
    abstract class Question
    {
        public string QuestionText { get; set; }

        public Question(string text)
        {
            QuestionText = text;
        }
        public abstract bool CheckAnswer(string answer);

        public override string ToString()
        {
            return "Q: " + QuestionText + Environment.NewLine;
        }
    }
}
