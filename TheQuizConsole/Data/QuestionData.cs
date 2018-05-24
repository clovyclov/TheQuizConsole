using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheQuizConsole.Models;

namespace TheQuizConsole.Data
{
    public class QuestionData
    {
        public List<IQuestion> Questions { get; set; }
        public QuestionData()
        {
            this.Questions = new List<IQuestion>
            {
                new SingleChoiceQuestion()
                {
                    Id = 1,
                    Description = "How much is 2 + 2?",
                    Answer = new string[]{"4"}
                },
                new SingleChoiceQuestion()
                {
                    Id = 1,
                    Description = "What is the capitol of MI?",
                    Answer = new string[]{"Lansing"}
                },
                new SingleChoiceQuestion()
                {
                    Id = 1,
                    Description = "How many players start on a basketball team?",
                    Answer = new string[]{"5"}
                }
            };
        }
    }
}
