using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangaroo
{
    public class Result
    {
        protected const string Yes = "YES";
        protected const string No = "NO";
        /* https://www.hackerrank.com/challenges/kangaroo/problem?isFullScreen=true
         * Complete the 'kangaroo' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts following parameters:
         *  1. INTEGER x1
         *  2. INTEGER v1
         *  3. INTEGER x2
         *  4. INTEGER v2
         */

        public static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            int kangaroo1 = x1;
            int kangaroo2 = x2;

            for(int i = 1; i <= 10000; i++) 
            {
                kangaroo1 += v1;
                kangaroo2 += v2;
                
                if(kangaroo1 == kangaroo2)
                {
                    return Yes;
                }
            }
            return No;
        }

    }
}
