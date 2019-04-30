/*
    Here are examples of two null operators
    1) the null coalescing operator: ??
    2) the elvis operator (null conditional operator): ?.
*/

using System;

class MainClass
{
    static void Main(string[] args)
    {
        // the null coalescing operator gives you the value, or the
        // default if the value is null
        string s1 = null;
        string s2 = s1 ?? "nothing";

        // the elvis operator allows you to access members and methods
        // like the dot operator, but if the operand on the left is null,
        // the expression evaluates to null (rather than throwing a NullReferenceException)
        System.Text.StringBuilder sb = null;
        string s3 = sb ?. ToString(); // No error; s instead evaluates to null

        Console.WriteLine(s2);
        Console.WriteLine(s3 ?? "it's null...");
    }
}