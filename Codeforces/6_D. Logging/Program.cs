using System;

//https://codeforces.com/problemset/problem/16/D
/*
Easy thought

First of all, turn all log time into minutes,
then enter the cycle comparison,
and compare this time with the previous one.
If the result is less than 0, add one day to the counter,
equal to zero, add one day to the counter.
When the counter is full of 10 days,
pay attention to 12:00 am in the morning,
the counter and the number of days should be 1 at the beginning.
The counter is used to record the number of times a value appears;
the number of log days is at least 1).

*/

namespace _6_D._Logging
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            #region first method

            /*

            //var dt = DateTime.Now;
            //Console.WriteLine("hh:mm tt Format: " + dt.ToString("[hh:mm]"));
            var count = 0;

            var n = int.Parse(Console.ReadLine());
            var input = new string[100];
            var spltInput = new string[100];
            var ampm = new string[100];
            var hourInt = new int[100];
            var secondInt = new int[100];

            var timestirng = new string[100];

            //var input = Console.ReadLine();
            // var spltInput = input.Split('[', ' ', '.');

            //DateTime d = DateTime.Parse(spltInput[1]);
            // Console.WriteLine(d.ToString("HH:mm"));

            for (int i = 0; i < n; i++)
            {
                input[i] = Console.ReadLine();
                spltInput = input[i].Split('[', ':', ' ', '.');
                //timestirng[i] = spltInput[1];
                hourInt[i] = int.Parse(spltInput[1]);
                secondInt[i] = int.Parse(spltInput[2]);
                ampm[i] = spltInput[3];
            }
            for (int j = 0; j < n; j++)
            {
                //  Console.WriteLine(timeInt[j]);
                //  Console.WriteLine(ampm[j]);
                if (n == 1)
                {
                    count++;
                    break;
                }
                if (hourInt[j] > hourInt[j + 1])
                {
                    if (hourInt[n - 1] < hourInt[n - 2])
                    {
                        count++;
                    }
                    else if (hourInt[n - 1] > hourInt[n - 2] && hourInt[j + 1] != 0)
                    {
                        continue;
                    }
                    else
                        count++;
                }
                if (hourInt[j] == hourInt[j + 1])
                {
                    if (ampm[j] != ampm[j + 1])
                    {
                        count++;
                    }
                    else if (secondInt[j] > secondInt[j + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"{count}");

            */

            #endregion first method

            #region second method

            /*var count = 1;
            var cnt = 0;
            var ans = 0;

            var n = int.Parse(Console.ReadLine());
            var input = new string[100];
            var spltInput = new string[100];

            var am_pm = new string[100];  // a,p
            var hour = new int[100];      // hh
            var minuts = new int[100];   //  mm
            var x = new int[100];

            for (int i = 0; i < n; i++)
            {
                input[i] = Console.ReadLine();
                spltInput = input[i].Split('[', ':', ' ', '.');

                hour[i] = int.Parse(spltInput[1]);
                minuts[i] = int.Parse(spltInput[2]);
                am_pm[i] = spltInput[3];
            }
            for (int i = 0; i < n; i++)
            {
                if (hour[i] == 12 && am_pm[i] == "a")
                    hour[i] = 0;
                else if (hour[i] != 12 && am_pm[i] == "p")
                    hour[i] += 12;

                x[i] = hour[i] * 60 + minuts[i];
                if (x[i] == x[i - 1])
                    cnt++;
            }
            for (int i = 0; i < n; i++)
            {
                if (x[i - 1] > x[i])
                    count++;
            }
            ans = cnt + count / 10;
            Console.WriteLine($"{ans}");*/

            #endregion second method

            #region third mehtod trying

            int count = 1;
            var output = 0;
            var m = 1441; //14:41 time for 12 hour clock system [Military time]https://24hourtime.net/14-41-time
            var m2 = 0;

            var n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                m2 = hh_To_mm(input[1], input[2], input[4], input[5], input[7]);
                if (m > m2)
                {
                    output += 1;
                    count = 1;
                }
                else if (m == m2)
                {
                    count++;
                    if (count > 10)
                    {
                        output++;
                        count = 1;
                    }
                }
                else
                {
                    count = 1;
                }

                m = m2;
            }
            Console.WriteLine(output);
        }

        public static int hh_To_mm(char h1, char h2, char m1, char m2, char am_pm)
        {
            var hh = ((h1 - '0') * 10) + (h2 - '0');
            var mm = ((m1 - '0') * 10) + (m2 - '0');
            if (h1 == '1' && h2 == '2')
            {
                hh = 0;
            }
            var s = (hh * 60) + mm;
            if (am_pm == 'p')
            {
                s = s + (12 * 60);
            }
            return s;

            #endregion third mehtod trying
        }
    }
}