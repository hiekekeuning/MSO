using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
    class Open : Question
    {
        public string Answer { get; set; }

        public Open(string text, string answer): base(text)
        {
            Answer = answer;
        }
        public override bool CheckAnswer(string answer)
        {
            return answer.Contains(Answer);
        }
    }
}
