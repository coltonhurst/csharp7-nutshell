/*
    Examples of implicit and explicit numeric conversions.
    Implicit conversions happen automatically.
    Explicit conversions are forced (using a cast).

    If the compiler can guarantee the success of the conversion,
    and no data is lost, it's an implicit conversion.

    If data will be lost, or the compiler can't guarantee the
    conversion will succeed, it's an explicit conversion.

    C# also supports reference, boxing, and custom conversions.

    Page 23
*/

using System;

class Test
{
    int x = 12345;      // int is a 32-bit integer

    long y = x;         // Implicit conversion to 64-bit integer
                        // no data is lost

    short z = short(x); // Explicit conversion to 16-bit integer
                        // data is lost
}