/*
Write a program that reads a string, converts it to Boolean variable 
and prints “Yes” if the variable is true and “No” if the variable is false.
 */


using System;
using System.Numerics;
namespace CenturiesToNanoseconds
{
    public class CenturiesToNanoseconds
    {
        public static void Main()
        {
            byte centuries = byte.Parse(Console.ReadLine());
            short years = (short)(centuries * 100);
            int days = (int)(years * 365.242);
            int hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            long millisecconds = seconds * 1000;
            long microseconds = millisecconds * 1000;
            BigInteger nanoseconds = BigInteger.Multiply(microseconds, 1000);

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {millisecconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
