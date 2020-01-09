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

    static void insertionSort2(int n, int[] arr)
    {
        // Complete this function

        for (int k = 0; k < arr.Length - 1; k++)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int key = arr[k + 1];
                if (i == k + 1)
                    break;
                if (arr[i] > key)
                {
                    arr[k + 1] = arr[i];
                    arr[i] = key;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }

    static void main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int m = Convert.ToInt32(Console.ReadLine());

        int[] brr = Array.ConvertAll(Console.ReadLine().Split(' '), brrTemp => Convert.ToInt32(brrTemp))
        ;
        int[] result = missingNumbers(arr, brr);

        Console.WriteLine(result);
    }



    // Complete the missingNumbers function below.
    static int[] missingNumbers(int[] arr, int[] brr)
    {
        int count = brr.Length - arr.Length;

        int[] arrresult = new int[count];
        var arrayresult = new List<int>();

        int[] brrdist = brr.Distinct().ToArray();

        for(int i =0; i<brrdist.Length; i++)
        {
            int counina = arr.Count(x => x == brrdist[i]);
            int couninb = brr.Count(x => x == brrdist[i]);
            if(couninb > counina)
            {
                arrayresult.Add(brrdist[i]);
            }
        }

        arrresult = arrayresult.ToArray();
        Array.Sort(arrresult);

        return arrresult;

    }

  
}

