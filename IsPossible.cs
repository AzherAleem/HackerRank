using System;
using System.Collections.Generic;
using System.Text;

namespace HankerRank
{
    class IsPossible
    {
        public static string isPossible(int a, int b, int c, int d)
        {
            string result = "No";
            while(a < c || a!=c)
            {
                a = a + b;
            }
            while(b<d || b!=d)
            {
                a = a + b;
            }
            if (a == c && b == d)
                result = "YES";

            return result;
        }
        public static void Main(string[] args)
        {
            string result = isPossible(1, 2, 3, 6);
            Console.WriteLine(result);
        }
    }
}
