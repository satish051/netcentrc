using System;

namespace SimpleInterestApp
{
    // SimpleInterestCalculator class
    public class SimpleInterestCalculator
    {
        // Method to calculate simple interest
        public double CalculateInterest(double principal, double rate, double time)
        {
            return (principal * rate * time) / 100;
        }
    }

    // Main program
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an object of SimpleInterestCalculator
            SimpleInterestCalculator calculator = new SimpleInterestCalculator();

            // Input: Accept user input for principal, rate, and time
            Console.WriteLine("Enter Principal Amount:");
            double principal = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Rate of Interest:");
            double rate = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Time (in years):");
            double time = double.Parse(Console.ReadLine());

            // Calculate and display the simple interest
            double interest = calculator.CalculateInterest(principal, rate, time);
            Console.WriteLine($"The Simple Interest is: {interest}");
        }
    }
}
