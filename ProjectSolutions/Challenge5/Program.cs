using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5
{
    internal class Program
    {
        static double Credit = 1;
        static string[] Fruits = new string[6] { "Cherry", "Bell", "Lemon", "Orange", "Star", "Skull" };
        static Random RNG = new Random();

        static void DisplayCredit()
        {
            Console.WriteLine("Your credit: £" + Credit.ToString());
        }

        static string GetRandomFruit()
        {
            int NextFruitIndex = RNG.Next(0, Fruits.Length);
            //Console.WriteLine(NextFruitIndex + " - " + Fruits[NextFruitIndex]);

            return Fruits[NextFruitIndex];
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                DisplayCredit();

                // Minimum to play is 20 pence.
                if (Credit <= 0.20)
                {
                    Console.WriteLine("You ran out of money! Better luck next time.");
                    break;
                }

                Credit = Credit - 0.20;
                double OldCredit = Credit;

                List<string> Rolls = new List<string>();
                Rolls.Add(GetRandomFruit());
                Rolls.Add(GetRandomFruit());
                Rolls.Add(GetRandomFruit());

                Console.WriteLine(String.Join(", ", Rolls));

                for (int i = 0; i < Rolls.Count; i++)
                {
                    int Count = Rolls.FindAll(f => f == Rolls[i]).Count;
                    // Triple Roll
                    if (Count > 2)
                    {
                        if (Rolls[i] == "Skull")
                        {
                            Credit = 0.00;
                            Console.WriteLine("You lost your money!");
                        }
                        else if (Rolls[i] == "Bell")
                        {
                            Credit = Credit + 5.00;
                            Console.WriteLine("You won £5!");
                        }
                        else
                        {
                            Credit = Credit + 1.00;
                            Console.WriteLine("You won £1!");
                        }
                    }
                    // Double roll
                    else if (Count > 1)
                    {
                        if (Rolls[i] == "Skull")
                        {
                            Credit = Credit - 1.00;
                            Console.WriteLine("You lost £1!");
                        }
                        else
                        {
                            Credit = Credit + 0.50;
                            Console.WriteLine("You won 50p!");
                        }
                    }
                    // Remove the entries so it doesnt keep repeating
                    Rolls[i] = null;
                }

                if (Credit == OldCredit)
                {
                    Console.WriteLine("You won nothing :(");
                }

                Console.WriteLine("Would you like to continue playing?");
                string Response = Console.ReadLine();
                if (Response != string.Empty && Response.Substring(0, 1) == "n")
                {
                    Console.WriteLine("Bye!");
                    break;
                }
            }

            Console.ReadKey();

        }
    }
}
