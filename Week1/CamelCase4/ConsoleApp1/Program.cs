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
        var entrada = Console.ReadLine();
        string saida="";
        var lista = new string[3];
        lista = entrada.Split(";");
        switch (lista[0])
        {
            case "C": //Combine(lista);
                saida = CombineMethod(lista[2].Split(" "), lista[1]);
                break;
            case "S":
                saida = Split(lista[2], lista[1]);
                break;
            default:
                break;
        }
        Console.WriteLine(saida);
       // Console.WriteLine($"0 {lista[0]} 1{lista[1]} 2 {lista[2]}");
    }

    private static string Split(string palavra, string letra)
    {
        if(letra == "M")
            palavra = palavra.Remove(palavra.Length - 2, 2);
        int i = 0;
        do
        {
            if (VerificaIgualdade(palavra[i].ToString()))
            {
                palavra=palavra.Insert(i, palavra[i].ToString());   
                palavra=palavra.Remove(i+1, 1);
                palavra = palavra.Insert(i, " ");
                i += 1;
            }
            i += 1;

        } while (i <palavra.Length);
        palavra = palavra.TrimStart();
        return palavra;
    }
    private static bool VerificaIgualdade(string letra)
    {
        if(letra == letra.ToUpper())
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
                    if(letra=="C")
                        lista[i] = PrimeiraLetraUpper(lista, i);
                    else
                    lista[i] = lista[i].ToLower();
                    break;
                default:
                    lista[i]= PrimeiraLetraUpper(lista, i);
                    break;
            }
            saida += $"{lista[i]}";
        }
        if(letra=="M")
        saida = saida.Insert(saida.Length, "()");
        return saida;
    }

    private static string PrimeiraLetraUpper(string[] lista, int i)
    {
        var primeiraLetra = lista[i][0].ToString().ToUpper();
        lista[i] = $"{primeiraLetra}{lista[i].Remove(0, 1)}";
        return lista[i];
    }
}