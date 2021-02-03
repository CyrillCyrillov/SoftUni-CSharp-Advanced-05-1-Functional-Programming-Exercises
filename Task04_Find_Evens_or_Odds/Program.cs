using System;
using System.Linq;

namespace Task04_Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] limits = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();            
            
            int minLimit = limits[0];
            int maxLimit = limits[1];
            string typeNumber = Console.ReadLine();

            Predicate<int> evenNumber = x => { return x % 2 == 0; };
            Predicate<int> oddNumber = x => { return x % 2 != 0; };

            for (int i = minLimit; i <= maxLimit; i++)
            {
                if(typeNumber == "odd")
                {
                    if(oddNumber(i))
                    {
                        Console.Write($"{i} ");
                    }
                }
                if(typeNumber == "even")
                {
                    if(evenNumber(i))
                    {
                        Console.Write($"{i} ");
                    }
                }
            }
            
            //Console.WriteLine("Hello World!");
        }
    }
}
