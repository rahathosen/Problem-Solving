using System;

//https://codeforces.com/problemset/problem/1097/A
namespace _31_A._Gennady_and_a_Card_Game
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var a = Console.ReadLine();
            bool flag = false;
            var b = Console.ReadLine().Split(' ');
            for (int i = 0; i < 5; i++)
            {
                if (b[i][0] == a[0] || b[i][1] == a[1])
                {
                    flag = true;
                    break;
                }
            }

            if (flag)
            {
                Console.WriteLine("YES");
            }
            else
                Console.WriteLine("NO");
        }
    }
}