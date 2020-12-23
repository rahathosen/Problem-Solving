using System;

//https://codeforces.com/problemset/problem/118/A
namespace _9_A._String_Task
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var str1 = Console.ReadLine();
            string str = str1.ToLower();
            char[] cha_str = str.ToCharArray();

            for (int i = 0; i < str.Length; i++)
            {
                if (cha_str[i] == 'a' || cha_str[i] == 'o' || cha_str[i] == 'y' || cha_str[i] == 'e' || cha_str[i] == 'u' || cha_str[i] == 'i')
                {
                    continue;
                }
                else
                {
                    Console.Write("." + cha_str[i]);
                }
            }
        }
    }
}