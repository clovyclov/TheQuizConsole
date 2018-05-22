using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuizConsole.Models
{
    class Answer
    {
        public int Id { get; set; }
        public string AnswerText { get; set; }

        public Answer(string answer)
        {
            AnswerText = answer;
        }
    }
}
