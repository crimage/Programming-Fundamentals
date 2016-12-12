/*
Write program to enter a radius r (real number) and print the area of the circle with exactly 12 digits after the decimal point. 
Use data type of enough precision to hold the results. 
*/
using System;
namespace CircleAreaPrecision12
{
    public class CircleAreaPrecision12
    {
        public static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;

            Console.WriteLine("{0:f12}", area);
        }
    }
}
