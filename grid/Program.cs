using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the gridChallenge function below.
    static string gridChallenge(string[] grid)
    {
        string[] column = new string[grid.Length];
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid.Length; j++)
            {

                column[i] += grid[j][i];
            }
          var sorted = new string(column[i].OrderBy(c => c).ToArray());
            if (column[i] != sorted)
                return "NO";

        }
        return "YES";

    }

    static void Main(string[] args)
    {

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string[] grid = new string[n];

            for (int i = 0; i < n; i++)
            {
                string gridItem = Console.ReadLine();
                grid[i] = gridItem;
                grid[i] = new string(grid[i].OrderBy(c => c).ToArray());
            }

            string result = gridChallenge(grid);
            Console.WriteLine(result);
            
        }
        
    }
}
