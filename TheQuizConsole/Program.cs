using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheQuizConsole.Models;

namespace TheQuizConsole
{
    class Program
    {
        
        static void Main(string[] args)
        {
            SingleChoiceQuestion question = new SingleChoiceQuestion()
            {
                Id = 1,
                Description = "How much is 2 + 2?",
                Answer = new Answer("4")
            };

            Console.WriteLine(question.Description);
            var userAnswer = Console.ReadLine();
            if (userAnswer == question.Answer.AnswerText)
            {
                Console.WriteLine("Awesome job!");
            }
            else
            {
                Console.WriteLine("Sorry, wrong answer");
            }
            Console.ReadLine();

        }
    }
}
