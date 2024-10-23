using System;
public class Vehicle
{
    public static void Main(string[] args)
    {
        // Inherits from Vehicle
        Car myCar = new Car();
        myCar.Honk();  // Inherited method
    }
    public string brand = "Ford";

    public void Honk()
    {
        Console.WriteLine("Beep Beep!");
    }
}

public class Car : Vehicle
{
    public string model = "Mustang";
}
