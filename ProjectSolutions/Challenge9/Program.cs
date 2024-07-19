using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Challenge9
{
    internal class Program
    {
        static bool IsHappyNumber(List<int> InitialNumbers, int Depth)
        {
            Console.WriteLine(string.Join(", ", InitialNumbers));
            int CalculatedNumber = 0;

            for (int i = 0; i < InitialNumbers.Count; i++)
            {
                int Num = InitialNumbers[i];
                CalculatedNumber = CalculatedNumber + (Num * Num);
            }

            if (CalculatedNumber == 1) { return true; }

            return IsHappyNumber(GetDigits(CalculatedNumber.ToString()), Depth + 1);
        }

        static List<int> GetDigits(string NumberInput)
        {
            List<int> Digits = new List<int>();

            for (int i = 0; i < NumberInput.Length; i++)
            {
                string SplitNumber = NumberInput.Substring(i, 1);
                int ConvertedNumber = 0;

                Int32.TryParse(SplitNumber, out ConvertedNumber);
                Digits.Add(ConvertedNumber);
            }

            return Digits;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string NumberInput = Console.ReadLine();

            List<int> InitialNumbers = GetDigits(NumberInput);

            bool HappyNumber = false;

            try
            {
                HappyNumber = IsHappyNumber(InitialNumbers, 0);
            }
            catch { }

            if (HappyNumber)
            {
                Console.WriteLine($"{NumberInput} is a happy number");
            }
            else
            {
                Console.WriteLine($"{NumberInput} is not a happy number");
            }
            Console.ReadLine();
        }
    }
}
