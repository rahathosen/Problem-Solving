using System;

//https://codeforces.com/problemset/problem/660/B
namespace _4_B._Seating_On_Bus
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var inputstr = Console.ReadLine();
            var spltStr = inputstr.Split(' ');
            var n = int.Parse(spltStr[0]);
            var m = int.Parse(spltStr[1]);
            for (int i = 1; i <= n * 2; i++)
            {                                       //just follow the pattern (n=2, m=7) = 5 1 6 2 7 3 4
                if (2 * n + i <= m)
                    Console.Write(2 * n + i + " ");
                if (i <= m)
                    Console.Write(i + " ");
            }
        }
    }
}