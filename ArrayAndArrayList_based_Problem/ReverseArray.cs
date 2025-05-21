using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndArrayList_based_Problem;
class ReverseArray
{
    /// <summary>
    /// Return the list aray reversed
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] reverseArray(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left < right)
        {
            int temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;
            left++;
            right--;

        }
        return nums;
    }
}
