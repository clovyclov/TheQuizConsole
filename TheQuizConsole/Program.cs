using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheQuizConsole.Data;
using TheQuizConsole.Models;

namespace TheQuizConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var initQuestions = new QuestionData();
            var questions = initQuestions.Questions;

            foreach(var question in questions)
            {
                Console.WriteLine(question.Description);
            }
            Console.ReadLine();
        }
    }
}
