using System;

namespace ArrayAndArrayList_based_Problem
{
    class Program
    {
        public static void Main(string[] args)
        {
            //   ArrayWithDifferentLength();
            //ReverseArray reverseArray = new ReverseArray();
            //int[] arr = { 1, 3, 4, 5, 6 };

            //int[] value = reverseArray.reverseArray(arr);
            //Console.WriteLine(string.Join(",", value));

            //int[] TakeMaximumValue = { 1, 22, 33, 444, 55, 66 };
            //TakeMaximumInArray takeMaximumInArray = new TakeMaximumInArray();
            //int maxValue=takeMaximumInArray.maximumInArray(TakeMaximumValue);
            //Console.WriteLine(maxValue);

            int[] ReturnTargetNum = { 1, 22, 33, 44, 55, 66, 9, 0 };
            int targetNum = 9;
            FindTargetNumber findTargetNumber = new FindTargetNumber();
            int values = FindTargetNumber.ReturnTargetInt(ReturnTargetNum, targetNum);
            // Console.WriteLine(values);

            SearchNumberInRange searchNumberInRange = new SearchNumberInRange();
            var searchvalue = searchNumberInRange.SearchNumberInRanges(ReturnTargetNum, targetNum);
            //    Console.WriteLine(searchvalue);

            FindMiimumNumber findMiimumNumber = new FindMiimumNumber();
            int min = findMiimumNumber.findMinNumber(ReturnTargetNum);
          //  Console.WriteLine(min);

            int[][] FindMinTargetArray = new int[][]{
                                                    new int[]{ 1, 2, 3 },
                                                    new int[]{ 4, 5, 6 },
                                                    new int[]{ 7, 8, 9 }
                                                     };
            FIndTargetNumIn2DArray fIndTargetNumIn2DArray = new FIndTargetNumIn2DArray();
            int targetIndex = 6;
            int[][] returnIndex = fIndTargetNumIn2DArray.findTargetNum2DArray(FindMinTargetArray, targetIndex);
           // Console.WriteLine($"Target found at: [{returnIndex[0][0]}, {returnIndex[0][1]}]");



            int[] nums = [12, 345, 2, 6, 7896];
            FindEvenDigitsCount findEvenDigitsCount = new FindEvenDigitsCount();


            FindthirdLargeNumberInArray findthirdLargeNumberInArray = new FindthirdLargeNumberInArray();
            int thirdlargenum=findthirdLargeNumberInArray.ThirdLargestNumber(nums);
           // Console.WriteLine(thirdlargenum);

            int[][] MaxInt = { [1, 2, 3], [13, 2, 1] };
            SumAndFindLargerNumber sumAndFindLarger = new SumAndFindLargerNumber();
            int MaxValue=sumAndFindLarger.MaximumWealth(MaxInt);
            Console.WriteLine(MaxValue);
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

        #region 2d Array with different column length
        public static void ArrayWithDifferentLength()
        {
            int[][] nums = new int[][]
            {
                new int []{ 1,2,3 },
                new int[] { 4, 5 },
                new int[] { 6, 7, 8 }
            };

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums[i].Length; j++)
                {
                    Console.Write(nums[i][j] + " ");
                }
                Console.WriteLine();
            }

            foreach (int[] arrs in nums)
            {
                foreach (int i in arrs)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
        #endregion



    }
}