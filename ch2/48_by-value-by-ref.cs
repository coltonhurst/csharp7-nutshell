/*
	Parameters passed by value vs by reference.

	Page 48
*/

using System;

class Program
{
    static void Main(string[] args)
    {
    	int x = 0;

    	AddFiveToAnInt(x);
        Console.WriteLine(x);	// x is still 0

        AddTenToAnInt(ref x);	// Add the ref keyword to ensure you want to pass by reference
        Console.WriteLine(x);	// x is now 10
    }

    static void AddFiveToAnInt(int num) {
    	num += 5;	// because this is passed by value, it won't change
    				// the variable x in main
    }

    static void AddTenToAnInt(ref int num) {
    	num += 10;	// because this is passed by reference, it WILL change
    				// the variable x in main
    }
}