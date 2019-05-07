/*
    Polymorphic References

    Polymorphism... is essentially- objects of different types
    can be accessed via the same interface.

    In C#, references are polymorphic. In the example below, we can
    display a Stock or a House because they are subclasses of Asset.

    However, you can not pass a base class in place of the subclass
    (example- you cannot pass Asset when a function expects a House object).

    Page 112
*/

using System;

class MainClass
{
    public static void Main(string[] args) {
        Stock s = new Stock();
        s.value = "This stock is worth $500.";

        House h = new House();
        h.value = "This house is worth $50,000.";

        // s and h are instances of objects that inherit from
        // Asset, so they can be passed here. An example of polymorphism!
        Display(s);
        Display(h);
    }

    // Any asset obj or subclass of asset can be
    // passed here. Polymorphism!
    public static void Display(Asset theAsset) {
        Console.WriteLine(theAsset.value);
    }
}

// our base class
class Asset
{
    // the automatic property called 'value'
    public string value { get; set; }
}

class Stock : Asset {

}

class House : Asset {

}