using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var sr = new StreamReader(Console.OpenStandardInput());
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        var entrada = sr.ReadToEnd();
        string saida = "";
        var frases = new List<string>();
        var dados = new List<string>();

        frases = entrada.Split("\n").Where(x => x != "").ToList();

        for (int i = 0; i < frases.Count(); i++)
        {
            if(i>0)
            saida = $"{saida}\n";
            //Console.WriteLine($"frase {i}: {lista[i]} ");
            dados = frases[i].Split(";").ToList();
            switch (dados[0])
            {
                case "C":
                    saida += CombineMethod(dados[2].Split(" "), dados[1]);
                    break;
                case "S":
                    saida += Split(dados[2], dados[1]);
                    break;
                default:
                    break;
            }
        }

        textWriter.WriteLine(saida);

        textWriter.Flush();
        textWriter.Close();
    }

    private static string Split(string palavra, string letra)
    {
        if (letra == "M")
            palavra = palavra.Remove(palavra.Length - 2, 2);
        int i = 0;
        do
        {
            if (VerificaIgualdade(palavra[i].ToString()))
            {
                palavra = palavra.Insert(i, palavra[i].ToString().ToLower());
                palavra = palavra.Remove(i + 1, 1);
                palavra = palavra.Insert(i, " ");
                i += 1;
            }
            i += 1;
        } while (i < palavra.Length);
        palavra = palavra.TrimStart();
        Console.WriteLine(palavra);
        return palavra;
    }
    private static bool VerificaIgualdade(string letra)
    {
        if (letra == letra.ToUpper())
            return true;
        return false;
    }
    private static string CombineMethod(string[] lista, string letra)
    {
        string saida = "";
        for (int i = 0; i < lista.Count(); i++)
        {
            switch (i)
            {
                case 0:
                    if (letra == "C")
                        lista[i] = PrimeiraLetraUpper(lista, i);
                    else
                        lista[i] = lista[i].ToLower();
                    break;
                default:
                    lista[i] = PrimeiraLetraUpper(lista, i);
                    break;
            }
            saida += $"{lista[i]}";
        }
        if (letra == "M")
            saida = saida.Insert(saida.Length, "()");
        Console.WriteLine(saida.TrimEnd());
        return saida;
    }

    private static string PrimeiraLetraUpper(string[] lista, int i)
    {
        var primeiraLetra = lista[i][0].ToString().ToUpper();
        lista[i] = $"{primeiraLetra}{lista[i].Remove(0, 1)}";
        return lista[i];
    }
}
