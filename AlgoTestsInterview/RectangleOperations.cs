using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoTestsInterview
{
    public class RectangleOperations
    {
        public bool[] rectangleBoxes(int[][] operations)
        {
            var result = new List<bool>();

            for (int i = 0; i < operations.Length; i++)
            {
                if(i==0 && operations[i][0] == 1)
                {
                    result.Add(true);
                    break;
                }

                if(operations[i][0] == 1)
                {
                    var itFits = true;
                    for (int j = 0; j < i; j++)
                    {
                        if (operations[j][0] == 0)
                        {
                            if (!ItFitsInRectangle(operations[j], operations[i]))
                            {
                                itFits = false;
                                break;
                            }
                        }
                    }
                    result.Add(itFits);
                }
            }

            return result.ToArray();
        }

        private bool ItFitsInRectangle(int[] child,int[] parent)
        {
                if (
                    (child[1] <= parent[1] && child[2] <= parent[2]) ||
                    (child[1] <= parent[2] && child[2] <= parent[1])
                    )
                {
                    return true;
                }
            return false;
        }
    }
}
