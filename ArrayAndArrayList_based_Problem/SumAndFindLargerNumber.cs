using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndArrayList_based_Problem;
class SumAndFindLargerNumber
{
    /// <summary>
    /// Return the maximum value of accounts
    /// </summary>
    /// <param name="accounts"></param>
    /// <returns></returns>
    public int MaximumWealth(int[][] accounts)
    {

        int max = 0;
        #region approach 1
        for (int i = 0; i < accounts.Length; i++)//calculate the row
        {
            int sum = 0;
            for (int j = 0; j < accounts[i].Length; j++)//calculate the column
            {
                sum += accounts[i][j]; //add all the column based each row
            }

            if (sum > max)//check max number
            {
                max = sum;
            }
        }
        #endregion

        #region approach 2
        int ans = 0;
        foreach(int[] person in accounts)
        {
            int MaxOfRow = 0;
            foreach(int account in person)
            {
                MaxOfRow += account;
            }
            if (MaxOfRow > ans)
            {
                ans = MaxOfRow;
            }
        }
        #endregion
        return ans;
    }
}
