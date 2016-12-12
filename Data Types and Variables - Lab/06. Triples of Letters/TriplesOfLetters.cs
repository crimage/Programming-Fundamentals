/*
Write a program to read an integer n and print all triples of the first n small Latin letters, ordered alphabetically:
*/

using System;
namespace TriplesOfLetters
{
    public class TriplesOfLetters
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int num = 0; num < n; num++)
            {
                for (int num1 = 0; num1 < n; num1++)
                {
                    for (int num2 = 0; num2 < n; num2++)
                    {
                        Console.WriteLine("{0}{1}{2}", (char)('a' + num), (char)('a' + num1), (char)('a' + num2));
                    }
                }
            }
        }
    }
}
