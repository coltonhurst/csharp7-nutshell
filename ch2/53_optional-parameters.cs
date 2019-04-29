/*
    A simple example of an optional parameter in C#.

    Mandatory parameters have to come first in the parameter list.

    If you want, you can also be specific with 'named arguments', which is
    useful when combining default & explicit parameters. It also allows you
    to put the arguments wherever you want.

    Page 53
*/

using System;

class MainClass
{
    static void Main(string[] args)
    {
        Console.WriteLine(GetANumber(10));              // prints 10
        Console.WriteLine(GetANumber());                // prints 5

        Console.WriteLine(Subtract(6));                 // prints 1
        Console.WriteLine(Subtract(y:5, x:2));          // prints -3
        Console.WriteLine(Subtract(y:2, x:10));         // prints 8
    }

    static int GetANumber(int num = 5) {
        return num;
    }

    static int Subtract(int x, int y = 5) {
        return x - y;
    }
}