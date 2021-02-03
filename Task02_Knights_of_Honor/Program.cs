using System;
using System.Linq;

namespace Task02_Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            Action<string> printNamesWithTitle = name => Console.WriteLine($"Sir {name}");

            foreach (string item in names)
            {
                printNamesWithTitle(item);
            }
            
            //Console.WriteLine("Hello World!");
        }
    }
}
