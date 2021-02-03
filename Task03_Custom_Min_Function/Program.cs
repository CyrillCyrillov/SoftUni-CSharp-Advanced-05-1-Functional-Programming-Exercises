using System;
using System.Linq;

namespace Task03_Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Func<int[], int> findMin = n => n.Min();
            
            Console.WriteLine(findMin(numbers));
        }
    }
}
