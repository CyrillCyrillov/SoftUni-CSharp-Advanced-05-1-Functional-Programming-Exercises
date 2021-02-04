using System;
using System.Linq;
using System.Collections.Generic;

namespace Task10_Predicate_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> partyList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                string[] comand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (comand[0].ToUpper() == "PARTY!")
                {
                    break;
                }

                string type = comand[0];
                string partChek = comand[1];
                string chars = comand[2];

                var argumnents = ComandArguments(partChek, chars);

                switch (type.ToUpper())
                {
                    case "REMOVE":
                        partyList.RemoveAll(argumnents);
                        break;
                    case "DOUBLE":
                        {
                            var matches = partyList.FindAll(argumnents);
                            if (matches.Count > 0)
                            {
                                var index = partyList.FindIndex(argumnents);
                                partyList.InsertRange(index, matches);
                            }

                            break;
                        }
                }

                if (partyList.Count == 0)
                {
                    Console.WriteLine("Nobody is going to the party!");
                }
                else
                {
                    Console.WriteLine(string.Join(", ", partyList) + " are going to the party!");
                }
            }

            //Console.WriteLine("Hello World!");
        }

        private static Predicate<string> ComandArguments(string argumentOne, string argumentTwo)
        {
            switch (argumentOne)
            {
                case "StartsWith":
                    return (name) => name.StartsWith(argumentTwo);
                case "EndsWith":
                    return (name) => name.EndsWith(argumentTwo);
                case "Length":
                    return (name) => name.Length == int.Parse(argumentTwo);
                default:
                    throw new ArgumentException("Invalid command type: " + argumentOne);
            }
        }
    }
}
