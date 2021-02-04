using System;
using System.Linq;

namespace Task09_List_of_Predicates_A
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxLimit = int.Parse(Console.ReadLine());

            int[] divisibles = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();



            for (int i = 1; i <= maxLimit; i++)
            {
                bool isValid = true;
                Predicate<int> isNodivible = x => i % x != 0;

                foreach (int elelment in divisibles)
                {
                    if(isNodivible(elelment))
                    {
                        isValid = false;
                        break;
                    }
                }

                if(isValid)
                {
                    Console.Write($"{i} ");
                }
            }


            //Console.WriteLine("Hello World!");
        }
    }
}
