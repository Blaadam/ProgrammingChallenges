using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSolutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int maxCount = 0;
            maxCount = Int32.Parse(input);

            int currentNumber = 1;

            for (int i = 1; i <= maxCount; i++)
            {
                currentNumber = currentNumber * i;
            }

            Console.WriteLine(currentNumber);
            Console.ReadKey();
        }
    }
}
