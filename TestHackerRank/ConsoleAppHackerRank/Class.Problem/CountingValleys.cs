using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHackerRank.Class.Problem
{
    public class CountingValleys
    {
        public static int countingValleys(int steps, string path)
        {
            int way = 0, lastStep = 0, valley = 0;
            foreach (char c in path.ToUpper())
            {
                lastStep = way;

                if (c == 'U')
                    way++;

                if (c == 'D')
                    way--;


                if (way == -1 && lastStep == 0)
                    valley++;
            }
            return valley;
        }
    }
}
