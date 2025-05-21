using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndArrayList_based_Problem;
 class FindMiimumNumber
{
    public int findMinNumber(int[] arr)
    {
        int min=arr[0];

        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min=arr[i];

            }
        }
        return min;
    }
}
