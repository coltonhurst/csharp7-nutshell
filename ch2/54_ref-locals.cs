/*
    C# 7 introduced a feature where you can define a local variable
    that references an element in an array or field in an object.

    'ref locals' cannot be used with properties.
*/

using System;

class MainClass
{
    static void Main(string[] args)
    {
        int[] numbers = { 0, 1, 2, 3, 4 };

        ref int numRef = ref numbers[2];

        numRef *= 10;

        Console.WriteLine(numbers[2]);  // 2
        Console.WriteLine(numRef);      // 20
        Console.WriteLine(numbers[2]);  // 20
    }
}