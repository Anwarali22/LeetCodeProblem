using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndArrayList_based_Problem;
class FindEvenDigitsCount
{

    /// <summary>
    /// find the number of digit are even
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public int findCountOfevenNum(int[] arr)
    {
        int EvenNumCount = 0;
        for (int i = 0; i < arr.Length; i++)
        {

            if (even(arr[i]))
            {
                EvenNumCount++;
            }
        }
        return EvenNumCount;
    }

    /// <summary>
    /// passed parameter number is even or odd
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public bool even(int n)
    {
        #region approach 1
        int lengthOfNum = Count(n);
        if (lengthOfNum % 2 == 0)
        {
            return true;
        }
        return false;
        #endregion

        #region approach 2
        //return lengthOfNum % 2 == 0;    
        #endregion


    }
    /// <summary>
    /// Return the digit count of given number
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Count(int n)
    {
        #region approach 1
        if (n > 0)
        {
            n = n * -1;
        }
        if (n == 0) 
        {
            return -1;
        }

        int count = 0;
        while (n > 0)
        {
            count++;
            n = n / 10;
        }
        return count;
        #endregion

        #region approach 2
     //   return (int)(Math.Log10(n));
        #endregion



    }

}
