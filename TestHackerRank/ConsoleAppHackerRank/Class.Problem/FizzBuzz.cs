using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHackerRank.Class.Problem
{
    public class FizzBuzz
    {
        public static string fizzBuzz(int n)
        {
            var ret = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                bool multi3 = (i % 3) == 0, multi5 = (i % 5) == 0;
                if (multi3 && multi5)
                    ret = string.Concat(ret, @"FizzBuzz\r\n");
                else if (multi3)
                    ret = string.Concat(ret, @"Fizz\r\n");
                else if (multi5)
                    ret = string.Concat(ret, @"Buzz\r\n");
                else
                    ret = string.Concat(ret, i.ToString(), @"\r\n");
            }

            return ret;
        }
    }
}
