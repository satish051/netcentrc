using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print Hello, World! to the console
            Console.WriteLine("Hello, World!");

            // Prompt the user for their names
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            // Greet the user
            Console.WriteLine($"Hello, {name}! Welcome to C# programming.");
        }
    }
}
