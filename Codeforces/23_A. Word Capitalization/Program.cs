using System;

namespace _23_A._Word_Capitalization
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            ch[0] = char.ToUpper(ch[0]);
            for (int i = 0; i < ch.Length; i++)
            {
                Console.Write(ch[i]);
            }
        }
    }
}