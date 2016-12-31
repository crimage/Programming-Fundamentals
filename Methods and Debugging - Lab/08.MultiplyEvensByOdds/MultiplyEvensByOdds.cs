/*
Multiply Evens by Odds
*/
using System;

    class Program
    {
    
    static void Main()
         {
        int n = Math.Abs(int.Parse(Console.ReadLine()));
        Console.WriteLine(GetMultipleOfEvenAndOdds(n)); 
        }
    private static int GetMultipleOfEvenAndOdds(int n)
    {
        int sumEvens = GetSumOfEvenDigits(n);
        int sumOdds = GetSumOfOddDigits(n);
        return sumEvens * sumOdds;
    }
    private static int GetSumOfEvenDigits(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            int lastDigit = n % 10;
            if (lastDigit % 2 == 0)
            {
                sum += lastDigit;
            }
            n /= 10;
        }
        return sum;
    }
    private static int GetSumOfOddDigits(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            int lastDigit = n % 10;
            if (lastDigit % 2 != 0)
            {
                sum += lastDigit;
            }
            n /= 10;
        }
        return sum;
    }
}

