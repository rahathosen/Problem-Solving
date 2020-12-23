using System;

//https://codeforces.com/problemset/problem/94/A
namespace _15_A._Restoring_Password
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var strAry = new string[10];
            for (int i = 0; i < strAry.Length; i++)
            {
                strAry[i] = Console.ReadLine();
            }
            for (int i = 0; i < 8; ++i)
            {
                string temp = str.Substring(i * 10, 10);
                for (int j = 0; j < 10; ++j)
                {
                    if (temp == strAry[j])
                    {
                        Console.Write($"{j}");
                        break;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}