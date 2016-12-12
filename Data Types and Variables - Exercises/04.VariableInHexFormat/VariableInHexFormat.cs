/*
Write a program that reads a number in hexadecimal format (0x##) convert it to decimal format and prints it.
 */

using System;

namespace VariableInHexFormat
{
    public class VariableInHexFormat
    {
        public static void Main()
        {
            string varInHex = Console.ReadLine();
            int number = Convert.ToInt32(varInHex, 16);
            Console.WriteLine(number);
        }
    }
}
