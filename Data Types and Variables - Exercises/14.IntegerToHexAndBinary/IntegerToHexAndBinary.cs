/*
Create a program to convert a decimal number to hexadecimal and binary number and print it.
 */


using System;

namespace IntegerToHexAndBinary
{
    public class IntegerToHexAndBinary
    {
        public static void Main()
        {
            string number = Console.ReadLine();
            string hexadecimal = Convert.ToString(Convert.ToInt32(number, 10), 16);
            string hexadecimalToUpper = hexadecimal.ToUpper();
            string binary = Convert.ToString(Convert.ToInt32(number, 10), 2);
            Console.WriteLine(hexadecimalToUpper);
            Console.WriteLine(binary);

        }
    }
}
