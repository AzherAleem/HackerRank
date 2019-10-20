using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HankerRank
{
    class CountingValley
    {
        // Complete the countingValleys function below.
        static int countingValleys(int n, string s)
        {
            int numberOfValleys = 0;
            int hike = 0; // 

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].ToString().Equals("U")) hike++;
                else if (s[i].ToString().Equals("D")) hike--;
                if(i!=0 && hike == 0 && s[i].ToString().Equals("U"))
                {
                    numberOfValleys++;
                }
            }

            return numberOfValleys;
        }
        static void Main2(string[] args)
        {
           // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int n = Convert.ToInt32(Console.ReadLine());
            int n = 8;
            //string s = Console.ReadLine();
            string s = "UDDDUDUU";
            int result = countingValleys(n, s);
            Console.WriteLine(result);
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
