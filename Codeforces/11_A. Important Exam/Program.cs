using System;

//https://codeforces.com/problemset/problem/1201/A
namespace _11_A._Important_Exam
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var splt_input = input.Split(' ');
            var splt_n = int.Parse(splt_input[0]);
            var splt_m = int.Parse(splt_input[1]);

            for (int i = 0; i < splt_n; i++)
            {
                var input2 = Console.ReadLine();
            }

            var input3 = Console.ReadLine();
            var input_a = new int[splt_m];
            for (int i = 0; i < splt_m; i++)
            {
                var splt_input3 = input3.Split(' ');
                input_a[i] = int.Parse(splt_input3[i]);
            }
            for (int i = 0; i < splt_m; i++)
            {
            }
        }
    }
}