using System;

//https://codeforces.com/problemset/problem/1108/A
namespace _33_A._Two_distinct_points
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var a = int.Parse(input[0]);
                var b = int.Parse(input[1]);
                var c = int.Parse(input[2]);
                var d = int.Parse(input[3]);
                if (a == d)
                {
                    Console.WriteLine($"{b} {c}");
                }
                else
                    Console.WriteLine($"{a} {d}");
            }
        }
    }
}