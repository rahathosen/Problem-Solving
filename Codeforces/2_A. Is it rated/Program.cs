using System;

//https://codeforces.com/problemset/problem/807/A
namespace _2_A._Is_it_rated
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var count1 = 0;
            var count2 = 0;
            var count3 = 0;
            var t = int.Parse(Console.ReadLine());

            var nStr = new string[t * 2]; //strng array
            var nInt = new int[t * 2];   //int array
            var nInt2 = new int[t * 2];

            for (int i = 0; i < t; i++)
            {
                nStr[i] = Console.ReadLine();  //take a string
                var splt_sStr = nStr[i].Split(' ');   //split string by space(' ')
                nInt[i] = int.Parse(splt_sStr[0]);  //splitstring convert to integer
                nInt2[i] = int.Parse(splt_sStr[1]);
            }
            for (int j = 0; j < t; j++)
            {
                if (nInt[j] != nInt2[j])
                {
                    count1++;  //rated
                }
                else if (nInt[j] == nInt2[j])
                {
                    if (nInt[j] < nInt[j + 1] && nInt2[j] < nInt2[j + 1])
                    {
                        count2++; //unrated
                    }
                }
                else
                {
                    count3++; //maybe
                }
            }
            if (count1 > 0)
            {
                Console.WriteLine("rated");
            }
            else if (count2 > 0)
            {
                Console.WriteLine("unrated");
            }
            else
            {
                Console.WriteLine("maybe");
            }
        }
    }
}