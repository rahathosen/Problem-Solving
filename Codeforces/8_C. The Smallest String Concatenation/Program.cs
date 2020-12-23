using System;
using System.Collections.Generic;

//wrong ans for TLE
//unsolve
//https://codeforces.com/problemset/problem/632/C
namespace _8_C._The_Smallest_String_Concatenation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var str = new string[600000];
            var tempStr = new string[600000];
            var tempStr2 = new string[600000];
            List<string> temp_1 = new List<string>();
            List<string> temp_2 = new List<string>();
            for (int i = 0; i < n; i++)
            {
                str[i] = Console.ReadLine();
            }

            for (int k = 0; k < n; k++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (str[k].Length >= str[j].Length)
                    {
                        tempStr[k] = str[k];
                        str[k] = str[j];
                        str[j] = tempStr[k];
                    }
                }
            }

            /* for (int i = 0; i < n; i++)
             {
                 tempStr2[i] += str[i];
             }*/
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write($"{str[i]}");
            }
        }
    }
}