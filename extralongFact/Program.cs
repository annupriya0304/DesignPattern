using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace extralongFact
{
    class Solution
    {

        // Complete the extraLongFactorials function below.
        static void extraLongFactorials(int n)
        {
            BigInteger b = new BigInteger();
            b = 1;

            for(int i =n; i>0; i--)
            {
                b = b * i;
            }

            Console.WriteLine(b);

        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            extraLongFactorials(n);
        }
    }
}
