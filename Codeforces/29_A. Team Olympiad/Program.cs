using System;
using System.Collections.Generic;
using System.Linq;

//https://codeforces.com/problemset/problem/490/A
namespace _29_A._Team_Olympiad
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> t1 = new List<int>();
            List<int> t2 = new List<int>();
            List<int> t3 = new List<int>();
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < n; i++)
            {
                if (input[i] == 1)
                    t1.Add(i + 1);
                else if (input[i] == 2)
                    t2.Add(i + 1);
                else if (input[i] == 3)
                    t3.Add(i + 1);
            }
            var w = Math.Min(t1.Count, Math.Min(t2.Count, t3.Count));
            if (w == 0)
                Console.WriteLine("0");
            else
            {
                Console.WriteLine(w);

                for (int j = 0; j < w; j++)
                {
                    Console.WriteLine($"{t1[j]} {t2[j]} {t3[j]}");
                }
            }
        }
    }
}