using System;

//https://codeforces.com/problemset/problem/510/A
namespace _27_A._Fox_And_Snake
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var splt = input.Split(' ');
            var a = int.Parse(splt[0]);
            var b = int.Parse(splt[1]);
            for (int i = 1; i <= a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (i % 4 == 0)
                    {
                        if (j == 0)
                        {
                            Console.Write("#");
                        }
                        else
                            Console.Write(".");
                    }
                    else if (i % 4 == 2)
                    {
                        if (j == b - 1)
                        {
                            Console.Write("#");
                        }
                        else
                            Console.Write(".");
                    }
                    else
                        Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}