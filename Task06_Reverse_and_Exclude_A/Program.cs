using System;
using System.Collections.Generic;
using System.Linq;

namespace Task06_Reverse_and_Exclude_A
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int divisibleNumber = int.Parse(Console.ReadLine());

            Func<int, bool> notDivisible = n => n % divisibleNumber != 0;

            numbers = (List<int>)numbers.Where(notDivisible).Reverse().ToList();

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
