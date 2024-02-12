using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHackerRank.Class.Problem
{
    internal class DiagonalDifference
    {        
        public static int diagonalDifference(List<List<int>> arr)
        {
            int qtdLines = arr.Count(), sumPriDia = 0, sumSecDia = 0;
            for (int m = 0; m < qtdLines; m++)
            {
                for (int n = 0; n < qtdLines; n++)
                {
                    if (m == n)
                        sumPriDia += arr[m][n];
                    if ((m + n) == (qtdLines - 1))
                        sumSecDia += arr[m][n];
                }
            }
            int val = sumPriDia - sumSecDia;
            return val < 0 ? val * -1 : val;
        }
    }
}
