using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Time_Test_
{
    class SparseMatrixCompress
    {


        public Dictionary<(int, int), int> compress(int[][] arr)
        {
            if (arr.Length == 0 || arr[0].Length == 0)
            {
                Console.WriteLine("Please The array must be 2 dimensional array ! \n please renter the array again!");
                return null;
            }
            var compressResult = new Dictionary<(int, int), int>();
            int rowsCount = arr.Length;//this to get the row count
            int colsCount = arr[0].Length;//this to get the column count
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    if (arr[i][j] != 0)
                    {
                        compressResult.Add((i, j), arr[i][j]);

                    }
                }
            }

            return compressResult;


        }


        public int[][] decompress2DArray(Dictionary<(int, int), int> map, int rows, int columns)
        {

            int[][] result = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                result[i] = new int[columns];
            }
            foreach (var element in map)
            {
                (int, int) key = element.Key;
                result[key.Item1][key.Item2] = element.Value;

            }
            return result;
        }
    }
}
