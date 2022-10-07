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
        var lista = new string[3];
        lista = entrada.Split(";");
        switch (lista[0])
        {
            case "C": Combine(lista);
                break;
            default:
                break;
        }
        
        Console.WriteLine($"0 {lista[0]} 1{lista[1]} 2 {lista[2]}");
    }

    private static void Combine(string[] lista)
    {
        string saida = "";
        switch (lista[1])
        {
            case "M":
                lista = lista[2].Split(" ");
                saida = CombineMethod(lista,"M");
                Console.WriteLine($"Combine Method: {saida}");
                break;
            case "V":
                lista = lista[2].Split(" ");
                saida = CombineMethod(lista, "V");
                Console.WriteLine($"Combine V: {saida}");
                break;
            case "C":

                lista = lista[2].Split(" ");
                saida = CombineMethod(lista, "C");
                Console.WriteLine($"Combine C: {saida}");
                break;
            default:
                break;
        }
        
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