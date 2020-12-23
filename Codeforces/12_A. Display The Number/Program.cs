using System;

//https://codeforces.com/problemset/problem/1295/A
namespace _12_A._Display_The_Number
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                var m = int.Parse(Console.ReadLine());
                if (m % 2 == 0)
                {
                    for (int j = 0; j < m / 2; j++)
                    {
                        Console.Write("1");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("7");
                    m = m - 3;
                    for (int j = 0; j < m / 2; j++)
                    {
                        Console.Write("1");
                    }
                    Console.WriteLine();
                }

                n--;
            }
        }
    }
}