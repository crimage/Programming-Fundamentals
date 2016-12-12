/*
Write a program to read an integer n and for all numbers in the range 1…n to print the number and if it is special or not (True / False).
*/

using System;
public class SpecialNumbers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int num = 1; num <= n; num++)
        {
            int sum = 0;
            int dig = num;
            while (dig > 0)
            {
                sum = sum + dig % 10;
                dig = dig / 10;
            }
            bool special = sum == 5 || sum == 7 || sum == 11;
            Console.WriteLine("{0} -> {1}", num, special);

        }

    }
}
