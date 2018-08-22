/*
    An example of the ternary operator.

    Page 39
*/

using System;

class Test
{
    static void Main()
    {
        Console.WriteLine("The max of 5 and 10 is: " + Max(5, 10));
    }

    static int Max(int num1, int num2)
    {
        return (num1 > num2) ? num1 : num2;
    }
}