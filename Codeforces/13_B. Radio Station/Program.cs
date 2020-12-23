using System;

//https://codeforces.com/problemset/problem/918/B
namespace _13_B._Radio_Station
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var splt = input.Split(' ');
            var n = int.Parse(splt[0]);
            var m = int.Parse(splt[1]);
            var ip = new string[1000];
            var ip2 = new string[1000];
            var name = new string[1000];
            var name2 = new string[1000];
            for (int i = 0; i < n; i++)
            {
                var serverInput = Console.ReadLine();
                var splt_serverName = serverInput.Split(' ');
                name[i] = splt_serverName[0];
                ip[i] = splt_serverName[1];
            }
            for (int j = 0; j < m; j++)
            {
                var commandInput = Console.ReadLine();
                var splt_commandInput = commandInput.Split(' ', ';');
                name2[j] = splt_commandInput[0];
                ip2[j] = splt_commandInput[1];
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (ip2[i] == ip[j])
                    {
                        Console.WriteLine($"{name2[i]} {ip2[i]}; #{name[j]}");
                    }
                }
            }
        }
    }
}