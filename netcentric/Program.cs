using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netcentric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first_var = 5;
            int second_var = 10;
            Console.WriteLine("Before Swapping:");
            Console.WriteLine("First_var=" + first_var);
            Console.WriteLine("Second_var=" + second_var);
            first_var = first_var + second_var;
            second_var = first_var - second_var;
            first_var = first_var - second_var;
            Console.WriteLine("\nAfter Swapping:");
            Console.WriteLine("First_var=" + first_var);
            Console.WriteLine("Second_var=" + second_var);

        }
    }
}
