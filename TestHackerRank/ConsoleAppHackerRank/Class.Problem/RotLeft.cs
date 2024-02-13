using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHackerRank.Class.Problem
{
    public class RotLeft
    {
        /// <summary>
        /// A left rotation operation on an array shifts each of the array's elements  unit to the left. For example, if  left rotations are performed on array , then the array would become . Note that the lowest index item moves to the highest index in a rotation. This is called a circular array.
        /// Given an array of  integers and a number, , perform  left rotations on the array.Return the updated array to be printed as a single line of space-separated integers.
        /// </summary>
        /// <param name="a">int a[n]: the array to rotate</param>
        /// <param name="d">int d: the number of rotations</param>
        /// <returns>int a'[n]: the rotated array</returns>
        public static List<int> rotLeft(List<int> a, int d)
        {
            List<int> retList = new ();
            retList.AddRange(a.GetRange(d, a.Count - d));
            retList.AddRange(a.GetRange(0, d));
            return retList;
        }
    }
}
