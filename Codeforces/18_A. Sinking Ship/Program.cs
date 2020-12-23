using System;
using System.Collections.Generic;

//https://codeforces.com/problemset/problem/63/A
namespace _18_A._Sinking_Ship
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var name = new string[101];
            var type = new string[101];
            List<string> rat = new List<string>();
            List<string> woman = new List<string>();
            List<string> man = new List<string>();
            List<string> captain = new List<string>();

            for (int i = 0; i < n; i++)
            {
                var str = Console.ReadLine();
                var spltStr = str.Split(' ');
                name[i] = spltStr[0];
                type[i] = spltStr[1];
                if (type[i] == "rat")
                {
                    rat.Add(name[i]);
                }
                else if (type[i] == "woman")
                {
                    woman.Add(name[i]);
                }
                else if (type[i] == "child")
                {
                    woman.Add(name[i]);
                }
                else if (type[i] == "man")
                {
                    man.Add(name[i]);
                }
                else if (type[i] == "captain")
                {
                    captain.Add(name[i]);
                }
            }

            for (int i = 0; i < rat.Count; i++)
            {
                Console.WriteLine($"{rat[i]}");
            }
            for (int i = 0; i < woman.Count; i++)
            {
                Console.WriteLine($"{woman[i]}");
            }
            for (int i = 0; i < man.Count; i++)
            {
                Console.WriteLine($"{man[i]}");
            }
            for (int i = 0; i < captain.Count; i++)
            {
                Console.WriteLine($"{captain[i]}");
            }
        }
    }
}