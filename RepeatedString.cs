using System;
using System.Collections.Generic;
using System.Text;

namespace HankerRank
{
    class RepeatedString
    {
        static long repeatedString(string s, long n)
        {
            long numberOfA = 0;
            if(s.Equals("a") && s.Length==1)
            {
                return n;
            }
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                if (j > s.Length - 1)
                {
                    j = 0;
                }
                if (s[j].ToString().Equals("a"))
                {
                    numberOfA++;
                }
                j++;
            }
            return numberOfA;
        }

        //optimized version
        static long repeatedString2(string s, long n)
        {
            long numberOfA = 0;
            long countA = 0;
            long countASub = 0;

            for (int i = 0; i < s   .Length; i++)
            {
                if (s[i].ToString().Equals("a"))
                {
                    countA++;
                }
            }
            for (int i = 0; i < n%s.Length; i++)
            {
                if (s[i].ToString().Equals("a"))
                {
                    countASub++;
                }
            }

            long quot = n / s.Length;
          //  long remainder = n % s.Length;
            numberOfA = (quot * countA) + countASub;
            
            return numberOfA;
        }
        static void Main4(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //string s = Console.ReadLine();
            string s = "ceebbcb";
            //long n = Convert.ToInt64(Console.ReadLine());
            long n = 817723;
            //long result = repeatedString(s, n);
            long result2 = repeatedString2(s, n);
            Console.WriteLine(result2);
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
