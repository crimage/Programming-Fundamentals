/*
 Draw at the console a filled square of size n like in the example
 input: 4
 output:
--------
-\/\/\/-
-\/\/\/-
--------
 */

using System;

    class Program
    {
    static void PrintHeaderRow(int n)
    {
        Console.WriteLine(new string ('-', 2 * n));
    }
    static void PrintMiddleRow(int n)
    {
        Console.Write('-');
        for (int i = 1; i < n; i++)
        {
            Console.Write("\\/");
        }
        Console.WriteLine('-');
    }
    static void PrintFooterRow(int n)
    {
        Console.WriteLine(new string('-', 2 * n));
    }
    
    static void Main()
        {
        int n = int.Parse(Console.ReadLine());
        PrintHeaderRow(n);
        for (int i = 0; i < n - 2; i++)
        {
            PrintMiddleRow(n);
        }       
        PrintFooterRow(n);
     }
    }
