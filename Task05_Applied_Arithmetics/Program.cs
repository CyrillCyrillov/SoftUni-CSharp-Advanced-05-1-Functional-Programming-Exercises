using System;
using System.Linq;

namespace Task05_Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Action<string> Manipulations = (type) =>
            {
                if (type.ToUpper() == "ADD")
                {
                    numbers = numbers.Select(n => n + 1).ToArray();
                }

                if (type.ToUpper() == "MULTIPLY")
                {
                    numbers = numbers.Select(n => n * 2).ToArray();
                }

                if (type.ToUpper() == "SUBTRACT")
                {
                    numbers = numbers.Select(n => n - 1).ToArray();
                }

                if (type.ToUpper() == "PRINT")
                {
                    Console.WriteLine(string.Join(' ', numbers));
                }

            };

            while (true)
            {
                string comand = Console.ReadLine();

                if (comand.ToUpper() == "END")
                {
                    break;
                }

                Manipulations(comand);

            }

        }   
            
    }
}
