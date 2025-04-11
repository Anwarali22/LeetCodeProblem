using System;

namespace Two_sum
{
    class Program
    {
        public static void Main(string[] args)
        {

        }

        #region Two_Sum
        public int[] TwoSum(int[] nums, int target)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }

                }
            }
            return null;
        }
        #endregion
    }
}