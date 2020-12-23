using System;

//https://codeforces.com/problemset/problem/186/A
namespace _20_A._Comparing_Strings
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var cnt = 0;
            var j = 0;
            var a = new char[10000];
            var b = new char[10000];
            var s1 = Console.ReadLine();
            var s2 = Console.ReadLine();
            var l1 = s1.Length;
            var l2 = s2.Length;
            if (l1 != l2)
            {
                Console.WriteLine("NO");
                Environment.Exit(0);
            }
            else
            {
                for (int i = 0; i < l1; i++)
                {
                    if (s1[i] != s2[i])
                    {
                        cnt++;
                        a[j] = s1[i];
                        b[j] = s2[i];
                        j++;
                        if (cnt > 2)
                        {
                            Console.WriteLine("NO");
                            Environment.Exit(0);
                        }
                    }
                }
            }
            if (a[1] == b[0] && a[0] == b[1])
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}