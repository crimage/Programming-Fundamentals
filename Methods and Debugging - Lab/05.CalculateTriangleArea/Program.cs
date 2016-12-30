/*
 Create a method that calculates and returns the area of a triangle by given base and height
 */
using System;

    class Program
    {
    static double GetTriangleArea(double width, double height)
    {
        return width * height / 2;
    }
        static void Main()
        {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double area = GetTriangleArea(width, height);
        Console.WriteLine(area);
        }
    }
