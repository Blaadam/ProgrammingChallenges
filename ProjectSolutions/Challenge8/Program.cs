using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string StudentName = Console.ReadLine();
            if (string.IsNullOrEmpty(StudentName)) { return; }

            List<bool> Answers = new List<bool> { };

            for (int i = 0; i < 10; i++)
            {
                Question Quest = new Question();

                Quest.GenateRandomNumbers();
                Console.WriteLine($"{Quest.NumberA.ToString()} + {Quest.NumberB.ToString()} = ?");

                bool IsCorrect = Quest.CheckAnswer(Console.ReadLine());
                Answers.Add(IsCorrect);
            }

            int CorrectAnswers = Answers.Where(a => a == true).Count();

            Console.WriteLine($"Your score: {CorrectAnswers.ToString()}/{Answers.Count().ToString()}");

            Console.ReadKey();
        }
    }
}
