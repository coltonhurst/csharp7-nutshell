/*
    This is an example of using a reserved keyword as an identifier with @ as a prefix.
    This is probably most helpful when using other .NET libraries that have different keywords.
    The @ symbol isn't part of the identifier.

    Note, some keywords are contextual, where they're used as identifies without the @.
    An example is 'value'.
    
    Page 18
*/

using System;

class Test
{
    static void Main()
    {
        int @false = 0;
        Console.WriteLine("false is: " + @false);
    }
}