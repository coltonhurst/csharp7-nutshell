/*
    Some basic examples with arrays.

    Page 41
*/

using System;

class Test
{
    static void Main()
    {
        char[] vowels = new char[5];    // An array of 5 characters

        // Give each index a value
        vowels[0] = 'a';
        vowels[1] = 'e';
        vowels[2] = 'i';
        vowels[3] = 'o';
        vowels[4] = 'u';
        
        // Print the array
        for (int i = 0; i < vowels.Length; i++)
            Console.Write(vowels[i]);
        Console.Write('\n');
        
        // Create a 2d int array
        int[,] graphPoints = new int[10,10];
        
        // Print the 2d array (a block of 100 0's)
        for (int i = 0; i < graphPoints.GetLength(0); i++) {
            for (int j = 0; j < graphPoints.GetLength(1); j++) {
                Console.Write(graphPoints[i,j]);
            }
            Console.Write('\n');
        }

        // This is a jagged array. There are multiple ways to create one.
        // Each inner array can be an arbitrary length.
        // Each inner array must be created manually.
        int[][] jaggedMatrix = {
            new int[] {0,1,2},
            new int[] {3,4,5},
            new int[] {6,7,8}
        };
    }
}

/*
    Note:

    The .Length property of an array returns the number of elements in the array
    The .GetLength() method of an array returns the length for a given dimension
*/