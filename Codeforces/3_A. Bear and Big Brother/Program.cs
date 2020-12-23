using System;

//https://codeforces.com/problemset/problem/791/A
namespace _3_A._Bear_and_Big_Brother
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var count = 0;
            var aStr = Console.ReadLine();
            var spltStr = aStr.Split(' ');
            var a = int.Parse(spltStr[0]);
            var b = int.Parse(spltStr[1]);
            while (a <= b)
            {
                a *= 3;
                b *= 2;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}