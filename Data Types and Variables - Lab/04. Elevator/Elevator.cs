/*
Calculate how many courses will be needed to elevate n persons by using an elevator of capacity of p persons. 
The input holds two lines: the number of people n and the capacity p of the elevator. 
*/

using System;

namespace Elevator
{
    public class Elevator
    {
       public static void Main()
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = persons / capacity;

            if (persons % capacity != 0)
            {
                courses ++;
            }
            Console.WriteLine(courses);        
        }

    }
}
