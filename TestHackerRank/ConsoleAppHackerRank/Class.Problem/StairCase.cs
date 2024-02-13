using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHackerRank.Class.Problem
{
    public class StairCase
    {
        /// <summary>
        /// Staircase detail
        ///This is a staircase of size :     
        ///   #
        ///  ##
        /// ###
        ///####
        ///Its base and height are both equal to.It is drawn using # symbols and spaces. The last line is not preceded by any spaces.
        ///Write a program that prints a staircase of size.
        /// </summary>
        /// <param name="n">The function accepts INTEGER n as parameter.</param>
        /// <returns>The function return a string with \r\n (break line)</returns>
        public static string stairCase(int n)
        {
            List<string> l = new();
            for (int i = 1; i <= n; i++)
            {
                string text = string.Empty;
                for (int j = i; j < n; j++)
                {
                    text = string.Concat(text, " ");
                }
                for (int j = text.Length; j < n; j++)
                {
                    text = string.Concat(text, "#");
                }
                l.Add(text);
            }

            return String.Join(@"\r\n", l);
        }
    }
}
