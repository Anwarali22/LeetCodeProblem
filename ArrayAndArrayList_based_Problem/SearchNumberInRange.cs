using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndArrayList_based_Problem;
 class SearchNumberInRange
{
    public int SearchNumberInRanges(int[]arr,int target)
    {
        int IndexNumber = -1;
        for(int i = 1; i <= 4; i++)
        {
            if (arr[i] == target)
            {
                return IndexNumber=i;
            }
        }

        return IndexNumber;

    }
}
