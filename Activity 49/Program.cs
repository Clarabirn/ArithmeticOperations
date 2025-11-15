
using System;
using System.Globalization;

namespace MultiplesOfNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter dividend");
            var dividendStr = Console.ReadLine();
            Console.WriteLine("Enter divisor");
            var divisorStr = Console.ReadLine();

            decimal dividend = decimal.Parse(dividendStr!, CultureInfo.InvariantCulture);
            decimal divisor  = decimal.Parse(divisorStr!, CultureInfo.InvariantCulture);

            if (divisor == 0m)
            {
                Console.WriteLine("Not multiples");
                return;
            }

            decimal remainder = dividend % divisor;

            Console.WriteLine(remainder == 0m ? "Multiples" : "Not multiples");
        }
    }
}
