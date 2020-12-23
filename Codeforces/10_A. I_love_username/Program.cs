using System;

//https://codeforces.com/problemset/problem/155/A
namespace _10_A._I_love_username
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var input_int = new int[1000];

            var input = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                var input_splt = input.Split(' ');
                input_int[i] = int.Parse(input_splt[i]);
            }

            int max = input_int[0];
            var min = input_int[0];
            var count = 0;
            for (int i = 0; i < n; i++)
            {
                if (input_int[i] > max)
                {
                    max = input_int[i];
                    count++;
                }
                if (input_int[i] < min)
                {
                    min = input_int[i];
                    count++;
                }
            }
            Console.WriteLine($"{count}");
        }
    }
}