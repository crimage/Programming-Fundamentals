/*
You are given a program that checks if numbers in a given range [2...N] are prime. For each number is printed "{number} is prime -> {True or False}". 
The code however, is not very well written. Your job is to modify it in a way that is easy to read and understand.

int ___Do___ = int.Parse(Console.ReadLine());
for (int DAVIDIM = 0; DAVIDIM <= ___Do___; DAVIDIM++)
{
    bool TowaLIE = true;
    for (int delio = 2; delio <= Math.Sqrt(DAVIDIM); delio++)
    {
        if (DAVIDIM % delio == 0)
        {
            TowaLIE = false;
            break;
        }
    }
    Console.WriteLine($"{DAVIDIM} is prime -> {TowaLIE}");
}

 */


using System;

namespace FastPrimeChecker
{
    public class FastPrimeChecker
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int number = 2; number <= n; number++)
            {
                bool isPrime = true;

                for (int numberTwo = 2; numberTwo <= Math.Sqrt(number); numberTwo++)
                {
                    if (number % numberTwo == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{number} -> {isPrime}");
            }

        }
    }
}
