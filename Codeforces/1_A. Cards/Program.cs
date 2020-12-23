using System;

//https://codeforces.com/problemset/problem/1220/A
namespace _1_A._Cards
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int count = 0;
            int count2 = 0;
            var n = int.Parse(Console.ReadLine());
            var str = Console.ReadLine();

            var i = str.ToCharArray();
            for (int j = 0; j < n; j++)
            {
                if (i[j] == 'n')
                {
                    count++;
                }
                else if (i[j] == 'z')
                    count2++;
            }
            for (int k = 0; k < count; k++)
            {
                Console.Write("1 ");
            }
            for (int k = 0; k < count2; k++)
            {
                Console.Write("0 ");
            }
        }
    }
}