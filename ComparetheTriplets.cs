using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HankerRank
{
    class CompareTheTriplets { 
        // Complete the compareTriplets function below.
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> lstScore = new List<int>();
            int scoreA = 0;
            int scoreB = 0;
            for( int i= 0; i < a.Count; i ++)
            {
                if (a[i] > b[i]) scoreA++;
                else if (b[i] > a[i]) scoreB++;
            }
            lstScore.Add(scoreA);
            lstScore.Add(scoreB);

            return lstScore;
        }

        static void Main5(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> a = new List<int>();
            a.Add(17);
            a.Add(28);
            a.Add(30);
            //List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();
            List<int> b = new List<int>();
            b.Add(99);
            b.Add(16);
            b.Add(8);
            List<int> result = compareTriplets(a, b);
            
            for(int i = 0; i < result.Count;i++)
            {
                Console.WriteLine(result[i]);
            }
            //Console.WriteLine(result);
            //textWriter.WriteLine(String.Join(" ", result));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
