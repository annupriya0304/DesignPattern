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



class Result
{

    /*
     * Complete the 'processStrings' function below.
     *
     * The function is expected to return a STRING_ARRAY.
     * The function accepts following parameters:
     *  1. STRING str1
     *  2. STRING str2
     */

    public static List<string> processStrings(string str1, string str2)
    {
        char[] str1chararray = str1.ToCharArray();
        char[] str2charrarray = str2.ToCharArray();
        var diff1 = string.Join("", str1chararray.Except(str2charrarray));
        var diff2 = string.Join("", str2charrarray.Except(str1chararray));

        var ans = new List<string>();
        ans.Add(diff1);
        ans.Add(diff2);
        return ans;
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        string str1 = Console.ReadLine();

        string str2 = Console.ReadLine();

        List<string> result = Result.processStrings(str1, str2);
        
    }
}