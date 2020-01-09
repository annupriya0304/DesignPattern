﻿using System.CodeDom.Compiler;
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

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n)
    {

        var numberofa = s.Count(x => x == 'a');
        var numberofrep = n / s.Length;

        var modulues = n % s.Length;
        

        var sbstr = s.Substring(0,Convert.ToInt32(modulues));

        var numberofainmiised = sbstr.Count(x => x == 'a');


        return (numberofa * modulues + numberofainmiised);

    }

    static void Main(string[] args)
    {

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);
        Console.WriteLine(result);
    }
}