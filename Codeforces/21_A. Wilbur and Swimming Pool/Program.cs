using System;

//https://codeforces.com/problemset/problem/596/A
namespace _21_A._Wilbur_and_Swimming_Pool
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int xmax, ymax, xmin, ymin, ans;

            var x = new int[100];
            var y = new int[100];
            ymax = xmax = -10000;

            ymin = xmin = 100000;
            var input = new string[10];
            for (int i = 0; i < n; i++)
            {
                input[i] = Console.ReadLine();
                var spltInput = input[i].Split(' ');
                x[i] = int.Parse(spltInput[0]);
                y[i] = int.Parse(spltInput[1]);

                if (x[i] > xmax)
                    xmax = x[i];
                if (x[i] < xmin)
                    xmin = x[i];
                if (y[i] > ymax)
                    ymax = y[i];
                if (y[i] < ymin)
                    ymin = y[i];
            }
            if (n == 1)
                ans = -1;
            else if (n == 2)
            {
                if ((x[0] == x[1]) || (y[1] == y[0]))
                    ans = -1;
                else
                    ans = Math.Abs(x[0] - x[1]) * Math.Abs(y[1] - y[0]);
            }
            else
            {
                ans = Math.Abs(xmax - xmin) * Math.Abs(ymax - ymin);
            }
            if (ans == 0)
                Console.WriteLine("-1");
            else
                Console.WriteLine($"{ans}");
        }
    }
}