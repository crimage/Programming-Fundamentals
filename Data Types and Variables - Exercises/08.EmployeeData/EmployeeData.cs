﻿/*
A marketing company wants to keep record of its employees. Each record would have the following characteristics:
 */


using System;

namespace EmployeeData
{
    public class EmployeeData
    {
        public static void Main()
        {
            string firstName = "Amanda";
            string lastName = "Jonson";
            byte age = 27;
            char gender = 'f';
            string id = "8306112507";
            string employeeNumber = "27563571";
            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", id);
            Console.WriteLine("Unique Employee number: {0}", employeeNumber);
        }
    }
}
