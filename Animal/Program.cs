using System;

public class Animal
{
    public static void Main(string[] args)
    {
        Animal animal = new Animal();
        animal.MakeSound();

        Dog dog = new Dog();  
        dog.MakeSound();  
    }
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}
    
