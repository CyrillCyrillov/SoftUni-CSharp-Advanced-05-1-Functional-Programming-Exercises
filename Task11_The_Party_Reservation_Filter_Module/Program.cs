using System;
using System.Collections.Generic;
using System.Linq;

namespace Task11_The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guestsList = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> filters = new List<string>();

            

            while (true)
            {
                string[] command = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries).ToArray();

                
                if(command[0].ToUpper() == "PRINT")
                {
                    break;
                }

                if (command[0].ToUpper() == "ADD FILTER")
                {
                    filters.Add(command[1] + " " + command[2]);
                }
                else if (command[0].ToUpper() == "REMOVE FILTER")
                {
                    filters.Remove(command[1] + " " + command[2]);
                }

                
            }

            foreach (string element in filters)
            {
                string[] filterCommands = element.Split(' ');

                if (filterCommands[0].ToUpper() == "STARTS")
                {
                    guestsList = guestsList.Where(p => !p.StartsWith(filterCommands[2])).ToList();
                }
                else if (filterCommands[0].ToUpper() == "ENDS")
                {
                    guestsList = guestsList.Where(p => !p.EndsWith(filterCommands[2])).ToList();
                }
                else if (filterCommands[0].ToUpper() == "LENGTH")
                {
                    guestsList = guestsList.Where(p => p.Length != int.Parse(filterCommands[1])).ToList();
                }
                else if (filterCommands[0].ToUpper() == "CONTAINS")
                {
                    guestsList = guestsList.Where(p => !p.Contains(filterCommands[1])).ToList();
                }
            }

            if (guestsList.Count > 0)
            {
                Console.WriteLine(string.Join(" ", guestsList));
            }

            //Console.WriteLine("Hello World!");
        }
    }
}
