/*
Write a program to ask the user for 3 letters and print them in reversed order.
 */


using System;

namespace ReversedChars
{
    public class ReversedChars
    {
        public static void Main()
        {
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());
            char three = char.Parse(Console.ReadLine());

            Console.WriteLine($"{three}{two}{one}");

        }
    }
}
