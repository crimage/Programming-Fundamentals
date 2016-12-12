/*
 	Refactor Special Numbers
int kolkko = int.Parse(Console.ReadLine());
int obshto = 0; int takova = 0; bool toe = false;
for (int ch = 1; ch <= kolkko; ch++)
{
    takova = ch;
    while (ch > 0)
    {
        obshto += ch % 10;
        ch = ch / 10;
    }
    toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
    Console.WriteLine($"{takova} -> {toe}");
    obshto = 0;
    ch = takova;
}
 */

using System;

namespace RefactorSpecialNumbers
{
    public class RefactorSpecialNumbers
    {
       public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int currentNum = 0;
            bool special = false;

            for (int num = 1; num <= n; num++)
            {
                currentNum = num;
                while (num > 0)
                {
                    totalSum += num % 10;
                    num = num / 10;
                }

                special = (totalSum == 5) || (totalSum == 7) || (totalSum == 11);
                Console.WriteLine($"{currentNum} -> {special}");
                totalSum = 0;
                num = currentNum;
            }
        }
    }
}