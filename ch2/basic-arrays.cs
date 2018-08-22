/*
    Some basic examples with arrays.

    Page 41
*/

using System;

class Test
{
    static void Main()
    {
        char[] vowels = new char[5];    // An array of 5 characters
        
        for (int i = 0; i < vowels.Length; i++)
            Console.Write(vowels[0]);
    }
}