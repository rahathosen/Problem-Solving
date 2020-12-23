using System;
using System.Collections.Generic;

// https://codeforces.com/problemset/problem/847/G

namespace _16_G._University_Classes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var min_room = 0;
            var n = int.Parse(Console.ReadLine());
            List<string> schedule = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                schedule.Add(input);
            }

            for (int i = 0; i < 7; i++)
            {
                var count = 0;

                for (int j = 0; j < n; j++)
                {
                    string str = schedule[j];
                    count += str[i] - '0';
                }
                if (count > min_room)
                    min_room = count;
            }

            Console.WriteLine($"{min_room}");
        }
    }
}