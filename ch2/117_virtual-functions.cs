/*
    Virtual Functions

    A virtual function allows subclasses to override with their own implementation.

    In the example below, we override Area() (though it's not needed, technically)

    page 117
*/

using System;

class MainClass
{
    static void Main(string[] args)
    {
        Rectangle r1 = new Rectangle(5, 10);
        Console.WriteLine(r1.Area());

        Square s1 = new Square(5);
        Console.WriteLine(s1.Area());
    }
}

class Rectangle
{
    protected double length;
    protected double width;

    public Rectangle(double length, double width) {
        this.length = length;
        this.width = width;
    }

    public virtual double Area() {
        return length * width;
    }
}

class Square : Rectangle
{
    public Square(double width) : base(width, width) { }

    public override double Area() {
        return width * width;
    }
}