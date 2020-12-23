using System;

//https://codeforces.com/problemset/problem/96/A
namespace _22_A._Football
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var s = Console.ReadLine();

            if (s.Contains("1111111") || s.Contains("0000000"))
            {
                Console.WriteLine("YES");
            }
            else
                Console.WriteLine("NO");
        }
    }
}