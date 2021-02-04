using System;
using System.Linq;

namespace Task01_Action_Print_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            Action<string> printName = curentName => Console.WriteLine(curentName);

            for (int i = 0; i < names.Length; i++)
            {
                printName(names[i]);
            }

            
        }
    }
}
