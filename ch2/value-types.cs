/*
    An example of value types, and how assignment works.
    Value types are all numeric types, the char type, the bool type,
    and custom struct and enum types.
    Below, our example is built with a custom struct type.

    Value types only occupy the memory required to store their fields.
    The Point struct below takes 8 bytes of memory. However, see the note
    at the bottom.

    The content of a value type is just the value.

    Page 24
*/

using System;

public struct Point
{
    public int X;   // 4 bytes
    public int Y;   // 4 bytes
}

class Test
{
    static void Main()
    {
        Point p1 = new Point();
        p1.X = 7;

        Point p2 = p1;              // Assignment causes copy
        Console.WriteLine(p1.X);    // 7
        Console.WriteLine(p2.X);    // 7

        p1.X = 9;                   // Change p1.X

        Console.WriteLine(p1.X);    // 9
        Console.WriteLine(p2.X);    // 7
    }
}

/*
    Memory note from page 28:
    The CLR (Common Language Runtime) puts fields within a type
    at a memory address that's a multiple of the field's size.
    (max 8 bytes)

    So, the following uses 16 bytes of memory:

    struct A {
        byte b;     // 1 byte
        long l;     // 8 bytes
    }

    This can be overriden with the StructLayout attribute.
*/