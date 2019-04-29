/*
    Length Property Example

    In this example, we demonstrate how the Length property of arrays
    returns the number of items in the array, NOT the number of items in the
    dimension. (To get that, use .GetLength())

    For jagged arrays, the .Length property returns the number of arrays
    contained in the jagged array.
*/

using System;

public class MainClass {
    static void Main(string[] args) {
        int[] anArray = {1, 2, 3, 5, 9, 5, 3, 1, -1};
        Console.WriteLine(anArray.Length);  // 9 items

        int[,] aTwoDArray = {{1, 2, 3, 4}, {5, 6, 7, 8}};
        Console.WriteLine(aTwoDArray.Length);  // 8 items, 4 values in each "row"

        int[][] aJaggedArray = new int [2][];
        aJaggedArray[0] = new int[5] {1, 2, 3, 4, 5};
        aJaggedArray[1] = new int[2] {1, 2};
        // aJaggedArray[2] = new int[1] {1};     // this will throw an System.IndexOutOfRangeException
        Console.WriteLine(aJaggedArray.Length);  // The jagged array holds 2 arrays
    }
}