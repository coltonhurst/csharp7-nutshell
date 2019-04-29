/*
    The 'out' modifier

    The 'out' modifier is like the 'ref' argument,
    except the variable doesn't need to be assigned going in
    to the function, but must be assigned before going out of the function.

    Often used to get multiple return values back from a function.
*/

using System;

class Test
{
    static void Split(string name, out string firstName, out string lastName) {
        int i = name.LastIndexOf(' ');
        firstName = name.Substring(0, i);
        lastName = name.Substring(i + 1);
    }

    public static void Main(string[] args) {
        string a, b;
        Split("Stevie Ray Vaughan", out a, out b);
        Console.WriteLine(a);   // Stevie Ray
        Console.WriteLine(b);   // Vaughan
    }
}

/*
    You can shorten the Split() call above by declaring the out variables in the func call.
    Example: Split("Stevie Ray Vaughan", out string a, out string b);

    You can also "discard" the items you're not interested in...
    Split("Stevie Ray Vaughan", out string a, out _);

    (if a real _ variable is in the scope, discarding won't work)
*/