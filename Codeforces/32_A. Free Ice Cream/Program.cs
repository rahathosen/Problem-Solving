using System;

//https://codeforces.com/problemset/problem/686/A
namespace _32_A._Free_Ice_Cream
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            long count = 0;
            var input = Console.ReadLine().Split();
            var n = long.Parse(input[0]);
            var x = long.Parse(input[1]);
            for (int i = 0; i < n; i++)
            {
                var input2 = Console.ReadLine().Split();
                var ch = char.Parse(input2[0]);
                var intValue = long.Parse(input2[1]);
                if (ch == '+')
                {
                    x += intValue;
                }
                else if (intValue <= x)
                {
                    x -= intValue;
                }
                else
                {
                    count++;
                }
            }
            Console.WriteLine($"{x} {count}");
        }
    }
}