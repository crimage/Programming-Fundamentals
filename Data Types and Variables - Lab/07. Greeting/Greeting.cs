/*
Write program to enter n numbers and calculate and print their exact sum (without rounding). 
*/

using System;

namespace Greeting
{
   public class Greeting
    {
       public static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string ageString = Console.ReadLine();
            int age = int.Parse(ageString);

            Console.WriteLine($"Hello, {firstName} {lastName}. \r\nYou are {age} years old.");
        }
    }
}
