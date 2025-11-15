// Program.cs
using System;

namespace ArithmeticOperations
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter first integer");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second integer");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result:");
            Console.WriteLine(a + b); // sum
            Console.WriteLine(a * b); // product
            Console.WriteLine(a - b); // difference
            Console.WriteLine(a / b); // integer quotient
            Console.WriteLine(a % b); // remainder
        }
    }
}