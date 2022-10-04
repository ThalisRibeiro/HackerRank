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
using System.Diagnostics;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        var arrCount = arr.Count;
        string saida;
        var elements = new int[3] { 0, 0, 0 };
        var proportions = new decimal[3];
        for (int i = 0; i < arrCount; i++)
        {
            if (arr[i] > 0)
            {
                elements[0] +=1;
                //Console.WriteLine($"Quantidade de elementos maior que 0 {elements[0]}");
            }
            else if (arr[i]<0)
            {
                elements[1] +=1;
                //Console.WriteLine($"Quantidade de elementos menor que 0 {elements[1]}");
            }
            else if (arr[i] == 0)
            {
                elements[2] +=1;
                //Console.WriteLine($"Quantidade de elementos igual a 0 {elements[2]}");
            }
        }
        for (int i = 0; i < 3; i++)
        {
            if (elements[i] == 0)
            {
                proportions[i] = 0M;
            }
            else
            {
                proportions[i] = ((decimal)elements[i] / (decimal)arrCount);
            }//Console.WriteLine($"{Decimal.Round(proportions[i],6)}");
            saida = proportions[i].ToString("0.000000");
            Console.WriteLine($"{saida}");
        }
    }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.plusMinus(arr);
        }
    }
