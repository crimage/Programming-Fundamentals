/*
Create a program to check if given symbol is digit, vowel or any other symbol
 */


using System;

namespace VowelOrDigit
{
    public class VowelOrDigit
    {
        public static void Main()
        {
            char symbol;
            symbol = Convert.ToChar(Console.ReadLine());

            if (symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'o' || symbol == 'u')
            {
                Console.WriteLine("vowel");
            }
            else if (symbol >= '0' && symbol <= '9')
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
