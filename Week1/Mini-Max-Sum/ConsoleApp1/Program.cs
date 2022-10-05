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
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    //retorna a soma minima e maxima de 4 inteiros
    public static uint[] Somas(List<uint> arrMin, List<uint> arrMax)
    {
        var minMaxSum = new uint[2] {0,0};
        for (int i = 0; i < 4; i++)
        {
            minMaxSum[0]+= arrMin[i];
            minMaxSum[1] += arrMax[i];
        }
        return minMaxSum;
    }
    
    //retorna uma lista com os numeros em ordem crescente
    public static List<uint> MinSum(List<uint> arr)
    {
        arr = arr.OrderBy(x => x).ToList();
        return arr;
        //Console.Write($"Lista menor maior: ");
        //for (int i = 0; i < arr.Count; i++)
        //{
        //    Console.Write($"{arr[i]} ");
        //}
    }

    //retorna uma lista com os numeros em ordem decrescente
    public static List<uint> MaxSum(List<uint> arr)
    {
        arr = arr.OrderByDescending(x => x).ToList();
        return arr;
    }


    public static void MiniMaxSum(List<uint> arr)
    {
        var minMaxSum = Somas(MinSum(arr), MaxSum(arr));
        Console.WriteLine($"{minMaxSum[0]} {minMaxSum[1]}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<uint> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToUInt32(arrTemp)).ToList();

        Result.MiniMaxSum(arr);
    }
}
