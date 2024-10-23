class Program 
{
    public static void Main(string[] args)
    {
        int a = 4;
        int b = 3;

        Console.WriteLine($"The sum of {a} and {b} is: {Add(a, b)}");
    }

    public static int Add(int a, int b)
    {
        return a + b;
    }
}
