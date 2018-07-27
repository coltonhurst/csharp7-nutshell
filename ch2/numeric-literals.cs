/*
    Simple examples using C# numeric literals,
    and different ways to express numeric values.

    By default, the compiler infers the type. However,
    with numeric suffixes, you can explicitly define the type of a literal.

    You may not always use this stuff, even in production code, but hey- it's good to learn,
    and at the bare minimum, this is some documentation for myself.

    Page 30
*/

using System;

class Test
{
    static void Main()
    {
        int x = 127;    // decimal notation
        long y = 0x7F;  // hexadecimal notation with 0x
        int million = 1_000_000;    // we can add underscore's to make a numeric literal more readable
        var b = 0b1010_1011_1100_1101_1110_1111;    // binary with 0b & underscore's
        double d = 1.5;         // a 'real' literal (not an integral type)
        double million2 = 1E06;  // real literals can use exponential notation

        // Examples of numeric literal type inference
        // If it has a decimal point or exponential symbol (E), it's a double
        // Otherwise, it picks the first type that fits in this list: int, uint, long, ulong
        Console.WriteLine(        1.0.GetType());   // Double (double)
        Console.WriteLine(       1E06.GetType());   // Double (double)
        Console.WriteLine(          1.GetType());   // Int32  (int)
        Console.WriteLine( 0xF0000000.GetType());   // UInt32 (uint)
        Console.WriteLine(0x100000000.GetType());   // Int64  (long)

        // Explicitly defining the numeric literal type
        // by adding numeric suffixes
        float f = 1.0F;     // F for float
        double dou = 1D;      // D for double (redundant, but still there)
        decimal dec = 1.0M; // M for money
        uint i = 1U;        // U for unsigned int
        long l = 1L;        // L for long
        ulong ul = 1UL;     // UL for unsigned long
    }
}