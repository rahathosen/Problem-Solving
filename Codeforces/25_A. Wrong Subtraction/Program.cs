using System;

// https://codeforces.com/problemset/problem/977/A

namespace _25_A._Wrong_Subtraction
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var splt = input.Split(' ');
            var a = int.Parse(splt[0]);
            var b = long.Parse(splt[1]);
            for (int i = 0; i < b; i++)
            {
                if (a % 10 == 0)
                    a /= 10;
                else
                    a--;
            }
            Console.WriteLine($"{a}");
        }
    }
}