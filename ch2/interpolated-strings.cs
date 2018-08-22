/*
    Some examples of interpolated strings.

    Interpolated strings allow you to include expressions inside braces: {expression here}
    Add a $ to the beginning of the string

    Page 41
*/

using System;

class Test
{
    static void Main()
    {
        int oranges = 5;
        Console.WriteLine($"We have {oranges} oranges.");
    }
}