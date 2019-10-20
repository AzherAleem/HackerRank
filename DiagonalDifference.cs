using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HankerRank
{
    class DiagonalDifference
    {

        class Result
        {

            public static int diagonalDifference(List<List<int>> arr)
            {
                int absoluteDiff = 0;
                int sumRightDiag = 0;
                int sumLeftDiag = 0;
                int k = arr.Count - 1;

                for (int i = 0; i < arr.Count; i++)
                {
                    for (int j = 0; j < arr[i].Count; j++)
                    {
                        if (i == j) sumRightDiag += arr[i][j];
                        
                    }
                    sumLeftDiag += arr[i][k];
                    k--;
                }

                absoluteDiff = sumRightDiag - sumLeftDiag;
                if (absoluteDiff < 0) absoluteDiff *= -1;

                return absoluteDiff;
            }

        }

        class Solution
        {
            public static void Main7(string[] args)
            {
                // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

                int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<List<int>> arr = new List<List<int>>();

                for (int i = 0; i < n; i++)
                {
                    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
                }

                int result = Result.diagonalDifference(arr);
                Console.WriteLine(result);
                //textWriter.WriteLine(result);

                //textWriter.Flush();
                //textWriter.Close();
            }
        }
    }
}
