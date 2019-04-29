/*
    A reference can be assigned the literall null.
    This means the reference points to no object.

    Page 27
*/

using System;

public class Point
{
    public int X;
    public int Y;
}

public stuct PointS
{
    public int X;
    public int Y;
}

class Test
{
    static void Main()
    {
        Point p = null;

        Console.WriteLine(p == null);   // true

        // But you cannot do this:
        // (runtime error)
        Console.WriteLine(p.X);

        // A value type cannot have a null value,
        // unless it's a nullable type.
        // These will fail:

        PointS p2 = null;
        int x = null;
    }
}