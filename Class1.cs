using System;

class Program
{
    static void Main()
    {
        // Initialize two variables
        int a = 5;
        int b = 10;

        Console.WriteLine("Before swapping:");
        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");

        // Swap using a temporary variable
        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine("\nAfter swapping:");
        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
    }
}
