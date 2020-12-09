using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoTestsInterview
{
    public class NKSubstrings
    {
        public int divisorSubstrings(int n, int k)
        {
            var count = 0;
            var listKStrings = new List<string>();
            var nString = n.ToString();

            //find list substrings of length k
            for (int i = 0; i <= nString.Length - k; i++)
            {
                var s = nString.Substring(i, k);
                listKStrings.Add(s);
            }

            //make list of substrings distinct
            listKStrings = listKStrings.Distinct().ToList<string>();

            //iterate list of substrings and find which are divisible by n and increment counter
            foreach (var s in listKStrings)
            {
                int.TryParse(s, out int sInt);
                if (sInt > 0 && (n % sInt)== 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
