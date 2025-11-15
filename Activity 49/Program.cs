
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

            // Brug decimal for base-10 præcision (34.1 % 0.1 virker som forventet)
            decimal dividend = decimal.Parse(dividendStr!, CultureInfo.InvariantCulture);
            decimal divisor  = decimal.Parse(divisorStr!, CultureInfo.InvariantCulture);

            if (divisor == 0m)
            {
                // Opgaven specificerer ikke 0; vi vælger at sige ikke-multipla.
                Console.WriteLine("Not multiples");
                return;
            }

            decimal remainder = dividend % divisor;

            // For decimal behøver vi normalt ikke tolerance; == 0 er fint.
            Console.WriteLine(remainder == 0m ? "Multiples" : "Not multiples");
        }
    }
}
