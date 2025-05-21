using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndArrayList_based_Problem;
class FindthirdLargeNumberInArray
{

    
    public int ThirdLargestNumber(int[] arr)
    {
        int result = arr[0];


        int thirdnumber = 0;
        int Firstnumber = 0;
        int Secondnumber = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < result)
            {
                Firstnumber = arr[i];
            }
            result++;
        }
        return thirdnumber;
    }
}
