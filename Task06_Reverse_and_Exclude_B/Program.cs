using System;
using System.Linq;

namespace Task06_Reverse_and_Exclude_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int divisibleNumber = int.Parse(Console.ReadLine());

            Func<int, bool> yesPrint = (n => n % divisibleNumber != 0);


            for (int i = numbers.Length - 1; i>= 0; i--)
			{
                if(yesPrint(numbers[i]))
                {
                    Console.Write($"{numbers[i]} ");
                }
			}
            
        }
    }
}
