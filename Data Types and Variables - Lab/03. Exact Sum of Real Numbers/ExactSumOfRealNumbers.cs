/*
Write program to enter n numbers and calculate and print their exact sum (without rounding). 
*/
using System;

namespace ExactSumOfRealNumbers
{
   public class ExactSumOfRealNumbers
    {
       public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
