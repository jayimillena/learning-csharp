class Program 
{
    public static void Main(string[] args)
    {
        int age = 25;
        string name = "Alice";

        int number = 5;
        const double PI = 3.14159;

        // Arithmetic Operators: +, -, *, /, %
        int sum = 2 + 3 + 4 + 5;
        double average = (sum) / 4;

        Console.WriteLine($"The average of 2, 3, 4, 5 is: {average}!");

        int win = 2;
        int totalGames = 4;
        double winRate = ((double)win / totalGames) * 100;

        Console.WriteLine($"Your winning rate with win: {win} out of {totalGames} is: {winRate}%!");

        int quantity = 122;
        double itemPrice = 2700.23;
        double totalPrice = quantity * itemPrice;

        Console.WriteLine($"You have {quantity} left on your stocks with the price of {itemPrice} a total of ₱ {totalPrice} if all are sold.");

        Console.WriteLine($"Hello {name} to this world, so you are a {age} years old!");

        // Logical Operators: &&, ||, !
        if (name == "Alice" && age == 25)
        {
            Console.WriteLine($"{name} you are definetly Alice");
        }
        else 
        {
            Console.WriteLine($"{name} you must be the other Alice");
        }

        // Comparison Operators: ==, !=, >, <, >=, <=

        if (age < 18) 
        {
            Console.WriteLine($"{name} is not an adult!");
        }
        else 
        {
            Console.WriteLine($"{name} is an adult!");
        }

        Console.WriteLine($"Hello {name} to this world, so you are a {age} years old!");
        Console.WriteLine($"This is a number {number} and PI is equiavalent to {PI}!");
    }
}
