using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution
{
    class Solution
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var words = line.Split(' ').ToArray();
            int i = 0;
            foreach(var word in words)
            {
                var tcount = word.Count(x => x == 't');
                if(tcount==1 || tcount==3)
                {
                    i++;
                    Console.WriteLine(string.Join("",word.ToCharArray().Reverse()));
                }
            }

            if(i==0)
            {
                Console.WriteLine("None");
            }
        }
    }
}