using System;
using System.Linq;

namespace Task12_TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int charactersSum = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split().ToArray();

            Func<string, int, bool> isValidWord = (str, num) => str.ToCharArray().Select(ch => (int)ch).Sum() >= num;

            Func<string[], int, Func<string, int, bool>, string> firstValidName = (arr, num, func) => arr.FirstOrDefault(str => func(str, num));

            string result = firstValidName(names, charactersSum, isValidWord);
            
            
            Console.WriteLine(result);
        }
    }
}
