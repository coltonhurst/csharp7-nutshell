/*
    An example contrasting instance members from static members.

    Data members and function members that operate on the type itself,
    rather than on an instance of the type, must be marked as static.

    Basically, if something is static, it's shared among the type, rather than
    private to each instance of the type. In this example, it's the variable Name
    versus the variable Population. Each panda has a name, while there's only one
    population for ALL panda's.

    'public' exposes members to other classes.
    'private' hides members from other classes.
    In OOP, this is encapsulation- data hiding.

    Page 23
*/

using System;

public class Panda
{
    public string Name;                 // Instance field
    public static int Population;       // Static field

    public Panda(string n)             // Constructor
    {
        Name = n;                       // Assign the instance field
        Population = Population + 1;    // Increment the static Population field
    }
}

class Test
{
    static void Main()
    {
        Panda p1 = new Panda("Pan Dee");
        Panda p2 = new Panda("Pan Dah");

        Console.WriteLine(p1.Name);             // Pan Dee
        Console.WriteLine(p2.Name);             // Pan Dah

        Console.WriteLine(Panda.Population);    // 2

        // The line below will fail, you must reference the Population field from the type,
        // not an instance of the type
        Console.WriteLine(p1.Population + " vs " + p2.Population);

        // The line below will fail, you must reference an instance of a Panda, not the
        // Panda type itself, to access the Name field
        Console.WriteLine(Panda.Name);
    }
}