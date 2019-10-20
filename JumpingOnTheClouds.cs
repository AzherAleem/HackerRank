using System;
using System.Collections.Generic;
using System.Text;

namespace HankerRank
{
    class JumpingOnTheClouds
    {
        static int jumpingOnClouds(int[] c)
        {
            int minNumberOfSteps = 0;

            for(int i = 0; i < c.Length; )
            {
                if( i+2 < c.Length && c[i+2] == 0)
                {
                    minNumberOfSteps++;
                    i = i+2;
                }
                else if(i + 1 < c.Length && c[i + 1] == 0)
                {
                    minNumberOfSteps+=1;
                    i = i + 1;
                }
                else
                {
                    break;
                }
            }   
            return minNumberOfSteps;
        }
        static void Main3(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int n = Convert.ToInt32(Console.ReadLine());
            //int n = 7;
            //int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
            int[] c = { 0, 0, 1, 0, 0, 1, 0 };
            //int[] c = { 0, 0, 0, 0, 1, 0 };
            int result = jumpingOnClouds(c);
            Console.WriteLine(result);
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }

    }
}
