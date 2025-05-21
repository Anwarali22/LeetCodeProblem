using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndArrayList_based_Problem;
class FIndTargetNumIn2DArray
{
    //Jagged array: you're walking through arrays of arrays.
    // Rectangular array: you're walking through a solid grid.
    public int[][] findTargetNum2DArray(int[][] arr, int target)
    {

        for (int row = 0; row < arr.Length; row++)
        {
            for (int col = 0; col < arr[row].Length; col++)
            {
                if (arr[row][col] == target)
                {
                    return new int[][] { new int[] { row, col } };
                }
            }


        }
        return new int[][] { new int[] { 0, 0 } };

    }

    public int[] findTargetIndexNormalArray(int[,] normalArray, int target)
    {
        for (int row = 0; row < normalArray.GetLength(0); row++)
        {
            for (int col = 0; col < normalArray.GetLength(1); col++)
            {
                if (normalArray[row, col] == target)
                {
                    return new int[] { row, col };
                }
            }
        }
        return new int[] {0,0 };
    }
}