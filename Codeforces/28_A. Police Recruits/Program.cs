using System;

//https://codeforces.com/problemset/problem/427/A
namespace _28_A._Police_Recruits
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int untreated = 0; //first no crime occure
            int hired = 0;  //first none police hired

            var n = int.Parse(Console.ReadLine());
            var allEvent = Console.ReadLine().Split();

            for (int i = 0; i < n; i++)
            {
                var isEvent = int.Parse(allEvent[i]);
                if (isEvent > 0)
                {
                    hired += isEvent;
                }
                else if (hired <= 0)
                {
                    untreated++;
                }
                else
                {
                    hired--;
                }
            }
            Console.WriteLine(untreated);
        }
    }
}