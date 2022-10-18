using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src
{
    public class Result
    {
        /*
     * Complete the 'countingSort' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

        public static List<int> countingSort(List<int> arr)
        {
            List<int> frequencyArr = new List<int>(new int[4]);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < arr.Count; j++)
                {
                    if (i == arr[j])
                    {
                        frequencyArr[i]++;
                    }
                }
            }

            return frequencyArr;
        }

    }
}