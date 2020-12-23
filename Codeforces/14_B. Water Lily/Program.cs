using System;
using System.Globalization;

//https://codeforces.com/problemset/problem/1199/B
namespace _14_B._Water_Lily
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var splt_Input = input.Split(' ');
            var H = double.Parse(splt_Input[0]);
            var L = double.Parse(splt_Input[1]);

            //double output = Math.Pow(L, 2) - Math.Pow(H, 2) / (2 * H);
            double output = ((L * L - H * H) / (2.0 * H));
            Console.WriteLine($"{Math.Round(output, 14)}");
        }
    }
}