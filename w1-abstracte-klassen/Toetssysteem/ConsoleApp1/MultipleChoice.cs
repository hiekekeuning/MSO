using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{

    class MultipleChoice: Question
    {
        public Dictionary<char, string> Options { get;  }
        public char Answer { get; set; }

        public MultipleChoice(string text, string [] options, char answer): base(text)
        {
            Options = new Dictionary<char, string>();
            char c = 'a';
            foreach (var option in options)
            {
                Options.Add(c, option);
                c++;
            }
            Answer = answer;
        }
        public override bool CheckAnswer(string answer)
        {
            if (answer.Length >= 1)
            {
                return Char.ToLower(Answer) == answer.ToLower()[0];
            }
            return false;
        }

        public override string ToString()
        {
            string s = string.Empty;
            foreach (var option in Options)
            {
                s += $"{option.Key}) {option.Value}" + Environment.NewLine;
            }
            return base.ToString() + s;
        }
    }
}
