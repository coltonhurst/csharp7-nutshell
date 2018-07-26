/*
    A quick test to see if items in a class have access to the members that are
    a part of the private class inside it.

    If you have a private class in a class, the members/fields must be publicly
    accessible if you want the class holding the private class to have access. 
*/

using System;

public class MainClass
{
    static void Main()
    {
        Car myVehicle = new Car();
    }
}

public class Car
{
    int age;
    int mileage;
    string name;
    Person driver;

    public string getDriverName() {
        driver = new Person();
        return driver.firstName + " " + driver.lastName;
    }

    private class Person
    {
        private string firstName {get; set;}    // inaccessible
        public string lastName {get; set;}      // accessible
    }
}