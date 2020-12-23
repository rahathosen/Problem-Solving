using System;

//https://codeforces.com/problemset/problem/711/A
namespace _30_A._Bus_to_Udayland
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int count = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            string[] input = new string[n];
            for (int i = 0; i < n; i++)
            {
                input[i] = Console.ReadLine();
            }
            for (int i = 0; i < n; i++)
            {
                if (count == 1)
                    break;

                char[] ChZs = input[i].ToCharArray();
                if (ChZs[0] == 'O' && ChZs[1] == 'O' && count == 0)
                {
                    count = 1;
                    ChZs[0] = '+';
                    ChZs[1] = '+';
                }
                else if (ChZs[3] == 'O' && ChZs[4] == 'O' && count == 0)
                {
                    count = 1;
                    ChZs[3] = '+';
                    ChZs[4] = '+';
                }
                input[i] = new string(ChZs);
            }
            if (count == 1)
            {
                Console.WriteLine("YES");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(input[i]);
                }
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}