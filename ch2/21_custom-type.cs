/*
    An example creating our own "complex" type.
    There is a class, its data a member called ratio, and it has
    two function members, a constructor and a method.

    Page 21
*/

using System;

public class UnitConverter
{
    int ratio;      // field

    public UnitConverter(int unitRatio) {   // constructor
        ratio = unitRatio;
    }

    public int Convert(int unit) {          // method
        return unit * ratio;
    }
}

class Test
{
    static void Main()
    {
        // With 'UnitConverter feetToInchesConverter' we declared a type
        // The 'new' operator instantiates a new object, and calls the objects constructor
        UnitConverter feetToInchesConverter = new UnitConverter(12);
        UnitConverter milesToFeetConverter = new UnitConverter(5280);

        Console.WriteLine(feetToInchesConverter.Convert(30));   // 360
        Console.WriteLine(feetToInchesConverter.Convert(100));  // 1200
        Console.WriteLine(feetToInchesConverter.Convert(milesToFeetConverter.Convert(1)));  // 63360
    }
}