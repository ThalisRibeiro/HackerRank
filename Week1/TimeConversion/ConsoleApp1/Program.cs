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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        var ending = s[s.Length - 2];
        string saida = "";
        switch (ending)
        {
            case 'A': saida = AmConverter(s);
                break;
            case 'P': saida = PmConverter(s);
                break ;
            default:
                break;
        }
        return saida;
    }

    private static string PmConverter(string s)
    {

        string horas = $"{s[0]}{s[1]}";
        int horasInt = Convert.ToInt32(horas);
        if(horasInt < 12)
        horasInt += 12;
        s = s.Remove(0, 2); s = s.Insert(0, $"{horasInt}");
        s = s.Remove(s.Length - 2);
        return s;
    }

    private static string AmConverter(string s)
    {
        if (s == null) return "erro";
        string horas = $"{s[0]}{s[1]}";
        switch (horas)
        {
            case "12": s = s.Remove(0, 2); s = s.Insert(0, "00");
                break;
            default:
                break;
        }
        s = s.Remove(s.Length - 2);
        return s;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
