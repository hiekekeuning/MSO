using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
    class TrueFalse: Question
    {
        public bool Answer { get; set; }

        public TrueFalse(string text, bool answer) : base(text)
        {
            Answer = answer;
        }

        public override bool CheckAnswer(string answer)
        {
            if (answer.ToLower() == "true" && Answer)
            {
                return true;
            }
            else
            {
                return answer.ToLower() == "false" && !Answer;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "True/False" + Environment.NewLine;
        }
    }
}
