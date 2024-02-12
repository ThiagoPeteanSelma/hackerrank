﻿namespace TestHackerRank.Class.Problem
{
    internal class LonelyInteger
    {
        public static int lonelyInteger(List<int> a)
        {
            return a.GroupBy(x => x).Where(x => x.Count() <= 1).Select(x => x.Key).First();
        }
    }
}