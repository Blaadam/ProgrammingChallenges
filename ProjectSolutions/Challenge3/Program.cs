using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    internal class Program
    {
        static List<string> GetPermutations(List<string> array, int start)
        {
            List<string> Permutations = new List<string>();

            if (start == array.Count)
            {
                Console.WriteLine("[" + string.Join(", ", array) + "]");
                return array;
            }

            for (int i = start; i < array.Count; i++)
            {
                (array[start], array[i]) = (array[i], array[start]);
                List<string> Subpermutations = GetPermutations(array, start + 1);
                (array[start], array[i]) = (array[i], array[start]);
                Permutations.AddRange(Subpermutations);
            }

            return Permutations;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input 4 consecutive numbers");
            string AllNumbers = Console.ReadLine();
            List<string> Numbers = new List<string>();
            for (int i = 0; i < AllNumbers.Length; i++)
            {
                Numbers.Add(AllNumbers.Substring(i, 1));
            }

            Console.WriteLine(string.Join(", ", Numbers));

            List<string> Permutations = GetPermutations(Numbers, 0);
            Console.WriteLine(string.Join(", ", Permutations));

            Console.ReadKey();
        }
    }
}
