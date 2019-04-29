/*
    Example of how an integral type can overflow,
    and how you can check it.

    You can use the following compilation flags as well:
    -checked+   (throws run-time exception if there are overflows)
    -checked-   (prevents run-time exceptions for overflow)

    https://tinyurl.com/yc3jf54p

    Page 34
*/

using System;

class Test
{
    static void Main()
    {
        int a = 1000000;
        int b = 1000000;

        int c = checked(a * b);     // Will throw System.OverflowException

        checked
        {
            c = a * b;              // you can also check a statement block
        }

        int d = unchecked(a * b);   // unchecked prevents System.OverflowException

        Console.WriteLine(c);
    }
}