/*
    An example of reference types, and how assignment works.
    Anything that is of a class, array, delegate, interface, or
    predefined string type is considered a reference type.

    Note at the bottom.

    A reference type has two parts:
      1) An object (this contains the value)
      2) The reference to that object

    Page 26
*/

using System;

public class Point
{
    public int X;
    public int Y;
}

class Test
{
    static void Main()
    {
        Point p1 = new Point();
        p1.X = 7;

        Point p2 = p1;              // Copies p1 reference
        Console.WriteLine(p1.X);    // 7
        Console.WriteLine(p2.X);    // 7

        p1.X = 9;                   // Change p1.X

        Console.WriteLine(p1.X);    // 9
        Console.WriteLine(p2.X);    // 9
    }
}

/*
    The 'note at the bottom', from page 29:
    Reference types require separate allocations of memory
    for the reference and the object.
    The object consumes as many bytes as its fields, plus
    a minimum of 8 bytes of overhead to store other info.
    Each reference to an object requires an extra 4 or 8 bytes,
    depending if it's a 32-bit or 64-bit platform.
*/