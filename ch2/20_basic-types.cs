/*
    All values in C# are instances of a type.

    From Wikipedia on data types:
    A variable type defines the operations that can be done on the data,
    the meaning of the data, and the way values of that type are stored.

    There are predefined types, and custom types. Predefined types are supported by the compiler.
    The .NET Framework also has lots of types that are not predefined by C# (like the DateTime type)

    Page 20
*/

using System;

class Test
{
    static void Main()
    {
        int x = 12 * 30;    // an example of the predefined type 'int'
                            // used for representing integers that fit into 32 bits of memory
        Console.WriteLine(x);                       // prints: 360

        string message = "Hello world";             // string predefined type (but not a primitive type)
        string upperMessage = message.ToUpper();
        Console.WriteLine(upperMessage);            // prints: HELLO WORLD

        int y = 2015;
        message = message + y.ToString();           // converting our int to a string
        Console.WriteLine(message);                 // prints: Hello world2015

        bool simpleVar = false;
        if (simpleVar)
            Console.WriteLine("This will not print");
        
        int z = 5000;
        bool lessThanAMile = z < 5280;
        if (lessThanAMile)
            Console.WriteLine("This will print");
    }
}