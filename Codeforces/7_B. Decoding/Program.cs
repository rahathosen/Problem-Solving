using System;

//https://codeforces.com/problemset/problem/746/B
namespace _7_B._Decoding
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var str = Console.ReadLine();
            string temp = "";

            for (int i = 0; i < n; i++)
            {
                if ((n - i) % 2 != 0)
                {
                    temp = temp + str[i];
                }
                else temp = str[i] + temp;
            }
            Console.Write(temp);
        }
    }
}