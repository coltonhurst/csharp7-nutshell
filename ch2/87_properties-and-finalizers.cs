using System;

class MainClass
{
    static void Main(string[] args)
    {
        Car myCar = new Car();
        myCar.Weight = 1000.05;
        myCar.Name = "Eugine";

        Console.WriteLine(myCar);
    }
}

class Car
{
    // declaring the weight variable
    double weight;

    // the property definition for the weight
    public double Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    // combining the declaration and properties
    // called: automatic properties
    public string Name {get; set;}

    public override string ToString() {
        return Name + " weighs " + weight + " pounds.";
    }

    // the finalizer
    // this runs right before the object is garbage collected
    ~Car()
    {
        Console.WriteLine(Name + " is dead!");
    }
}