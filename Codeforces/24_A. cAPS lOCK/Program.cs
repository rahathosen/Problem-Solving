using System;

//https://codeforces.com/problemset/problem/131/A

namespace _24_A._cAPS_lOCK
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool IsCheck = true;
            var str = Console.ReadLine();
            char[] temp = str.ToCharArray();
            for (int i = 1; i < str.Length; i++)
            {
                if (char.IsLower(str[i]))
                {
                    IsCheck = false;
                }
            }
            if (IsCheck == true)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsLower(str[i]))
                    {
                        temp[i] = char.ToUpper(str[i]);
                    }
                    else
                        temp[i] = char.ToLower(str[i]);
                    Console.Write($"{temp[i]}");
                }
            }
            else
                Console.Write($"{str}");
        }
    }
}