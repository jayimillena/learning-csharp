using System;
public class Car
{
    private string brand = "";
    private int speed = 0;

    public static void Main(string[] args)
    {
        Car myCar = new Car();
        myCar.SetBrand("Toyota");
        Console.WriteLine($"Your car brand: {myCar.GetBrand()}");
    }
    public void SetBrand(string carBrand)
    {
        brand = carBrand;
    }

    public string GetBrand()
    {
        return brand;
    }

    public void Accelerate()
    {
        speed += 10;
    }
}

