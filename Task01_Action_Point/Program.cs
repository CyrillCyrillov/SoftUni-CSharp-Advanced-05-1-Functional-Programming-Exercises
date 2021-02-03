using System;
using System.Linq;

namespace Task01_Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            Action<string> printName = curentName => Console.WriteLine(curentName);

            foreach (string item in names)
            {
                printName(item);
            }
            
            
            //Console.WriteLine("Hello World!");
        }
    }
}
