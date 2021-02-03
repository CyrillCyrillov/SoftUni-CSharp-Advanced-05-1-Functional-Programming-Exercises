using System;
using System.Collections.Generic;
using System.Linq;

namespace Task06_Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int divisibleNumber = int.Parse(Console.ReadLine());

            numbers.RemoveAll(n => n % divisibleNumber == 0);

            numbers.Reverse();
            
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
