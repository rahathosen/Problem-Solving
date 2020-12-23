using System;

//https://codeforces.com/problemset/problem/200/B
namespace _26_B._Drinks
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var ary = new int[1000];
            var input = Console.ReadLine();
            var sum = 0.00;

            for (int i = 0; i < n; i++)
            {
                var splt = input.Split(' ');
                ary[i] = int.Parse(splt[i]);
                sum += ary[i];
            }
            Console.WriteLine($"{sum / n}");
        }
    }
}