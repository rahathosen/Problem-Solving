using System;

//https://codeforces.com/problemset/problem/602/A
namespace _19_A._Two_Bases
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            long sum1 = 0;
            long sum2 = 0;

            var input1 = Console.ReadLine();
            var splt_input1 = input1.Split(' ');
            var n1 = int.Parse(splt_input1[0]);
            var m1 = int.Parse(splt_input1[1]);

            var x = new int[10001];
            var _x_ = Console.ReadLine();
            for (int i = 0; i < n1; i++)
            {
                var splt_x = _x_.Split(' ');
                x[i] = int.Parse(splt_x[i]);
                sum1 = sum1 * m1 + x[i];
            }
            var input2 = Console.ReadLine();
            var splt_input2 = input2.Split(' ');
            var n2 = int.Parse(splt_input2[0]);
            var m2 = int.Parse(splt_input2[1]);

            var y = new int[10001];
            var _y_ = Console.ReadLine();
            for (int i = 0; i < n2; i++)
            {
                var splt_y = _y_.Split(' ');
                y[i] = int.Parse(splt_y[i]);
                sum2 = sum2 * m2 + y[i];
            }
            if (sum1 > sum2)
            {
                Console.WriteLine(">");
            }
            else if (sum1 < sum2)
            {
                Console.WriteLine("<");
            }
            else
                Console.WriteLine("=");
        }
    }
}