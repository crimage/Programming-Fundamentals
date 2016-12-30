/*
 Create a method for printing triangles as shown below:
    input: 4
    output: 1
1 2
1 2 3 
1 2 3 4
1 2 3
1 2
1
     */
using System;

    class Program
    {
    static void PrintLine(int start, int end)
    {
        for (int i  = start; i <= end; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
    static void PrintTriangle(int n)
    {
        for (int line = 1; line <= n; line++)
        {
            PrintLine(1, line);
        }
        for (int line = n - 1; line >= 1; line--)
        {
            PrintLine(1, line);
        }
    }

        static void Main()
        {
        int n = int.Parse(Console.ReadLine());
        PrintTriangle(n);
        }
    }
