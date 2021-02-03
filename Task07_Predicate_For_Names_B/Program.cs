using System;
using System.Linq;

namespace Task07_Predicate_For_Names_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthLimit = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join((char)10, Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Where(n => n.Length <= lengthLimit).ToArray()));
        }
    }
}
