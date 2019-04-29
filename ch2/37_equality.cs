/*
    Example of equality with boolean operators.
    Value types simply compare the value with boolean ops.
    Reference types compare the reference.

    Page 37
*/

using System;

class Test
{
    static void Main()
    {
        int x = 5, y = 5;
        Console.WriteLine(x == y);      // True
        x = 6;
        Console.WriteLine(x == y);      // False

        Dude d1 = new Dude("John");
        Dude d2 = new Dude("John");
        Console.WriteLine(d1 == d2);    // False
        Dude d3 = d1;
        Console.WriteLine(d1 == d3);    // True
    }
}

public class Dude
{
    public string Name;
    public Dude (string n) {
        Name = n;
    }
}