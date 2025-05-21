using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndArrayList_based_Problem;
 class FindTargetNumber
{
    public static int ReturnTargetInt(int[] num,int target)
    {
        int result = 0;

        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] == target)
            {
                result = num[i];
            }
        }

        return result;

    } 
}
