using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndArrayList_based_Problem;
class TakeMaximumInArray
{
    /// <summary>
    /// Return Maximum Number in list of array
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public int maximumInArray(int[] num)
    {
        int maximumvalue = num[0];
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] > maximumvalue)
            {
                maximumvalue = num[i];
            }
        }
        return maximumvalue;

    }
}
