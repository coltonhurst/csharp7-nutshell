/*
	The keyword 'params' is a parameter modifier. It can be added as the
	last parameter of a method so that the method accepts an infinite number
	of arguments of the specified type.

	In our example below, we can pass an (theoretically) infinite number of
	integers. In the SumNums method, they will be accessible as an integer
	array named 'ints'.

	Page 53
*/

using System;

class Program
{
	static int SumNums(params int[] ints)
	{
		int sum = 0;
		for (int i = 0; i < ints.Length; i++) {
			sum += ints[i];
		}
		return sum;
	}

    static void Main(string[] args)
    {
    	int total = SumNums(1, 2, 3, 4, 5);
        Console.WriteLine("The sume is: {0}", total);
    }
}