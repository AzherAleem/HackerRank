using System;
using System.Collections.Generic;
using System.Text;

namespace HankerRank
{
    class AVeryBigSum
    {
        static long aVeryBigSum(long[] ar)
        {
            //testing pull
	    //testing git
	    long sum = 0;
            for(int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }
            return sum;
        }

        static void Main6(string[] args)
        {
            // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int arCount = Convert.ToInt32(Console.ReadLine());
            int arCount = 5;
            //long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));
            long[] ar = { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
            long result = aVeryBigSum(ar);
            Console.WriteLine(result);
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
