/*
Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
Print the variable values before and after the exchange, as shown below:.
 */


using System;

namespace ExchangeVariableValues
{
    public class ExchangeVariableValues
    {
        public static void Main()
        {
            int a = 5;
            int b = 10;

            int temp = b;
            b = a;
            a = temp;

            Console.WriteLine("Before:\na = {0}\nb = {1}\nAfter:\na = {2}\nb = {3}",b,a,a,b);
        }
    }
}
