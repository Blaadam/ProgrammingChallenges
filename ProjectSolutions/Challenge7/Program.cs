using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Challenge7
{
    internal class Program
    {
        static bool ValidateCreditCardNumber(string CreditCardNumber)
        {
            CreditCardNumber = CreditCardNumber.Trim();

            if (String.IsNullOrEmpty(CreditCardNumber))
            {
                return false;
            }

            int Sum = 0;
            bool Alternate = false;
            for (int i = CreditCardNumber.Length - 1; i >= 0; i--)
            {
                int Num = Int32.Parse(CreditCardNumber[i].ToString());
                if (Alternate)
                {
                    Num *= 2;
                    if (Num > 9)
                    {
                        Num = (Num % 10) + 1;
                    }
                }
                Sum += Num;
                Alternate = !Alternate;
            }

            return (Sum % 10 == 0);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a credit card number. (No spaces)");
            string CreditCardNumber = Console.ReadLine().Trim();
            bool isValid = ValidateCreditCardNumber(CreditCardNumber);

            if (isValid)
            {
                Console.WriteLine("Credit Card is valid");
            }
            else
            {
                Console.WriteLine("Credit Card is invalid");
            }

            Console.ReadLine();
        }
    }
}
