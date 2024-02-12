using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHackerRank.Class.Problem
{
    internal class StairCase
    {
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
