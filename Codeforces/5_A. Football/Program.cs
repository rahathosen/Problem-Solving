using System;

//https://codeforces.com/problemset/problem/43/A
namespace _5_A._Football
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var maxFrequently = 0;
            //var count1 = 0;
            //var count2 = 0;
            var temp = 0;
            var n = int.Parse(Console.ReadLine());
            /* string str1;
             // var str2 = new string[50];
             string str2 = "";
             str1 = Console.ReadLine();
             for (int i = 0; i < n; i++)
             {
                 str2 = Console.ReadLine();
                 if (str1 == str2)
                 {
                     count1++;
                 }
                 else
                     count2++;
             }
             if (count1 > count2)
                 Console.WriteLine($"{str1}");
             else
                 Console.WriteLine($"{str2}");*/

            var team = new string[101];
            for (int i = 0; i < n; i++)
            {
                team[i] = Console.ReadLine();
            }
            for (int j = 0; j < n; j++)
            {
                var count = 0;
                for (int k = 0; k < n; k++)
                {
                    if (team[j] == team[k])
                    {
                        count++;
                    }
                }
                if (maxFrequently < count)
                {
                    maxFrequently = count;
                    temp = j;
                }
            }
            Console.WriteLine(team[temp]);
        }
    }
}