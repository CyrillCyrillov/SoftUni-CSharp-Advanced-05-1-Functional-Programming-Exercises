using System;
using System.Linq;

namespace Task07_Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthLimit = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            Func<string, bool> filter = n => n.Length <= lengthLimit;

            foreach (string name in names)
            {
                if(filter(name))
                {
                    Console.WriteLine(name);
                }
            }

            //Console.WriteLine("Hello World!");
        }
    }
}
