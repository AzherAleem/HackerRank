using System;
using System.Collections.Generic;
using System.IO;

namespace HankerRank
{
    class SockMerchant
    {
            // Complete the sockMerchant function below.
            static int sockMerchant(int n, int[] ar)
            {

                int totalPairs = 0;
                List<int> PairIndexList = new List<int>();

                for (int i = 0; i < n ; i++)
                {
                    int temp = ar[i];
                    for (int j = 0; j < n && j!=i; j++)
                    {
                        if (temp == ar[j] && !PairIndexList.Contains(i) && !PairIndexList.Contains(j))
                        {
                            PairIndexList.Add(i);
                            PairIndexList.Add(j);
                            continue;
                        }
                    }
                }
            if (PairIndexList.Count > 0)
                totalPairs = PairIndexList.Count / 2;
                return totalPairs;
            }

            static void Main1(string[] args)
            {
                //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
                //int n = Convert.ToInt32(Console.ReadLine());
                int n = 9;
                //int[] ar = { 1, 1, 2, 6, 2, 2, 3, 1, 2 };
                int[] ar = { 10 ,20, 20, 10, 10, 30, 50, 10, 20 };

                //int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

                int result = sockMerchant(n, ar);
                Console.WriteLine(result);
                //textWriter.WriteLine(result);
                //textWriter.Flush();
                //textWriter.Close();
            }

    }
}

