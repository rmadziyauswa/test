using System;
using System.Linq;
using System.Collections.Generic;

namespace AlgoTestsInterview
{
    public class PythagoreanTripple
    {
        public int[] tripleSquareSum(int[] a)
        {
            var result = new List<int>();
            for (int i = 0; i < a.Length -2; i++)
            {
                result.Add(isPythagoreanTripple(a[i], a[i + 1], a[i + 2]));
            }

            return result.ToArray<int>();
        }

        private int isPythagoreanTripple(int a,int b,int c)
        {
            if(
                Math.Pow(a,2) + Math.Pow(b,2) == Math.Pow(c,2) ||
                Math.Pow(a,2) + Math.Pow(c,2) == Math.Pow(b,2) ||
                Math.Pow(c,2) + Math.Pow(b,2) == Math.Pow(a,2)
                )
            {
                return 1;
            }
            return 0;
        }
    }
}
