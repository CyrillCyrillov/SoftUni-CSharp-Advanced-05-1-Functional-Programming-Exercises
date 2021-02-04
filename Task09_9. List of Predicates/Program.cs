using System;
using System.Linq;

namespace Task09_List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxLimit = int.Parse(Console.ReadLine());

            int[] divisibles = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            
            
            for (int i = 1; i <= maxLimit; i++)
            {
                if(divisibles.All(n => i % n == 0))
                {
                    Console.Write($"{(i)} ");
                }
            }

            //Console.WriteLine("Hello World!");
        }
    }
}
