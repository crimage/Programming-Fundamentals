/*Create a method that prints the sign of an integer number n.*/

using System;


    class Program
    {
    static void PrintSign(int number)
    {
        if (number > 0)
        {
            Console.WriteLine("The number {0} is positive.", number);
        }
        else if (number < 0)
        {
            Console.WriteLine("The number {0} is negative.", number);
        }
        else
        {
            Console.WriteLine("The number {0} is zero.", number);
        }
    }
        static void Main()
        {
        int number = int.Parse(Console.ReadLine());
        PrintSign(number);
        }
    }

